Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class DashboardForm
        Private ReadOnly mainForm As MainForm

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleGrid(dgvRecentRequests)
        End Sub

        Public Sub New(parent As MainForm)
            Me.New()
            mainForm = parent
        End Sub

        Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadDashboard()
            dashboardTimer.Start()
        End Sub

        Public Sub LoadDashboard()
            Try
                Dim stats = Database.GetTable(
                    "SELECT " &
                    "(SELECT COUNT(*) FROM tblstudents WHERE Status='Active') AS ActiveStudents, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE Status IN ('Pending','Processing')) AS InProgress, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE Status='Ready for Release') AS Ready, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE PaymentStatus='Unpaid' AND Status<>'Cancelled') AS Unpaid, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE Status='Pending') AS Backlog")

                If stats.Rows.Count > 0 Then
                    Dim row = stats.Rows(0)
                    lblActiveStudentsValue.Text = row("ActiveStudents").ToString()
                    lblInProgressValue.Text = row("InProgress").ToString()
                    lblReadyValue.Text = row("Ready").ToString()
                    lblUnpaidValue.Text = row("Unpaid").ToString()
                    lblBacklogValue.Text = row("Backlog").ToString()
                End If

                dgvRecentRequests.DataSource = Database.GetTable(
                    "SELECT r.RequestID, r.RequestNo, r.RequestDate, " &
                    "CONCAT(s.LastName, ', ', s.FirstName) AS Student, " &
                    "r.TotalAmount, r.PaymentStatus, r.Status " &
                    "FROM tblrequest r INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                    "ORDER BY r.RequestID DESC LIMIT 8")
                If dgvRecentRequests.Columns.Contains("RequestID") Then
                    dgvRecentRequests.Columns("RequestID").Visible = False
                End If
                If dgvRecentRequests.Columns.Contains("TotalAmount") Then
                    dgvRecentRequests.Columns("TotalAmount").DefaultCellStyle.Format = "N2"
                End If
                AppTheme.FitGridToRows(dgvRecentRequests, 330)
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub Card_MouseEnter(sender As Object, e As EventArgs) Handles _
            pnlActiveStudents.MouseEnter, pnlInProgress.MouseEnter, pnlReady.MouseEnter, pnlUnpaid.MouseEnter, pnlBacklog.MouseEnter
            DirectCast(sender, Panel).BackColor = AppTheme.AccentTintColor
        End Sub

        Private Sub Card_MouseLeave(sender As Object, e As EventArgs) Handles _
            pnlActiveStudents.MouseLeave, pnlInProgress.MouseLeave, pnlReady.MouseLeave, pnlUnpaid.MouseLeave, pnlBacklog.MouseLeave
            DirectCast(sender, Panel).BackColor = Color.White
        End Sub

        Private Sub ActiveStudents_Click(sender As Object, e As EventArgs) Handles _
            pnlActiveStudents.Click, lblActiveStudentsValue.Click, lblActiveStudentsLabel.Click
            If mainForm IsNot Nothing Then
                mainForm.ShowStudents(True)
            End If
        End Sub

        Private Sub InProgress_Click(sender As Object, e As EventArgs) Handles _
            pnlInProgress.Click, lblInProgressValue.Click, lblInProgressLabel.Click
            If mainForm IsNot Nothing Then
                mainForm.ShowRequests(String.Empty, "InProgress")
            End If
        End Sub

        Private Sub Ready_Click(sender As Object, e As EventArgs) Handles _
            pnlReady.Click, lblReadyValue.Click, lblReadyLabel.Click
            If mainForm IsNot Nothing Then
                mainForm.ShowRequests(String.Empty, "Ready")
            End If
        End Sub

        Private Sub Unpaid_Click(sender As Object, e As EventArgs) Handles _
            pnlUnpaid.Click, lblUnpaidValue.Click, lblUnpaidLabel.Click
            If mainForm IsNot Nothing Then
                mainForm.ShowRequests(String.Empty, "Unpaid")
            End If
        End Sub

        Private Sub Backlog_Click(sender As Object, e As EventArgs) Handles _
            pnlBacklog.Click, lblBacklogValue.Click, lblBacklogLabel.Click
            If mainForm IsNot Nothing Then
                mainForm.ShowRequests(String.Empty, "Backlog")
            End If
        End Sub

        Private Sub dgvRecentRequests_DoubleClick(sender As Object, e As EventArgs) Handles dgvRecentRequests.DoubleClick
            If dgvRecentRequests.CurrentRow Is Nothing Then Return
            If dgvRecentRequests.Columns.Contains("RequestID") Then
                Dim id = Convert.ToInt32(dgvRecentRequests.CurrentRow.Cells("RequestID").Value)
                Using dialog As New RequestDetailsForm(id)
                    dialog.ShowDialog(Me)
                End Using
            End If
        End Sub

        Private Sub dashboardTimer_Tick(sender As Object, e As EventArgs) Handles dashboardTimer.Tick
            If Visible Then
                LoadDashboard()
            End If
        End Sub
    End Class
End Namespace
