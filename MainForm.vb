Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class MainForm
        Private ReadOnly currentUserId As Integer
        Private ReadOnly currentUserName As String
        Private ReadOnly currentRole As String
        Private activeNavButton As Button
        Private currentChildForm As Form = Nothing

        Public Sub New(userId As Integer, fullName As String, role As String)
            currentUserId = userId
            currentUserName = fullName
            currentRole = role

            InitializeComponent()
            AppTheme.ApplyForm(Me)

            lblAccount.Text = currentUserName & "  •  " & currentRole
            lblOffice.Text = "OFFICE OF THE" & Environment.NewLine & "REGISTRAR"

            If Not AppTheme.IsAdministrator(currentRole) Then
                btnNavUsers.Visible = False
            End If

            ShowDashboard()
        End Sub

        Private Sub SetPageHeader(title As String, Optional subtitle As String = "")
            lblPageTitle.Text = title
            lblPageSubtitle.Text = subtitle
            Dim hasSubtitle = Not String.IsNullOrWhiteSpace(subtitle)
            lblPageSubtitle.Visible = hasSubtitle
            pnlHeading.Height = If(hasSubtitle, 92, 72)
            lblPageTitle.Top = If(hasSubtitle, 19, 21)
            pnlPageMarker.Top = If(hasSubtitle, 20, 15)
            pnlPageMarker.Height = If(hasSubtitle, 52, 42)
        End Sub

        Private Sub SetActiveNavButton(button As Button)
            If activeNavButton IsNot Nothing Then
                activeNavButton.BackColor = AppTheme.SurfaceColor
                activeNavButton.ForeColor = If(activeNavButton Is btnNavSignOut, AppTheme.DangerColor, AppTheme.PrimaryColor)
            End If
            activeNavButton = button
            If button IsNot Nothing Then
                button.BackColor = AppTheme.AccentTintColor
                button.ForeColor = AppTheme.PrimaryColor
            End If
        End Sub

        Public Sub OpenChildForm(childForm As Form, navButton As Button, title As String, Optional subtitle As String = "")
            SetActiveNavButton(navButton)
            SetPageHeader(title, subtitle)

            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
                currentChildForm.Dispose()
            End If

            currentChildForm = childForm
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill

            pnlContent.Controls.Clear()
            pnlContent.Controls.Add(childForm)
            childForm.BringToFront()
            childForm.Show()
        End Sub

        ' =====================================================================
        ' NAVIGATION METHODS
        ' =====================================================================
        Public Sub ShowDashboard()
            OpenChildForm(New DashboardForm(Me), btnNavDashboard, "Dashboard", "Good day, " & currentUserName & ". Here is the current registrar activity.")
        End Sub

        Public Sub ShowStudents(Optional activeOnly As Boolean = False)
            Dim subtitle = If(activeOnly, "Showing active students from the dashboard.", String.Empty)
            OpenChildForm(New StudentsForm(Me, activeOnly), btnNavStudents, "Student Management", subtitle)
        End Sub

        Public Sub ShowDocuments()
            OpenChildForm(New DocumentsForm(Me, currentRole), btnNavDocuments, "Document Management", String.Empty)
        End Sub

        Public Sub ShowNewRequest()
            OpenChildForm(New NewRequestForm(Me, currentUserId), btnNavNewRequest, "New Document Request", "Select an active student and add one or more document types.")
        End Sub

        Public Sub ShowRequests(Optional initialSearch As String = "", Optional dashboardFilter As String = "")
            Dim filterSubtitle = "Search, review request items, and record valid payment or status changes."
            If dashboardFilter <> String.Empty Then filterSubtitle = "Dashboard filter: " & dashboardFilter & "."
            OpenChildForm(New RequestListForm(Me, initialSearch, dashboardFilter), btnNavRequests, "Request List", filterSubtitle)
        End Sub

        Public Sub ShowReports()
            OpenChildForm(New ReportsForm(Me), btnNavReports, "Reports", "View request and payment activity for a selected date range.")
        End Sub

        Public Sub ShowUsers()
            If Not AppTheme.IsAdministrator(currentRole) Then
                MessageBox.Show("Only an Administrator can manage user accounts.", "Access denied",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            OpenChildForm(New UserAccountsForm(Me, currentUserId, currentRole), btnNavUsers, "User Accounts", String.Empty)
        End Sub

        ' =====================================================================
        ' DATABASE ERROR HANDLER
        ' =====================================================================
        Public Shared Sub ShowDatabaseError(ex As Exception)
            MessageBox.Show("The database is not available." & Environment.NewLine &
                            "Import registrar_db.sql, start MySQL, and check the REGISTRAR_DB_* settings." &
                            Environment.NewLine & Environment.NewLine & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        ' =====================================================================
        ' NAVIGATION EVENT HANDLERS
        ' =====================================================================
        Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
            ShowDashboard()
        End Sub

        Private Sub btnNavStudents_Click(sender As Object, e As EventArgs) Handles btnNavStudents.Click
            ShowStudents()
        End Sub

        Private Sub btnNavDocuments_Click(sender As Object, e As EventArgs) Handles btnNavDocuments.Click
            ShowDocuments()
        End Sub

        Private Sub btnNavNewRequest_Click(sender As Object, e As EventArgs) Handles btnNavNewRequest.Click
            ShowNewRequest()
        End Sub

        Private Sub btnNavRequests_Click(sender As Object, e As EventArgs) Handles btnNavRequests.Click
            ShowRequests()
        End Sub

        Private Sub btnNavReports_Click(sender As Object, e As EventArgs) Handles btnNavReports.Click
            ShowReports()
        End Sub

        Private Sub btnNavUsers_Click(sender As Object, e As EventArgs) Handles btnNavUsers.Click
            ShowUsers()
        End Sub

        Private Sub btnNavSignOut_Click(sender As Object, e As EventArgs) Handles btnNavSignOut.Click
            Close()
        End Sub

        Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs) Handles _
            btnNavDashboard.MouseEnter, btnNavStudents.MouseEnter, btnNavDocuments.MouseEnter,
            btnNavNewRequest.MouseEnter, btnNavRequests.MouseEnter, btnNavReports.MouseEnter,
            btnNavUsers.MouseEnter, btnNavSignOut.MouseEnter
            Dim btn = DirectCast(sender, Button)
            If btn IsNot activeNavButton Then
                btn.BackColor = AppTheme.SoftBlueColor
            End If
        End Sub

        Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs) Handles _
            btnNavDashboard.MouseLeave, btnNavStudents.MouseLeave, btnNavDocuments.MouseLeave,
            btnNavNewRequest.MouseLeave, btnNavRequests.MouseLeave, btnNavReports.MouseLeave,
            btnNavUsers.MouseLeave, btnNavSignOut.MouseLeave
            Dim btn = DirectCast(sender, Button)
            If btn IsNot activeNavButton Then
                btn.BackColor = AppTheme.SurfaceColor
            End If
        End Sub
    End Class
End Namespace
