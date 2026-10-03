Imports System.Data
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class UpdateRequestForm
        Private ReadOnly targetRequestId As Integer

        Public Sub New(requestId As Integer)
            targetRequestId = requestId
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnSave, False)
            AppTheme.StyleButton(btnCancel, True)
            AppTheme.StyleComboBox(cboPayment)
            AppTheme.StyleComboBox(cboStatus)
            AppTheme.StyleTextBox(txtORNo)

            LoadRequestData()
        End Sub

        Private Sub LoadRequestData()
            Try
                Dim table = Database.GetTable("SELECT * FROM tblrequest WHERE RequestID=@id",
                                              New Dictionary(Of String, Object) From {{"@id", targetRequestId}})
                If table.Rows.Count = 0 Then Return
                Dim row = table.Rows(0)
                Text = "Update " & row("RequestNo").ToString()

                Dim currentPayment = row("PaymentStatus").ToString()
                Dim currentStatus = row("Status").ToString()

                cboPayment.Text = currentPayment
                cboStatus.Items.Clear()
                cboStatus.Items.AddRange(GetAllowedStatuses(currentStatus))
                cboStatus.Text = currentStatus

                txtORNo.Text = If(DBNull.Value.Equals(row("ORNo")), String.Empty, row("ORNo").ToString())
                dtpORDate.Value = If(DBNull.Value.Equals(row("ORDate")), Date.Today, Convert.ToDateTime(row("ORDate")))

                Dim isPaid = (currentPayment = "Paid")
                txtORNo.Enabled = isPaid
                dtpORDate.Enabled = isPaid
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub cboPayment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPayment.SelectedIndexChanged
            Dim isPaid = (cboPayment.Text = "Paid")
            txtORNo.Enabled = isPaid
            dtpORDate.Enabled = isPaid
        End Sub

        Private Function GetAllowedStatuses(currentStatus As String) As Object()
            Select Case currentStatus
                Case "Pending"
                    Return {"Pending", "Processing", "Cancelled"}
                Case "Processing"
                    Return {"Processing", "Ready for Release", "Cancelled"}
                Case "Ready for Release"
                    Return {"Ready for Release", "Released", "Cancelled"}
                Case "Released"
                    Return {"Released"}
                Case "Cancelled"
                    Return {"Cancelled"}
                Case Else
                    Return {currentStatus}
            End Select
        End Function

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim isPaid = (cboPayment.Text = "Paid")
            Dim orNo = txtORNo.Text.Trim()

            If isPaid Then
                If String.IsNullOrWhiteSpace(orNo) Then
                    MessageBox.Show("Enter the official receipt number for a paid request.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtORNo.Focus()
                    Return
                End If
                If dtpORDate.Value.Date > Date.Today Then
                    MessageBox.Show("OR date cannot be in the future.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    dtpORDate.Focus()
                    Return
                End If

                Try
                    Dim countObj = Database.Scalar(
                        "SELECT COUNT(*) FROM tblrequest WHERE ORNo=@orNo AND RequestID<>@id",
                        New Dictionary(Of String, Object) From {
                            {"@orNo", orNo},
                            {"@id", targetRequestId}
                        })
                    If Convert.ToInt32(countObj) > 0 Then
                        MessageBox.Show("This OR number is already assigned to another request.",
                                        "Duplicate OR Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtORNo.Focus()
                        Return
                    End If
                Catch ex As Exception
                    MainForm.ShowDatabaseError(ex)
                    Return
                End Try
            End If

            If (cboStatus.Text = "Ready for Release" OrElse cboStatus.Text = "Released") AndAlso Not isPaid Then
                MessageBox.Show("The request must be paid before it can be ready for release or released.",
                                "Request status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Database.Execute(
                    "UPDATE tblrequest SET PaymentStatus=@payment, Status=@status, " &
                    "ORNo=@orNumber, ORDate=@orDate, " &
                    "ReleasedDate=CASE WHEN @status='Released' THEN COALESCE(ReleasedDate,CURDATE()) ELSE ReleasedDate END " &
                    "WHERE RequestID=@id",
                    New Dictionary(Of String, Object) From {
                        {"@payment", cboPayment.Text},
                        {"@status", cboStatus.Text},
                        {"@orNumber", If(isPaid, CType(orNo, Object), DBNull.Value)},
                        {"@orDate", If(isPaid, CType(dtpORDate.Value.Date, Object), DBNull.Value)},
                        {"@id", targetRequestId}
                    })

                DialogResult = DialogResult.OK
                Close()
            Catch ex As Exception
                If ex.Message.Contains("uq_request_orno") OrElse ex.Message.ToLowerInvariant().Contains("duplicate") Then
                    MessageBox.Show("This OR number is already assigned to another request.",
                                    "Duplicate OR Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Could not update request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub
    End Class
End Namespace
