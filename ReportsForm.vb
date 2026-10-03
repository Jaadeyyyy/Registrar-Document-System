Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class ReportsForm
        Private ReadOnly mainForm As MainForm

        Public Sub New()
            InitializeComponent()
            cboReportType.SelectedIndex = 0
            dtpFromDate.Value = DateTime.Today.AddDays(-30)
            dtpToDate.Value = DateTime.Today
        End Sub

        Public Sub New(parent As MainForm)
            Me.New()
            mainForm = parent
        End Sub

        Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            GenerateReport()
        End Sub

        Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
            GenerateReport()
        End Sub

        Private Sub GenerateReport()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim fromDate = dtpFromDate.Value.ToString("yyyy-MM-dd") & " 00:00:00"
                Dim toDate = dtpToDate.Value.ToString("yyyy-MM-dd") & " 23:59:59"
                Dim params As New Dictionary(Of String, Object) From {
                    {"@from", fromDate},
                    {"@to", toDate}
                }

                Dim dt As DataTable = Nothing
                Select Case cboReportType.SelectedIndex
                    Case 0 ' Daily Collections
                        Dim sql = "SELECT DATE_FORMAT(RequestDate, '%Y-%m-%d') AS `Collection Date`, " &
                                  "COUNT(*) AS `Paid Requests`, " &
                                  "SUM(TotalAmount) AS `Total Amount Collected` " &
                                  "FROM tblrequest " &
                                  "WHERE PaymentStatus='Paid' AND RequestDate BETWEEN @from AND @to " &
                                  "GROUP BY DATE_FORMAT(RequestDate, '%Y-%m-%d') " &
                                  "ORDER BY `Collection Date` DESC"
                        dt = Database.GetTable(sql, params)
                        Dim total As Decimal = 0
                        For Each row As DataRow In dt.Rows
                            If Not IsDBNull(row("Total Amount Collected")) Then
                                total += Convert.ToDecimal(row("Total Amount Collected"))
                            End If
                        Next
                        lblReportTotal.Text = "₱" & total.ToString("N2")

                    Case 1 ' Monthly Summary
                        Dim sql = "SELECT DATE_FORMAT(RequestDate, '%Y-%m') AS `Month`, " &
                                  "COUNT(*) AS `Total Requests`, " &
                                  "SUM(CASE WHEN PaymentStatus='Paid' THEN TotalAmount ELSE 0 END) AS `Paid Total`, " &
                                  "SUM(CASE WHEN PaymentStatus='Unpaid' THEN TotalAmount ELSE 0 END) AS `Unpaid Total` " &
                                  "FROM tblrequest " &
                                  "WHERE RequestDate BETWEEN @from AND @to " &
                                  "GROUP BY DATE_FORMAT(RequestDate, '%Y-%m') " &
                                  "ORDER BY `Month` DESC"
                        dt = Database.GetTable(sql, params)
                        Dim total As Decimal = 0
                        For Each row As DataRow In dt.Rows
                            If Not IsDBNull(row("Paid Total")) Then
                                total += Convert.ToDecimal(row("Paid Total"))
                            End If
                        Next
                        lblReportTotal.Text = "₱" & total.ToString("N2")

                    Case 2 ' Requests by Status
                        Dim sql = "SELECT Status AS `Request Status`, " &
                                  "COUNT(*) AS `Request Count`, " &
                                  "SUM(TotalAmount) AS `Total Value` " &
                                  "FROM tblrequest " &
                                  "WHERE RequestDate BETWEEN @from AND @to " &
                                  "GROUP BY Status " &
                                  "ORDER BY `Request Count` DESC"
                        dt = Database.GetTable(sql, params)
                        Dim count As Integer = 0
                        For Each row As DataRow In dt.Rows
                            If Not IsDBNull(row("Request Count")) Then
                                count += Convert.ToInt32(row("Request Count"))
                            End If
                        Next
                        lblReportTotal.Text = $"{count} Requests"

                    Case 3 ' Document Popularity
                        Dim sql = "SELECT d.DocumentName AS `Document Name`, " &
                                  "SUM(rd.Quantity) AS `Total Requested`, " &
                                  "SUM(rd.SubTotal) AS `Total Revenue Generated` " &
                                  "FROM tblrequestdetails rd " &
                                  "INNER JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                                  "INNER JOIN tblrequest r ON rd.RequestID = r.RequestID " &
                                  "WHERE r.RequestDate BETWEEN @from AND @to " &
                                  "GROUP BY d.DocumentID, d.DocumentName " &
                                  "ORDER BY `Total Requested` DESC"
                        dt = Database.GetTable(sql, params)
                        Dim totalRev As Decimal = 0
                        For Each row As DataRow In dt.Rows
                            If Not IsDBNull(row("Total Revenue Generated")) Then
                                totalRev += Convert.ToDecimal(row("Total Revenue Generated"))
                            End If
                        Next
                        lblReportTotal.Text = "₱" & totalRev.ToString("N2")
                End Select

                dgvReports.DataSource = dt
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub dgvReports_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvReports.CellFormatting
            If e.RowIndex < 0 Then Return
            Dim colName = dgvReports.Columns(e.ColumnIndex).Name
            If (colName.Contains("Amount") OrElse colName.Contains("Total") OrElse colName.Contains("Value") OrElse colName.Contains("Revenue") OrElse colName.Contains("Paid")) AndAlso e.Value IsNot Nothing Then
                Dim val As Decimal
                If Decimal.TryParse(e.Value.ToString(), val) Then
                    e.Value = val.ToString("N2")
                    e.FormattingApplied = True
                End If
            End If
        End Sub
    End Class
End Namespace
