Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class MainForm
        Public Property CurrentUserID As Integer = 1
        Public Property CurrentUserName As String = "Administrator"
        Public Property CurrentUserRole As String = "Administrator"

        Private currentChildForm As Form = Nothing
        Private navButtons As Button()

        Public Sub New()
            InitializeComponent()
            AppTheme.EnsureLogo(picLogo)
            navButtons = New Button() {
                btnNavDashboard, btnNavStudents, btnNavDocuments,
                btnNavNewRequest, btnNavRequestList, btnNavReports, btnNavUserAccounts
            }
        End Sub

        Public Sub New(userId As Integer, fullName As String, role As String)
            Me.New()
            CurrentUserID = userId
            CurrentUserName = fullName
            CurrentUserRole = role
        End Sub

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lblUserNameDisplay.Text = CurrentUserName
            lblUserRoleDisplay.Text = CurrentUserRole
            lblDashboardSubtitle.Text = $"Welcome back, {CurrentUserName}! Here's today's registrar overview."
            UpdateDateTimeDisplay()

            If CurrentUserRole <> "Administrator" Then
                btnNavUserAccounts.Visible = False
            End If

            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return

            ShowDashboard()
            tmrStats.Start()
        End Sub

        Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
            UpdateDateTimeDisplay()
        End Sub

        Private Sub UpdateDateTimeDisplay()
            lblHeaderDateTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy  hh:mm:ss tt")
        End Sub

        Private Sub tmrStats_Tick(sender As Object, e As EventArgs) Handles tmrStats.Tick
            If pnlDashboard.Visible Then
                LoadDashboardStatistics()
                LoadRecentRequests()
            End If
        End Sub

        ' =====================================================================
        ' Navigation & Child Form Management
        ' =====================================================================

        Public Sub OpenChildForm(childForm As Form, navBtn As Button, pageTitle As String)
            If currentChildForm IsNot Nothing Then
                pnlContent.Controls.Remove(currentChildForm)
                currentChildForm.Close()
                currentChildForm.Dispose()
                currentChildForm = Nothing
            End If

            currentChildForm = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill

            pnlDashboard.Visible = False
            pnlContent.Controls.Add(childForm)
            childForm.BringToFront()
            childForm.Show()

            lblHeaderPageTitle.Text = pageTitle
            SetActiveNavButton(navBtn)
        End Sub

        Public Sub ShowDashboard()
            If currentChildForm IsNot Nothing Then
                pnlContent.Controls.Remove(currentChildForm)
                currentChildForm.Close()
                currentChildForm.Dispose()
                currentChildForm = Nothing
            End If

            pnlDashboard.Visible = True
            pnlDashboard.BringToFront()
            lblHeaderPageTitle.Text = "Dashboard"
            SetActiveNavButton(btnNavDashboard)

            LoadDashboardStatistics()
            LoadRecentRequests()
        End Sub

        Private Sub SetActiveNavButton(activeBtn As Button)
            If navButtons Is Nothing Then Return
            For Each btn In navButtons
                If btn Is activeBtn Then
                    btn.BackColor = Color.FromArgb(15, 50, 95)
                    btn.ForeColor = Color.White
                    btn.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
                Else
                    btn.BackColor = Color.FromArgb(8, 25, 50)
                    btn.ForeColor = Color.FromArgb(180, 195, 215)
                    btn.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
                End If
            Next
        End Sub

        ' =====================================================================
        ' Sidebar Navigation Button Handlers
        ' =====================================================================

        Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
            ShowDashboard()
        End Sub

        Private Sub btnNavStudents_Click(sender As Object, e As EventArgs) Handles btnNavStudents.Click
            OpenChildForm(New StudentsForm(Me), btnNavStudents, "Students")
        End Sub

        Private Sub btnNavDocuments_Click(sender As Object, e As EventArgs) Handles btnNavDocuments.Click
            OpenChildForm(New DocumentsForm(Me), btnNavDocuments, "Documents")
        End Sub

        Private Sub btnNavNewRequest_Click(sender As Object, e As EventArgs) Handles btnNavNewRequest.Click
            OpenChildForm(New NewRequestForm(Me), btnNavNewRequest, "New Document Request")
        End Sub

        Private Sub btnNavRequestList_Click(sender As Object, e As EventArgs) Handles btnNavRequestList.Click
            OpenChildForm(New RequestListForm(Me), btnNavRequestList, "Request List")
        End Sub

        Private Sub btnNavReports_Click(sender As Object, e As EventArgs) Handles btnNavReports.Click
            OpenChildForm(New ReportsForm(Me), btnNavReports, "Reports")
        End Sub

        Private Sub btnNavUserAccounts_Click(sender As Object, e As EventArgs) Handles btnNavUserAccounts.Click
            If CurrentUserRole <> "Administrator" Then
                MessageBox.Show("Only administrators can manage user accounts.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            OpenChildForm(New UserAccountsForm(Me), btnNavUserAccounts, "User Accounts")
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            If MessageBox.Show("Are you sure you want to sign out?", "Sign out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Close()
            End If
        End Sub

        ' =====================================================================
        ' Dashboard Data & Handlers
        ' =====================================================================

        Private Sub LoadDashboardStatistics()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim countStudents = Convert.ToInt32(Database.Scalar("SELECT COUNT(*) FROM tblstudents WHERE Status='Active'"))
                Dim countInProgress = Convert.ToInt32(Database.Scalar("SELECT COUNT(*) FROM tblrequest WHERE Status='Processing'"))
                Dim countReady = Convert.ToInt32(Database.Scalar("SELECT COUNT(*) FROM tblrequest WHERE Status='Ready for Release'"))
                Dim countUnpaid = Convert.ToInt32(Database.Scalar("SELECT COUNT(*) FROM tblrequest WHERE PaymentStatus='Unpaid' AND Status<>'Cancelled'"))
                Dim countBacklog = Convert.ToInt32(Database.Scalar("SELECT COUNT(*) FROM tblrequest WHERE Status='Pending'"))

                lblActiveStudentsValue.Text = countStudents.ToString()
                lblInProgressValue.Text = countInProgress.ToString()
                lblReadyValue.Text = countReady.ToString()
                lblUnpaidValue.Text = countUnpaid.ToString()
                lblBacklogValue.Text = countBacklog.ToString()
            Catch ex As Exception
                ' Suppress silent timer errors
            End Try
        End Sub

        Private Sub LoadRecentRequests()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim query = "SELECT r.RequestNo, " &
                            "CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, " &
                            "COALESCE(GROUP_CONCAT(d.DocumentName SEPARATOR ', '), 'No items') AS DocumentName, " &
                            "DATE_FORMAT(r.RequestDate, '%Y-%m-%d') AS RequestDate, " &
                            "r.PaymentStatus, " &
                            "r.Status " &
                            "FROM tblrequest r " &
                            "INNER JOIN tblstudents s ON r.StudentID = s.StudentID " &
                            "LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                            "LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                            "GROUP BY r.RequestID, r.RequestNo, s.FirstName, s.LastName, r.RequestDate, r.PaymentStatus, r.Status " &
                            "ORDER BY r.RequestDate DESC LIMIT 15"

                Dim dt = Database.GetTable(query)
                dgvRecentRequests.DataSource = dt
                lblDashboardRecordCount.Text = $"{dt.Rows.Count} recent requests"
            Catch ex As Exception
                ' Suppress silent timer errors
            End Try
        End Sub

        Private Sub dgvRecentRequests_DoubleClick(sender As Object, e As EventArgs) Handles dgvRecentRequests.DoubleClick
            If dgvRecentRequests.CurrentRow Is Nothing Then Return
            Dim reqNo = dgvRecentRequests.CurrentRow.Cells("colDashReqNo").Value.ToString()
            Using dialog As New RequestDetailsForm(reqNo)
                dialog.ShowDialog(Me)
            End Using
        End Sub

        Private Sub dgvRecentRequests_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRecentRequests.CellFormatting
            If e.RowIndex < 0 Then Return
            If dgvRecentRequests.Columns(e.ColumnIndex).Name = "colDashPayment" AndAlso e.Value IsNot Nothing Then
                Dim payment = e.Value.ToString()
                If payment = "Paid" Then
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52)
                    e.CellStyle.Font = New Font(dgvRecentRequests.Font, FontStyle.Bold)
                Else
                    e.CellStyle.ForeColor = Color.FromArgb(220, 53, 69)
                    e.CellStyle.Font = New Font(dgvRecentRequests.Font, FontStyle.Bold)
                End If
            ElseIf dgvRecentRequests.Columns(e.ColumnIndex).Name = "colDashStatus" AndAlso e.Value IsNot Nothing Then
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
                e.CellStyle.Font = New Font(dgvRecentRequests.Font, FontStyle.Bold)
            End If
        End Sub

        ' =====================================================================
        ' Dashboard Card Navigation Handlers
        ' =====================================================================

        Private Sub pnlActiveStudents_Click(sender As Object, e As EventArgs) Handles pnlActiveStudents.Click, lblActiveStudentsValue.Click, lblActiveStudentsLabel.Click
            OpenChildForm(New StudentsForm(Me, activeOnly:=True), btnNavStudents, "Students")
        End Sub

        Private Sub pnlInProgress_Click(sender As Object, e As EventArgs) Handles pnlInProgress.Click, lblInProgressValue.Click, lblInProgressLabel.Click
            OpenChildForm(New RequestListForm(Me, statusFilter:="In Progress"), btnNavRequestList, "Request List")
        End Sub

        Private Sub pnlReady_Click(sender As Object, e As EventArgs) Handles pnlReady.Click, lblReadyValue.Click, lblReadyLabel.Click
            OpenChildForm(New RequestListForm(Me, statusFilter:="Ready for Pickup"), btnNavRequestList, "Request List")
        End Sub

        Private Sub pnlUnpaid_Click(sender As Object, e As EventArgs) Handles pnlUnpaid.Click, lblUnpaidValue.Click, lblUnpaidLabel.Click
            OpenChildForm(New RequestListForm(Me, paymentFilter:="Unpaid"), btnNavRequestList, "Request List")
        End Sub

        Private Sub pnlBacklog_Click(sender As Object, e As EventArgs) Handles pnlBacklog.Click, lblBacklogValue.Click, lblBacklogLabel.Click
            OpenChildForm(New RequestListForm(Me, statusFilter:="Pending"), btnNavRequestList, "Request List")
        End Sub

        Public Shared Sub ShowDatabaseError(ex As Exception)
            MessageBox.Show("Database error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class
End Namespace
