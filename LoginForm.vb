Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class LoginForm
        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleTextBox(txtUsername)
            AppTheme.StyleTextBox(txtPassword)
            AppTheme.SetPlaceholder(txtUsername, "Enter username")
            AppTheme.SetPlaceholder(txtPassword, "Enter password")
        End Sub

        Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
            lblUsernameError.Text = String.Empty
        End Sub

        Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
            lblPasswordError.Text = String.Empty
        End Sub

        Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
            lblUsernameError.Text = String.Empty
            lblPasswordError.Text = String.Empty
            If String.IsNullOrWhiteSpace(txtUsername.Text) Then lblUsernameError.Text = "Username is required."
            If String.IsNullOrWhiteSpace(txtPassword.Text) Then lblPasswordError.Text = "Password is required."
            If lblUsernameError.Text <> String.Empty OrElse lblPasswordError.Text <> String.Empty Then Return

            btnLogin.Enabled = False
            Try
                Dim parameters = New Dictionary(Of String, Object) From {
                    {"@username", txtUsername.Text.Trim()},
                    {"@password", txtPassword.Text}
                }
                Dim user = Database.GetTable(
                    "SELECT UserID, FullName, Role " &
                    "FROM tblusers " &
                    "WHERE Username=@username AND Password=@password AND Status='Active'", parameters)

                If user.Rows.Count = 0 Then
                    MessageBox.Show("The username or password is incorrect, or the account is inactive.",
                                    "Sign in failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPassword.SelectAll()
                    txtPassword.Focus()
                    Return
                End If

                Hide()
                Using main As New MainForm(
                    Convert.ToInt32(user.Rows(0)("UserID")),
                    user.Rows(0)("FullName").ToString(),
                    user.Rows(0)("Role").ToString())
                    main.ShowDialog()
                End Using
                Show()
                txtPassword.Clear()
                txtPassword.Focus()
            Catch ex As Exception
                MessageBox.Show(
                    "Cannot connect to MySQL at " & Database.ConnectionSummary() & "." &
                    Environment.NewLine & "Check the database service and REGISTRAR_DB_* settings." &
                    Environment.NewLine & Environment.NewLine & ex.Message,
                    "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                btnLogin.Enabled = True
            End Try
        End Sub
    End Class
End Namespace
