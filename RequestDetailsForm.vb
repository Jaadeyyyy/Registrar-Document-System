Imports System.Data
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class RequestDetailsForm
        Private ReadOnly targetRequestId As Integer

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnClose, True)
            AppTheme.StyleGrid(dgvItems)
        End Sub

        Public Sub New(requestId As Integer)
            Me.New()
            targetRequestId = requestId
            If System.ComponentModel.LicenseManager.UsageMode <> System.ComponentModel.LicenseUsageMode.Designtime Then
                LoadDetails()
            End If
        End Sub

        Public Sub New(requestNo As String)
            Me.New()
            Try
                Dim res = Database.Scalar("SELECT RequestID FROM tblrequest WHERE RequestNo=@no", New Dictionary(Of String, Object) From {{"@no", requestNo}})
                If res IsNot Nothing AndAlso Not IsDBNull(res) Then
                    targetRequestId = Convert.ToInt32(res)
                    If System.ComponentModel.LicenseManager.UsageMode <> System.ComponentModel.LicenseUsageMode.Designtime Then
                        LoadDetails()
                    End If
                End If
            Catch ex As Exception
            End Try
        End Sub

        Private Sub LoadDetails()
            Dim header = Database.GetTable(
                "SELECT r.RequestNo, r.RequestDate, r.Purpose, s.StudentID, CONCAT(s.LastName, ', ', s.FirstName) AS Student, " &
                "r.TotalAmount, r.PaymentStatus, r.ORNo, r.ORDate, r.Status, r.ReleasedDate, u.FullName AS CreatedBy " &
                "FROM tblrequest r INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                "INNER JOIN tblusers u ON u.UserID=r.CreatedBy WHERE r.RequestID=@id",
                New Dictionary(Of String, Object) From {{"@id", targetRequestId}})
            If header.Rows.Count = 0 Then Return
            Dim row = header.Rows(0)
            Text = "Request Details - " & row("RequestNo").ToString()

            lblSummary.Text = row("RequestNo").ToString() & "  |  " & Convert.ToDateTime(row("RequestDate")).ToString("MMM d, yyyy") &
                              Environment.NewLine & row("StudentID").ToString() & " - " & row("Student").ToString() &
                              Environment.NewLine & "Purpose: " & row("Purpose").ToString() &
                              Environment.NewLine & "Payment: " & row("PaymentStatus").ToString() &
                              If(DBNull.Value.Equals(row("ORNo")), String.Empty, "  |  OR: " & row("ORNo").ToString()) &
                              "  |  Status: " & row("Status").ToString() &
                              Environment.NewLine & "Recorded by: " & row("CreatedBy").ToString()

            If dgvItems.DataSource Is Nothing Then
                dgvItems.Rows.Clear()
            End If

            dgvItems.DataSource = Database.GetTable(
                "SELECT d.DocumentName, rd.Quantity, rd.Amount, rd.SubTotal " &
                "FROM tblrequestdetails rd INNER JOIN tbldocuments d ON d.DocumentID=rd.DocumentID " &
                "WHERE rd.RequestID=@id ORDER BY d.DocumentName",
                New Dictionary(Of String, Object) From {{"@id", targetRequestId}})

            If dgvItems.Columns.Contains("Amount") Then dgvItems.Columns("Amount").DefaultCellStyle.Format = "N2"
            If dgvItems.Columns.Contains("SubTotal") Then dgvItems.Columns("SubTotal").DefaultCellStyle.Format = "N2"

            lblTotal.Text = "Total: " & Convert.ToDecimal(row("TotalAmount")).ToString("N2")
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub
    End Class
End Namespace
