Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserAccountsForm
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
            Me.dgvUsers = New System.Windows.Forms.DataGridView()
            Me.btnToggleUserStatus = New System.Windows.Forms.Button()
            Me.btnEditUser = New System.Windows.Forms.Button()
            Me.btnAddUser = New System.Windows.Forms.Button()
            Me.txtSearchUsers = New System.Windows.Forms.TextBox()
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvUsers
            '
            Me.dgvUsers.AllowUserToAddRows = False
            Me.dgvUsers.AllowUserToDeleteRows = False
            Me.dgvUsers.AllowUserToResizeRows = False
            Me.dgvUsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvUsers.BackgroundColor = System.Drawing.Color.White
            Me.dgvUsers.ColumnHeadersHeight = 38
            Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvUsers.Location = New System.Drawing.Point(0, 50)
            Me.dgvUsers.MultiSelect = False
            Me.dgvUsers.Name = "dgvUsers"
            Me.dgvUsers.ReadOnly = True
            Me.dgvUsers.RowHeadersVisible = False
            Me.dgvUsers.RowTemplate.Height = 34
            Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvUsers.Size = New System.Drawing.Size(1085, 472)
            Me.dgvUsers.TabIndex = 4
            '
            'btnToggleUserStatus
            '
            Me.btnToggleUserStatus.BackColor = System.Drawing.Color.White
            Me.btnToggleUserStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToggleUserStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToggleUserStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnToggleUserStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleUserStatus.Location = New System.Drawing.Point(565, 1)
            Me.btnToggleUserStatus.Name = "btnToggleUserStatus"
            Me.btnToggleUserStatus.Size = New System.Drawing.Size(180, 38)
            Me.btnToggleUserStatus.TabIndex = 3
            Me.btnToggleUserStatus.Text = "Activate / Deactivate"
            Me.btnToggleUserStatus.UseVisualStyleBackColor = False
            '
            'btnEditUser
            '
            Me.btnEditUser.BackColor = System.Drawing.Color.White
            Me.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditUser.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditUser.Location = New System.Drawing.Point(455, 1)
            Me.btnEditUser.Name = "btnEditUser"
            Me.btnEditUser.Size = New System.Drawing.Size(100, 38)
            Me.btnEditUser.TabIndex = 2
            Me.btnEditUser.Text = "Edit"
            Me.btnEditUser.UseVisualStyleBackColor = False
            '
            'btnAddUser
            '
            Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddUser.ForeColor = System.Drawing.Color.White
            Me.btnAddUser.Location = New System.Drawing.Point(325, 1)
            Me.btnAddUser.Name = "btnAddUser"
            Me.btnAddUser.Size = New System.Drawing.Size(120, 38)
            Me.btnAddUser.TabIndex = 1
            Me.btnAddUser.Text = "Add User"
            Me.btnAddUser.UseVisualStyleBackColor = False
            '
            'txtSearchUsers
            '
            Me.txtSearchUsers.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchUsers.Name = "txtSearchUsers"
            Me.txtSearchUsers.Size = New System.Drawing.Size(310, 24)
            Me.txtSearchUsers.TabIndex = 0
            '
            'UserAccountsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1085, 522)
            Me.Controls.Add(Me.dgvUsers)
            Me.Controls.Add(Me.btnToggleUserStatus)
            Me.Controls.Add(Me.btnEditUser)
            Me.Controls.Add(Me.btnAddUser)
            Me.Controls.Add(Me.txtSearchUsers)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "UserAccountsForm"
            Me.Text = "User Accounts"
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
        Friend WithEvents btnToggleUserStatus As System.Windows.Forms.Button
        Friend WithEvents btnEditUser As System.Windows.Forms.Button
        Friend WithEvents btnAddUser As System.Windows.Forms.Button
        Friend WithEvents txtSearchUsers As System.Windows.Forms.TextBox
    End Class
End Namespace
