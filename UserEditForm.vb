Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class UserEditForm
        Private ReadOnly currentLoggedInUserId As Integer
        Private ReadOnly targetUserId As Integer?
        Private ReadOnly isEditing As Boolean

        Public Sub New(Optional loggedInUserId As Integer = 1, Optional userId As Integer? = Nothing)
            currentLoggedInUserId = loggedInUserId
            targetUserId = userId
            isEditing = userId.HasValue

            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnSave, False)
            AppTheme.StyleButton(btnCancel, True)
            AppTheme.StyleTextBox(txtUsername)
            AppTheme.StyleTextBox(txtFullName)
            AppTheme.StyleComboBox(cboRole)
            AppTheme.StyleTextBox(txtPassword)

            Text = If(isEditing, "Edit User", "Add User")
            lblPasswordNote.Text = If(isEditing, "Leave password blank to keep current password.", "Use at least 6 characters.")

            If isEditing Then
                LoadUserData()
            Else
                cboRole.SelectedIndex = 1
            End If
        End Sub

        Private Sub LoadUserData()
            Dim table = Database.GetTable("SELECT UserID,Username,FullName,Role FROM tblusers WHERE UserID=@id",
                                          New Dictionary(Of String, Object) From {{"@id", targetUserId.Value}})
            If table.Rows.Count = 0 Then Return
            Dim row = table.Rows(0)
            txtUsername.Text = row("Username").ToString()
            txtFullName.Text = row("FullName").ToString()
            cboRole.Text = row("Role").ToString()
            If targetUserId.Value = currentLoggedInUserId Then
                cboRole.Enabled = False
            End If
        End Sub

        Private Sub ClearErrors()
            lblUsernameError.Text = String.Empty
            lblFullNameError.Text = String.Empty
            lblRoleError.Text = String.Empty
            lblPasswordError.Text = String.Empty
        End Sub

        Private Function ValidateInput() As Boolean
            ClearErrors()
            Dim valid = True

            If Not Regex.IsMatch(txtUsername.Text.Trim(), "^[A-Za-z0-9._-]{3,30}$") Then
                lblUsernameError.Text = "Use 3-30 letters, numbers, dots, dashes, or underscores."
                valid = False
            End If
            If String.IsNullOrWhiteSpace(txtFullName.Text) Then
                lblFullNameError.Text = "Full name is required."
                valid = False
            End If
            If cboRole.SelectedItem Is Nothing Then
                lblRoleError.Text = "Choose an account role."
                valid = False
            End If
            If Not isEditing AndAlso txtPassword.Text.Length < 6 Then
                lblPasswordError.Text = "Password must contain at least 6 characters."
                valid = False
            ElseIf txtPassword.Text <> String.Empty AndAlso txtPassword.Text.Length < 6 Then
                lblPasswordError.Text = "New password must contain at least 6 characters."
                valid = False
            End If
            Return valid
        End Function

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            If Not ValidateInput() Then Return

            Dim parameters = New Dictionary(Of String, Object) From {
                {"@username", txtUsername.Text.Trim()},
                {"@fullName", txtFullName.Text.Trim()},
                {"@role", cboRole.Text}
            }
            Dim duplicateSql = "SELECT COUNT(*) FROM tblusers WHERE Username=@username"
            If isEditing Then
                duplicateSql &= " AND UserID<>@id"
                parameters.Add("@id", targetUserId.Value)
            End If
            If Convert.ToInt32(Database.Scalar(duplicateSql, parameters)) > 0 Then
                lblUsernameError.Text = "That username already exists."
                Return
            End If

            If isEditing Then
                If txtPassword.Text = String.Empty Then
                    Database.Execute("UPDATE tblusers SET Username=@username,FullName=@fullName,Role=@role WHERE UserID=@id", parameters)
                Else
                    parameters.Add("@password", txtPassword.Text)
                    Database.Execute("UPDATE tblusers SET Username=@username,FullName=@fullName,Role=@role,Password=@password WHERE UserID=@id", parameters)
                End If
            Else
                parameters.Add("@password", txtPassword.Text)
                Database.Execute("INSERT INTO tblusers(Username,Password,FullName,Role,Status) VALUES(@username,@password,@fullName,@role,'Active')", parameters)
            End If

            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles _
            txtUsername.TextChanged, txtFullName.TextChanged, cboRole.SelectedIndexChanged, txtPassword.TextChanged
            If sender Is txtUsername Then lblUsernameError.Text = String.Empty
            If sender Is txtFullName Then lblFullNameError.Text = String.Empty
            If sender Is cboRole Then lblRoleError.Text = String.Empty
            If sender Is txtPassword Then lblPasswordError.Text = String.Empty
        End Sub
    End Class
End Namespace
