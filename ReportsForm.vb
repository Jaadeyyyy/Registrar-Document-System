Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class ReportsForm
        Private ReadOnly mainForm As MainForm

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleComboBox(cboReportType)
            AppTheme.StyleButton(btnGenerateReport, False)
            AppTheme.StyleGrid(dgvReports)
            If cboReportType.Items.Count > 0 Then cboReportType.SelectedIndex = 0
            dtpFromDate.Value = New Date(Date.Today.Year, 1, 1)
            dtpToDate.Value = Date.Today
        End Sub

        Public Sub New(parent As MainForm)
            Me.New()
            mainForm = parent
        End Sub

        Private Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadReport()
        End Sub

        Public Sub LoadReport()
            If dtpFromDate.Value.Date > dtpToDate.Value.Date Then
                MessageBox.Show("From date must not be after To date.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim filter As String = String.Empty
            Dim dateColumn As String = "r.RequestDate"
            Select Case cboReportType.Text
                Case "Pending Requests"
                    filter = " AND r.Status='Pending'"
                    dateColumn = "r.RequestDate"
                Case "Released Requests"
                    filter = " AND r.Status='Released' AND r.ReleasedDate IS NOT NULL"
                    dateColumn = "r.ReleasedDate"
                Case "Payments Collected"
                    filter = " AND r.PaymentStatus='Paid' AND r.ORDate IS NOT NULL"
                    dateColumn = "r.ORDate"
                Case Else
                    dateColumn = "r.RequestDate"
            End Select
            Dim parameters = New Dictionary(Of String, Object) From {
                {"@fromDate", dtpFromDate.Value.Date}, {"@toDate", dtpToDate.Value.Date}
            }
            Try
                dgvReports.DataSource = Database.GetTable(
                    "SELECT r.RequestNo, r.RequestDate, s.StudentID, " &
                    "CONCAT(s.LastName, ', ', s.FirstName) AS Student, r.TotalAmount, " &
                    "r.PaymentStatus, r.ORNo, r.Status " &
                    "FROM tblrequest r INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                    "WHERE " & dateColumn & " BETWEEN @fromDate AND @toDate" & filter &
                    " ORDER BY " & dateColumn & " DESC, r.RequestID DESC", parameters)
                Dim totalObject = Database.Scalar(
                    "SELECT COALESCE(SUM(r.TotalAmount),0) FROM tblrequest r " &
                    "WHERE " & dateColumn & " BETWEEN @fromDate AND @toDate" & filter, parameters)
                lblReportTotal.Text = If(cboReportType.Text = "Payments Collected", "Collected: ", "Report Total: ") &
                                      Convert.ToDecimal(totalObject).ToString("N2")
                If dgvReports.Columns.Contains("TotalAmount") Then dgvReports.Columns("TotalAmount").DefaultCellStyle.Format = "N2"
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
            LoadReport()
        End Sub

        Private Sub cboReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportType.SelectedIndexChanged
            If IsHandleCreated AndAlso Visible Then LoadReport()
        End Sub
    End Class
End Namespace
