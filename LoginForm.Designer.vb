Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class LoginForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlBrand = New System.Windows.Forms.Panel()
            Me.picLogo = New System.Windows.Forms.PictureBox()
            Me.lblBrand = New System.Windows.Forms.Label()
            Me.pnlBrandRule = New System.Windows.Forms.Panel()
            Me.pnlGoldBar = New System.Windows.Forms.Panel()
            Me.lblHeading = New System.Windows.Forms.Label()
            Me.lblSubheading = New System.Windows.Forms.Label()
            Me.lblUsername = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.lblUsernameError = New System.Windows.Forms.Label()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.lblPasswordError = New System.Windows.Forms.Label()
            Me.btnLogin = New System.Windows.Forms.Button()
            Me.pnlCardLine = New System.Windows.Forms.Panel()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBrand.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlBrand
            '
            Me.pnlBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.pnlBrand.Controls.Add(Me.picLogo)
            Me.pnlBrand.Controls.Add(Me.lblBrand)
            Me.pnlBrand.Controls.Add(Me.pnlBrandRule)
            Me.pnlBrand.Controls.Add(Me.pnlGoldBar)
            Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
            Me.pnlBrand.Name = "pnlBrand"
            Me.pnlBrand.Size = New System.Drawing.Size(330, 480)
            Me.pnlBrand.TabIndex = 0
            '
            'picLogo
            '
            Me.picLogo.BackColor = System.Drawing.Color.Transparent
            Me.picLogo.Image = AppTheme.AppLogo
            Me.picLogo.Location = New System.Drawing.Point(44, 96)
            Me.picLogo.Name = "picLogo"
            Me.picLogo.Size = New System.Drawing.Size(80, 80)
            Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picLogo.TabIndex = 2
            Me.picLogo.TabStop = False
            '
            'lblBrand
            '
            Me.lblBrand.AutoSize = True
            Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
            Me.lblBrand.ForeColor = System.Drawing.Color.White
            Me.lblBrand.Location = New System.Drawing.Point(44, 202)
            Me.lblBrand.Name = "lblBrand"
            Me.lblBrand.Size = New System.Drawing.Size(262, 28)
            Me.lblBrand.TabIndex = 1
            Me.lblBrand.Text = "OFFICE OF THE REGISTRAR"
            '
            'pnlBrandRule
            '
            Me.pnlBrandRule.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.pnlBrandRule.Location = New System.Drawing.Point(44, 247)
            Me.pnlBrandRule.Name = "pnlBrandRule"
            Me.pnlBrandRule.Size = New System.Drawing.Size(72, 4)
            Me.pnlBrandRule.TabIndex = 0
            '
            'pnlGoldBar
            '
            Me.pnlGoldBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.pnlGoldBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlGoldBar.Location = New System.Drawing.Point(0, 0)
            Me.pnlGoldBar.Name = "pnlGoldBar"
            Me.pnlGoldBar.Size = New System.Drawing.Size(330, 8)
            Me.pnlGoldBar.TabIndex = 3
            '
            'lblHeading
            '
            Me.lblHeading.AutoSize = True
            Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold)
            Me.lblHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblHeading.Location = New System.Drawing.Point(390, 82)
            Me.lblHeading.Name = "lblHeading"
            Me.lblHeading.Size = New System.Drawing.Size(113, 41)
            Me.lblHeading.TabIndex = 1
            Me.lblHeading.Text = "Sign in"
            '
            'lblSubheading
            '
            Me.lblSubheading.AutoSize = True
            Me.lblSubheading.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblSubheading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblSubheading.Location = New System.Drawing.Point(393, 126)
            Me.lblSubheading.Name = "lblSubheading"
            Me.lblSubheading.Size = New System.Drawing.Size(332, 19)
            Me.lblSubheading.TabIndex = 2
            Me.lblSubheading.Text = "Use your authorized registrar account to continue."
            '
            'lblUsername
            '
            Me.lblUsername.AutoSize = True
            Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblUsername.Location = New System.Drawing.Point(393, 177)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(64, 15)
            Me.lblUsername.TabIndex = 3
            Me.lblUsername.Text = "Username"
            '
            'txtUsername
            '
            Me.txtUsername.BackColor = System.Drawing.Color.White
            Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtUsername.Location = New System.Drawing.Point(393, 201)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(350, 25)
            Me.txtUsername.TabIndex = 4
            '
            'lblUsernameError
            '
            Me.lblUsernameError.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblUsernameError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblUsernameError.Location = New System.Drawing.Point(393, 230)
            Me.lblUsernameError.Name = "lblUsernameError"
            Me.lblUsernameError.Size = New System.Drawing.Size(350, 17)
            Me.lblUsernameError.TabIndex = 5
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblPassword.Location = New System.Drawing.Point(393, 252)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(59, 15)
            Me.lblPassword.TabIndex = 6
            Me.lblPassword.Text = "Password"
            '
            'txtPassword
            '
            Me.txtPassword.BackColor = System.Drawing.Color.White
            Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtPassword.Location = New System.Drawing.Point(393, 276)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New System.Drawing.Size(350, 25)
            Me.txtPassword.TabIndex = 7
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'lblPasswordError
            '
            Me.lblPasswordError.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblPasswordError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblPasswordError.Location = New System.Drawing.Point(393, 305)
            Me.lblPasswordError.Name = "lblPasswordError"
            Me.lblPasswordError.Size = New System.Drawing.Size(350, 17)
            Me.lblPasswordError.TabIndex = 8
            '
            'btnLogin
            '
            Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLogin.FlatAppearance.BorderSize = 0
            Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogin.ForeColor = System.Drawing.Color.White
            Me.btnLogin.Location = New System.Drawing.Point(393, 337)
            Me.btnLogin.Name = "btnLogin"
            Me.btnLogin.Size = New System.Drawing.Size(350, 42)
            Me.btnLogin.TabIndex = 9
            Me.btnLogin.Text = "SIGN IN"
            Me.btnLogin.UseVisualStyleBackColor = False
            '
            'pnlCardLine
            '
            Me.pnlCardLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.pnlCardLine.Location = New System.Drawing.Point(393, 397)
            Me.pnlCardLine.Name = "pnlCardLine"
            Me.pnlCardLine.Size = New System.Drawing.Size(350, 3)
            Me.pnlCardLine.TabIndex = 10
            '
            'LoginForm
            '
            Me.AcceptButton = Me.btnLogin
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(820, 480)
            Me.Controls.Add(Me.pnlCardLine)
            Me.Controls.Add(Me.btnLogin)
            Me.Controls.Add(Me.lblPasswordError)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.lblPassword)
            Me.Controls.Add(Me.lblUsernameError)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.lblUsername)
            Me.Controls.Add(Me.lblSubheading)
            Me.Controls.Add(Me.lblHeading)
            Me.Controls.Add(Me.pnlBrand)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "LoginForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Registrar Document Request System - Sign in"
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBrand.ResumeLayout(False)
            Me.pnlBrand.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents pnlBrand As System.Windows.Forms.Panel
        Friend WithEvents picLogo As System.Windows.Forms.PictureBox
        Friend WithEvents lblBrand As System.Windows.Forms.Label
        Friend WithEvents pnlBrandRule As System.Windows.Forms.Panel
        Friend WithEvents pnlGoldBar As System.Windows.Forms.Panel
        Friend WithEvents lblHeading As System.Windows.Forms.Label
        Friend WithEvents lblSubheading As System.Windows.Forms.Label
        Friend WithEvents lblUsername As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblUsernameError As System.Windows.Forms.Label
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents lblPasswordError As System.Windows.Forms.Label
        Friend WithEvents btnLogin As System.Windows.Forms.Button
        Friend WithEvents pnlCardLine As System.Windows.Forms.Panel
    End Class
End Namespace
