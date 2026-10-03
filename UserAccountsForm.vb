Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class UserAccountsForm
        Private ReadOnly mainForm As MainForm
        Private ReadOnly currentUserId As Integer
        Private ReadOnly currentRole As String = String.Empty

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnAddUser, False)
            AppTheme.StyleButton(btnEditUser, True)
            AppTheme.StyleButton(btnToggleUserStatus, True)
            AppTheme.StyleTextBox(txtSearchUsers)
            AppTheme.SetPlaceholder(txtSearchUsers, "Search username or person name")
            AppTheme.StyleGrid(dgvUsers)
        End Sub

        Public Sub New(parent As MainForm, userId As Integer, role As String)
            Me.New()
            mainForm = parent
            currentUserId = userId
            currentRole = role
        End Sub

        Private Sub UserAccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If Not AppTheme.IsAdministrator(currentRole) Then
                MessageBox.Show("Only an Administrator can manage user accounts.", "Access denied",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Enabled = False
                Return
            End If
            RefreshUsersData()
        End Sub

        Public Sub RefreshUsersData()
            If Not AppTheme.IsAdministrator(currentRole) Then Return
            Try
                dgvUsers.DataSource = Database.GetTable(
                    "SELECT UserID, Username, FullName, Role, Status FROM tblusers " &
                    "WHERE CONCAT_WS(' ',Username,FullName) LIKE @search ORDER BY FullName",
                    New Dictionary(Of String, Object) From {{"@search", "%" & txtSearchUsers.Text.Trim() & "%"}})
                If dgvUsers.Columns.Contains("UserID") Then dgvUsers.Columns("UserID").Visible = False
                AppTheme.FitGridToRows(dgvUsers)
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchUsers_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUsers.TextChanged
            RefreshUsersData()
        End Sub

        Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
            Using dialog As New UserEditForm(currentUserId)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshUsersData()
                End If
            End Using
        End Sub

        Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
            If dgvUsers.CurrentRow Is Nothing Then
                MessageBox.Show("Select a user first.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)
            Using dialog As New UserEditForm(currentUserId, id)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshUsersData()
                End If
            End Using
        End Sub

        Private Sub btnToggleUserStatus_Click(sender As Object, e As EventArgs) Handles btnToggleUserStatus.Click
            If dgvUsers.CurrentRow Is Nothing Then
                MessageBox.Show("Select a user first.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)
            If id = currentUserId Then
                MessageBox.Show("You cannot deactivate the account currently signed in.", "User account",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim currentStatus = dgvUsers.CurrentRow.Cells("Status").Value.ToString()
            Dim newStatus = If(currentStatus = AppTheme.ActiveStatus, AppTheme.InactiveStatus, AppTheme.ActiveStatus)
            If MessageBox.Show("Set this user account to " & newStatus & "?", "Confirm status",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Database.Execute("UPDATE tblusers SET Status=@status WHERE UserID=@id",
                                 New Dictionary(Of String, Object) From {{"@status", newStatus}, {"@id", id}})
                RefreshUsersData()
            End If
        End Sub

        Private Sub dgvUsers_DoubleClick(sender As Object, e As EventArgs) Handles dgvUsers.DoubleClick
            btnEditUser.PerformClick()
        End Sub
    End Class
End Namespace
