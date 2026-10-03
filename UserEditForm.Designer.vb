Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserEditForm
        Inherits System.Windows.Forms.Form

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

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.lblUsername = New System.Windows.Forms.Label()
            Me.txtUsername = New System.Windows.Forms.TextBox()
            Me.lblUsernameError = New System.Windows.Forms.Label()
            Me.lblFullName = New System.Windows.Forms.Label()
            Me.txtFullName = New System.Windows.Forms.TextBox()
            Me.lblFullNameError = New System.Windows.Forms.Label()
            Me.lblRole = New System.Windows.Forms.Label()
            Me.cboRole = New System.Windows.Forms.ComboBox()
            Me.lblRoleError = New System.Windows.Forms.Label()
            Me.lblPassword = New System.Windows.Forms.Label()
            Me.txtPassword = New System.Windows.Forms.TextBox()
            Me.lblPasswordError = New System.Windows.Forms.Label()
            Me.lblPasswordNote = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblUsername
            '
            Me.lblUsername.AutoSize = True
            Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblUsername.Location = New System.Drawing.Point(24, 28)
            Me.lblUsername.Name = "lblUsername"
            Me.lblUsername.Size = New System.Drawing.Size(69, 17)
            Me.lblUsername.TabIndex = 0
            Me.lblUsername.Text = "Username"
            '
            'txtUsername
            '
            Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtUsername.Location = New System.Drawing.Point(160, 24)
            Me.txtUsername.Name = "txtUsername"
            Me.txtUsername.Size = New System.Drawing.Size(285, 25)
            Me.txtUsername.TabIndex = 1
            '
            'lblUsernameError
            '
            Me.lblUsernameError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblUsernameError.Location = New System.Drawing.Point(160, 52)
            Me.lblUsernameError.Name = "lblUsernameError"
            Me.lblUsernameError.Size = New System.Drawing.Size(285, 17)
            Me.lblUsernameError.TabIndex = 2
            '
            'lblFullName
            '
            Me.lblFullName.AutoSize = True
            Me.lblFullName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblFullName.Location = New System.Drawing.Point(24, 91)
            Me.lblFullName.Name = "lblFullName"
            Me.lblFullName.Size = New System.Drawing.Size(71, 17)
            Me.lblFullName.TabIndex = 3
            Me.lblFullName.Text = "Full Name"
            '
            'txtFullName
            '
            Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFullName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtFullName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtFullName.Location = New System.Drawing.Point(160, 87)
            Me.txtFullName.Name = "txtFullName"
            Me.txtFullName.Size = New System.Drawing.Size(285, 25)
            Me.txtFullName.TabIndex = 4
            '
            'lblFullNameError
            '
            Me.lblFullNameError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblFullNameError.Location = New System.Drawing.Point(160, 115)
            Me.lblFullNameError.Name = "lblFullNameError"
            Me.lblFullNameError.Size = New System.Drawing.Size(285, 17)
            Me.lblFullNameError.TabIndex = 5
            '
            'lblRole
            '
            Me.lblRole.AutoSize = True
            Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblRole.Location = New System.Drawing.Point(24, 154)
            Me.lblRole.Name = "lblRole"
            Me.lblRole.Size = New System.Drawing.Size(35, 17)
            Me.lblRole.TabIndex = 6
            Me.lblRole.Text = "Role"
            '
            'cboRole
            '
            Me.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboRole.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.cboRole.FormattingEnabled = True
            Me.cboRole.Items.AddRange(New Object() {"Administrator", "Registrar Staff"})
            Me.cboRole.Location = New System.Drawing.Point(160, 150)
            Me.cboRole.Name = "cboRole"
            Me.cboRole.Size = New System.Drawing.Size(285, 25)
            Me.cboRole.TabIndex = 7
            Me.cboRole.Text = "Registrar Staff"
            '
            'lblRoleError
            '
            Me.lblRoleError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblRoleError.Location = New System.Drawing.Point(160, 178)
            Me.lblRoleError.Name = "lblRoleError"
            Me.lblRoleError.Size = New System.Drawing.Size(285, 17)
            Me.lblRoleError.TabIndex = 8
            '
            'lblPassword
            '
            Me.lblPassword.AutoSize = True
            Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblPassword.Location = New System.Drawing.Point(24, 217)
            Me.lblPassword.Name = "lblPassword"
            Me.lblPassword.Size = New System.Drawing.Size(66, 17)
            Me.lblPassword.TabIndex = 9
            Me.lblPassword.Text = "Password"
            '
            'txtPassword
            '
            Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtPassword.Location = New System.Drawing.Point(160, 213)
            Me.txtPassword.Name = "txtPassword"
            Me.txtPassword.Size = New System.Drawing.Size(285, 25)
            Me.txtPassword.TabIndex = 10
            Me.txtPassword.UseSystemPasswordChar = True
            '
            'lblPasswordError
            '
            Me.lblPasswordError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblPasswordError.Location = New System.Drawing.Point(160, 241)
            Me.lblPasswordError.Name = "lblPasswordError"
            Me.lblPasswordError.Size = New System.Drawing.Size(285, 17)
            Me.lblPasswordError.TabIndex = 11
            '
            'lblPasswordNote
            '
            Me.lblPasswordNote.AutoSize = True
            Me.lblPasswordNote.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.lblPasswordNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblPasswordNote.Location = New System.Drawing.Point(160, 260)
            Me.lblPasswordNote.Name = "lblPasswordNote"
            Me.lblPasswordNote.Size = New System.Drawing.Size(138, 15)
            Me.lblPasswordNote.TabIndex = 12
            Me.lblPasswordNote.Text = "Use at least 6 characters."
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderSize = 1
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(160, 330)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(135, 38)
            Me.btnSave.TabIndex = 13
            Me.btnSave.Text = "Save User"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.White
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnCancel.FlatAppearance.BorderSize = 1
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(305, 330)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(140, 38)
            Me.btnCancel.TabIndex = 14
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'UserEditForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(480, 405)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.lblPasswordNote)
            Me.Controls.Add(Me.lblPasswordError)
            Me.Controls.Add(Me.txtPassword)
            Me.Controls.Add(Me.lblPassword)
            Me.Controls.Add(Me.lblRoleError)
            Me.Controls.Add(Me.cboRole)
            Me.Controls.Add(Me.lblRole)
            Me.Controls.Add(Me.lblFullNameError)
            Me.Controls.Add(Me.txtFullName)
            Me.Controls.Add(Me.lblFullName)
            Me.Controls.Add(Me.lblUsernameError)
            Me.Controls.Add(Me.txtUsername)
            Me.Controls.Add(Me.lblUsername)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "UserEditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "User Account"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblUsername As System.Windows.Forms.Label
        Friend WithEvents txtUsername As System.Windows.Forms.TextBox
        Friend WithEvents lblUsernameError As System.Windows.Forms.Label
        Friend WithEvents lblFullName As System.Windows.Forms.Label
        Friend WithEvents txtFullName As System.Windows.Forms.TextBox
        Friend WithEvents lblFullNameError As System.Windows.Forms.Label
        Friend WithEvents lblRole As System.Windows.Forms.Label
        Friend WithEvents cboRole As System.Windows.Forms.ComboBox
        Friend WithEvents lblRoleError As System.Windows.Forms.Label
        Friend WithEvents lblPassword As System.Windows.Forms.Label
        Friend WithEvents txtPassword As System.Windows.Forms.TextBox
        Friend WithEvents lblPasswordError As System.Windows.Forms.Label
        Friend WithEvents lblPasswordNote As System.Windows.Forms.Label
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace
