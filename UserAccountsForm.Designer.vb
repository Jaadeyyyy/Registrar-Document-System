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
            Dim dgvCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.txtSearchUsers = New System.Windows.Forms.TextBox()
            Me.cboRoleFilter = New System.Windows.Forms.ComboBox()
            Me.btnAddUser = New System.Windows.Forms.Button()
            Me.pnlTableCard = New System.Windows.Forms.Panel()
            Me.lblRecordCount = New System.Windows.Forms.Label()
            Me.btnToggleUserStatus = New System.Windows.Forms.Button()
            Me.btnEditUser = New System.Windows.Forms.Button()
            Me.lblCardTitle = New System.Windows.Forms.Label()
            Me.dgvUsers = New System.Windows.Forms.DataGridView()
            Me.colUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colRole = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colUserStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlHeader.SuspendLayout()
            Me.pnlTableCard.SuspendLayout()
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlHeader.Controls.Add(Me.lblSubtitle)
            Me.pnlHeader.Controls.Add(Me.lblTitle)
            Me.pnlHeader.Location = New System.Drawing.Point(24, 16)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(902, 60)
            Me.pnlHeader.TabIndex = 0
            '
            'lblSubtitle
            '
            Me.lblSubtitle.AutoSize = True
            Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblSubtitle.Location = New System.Drawing.Point(0, 34)
            Me.lblSubtitle.Name = "lblSubtitle"
            Me.lblSubtitle.Size = New System.Drawing.Size(271, 17)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Manage administrator and system user accounts."
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(-2, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(199, 37)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "User Accounts"
            '
            'txtSearchUsers
            '
            Me.txtSearchUsers.BackColor = System.Drawing.Color.White
            Me.txtSearchUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearchUsers.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtSearchUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.txtSearchUsers.Location = New System.Drawing.Point(24, 96)
            Me.txtSearchUsers.Name = "txtSearchUsers"
            Me.txtSearchUsers.Size = New System.Drawing.Size(320, 25)
            Me.txtSearchUsers.TabIndex = 1
            '
            'cboRoleFilter
            '
            Me.cboRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRoleFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboRoleFilter.FormattingEnabled = True
            Me.cboRoleFilter.Items.AddRange(New Object() {"All Roles", "Administrator", "Staff"})
            Me.cboRoleFilter.Location = New System.Drawing.Point(356, 96)
            Me.cboRoleFilter.Name = "cboRoleFilter"
            Me.cboRoleFilter.Size = New System.Drawing.Size(160, 25)
            Me.cboRoleFilter.TabIndex = 2
            '
            'btnAddUser
            '
            Me.btnAddUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddUser.FlatAppearance.BorderSize = 0
            Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddUser.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddUser.ForeColor = System.Drawing.Color.White
            Me.btnAddUser.Location = New System.Drawing.Point(776, 90)
            Me.btnAddUser.Name = "btnAddUser"
            Me.btnAddUser.Size = New System.Drawing.Size(150, 36)
            Me.btnAddUser.TabIndex = 3
            Me.btnAddUser.Text = "+ Add User"
            Me.btnAddUser.UseVisualStyleBackColor = False
            '
            'pnlTableCard
            '
            Me.pnlTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTableCard.BackColor = System.Drawing.Color.White
            Me.pnlTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTableCard.Controls.Add(Me.lblRecordCount)
            Me.pnlTableCard.Controls.Add(Me.btnToggleUserStatus)
            Me.pnlTableCard.Controls.Add(Me.btnEditUser)
            Me.pnlTableCard.Controls.Add(Me.lblCardTitle)
            Me.pnlTableCard.Controls.Add(Me.dgvUsers)
            Me.pnlTableCard.Location = New System.Drawing.Point(24, 145)
            Me.pnlTableCard.Name = "pnlTableCard"
            Me.pnlTableCard.Size = New System.Drawing.Size(902, 480)
            Me.pnlTableCard.TabIndex = 4
            '
            'lblRecordCount
            '
            Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblRecordCount.Location = New System.Drawing.Point(340, 16)
            Me.lblRecordCount.Name = "lblRecordCount"
            Me.lblRecordCount.Size = New System.Drawing.Size(250, 24)
            Me.lblRecordCount.TabIndex = 1
            Me.lblRecordCount.Text = "Showing user accounts"
            Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnToggleUserStatus
            '
            Me.btnToggleUserStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnToggleUserStatus.BackColor = System.Drawing.Color.White
            Me.btnToggleUserStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToggleUserStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToggleUserStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnToggleUserStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleUserStatus.Location = New System.Drawing.Point(725, 12)
            Me.btnToggleUserStatus.Name = "btnToggleUserStatus"
            Me.btnToggleUserStatus.Size = New System.Drawing.Size(160, 32)
            Me.btnToggleUserStatus.TabIndex = 3
            Me.btnToggleUserStatus.Text = "Activate / Deactivate"
            Me.btnToggleUserStatus.UseVisualStyleBackColor = False
            '
            'btnEditUser
            '
            Me.btnEditUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEditUser.BackColor = System.Drawing.Color.White
            Me.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditUser.Location = New System.Drawing.Point(625, 12)
            Me.btnEditUser.Name = "btnEditUser"
            Me.btnEditUser.Size = New System.Drawing.Size(90, 32)
            Me.btnEditUser.TabIndex = 2
            Me.btnEditUser.Text = "Edit"
            Me.btnEditUser.UseVisualStyleBackColor = False
            '
            'lblCardTitle
            '
            Me.lblCardTitle.AutoSize = True
            Me.lblCardTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblCardTitle.Location = New System.Drawing.Point(16, 16)
            Me.lblCardTitle.Name = "lblCardTitle"
            Me.lblCardTitle.Size = New System.Drawing.Size(176, 21)
            Me.lblCardTitle.TabIndex = 0
            Me.lblCardTitle.Text = "System User Accounts"
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
            Me.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsers.ColumnHeadersDefaultCellStyle = dgvCellStyle1
            Me.dgvUsers.ColumnHeadersHeight = 40
            Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUserID, Me.colFullName, Me.colUsername, Me.colRole, Me.colUserStatus})
            dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle2.BackColor = System.Drawing.Color.White
            dgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            dgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvUsers.DefaultCellStyle = dgvCellStyle2
            Me.dgvUsers.EnableHeadersVisualStyles = False
            Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvUsers.Location = New System.Drawing.Point(0, 56)
            Me.dgvUsers.MultiSelect = False
            Me.dgvUsers.Name = "dgvUsers"
            Me.dgvUsers.ReadOnly = True
            Me.dgvUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle3.BackColor = System.Drawing.Color.White
            dgvCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dgvCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dgvCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvUsers.RowHeadersDefaultCellStyle = dgvCellStyle3
            Me.dgvUsers.RowHeadersVisible = False
            Me.dgvUsers.RowTemplate.Height = 36
            Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvUsers.Size = New System.Drawing.Size(900, 422)
            Me.dgvUsers.TabIndex = 4
            '
            'colUserID
            '
            Me.colUserID.DataPropertyName = "UserID"
            Me.colUserID.FillWeight = 60.0!
            Me.colUserID.HeaderText = "ID"
            Me.colUserID.Name = "colUserID"
            Me.colUserID.ReadOnly = True
            '
            'colFullName
            '
            Me.colFullName.DataPropertyName = "FullName"
            Me.colFullName.FillWeight = 160.0!
            Me.colFullName.HeaderText = "Full Name"
            Me.colFullName.Name = "colFullName"
            Me.colFullName.ReadOnly = True
            '
            'colUsername
            '
            Me.colUsername.DataPropertyName = "Username"
            Me.colUsername.FillWeight = 120.0!
            Me.colUsername.HeaderText = "Username"
            Me.colUsername.Name = "colUsername"
            Me.colUsername.ReadOnly = True
            '
            'colRole
            '
            Me.colRole.DataPropertyName = "Role"
            Me.colRole.FillWeight = 90.0!
            Me.colRole.HeaderText = "Role"
            Me.colRole.Name = "colRole"
            Me.colRole.ReadOnly = True
            '
            'colUserStatus
            '
            Me.colUserStatus.DataPropertyName = "Status"
            Me.colUserStatus.FillWeight = 80.0!
            Me.colUserStatus.HeaderText = "Status"
            Me.colUserStatus.Name = "colUserStatus"
            Me.colUserStatus.ReadOnly = True
            '
            'UserAccountsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(950, 650)
            Me.Controls.Add(Me.pnlTableCard)
            Me.Controls.Add(Me.btnAddUser)
            Me.Controls.Add(Me.cboRoleFilter)
            Me.Controls.Add(Me.txtSearchUsers)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "UserAccountsForm"
            Me.Text = "User Accounts"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlTableCard.ResumeLayout(False)
            Me.pnlTableCard.PerformLayout()
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As System.Windows.Forms.Label
        Friend WithEvents txtSearchUsers As System.Windows.Forms.TextBox
        Friend WithEvents cboRoleFilter As System.Windows.Forms.ComboBox
        Friend WithEvents btnAddUser As System.Windows.Forms.Button
        Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
        Friend WithEvents lblCardTitle As System.Windows.Forms.Label
        Friend WithEvents lblRecordCount As System.Windows.Forms.Label
        Friend WithEvents btnEditUser As System.Windows.Forms.Button
        Friend WithEvents btnToggleUserStatus As System.Windows.Forms.Button
        Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
        Friend WithEvents colUserID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFullName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colUsername As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colRole As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colUserStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
