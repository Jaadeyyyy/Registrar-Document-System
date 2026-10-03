Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class UserAccountsForm
        Private ReadOnly mainForm As MainForm

        Public Sub New()
            InitializeComponent()
            cboRoleFilter.SelectedIndex = 0
            AppTheme.SetPlaceholder(txtSearchUsers, "Search full name, username, or role...")
        End Sub

        Public Sub New(parent As MainForm)
            Me.New()
            mainForm = parent
        End Sub

        Private Sub UserAccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            RefreshUsersData()
        End Sub

        Public Sub RefreshUsersData()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim conditions As New List(Of String)()
                Dim parameters As New Dictionary(Of String, Object)()

                Dim search = txtSearchUsers.Text.Trim()
                If Not String.IsNullOrEmpty(search) Then
                    conditions.Add("(FullName LIKE @search OR Username LIKE @search)")
                    parameters.Add("@search", "%" & search & "%")
                End If

                If cboRoleFilter.SelectedIndex > 0 Then
                    conditions.Add("Role = @role")
                    parameters.Add("@role", cboRoleFilter.SelectedItem.ToString())
                End If

                Dim whereClause = If(conditions.Count > 0, "WHERE " & String.Join(" AND ", conditions), String.Empty)

                Dim query = "SELECT UserID, FullName, Username, Role, Status " &
                            "FROM tblusers " &
                            whereClause & " " &
                            "ORDER BY FullName"

                Dim dt = Database.GetTable(query, parameters)
                dgvUsers.DataSource = dt
                lblRecordCount.Text = $"{dt.Rows.Count} users"
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchUsers_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUsers.TextChanged
            RefreshUsersData()
        End Sub

        Private Sub cboRoleFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoleFilter.SelectedIndexChanged
            RefreshUsersData()
        End Sub

        Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
            Using dialog As New UserEditForm()
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshUsersData()
                End If
            End Using
        End Sub

        Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
            If dgvUsers.CurrentRow Is Nothing Then
                MessageBox.Show("Select a user first.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells("colUserID").Value)
            Using dialog As New UserEditForm(userId)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshUsersData()
                End If
            End Using
        End Sub

        Private Sub btnToggleUserStatus_Click(sender As Object, e As EventArgs) Handles btnToggleUserStatus.Click
            If dgvUsers.CurrentRow Is Nothing Then
                MessageBox.Show("Select a user first.", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells("colUserID").Value)
            Dim username = dgvUsers.CurrentRow.Cells("colUsername").Value.ToString()
            Dim currentStatus = dgvUsers.CurrentRow.Cells("colUserStatus").Value.ToString()

            If mainForm IsNot Nothing AndAlso userId = mainForm.CurrentUserID Then
                MessageBox.Show("You cannot change the status of your own account.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim newStatus = If(currentStatus = "Active", "Inactive", "Active")
            If MessageBox.Show("Set user " & username & " to " & newStatus & "?",
                               "Confirm status", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Database.Execute("UPDATE tblusers SET Status=@status WHERE UserID=@id",
                             New Dictionary(Of String, Object) From {{"@status", newStatus}, {"@id", userId}})
            RefreshUsersData()
        End Sub

        Private Sub dgvUsers_DoubleClick(sender As Object, e As EventArgs) Handles dgvUsers.DoubleClick
            btnEditUser.PerformClick()
        End Sub

        Private Sub dgvUsers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUsers.CellFormatting
            If e.RowIndex < 0 Then Return
            If dgvUsers.Columns(e.ColumnIndex).Name = "colUserStatus" AndAlso e.Value IsNot Nothing Then
                If e.Value.ToString() = "Active" Then
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52)
                    e.CellStyle.Font = New Font(dgvUsers.Font, FontStyle.Bold)
                Else
                    e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184)
                End If
            ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "colRole" AndAlso e.Value IsNot Nothing Then
                If e.Value.ToString() = "Administrator" Then
                    e.CellStyle.ForeColor = Color.FromArgb(8, 52, 112)
                    e.CellStyle.Font = New Font(dgvUsers.Font, FontStyle.Bold)
                End If
            End If
        End Sub
    End Class
End Namespace
