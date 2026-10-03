Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Text
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class ReceiptForm
        Private ReadOnly requestId As Integer
        Private receiptText As String = String.Empty

        Public Sub New(id As Integer)
            requestId = id
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnPrint, False)
            AppTheme.StyleButton(btnClose, True)
            LoadReceipt()
        End Sub

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            Close()
        End Sub

        Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
            PrintReceipt()
        End Sub

        Private Sub LoadReceipt()
            Try
                Dim header = Database.GetTable(
                    "SELECT r.RequestNo,r.RequestDate,r.Purpose,s.StudentID, " &
                    "CONCAT(s.LastName, ', ', s.FirstName) AS Student, " &
                    "r.TotalAmount,r.PaymentStatus,r.ORNo,r.ORDate,r.Status,r.ReleasedDate, " &
                    "u.FullName AS CreatedByName " &
                    "FROM tblrequest r " &
                    "INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                    "INNER JOIN tblusers u ON u.UserID=r.CreatedBy " &
                    "WHERE r.RequestID=@id",
                    New Dictionary(Of String, Object) From {{"@id", requestId}})
                If header.Rows.Count = 0 Then
                    receiptText = "The selected request could not be found."
                    receiptBox.Text = receiptText
                    Return
                End If

                Dim items = Database.GetTable(
                    "SELECT d.DocumentName,rd.Quantity,rd.Amount,rd.SubTotal " &
                    "FROM tblrequestdetails rd " &
                    "INNER JOIN tbldocuments d ON d.DocumentID=rd.DocumentID " &
                    "WHERE rd.RequestID=@id ORDER BY d.DocumentName",
                    New Dictionary(Of String, Object) From {{"@id", requestId}})
                receiptText = BuildReceiptText(header.Rows(0), items)
                receiptBox.Text = receiptText
                receiptBox.Select(0, 0)
            Catch ex As Exception
                receiptText = "The request slip could not be loaded." & Environment.NewLine & ex.Message
                receiptBox.Text = receiptText
            End Try
        End Sub

        Private Function BuildReceiptText(row As DataRow, items As DataTable) As String
            Dim builder As New StringBuilder()
            builder.AppendLine(CenterText(AppTheme.SchoolName, 49))
            builder.AppendLine(CenterText(AppTheme.SchoolAddress, 49))
            builder.AppendLine(CenterText(AppTheme.RegistrarOffice, 49))
            builder.AppendLine()
            builder.AppendLine(CenterText("DOCUMENT REQUEST SLIP", 49))
            builder.AppendLine(New String("-"c, 49))
            builder.AppendLine("Request No.  " & ValueText(row("RequestNo")))
            builder.AppendLine("Date         " & Convert.ToDateTime(row("RequestDate")).ToString("MM/dd/yyyy"))
            builder.AppendLine("Student ID   " & ValueText(row("StudentID")))
            builder.AppendLine("Student      " & ValueText(row("Student")))
            builder.AppendLine("Purpose      " & ValueText(row("Purpose")))
            builder.AppendLine("OR Number    " & ValueText(row("ORNo"), "________________"))
            builder.AppendLine("Date Release " & DateText(row("ReleasedDate"), "________________"))
            builder.AppendLine(New String("-"c, 49))
            builder.AppendLine(String.Format("{0,-25}{1,4}{2,9}{3,11}", "DOCUMENT", "QTY", "FEE", "AMOUNT"))
            builder.AppendLine(New String("-"c, 49))
            For Each item As DataRow In items.Rows
                Dim documentName = ValueText(item("DocumentName"))
                If documentName.Length > 25 Then documentName = documentName.Substring(0, 22) & "..."
                builder.AppendLine(String.Format("{0,-25}{1,4}{2,9:N2}{3,11:N2}",
                                                 documentName,
                                                 Convert.ToInt32(item("Quantity")),
                                                 Convert.ToDecimal(item("Amount")),
                                                 Convert.ToDecimal(item("SubTotal"))))
            Next
            builder.AppendLine(New String("-"c, 49))
            builder.AppendLine(String.Format("{0,-38}{1,11:N2}", "TOTAL", Convert.ToDecimal(row("TotalAmount"))))
            builder.AppendLine()
            builder.AppendLine(CenterText(ValueText(row("PaymentStatus")).ToUpperInvariant(), 49))
            builder.AppendLine(CenterText("Request Status: " & ValueText(row("Status")), 49))
            builder.AppendLine()
            builder.AppendLine("Processed by: " & ValueText(row("CreatedByName")))
            builder.AppendLine("Signature:    ______________________________")
            builder.AppendLine()
            builder.AppendLine(CenterText("This slip is NOT an official receipt.", 49))
            builder.AppendLine(CenterText("Please present it to the cashier for payment.", 49))
            Return builder.ToString()
        End Function

        Private Function CenterText(value As String, width As Integer) As String
            If value.Length >= width Then Return value
            Return New String(" "c, (width - value.Length) \ 2) & value
        End Function

        Private Function ValueText(value As Object, Optional blankText As String = "") As String
            If value Is Nothing OrElse value Is DBNull.Value OrElse String.IsNullOrWhiteSpace(value.ToString()) Then
                Return blankText
            End If
            Return value.ToString()
        End Function

        Private Function DateText(value As Object, blankText As String) As String
            If value Is Nothing OrElse value Is DBNull.Value Then Return blankText
            Return Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Function

        Private Sub PrintReceipt()
            Using document As New PrintDocument(), dialog As New PrintDialog()
                document.DocumentName = "Document Request Slip"
                AddHandler document.PrintPage, AddressOf DrawReceipt
                dialog.Document = document
                dialog.UseEXDialog = True
                If dialog.ShowDialog(Me) = DialogResult.OK Then document.Print()
            End Using
        End Sub

        Private Sub DrawReceipt(sender As Object, e As PrintPageEventArgs)
            Using receiptFont As New Font("Consolas", 10.0F)
                Dim area As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top,
                                           e.MarginBounds.Width, e.MarginBounds.Height)
                e.Graphics.DrawString(receiptText, receiptFont, Brushes.Black, area)
            End Using
            e.HasMorePages = False
        End Sub
    End Class
End Namespace
