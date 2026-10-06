Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class LoginForm
        Private Const MaxAttempts As Integer = 3
        Private Const LockSeconds As Integer = 60

        Private failedAttempts As New Dictionary(Of Integer, Integer)
        Private lockedUntil As New Dictionary(Of Integer, DateTime)
        Private currentAccountId As Integer = 0

        Private WithEvents tmrLockout As New System.Windows.Forms.Timer With {
            .Interval = 1000
        }

        Public Sub New()
            InitializeComponent()

            AppTheme.ApplyForm(Me)
            AppTheme.EnsureLogo(picLogo)
            AppTheme.StyleTextBox(txtUsername)
            AppTheme.StyleTextBox(txtPassword)

            AppTheme.SetPlaceholder(txtUsername, "Enter username")
            AppTheme.SetPlaceholder(txtPassword, "Enter password")

            chkShowPassword.Checked = False
            txtPassword.PasswordChar = ChrW(0)
            txtPassword.UseSystemPasswordChar = True

            lblHeading.Text = "Login"
            btnLogin.Text = "LOGIN"

            lblUsernameError.Text = String.Empty
            lblPasswordError.Text = String.Empty

            tmrLockout.Start()
        End Sub

        Private Sub chkShowPassword_CheckedChanged(
            sender As Object,
            e As EventArgs
        ) Handles chkShowPassword.CheckedChanged

            txtPassword.PasswordChar = ChrW(0)
            txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
        End Sub

        Private Sub txtUsername_TextChanged(
            sender As Object,
            e As EventArgs
        ) Handles txtUsername.TextChanged

            currentAccountId = 0
            lblUsernameError.Text = String.Empty
            lblPasswordError.Text = String.Empty
        End Sub

        Private Sub txtPassword_TextChanged(
            sender As Object,
            e As EventArgs
        ) Handles txtPassword.TextChanged

            If Not ShowCurrentLockout() Then
                lblPasswordError.Text = String.Empty
            End If
        End Sub

        Private Function ShowCurrentLockout() As Boolean
            If currentAccountId = 0 Then Return False
            If Not lockedUntil.ContainsKey(currentAccountId) Then Return False

            Dim secondsLeft As Integer = CInt(
                Math.Ceiling(
                    (lockedUntil(currentAccountId) - DateTime.UtcNow).TotalSeconds
                )
            )

            If secondsLeft <= 0 Then
                lockedUntil.Remove(currentAccountId)
                failedAttempts.Remove(currentAccountId)
                lblPasswordError.Text = String.Empty
                Return False
            End If

            Dim remaining As TimeSpan = TimeSpan.FromSeconds(secondsLeft)

            lblPasswordError.Text =
                $"Locked. Try again in {remaining.Minutes:00}:{remaining.Seconds:00}"

            Return True
        End Function

        Private Sub tmrLockout_Tick(
            sender As Object,
            e As EventArgs
        ) Handles tmrLockout.Tick

            ShowCurrentLockout()
        End Sub

        Private Sub btnLogin_Click(
            sender As Object,
            e As EventArgs
        ) Handles btnLogin.Click

            lblUsernameError.Text = String.Empty
            lblPasswordError.Text = String.Empty

            If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
               String.IsNullOrEmpty(txtPassword.Text) Then

                lblPasswordError.Text = "Enter your username and password."
                Return
            End If

            btnLogin.Enabled = False

            Try
                Dim parameters As New Dictionary(Of String, Object) From {
                    {"@username", txtUsername.Text.Trim()},
                    {"@password", txtPassword.Text}
                }

                Dim user = Database.GetTable(
                    "SELECT UserID, FullName, Role, " &
                    "CASE WHEN Password=@password THEN 1 ELSE 0 END AS PasswordMatches " &
                    "FROM tblusers " &
                    "WHERE Username=@username AND Status='Active'",
                    parameters
                )

                If user.Rows.Count = 0 Then
                    currentAccountId = 0
                    lblPasswordError.Text = "Incorrect username or password."
                    txtPassword.SelectAll()
                    txtPassword.Focus()
                    Return
                End If

                Dim row = user.Rows(0)
                Dim userId As Integer = Convert.ToInt32(row("UserID"))
                Dim role As String = row("Role").ToString()

                Dim isRegistrarStaff As Boolean =
                    String.Equals(
                        role.Trim(),
                        "Registrar Staff",
                        StringComparison.OrdinalIgnoreCase
                    )

                currentAccountId = If(isRegistrarStaff, userId, 0)

                If isRegistrarStaff AndAlso ShowCurrentLockout() Then
                    Return
                End If

                Dim correctPassword As Boolean =
                    Convert.ToInt32(row("PasswordMatches")) = 1

                If Not correctPassword Then
                    If isRegistrarStaff Then
                        If Not failedAttempts.ContainsKey(userId) Then
                            failedAttempts(userId) = 0
                        End If

                        failedAttempts(userId) += 1

                        If failedAttempts(userId) >= MaxAttempts Then
                            lockedUntil(userId) =
                                DateTime.UtcNow.AddSeconds(LockSeconds)

                            ShowCurrentLockout()
                        Else
                            Dim attemptsLeft As Integer =
                                MaxAttempts - failedAttempts(userId)

                            lblPasswordError.Text = If(
                                attemptsLeft = 1,
                                "Incorrect password. 1 attempt left.",
                                $"Incorrect password. {attemptsLeft} attempts left."
                            )
                        End If
                    Else
                        lblPasswordError.Text = "Incorrect username or password."
                    End If

                    txtPassword.SelectAll()
                    txtPassword.Focus()
                    Return
                End If

                failedAttempts.Remove(userId)
                lockedUntil.Remove(userId)
                currentAccountId = 0
                lblPasswordError.Text = String.Empty

                Hide()

                Try
                    Using main As New MainForm(
                        userId,
                        row("FullName").ToString(),
                        role
                    )
                        main.ShowDialog()
                    End Using
                Finally
                    txtPassword.Clear()
                    chkShowPassword.Checked = False
                    txtPassword.PasswordChar = ChrW(0)
                    txtPassword.UseSystemPasswordChar = True

                    Show()
                    txtPassword.Focus()
                End Try

            Catch ex As Exception
                MessageBox.Show(
                    ex.Message,
                    "Login error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            Finally
                btnLogin.Enabled = True
            End Try
        End Sub

        Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
            tmrLockout.Stop()
            tmrLockout.Dispose()
            MyBase.OnFormClosed(e)
        End Sub
    End Class
End Namespace