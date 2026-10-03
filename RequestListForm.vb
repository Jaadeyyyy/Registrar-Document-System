Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class RequestListForm
        Private ReadOnly mainForm As MainForm
        Private initialStatusFilter As String = Nothing
        Private initialPaymentFilter As String = Nothing

        Public Sub New()
            InitializeComponent()
            cboRequestStatusFilter.SelectedIndex = 0
            cboPaymentStatusFilter.SelectedIndex = 0
            AppTheme.SetPlaceholder(txtSearchRequests, "Search request no, student ID, or student name...")
        End Sub

        Public Sub New(parent As MainForm, Optional statusFilter As String = Nothing, Optional paymentFilter As String = Nothing)
            Me.New()
            mainForm = parent
            initialStatusFilter = statusFilter
            initialPaymentFilter = paymentFilter

            If Not String.IsNullOrEmpty(statusFilter) Then
                For i As Integer = 0 To cboRequestStatusFilter.Items.Count - 1
                    If cboRequestStatusFilter.Items(i).ToString().Equals(statusFilter, StringComparison.OrdinalIgnoreCase) Then
                        cboRequestStatusFilter.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If Not String.IsNullOrEmpty(paymentFilter) Then
                For i As Integer = 0 To cboPaymentStatusFilter.Items.Count - 1
                    If cboPaymentStatusFilter.Items(i).ToString().Equals(paymentFilter, StringComparison.OrdinalIgnoreCase) Then
                        cboPaymentStatusFilter.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
        End Sub

        Private Sub RequestListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            RefreshRequestsData()
        End Sub

        Public Sub RefreshRequestsData()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim conditions As New List(Of String)()
                Dim parameters As New Dictionary(Of String, Object)()

                Dim search = txtSearchRequests.Text.Trim()
                If Not String.IsNullOrEmpty(search) Then
                    conditions.Add("(r.RequestNo LIKE @search OR r.StudentID LIKE @search OR CONCAT(s.FirstName, ' ', s.LastName) LIKE @search)")
                    parameters.Add("@search", "%" & search & "%")
                End If

                If cboRequestStatusFilter.SelectedIndex > 0 Then
                    conditions.Add("r.Status = @status")
                    parameters.Add("@status", cboRequestStatusFilter.SelectedItem.ToString())
                End If

                If cboPaymentStatusFilter.SelectedIndex > 0 Then
                    conditions.Add("r.PaymentStatus = @payment")
                    parameters.Add("@payment", cboPaymentStatusFilter.SelectedItem.ToString())
                End If

                Dim whereClause = If(conditions.Count > 0, "WHERE " & String.Join(" AND ", conditions), String.Empty)

                Dim query = "SELECT r.RequestNo, " &
                            "DATE_FORMAT(r.RequestDate, '%Y-%m-%d') AS RequestDate, " &
                            "r.StudentID, " &
                            "CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, " &
                            "COALESCE(GROUP_CONCAT(CONCAT(d.DocumentName, ' (', rd.Quantity, ')') SEPARATOR ', '), 'No items') AS DocumentList, " &
                            "r.TotalAmount, " &
                            "r.PaymentStatus, " &
                            "r.Status " &
                            "FROM tblrequest r " &
                            "INNER JOIN tblstudents s ON r.StudentID = s.StudentID " &
                            "LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                            "LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                            whereClause & " " &
                            "GROUP BY r.RequestID, r.RequestNo, r.RequestDate, r.StudentID, s.FirstName, s.LastName, r.TotalAmount, r.PaymentStatus, r.Status " &
                            "ORDER BY r.RequestDate DESC"

                Dim dt = Database.GetTable(query, parameters)
                dgvRequests.DataSource = dt
                lblRecordCount.Text = $"{dt.Rows.Count} requests"
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchRequests_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRequests.TextChanged
            RefreshRequestsData()
        End Sub

        Private Sub cboRequestStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRequestStatusFilter.SelectedIndexChanged
            RefreshRequestsData()
        End Sub

        Private Sub cboPaymentStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentStatusFilter.SelectedIndexChanged
            RefreshRequestsData()
        End Sub

        Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
            If dgvRequests.CurrentRow Is Nothing Then
                MessageBox.Show("Select a request first.", "Requests", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim reqNo = dgvRequests.CurrentRow.Cells("colReqNo").Value.ToString()
            Using dialog As New RequestDetailsForm(reqNo)
                dialog.ShowDialog(Me)
            End Using
        End Sub

        Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
            If dgvRequests.CurrentRow Is Nothing Then
                MessageBox.Show("Select a request first.", "Requests", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim reqNo = dgvRequests.CurrentRow.Cells("colReqNo").Value.ToString()
            Using dialog As New UpdateRequestForm(reqNo)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshRequestsData()
                End If
            End Using
        End Sub

        Private Sub btnViewSlipRequest_Click(sender As Object, e As EventArgs) Handles btnViewSlipRequest.Click
            If dgvRequests.CurrentRow Is Nothing Then
                MessageBox.Show("Select a request first.", "Requests", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim reqNo = dgvRequests.CurrentRow.Cells("colReqNo").Value.ToString()
            Using rec As New ReceiptForm(reqNo)
                rec.ShowDialog(Me)
            End Using
        End Sub

        Private Sub dgvRequests_DoubleClick(sender As Object, e As EventArgs) Handles dgvRequests.DoubleClick
            btnViewDetails.PerformClick()
        End Sub

        Private Sub dgvRequests_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRequests.CellFormatting
            If e.RowIndex < 0 Then Return
            If dgvRequests.Columns(e.ColumnIndex).Name = "colReqTotal" AndAlso e.Value IsNot Nothing Then
                Dim val As Decimal
                If Decimal.TryParse(e.Value.ToString(), val) Then
                    e.Value = val.ToString("N2")
                    e.FormattingApplied = True
                End If
            ElseIf dgvRequests.Columns(e.ColumnIndex).Name = "colReqPayment" AndAlso e.Value IsNot Nothing Then
                Dim payment = e.Value.ToString()
                If payment = "Paid" Then
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52)
                    e.CellStyle.Font = New Font(dgvRequests.Font, FontStyle.Bold)
                Else
                    e.CellStyle.ForeColor = Color.FromArgb(220, 53, 69)
                    e.CellStyle.Font = New Font(dgvRequests.Font, FontStyle.Bold)
                End If
            ElseIf dgvRequests.Columns(e.ColumnIndex).Name = "colReqStatus" AndAlso e.Value IsNot Nothing Then
                Dim status = e.Value.ToString()
                Select Case status
                    Case "Completed"
                        e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52)
                    Case "Ready for Pickup"
                        e.CellStyle.ForeColor = Color.FromArgb(13, 110, 253)
                    Case "In Progress"
                        e.CellStyle.ForeColor = Color.FromArgb(180, 83, 9)
                    Case "Cancelled"
                        e.CellStyle.ForeColor = Color.FromArgb(220, 53, 69)
                    Case Else
                        e.CellStyle.ForeColor = Color.FromArgb(100, 116, 139)
                End Select
                e.CellStyle.Font = New Font(dgvRequests.Font, FontStyle.Bold)
            End If
        End Sub
    End Class
End Namespace
