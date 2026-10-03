Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
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
            Me.components = New System.ComponentModel.Container()
            Dim dgvCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlSidebar = New System.Windows.Forms.Panel()
            Me.pnlUserBadge = New System.Windows.Forms.Panel()
            Me.btnLogout = New System.Windows.Forms.Button()
            Me.lblUserRoleDisplay = New System.Windows.Forms.Label()
            Me.lblUserNameDisplay = New System.Windows.Forms.Label()
            Me.btnNavUserAccounts = New System.Windows.Forms.Button()
            Me.btnNavReports = New System.Windows.Forms.Button()
            Me.btnNavRequestList = New System.Windows.Forms.Button()
            Me.btnNavNewRequest = New System.Windows.Forms.Button()
            Me.btnNavDocuments = New System.Windows.Forms.Button()
            Me.btnNavStudents = New System.Windows.Forms.Button()
            Me.btnNavDashboard = New System.Windows.Forms.Button()
            Me.pnlBrand = New System.Windows.Forms.Panel()
            Me.picLogo = New System.Windows.Forms.PictureBox()
            Me.lblBrandSubtitle = New System.Windows.Forms.Label()
            Me.lblBrandTitle = New System.Windows.Forms.Label()
            Me.pnlTopBar = New System.Windows.Forms.Panel()
            Me.lblSystemGreeting = New System.Windows.Forms.Label()
            Me.lblHeaderDateTime = New System.Windows.Forms.Label()
            Me.lblHeaderPageTitle = New System.Windows.Forms.Label()
            Me.pnlContent = New System.Windows.Forms.Panel()
            Me.pnlDashboard = New System.Windows.Forms.Panel()
            Me.pnlDashboardTableCard = New System.Windows.Forms.Panel()
            Me.lblDashboardRecordCount = New System.Windows.Forms.Label()
            Me.lblDashboardCardTitle = New System.Windows.Forms.Label()
            Me.dgvRecentRequests = New System.Windows.Forms.DataGridView()
            Me.colDashReqNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDashStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDashDoc = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDashDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDashPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDashStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlBacklog = New System.Windows.Forms.Panel()
            Me.lblBacklogLabel = New System.Windows.Forms.Label()
            Me.lblBacklogValue = New System.Windows.Forms.Label()
            Me.pnlAccent5 = New System.Windows.Forms.Panel()
            Me.pnlUnpaid = New System.Windows.Forms.Panel()
            Me.lblUnpaidLabel = New System.Windows.Forms.Label()
            Me.lblUnpaidValue = New System.Windows.Forms.Label()
            Me.pnlAccent4 = New System.Windows.Forms.Panel()
            Me.pnlReady = New System.Windows.Forms.Panel()
            Me.lblReadyLabel = New System.Windows.Forms.Label()
            Me.lblReadyValue = New System.Windows.Forms.Label()
            Me.pnlAccent3 = New System.Windows.Forms.Panel()
            Me.pnlInProgress = New System.Windows.Forms.Panel()
            Me.lblInProgressLabel = New System.Windows.Forms.Label()
            Me.lblInProgressValue = New System.Windows.Forms.Label()
            Me.pnlAccent2 = New System.Windows.Forms.Panel()
            Me.pnlActiveStudents = New System.Windows.Forms.Panel()
            Me.lblActiveStudentsLabel = New System.Windows.Forms.Label()
            Me.lblActiveStudentsValue = New System.Windows.Forms.Label()
            Me.pnlAccent1 = New System.Windows.Forms.Panel()
            Me.pnlDashboardHeader = New System.Windows.Forms.Panel()
            Me.lblDashboardSubtitle = New System.Windows.Forms.Label()
            Me.lblDashboardTitle = New System.Windows.Forms.Label()
            Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
            Me.tmrStats = New System.Windows.Forms.Timer(Me.components)
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSidebar.SuspendLayout()
            Me.pnlUserBadge.SuspendLayout()
            Me.pnlBrand.SuspendLayout()
            Me.pnlTopBar.SuspendLayout()
            Me.pnlContent.SuspendLayout()
            Me.pnlDashboard.SuspendLayout()
            Me.pnlDashboardTableCard.SuspendLayout()
            CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBacklog.SuspendLayout()
            Me.pnlUnpaid.SuspendLayout()
            Me.pnlReady.SuspendLayout()
            Me.pnlInProgress.SuspendLayout()
            Me.pnlActiveStudents.SuspendLayout()
            Me.pnlDashboardHeader.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlSidebar
            '
            Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(50, Byte), Integer))
            Me.pnlSidebar.Controls.Add(Me.pnlUserBadge)
            Me.pnlSidebar.Controls.Add(Me.btnNavUserAccounts)
            Me.pnlSidebar.Controls.Add(Me.btnNavReports)
            Me.pnlSidebar.Controls.Add(Me.btnNavRequestList)
            Me.pnlSidebar.Controls.Add(Me.btnNavNewRequest)
            Me.pnlSidebar.Controls.Add(Me.btnNavDocuments)
            Me.pnlSidebar.Controls.Add(Me.btnNavStudents)
            Me.pnlSidebar.Controls.Add(Me.btnNavDashboard)
            Me.pnlSidebar.Controls.Add(Me.pnlBrand)
            Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
            Me.pnlSidebar.Name = "pnlSidebar"
            Me.pnlSidebar.Size = New System.Drawing.Size(250, 720)
            Me.pnlSidebar.TabIndex = 0
            '
            'pnlUserBadge
            '
            Me.pnlUserBadge.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(38, Byte), Integer))
            Me.pnlUserBadge.Controls.Add(Me.btnLogout)
            Me.pnlUserBadge.Controls.Add(Me.lblUserRoleDisplay)
            Me.pnlUserBadge.Controls.Add(Me.lblUserNameDisplay)
            Me.pnlUserBadge.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlUserBadge.Location = New System.Drawing.Point(0, 642)
            Me.pnlUserBadge.Name = "pnlUserBadge"
            Me.pnlUserBadge.Padding = New System.Windows.Forms.Padding(16, 12, 16, 12)
            Me.pnlUserBadge.Size = New System.Drawing.Size(250, 78)
            Me.pnlUserBadge.TabIndex = 8
            '
            'btnLogout
            '
            Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnLogout.FlatAppearance.BorderSize = 0
            Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
            Me.btnLogout.ForeColor = System.Drawing.Color.White
            Me.btnLogout.Location = New System.Drawing.Point(166, 24)
            Me.btnLogout.Name = "btnLogout"
            Me.btnLogout.Size = New System.Drawing.Size(68, 30)
            Me.btnLogout.TabIndex = 2
            Me.btnLogout.Text = "Logout"
            Me.btnLogout.UseVisualStyleBackColor = False
            '
            'lblUserRoleDisplay
            '
            Me.lblUserRoleDisplay.AutoSize = True
            Me.lblUserRoleDisplay.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUserRoleDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.lblUserRoleDisplay.Location = New System.Drawing.Point(16, 42)
            Me.lblUserRoleDisplay.Name = "lblUserRoleDisplay"
            Me.lblUserRoleDisplay.Size = New System.Drawing.Size(76, 13)
            Me.lblUserRoleDisplay.TabIndex = 1
            Me.lblUserRoleDisplay.Text = "Administrator"
            '
            'lblUserNameDisplay
            '
            Me.lblUserNameDisplay.AutoSize = True
            Me.lblUserNameDisplay.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblUserNameDisplay.ForeColor = System.Drawing.Color.White
            Me.lblUserNameDisplay.Location = New System.Drawing.Point(16, 20)
            Me.lblUserNameDisplay.Name = "lblUserNameDisplay"
            Me.lblUserNameDisplay.Size = New System.Drawing.Size(95, 17)
            Me.lblUserNameDisplay.TabIndex = 0
            Me.lblUserNameDisplay.Text = "Administrator"
            '
            'btnNavUserAccounts
            '
            Me.btnNavUserAccounts.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavUserAccounts.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNavUserAccounts.FlatAppearance.BorderSize = 0
            Me.btnNavUserAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavUserAccounts.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.btnNavUserAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
            Me.btnNavUserAccounts.Location = New System.Drawing.Point(0, 370)
            Me.btnNavUserAccounts.Name = "btnNavUserAccounts"
            Me.btnNavUserAccounts.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
            Me.btnNavUserAccounts.Size = New System.Drawing.Size(250, 48)
            Me.btnNavUserAccounts.TabIndex = 7
            Me.btnNavUserAccounts.Text = "User Accounts"
            Me.btnNavUserAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavUserAccounts.UseVisualStyleBackColor = True
            '
            'btnNavReports
            '
            Me.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavReports.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNavReports.FlatAppearance.BorderSize = 0
            Me.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavReports.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
            Me.btnNavReports.Location = New System.Drawing.Point(0, 322)
            Me.btnNavReports.Name = "btnNavReports"
            Me.btnNavReports.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
            Me.btnNavReports.Size = New System.Drawing.Size(250, 48)
            Me.btnNavReports.TabIndex = 6
            Me.btnNavReports.Text = "Reports"
            Me.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavReports.UseVisualStyleBackColor = True
            '
            'btnNavRequestList
            '
            Me.btnNavRequestList.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavRequestList.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNavRequestList.FlatAppearance.BorderSize = 0
            Me.btnNavRequestList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavRequestList.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.btnNavRequestList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
            Me.btnNavRequestList.Location = New System.Drawing.Point(0, 274)
            Me.btnNavRequestList.Name = "btnNavRequestList"
            Me.btnNavRequestList.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
            Me.btnNavRequestList.Size = New System.Drawing.Size(250, 48)
            Me.btnNavRequestList.TabIndex = 5
            Me.btnNavRequestList.Text = "Request List"
            Me.btnNavRequestList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavRequestList.UseVisualStyleBackColor = True
            '
            'btnNavNewRequest
            '
            Me.btnNavNewRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavNewRequest.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNavNewRequest.FlatAppearance.BorderSize = 0
            Me.btnNavNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavNewRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.btnNavNewRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
            Me.btnNavNewRequest.Location = New System.Drawing.Point(0, 226)
            Me.btnNavNewRequest.Name = "btnNavNewRequest"
            Me.btnNavNewRequest.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
            Me.btnNavNewRequest.Size = New System.Drawing.Size(250, 48)
            Me.btnNavNewRequest.TabIndex = 4
            Me.btnNavNewRequest.Text = "New Request"
            Me.btnNavNewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavNewRequest.UseVisualStyleBackColor = True
            '
            'btnNavDocuments
            '
            Me.btnNavDocuments.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavDocuments.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNavDocuments.FlatAppearance.BorderSize = 0
            Me.btnNavDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavDocuments.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.btnNavDocuments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
            Me.btnNavDocuments.Location = New System.Drawing.Point(0, 178)
            Me.btnNavDocuments.Name = "btnNavDocuments"
            Me.btnNavDocuments.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
            Me.btnNavDocuments.Size = New System.Drawing.Size(250, 48)
            Me.btnNavDocuments.TabIndex = 3
            Me.btnNavDocuments.Text = "Documents"
            Me.btnNavDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavDocuments.UseVisualStyleBackColor = True
            '
            'btnNavStudents
            '
            Me.btnNavStudents.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavStudents.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNavStudents.FlatAppearance.BorderSize = 0
            Me.btnNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavStudents.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.btnNavStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
            Me.btnNavStudents.Location = New System.Drawing.Point(0, 130)
            Me.btnNavStudents.Name = "btnNavStudents"
            Me.btnNavStudents.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
            Me.btnNavStudents.Size = New System.Drawing.Size(250, 48)
            Me.btnNavStudents.TabIndex = 2
            Me.btnNavStudents.Text = "Students"
            Me.btnNavStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavStudents.UseVisualStyleBackColor = True
            '
            'btnNavDashboard
            '
            Me.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(95, Byte), Integer))
            Me.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top
            Me.btnNavDashboard.FlatAppearance.BorderSize = 0
            Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavDashboard.ForeColor = System.Drawing.Color.White
            Me.btnNavDashboard.Location = New System.Drawing.Point(0, 82)
            Me.btnNavDashboard.Name = "btnNavDashboard"
            Me.btnNavDashboard.Padding = New System.Windows.Forms.Padding(24, 0, 0, 0)
            Me.btnNavDashboard.Size = New System.Drawing.Size(250, 48)
            Me.btnNavDashboard.TabIndex = 1
            Me.btnNavDashboard.Text = "Dashboard"
            Me.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavDashboard.UseVisualStyleBackColor = False
            '
            'pnlBrand
            '
            Me.pnlBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.pnlBrand.Controls.Add(Me.picLogo)
            Me.pnlBrand.Controls.Add(Me.lblBrandSubtitle)
            Me.pnlBrand.Controls.Add(Me.lblBrandTitle)
            Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
            Me.pnlBrand.Name = "pnlBrand"
            Me.pnlBrand.Padding = New System.Windows.Forms.Padding(14, 14, 14, 14)
            Me.pnlBrand.Size = New System.Drawing.Size(250, 82)
            Me.pnlBrand.TabIndex = 0
            '
            'picLogo
            '
            Me.picLogo.BackColor = System.Drawing.Color.Transparent
            Me.picLogo.Image = AppTheme.AppLogo
            Me.picLogo.Location = New System.Drawing.Point(14, 15)
            Me.picLogo.Name = "picLogo"
            Me.picLogo.Size = New System.Drawing.Size(52, 52)
            Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.picLogo.TabIndex = 2
            Me.picLogo.TabStop = False
            '
            'lblBrandSubtitle
            '
            Me.lblBrandSubtitle.AutoSize = True
            Me.lblBrandSubtitle.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.lblBrandSubtitle.Location = New System.Drawing.Point(73, 43)
            Me.lblBrandSubtitle.Name = "lblBrandSubtitle"
            Me.lblBrandSubtitle.Size = New System.Drawing.Size(142, 13)
            Me.lblBrandSubtitle.TabIndex = 1
            Me.lblBrandSubtitle.Text = "Document Request System"
            '
            'lblBrandTitle
            '
            Me.lblBrandTitle.AutoSize = True
            Me.lblBrandTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblBrandTitle.ForeColor = System.Drawing.Color.White
            Me.lblBrandTitle.Location = New System.Drawing.Point(72, 18)
            Me.lblBrandTitle.Name = "lblBrandTitle"
            Me.lblBrandTitle.Size = New System.Drawing.Size(100, 21)
            Me.lblBrandTitle.TabIndex = 0
            Me.lblBrandTitle.Text = "REGISTRAR"
            '
            'pnlTopBar
            '
            Me.pnlTopBar.BackColor = System.Drawing.Color.White
            Me.pnlTopBar.Controls.Add(Me.lblSystemGreeting)
            Me.pnlTopBar.Controls.Add(Me.lblHeaderDateTime)
            Me.pnlTopBar.Controls.Add(Me.lblHeaderPageTitle)
            Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTopBar.Location = New System.Drawing.Point(250, 0)
            Me.pnlTopBar.Name = "pnlTopBar"
            Me.pnlTopBar.Padding = New System.Windows.Forms.Padding(24, 0, 24, 0)
            Me.pnlTopBar.Size = New System.Drawing.Size(950, 68)
            Me.pnlTopBar.TabIndex = 1
            '
            'lblSystemGreeting
            '
            Me.lblSystemGreeting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSystemGreeting.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.lblSystemGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(184, Byte), Integer))
            Me.lblSystemGreeting.Location = New System.Drawing.Point(656, 38)
            Me.lblSystemGreeting.Name = "lblSystemGreeting"
            Me.lblSystemGreeting.Size = New System.Drawing.Size(270, 18)
            Me.lblSystemGreeting.TabIndex = 2
            Me.lblSystemGreeting.Text = "Welcome to the Registrar Portal"
            Me.lblSystemGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblHeaderDateTime
            '
            Me.lblHeaderDateTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblHeaderDateTime.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblHeaderDateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblHeaderDateTime.Location = New System.Drawing.Point(656, 16)
            Me.lblHeaderDateTime.Name = "lblHeaderDateTime"
            Me.lblHeaderDateTime.Size = New System.Drawing.Size(270, 22)
            Me.lblHeaderDateTime.TabIndex = 1
            Me.lblHeaderDateTime.Text = "Wednesday, October 04, 2026"
            Me.lblHeaderDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblHeaderPageTitle
            '
            Me.lblHeaderPageTitle.AutoSize = True
            Me.lblHeaderPageTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lblHeaderPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblHeaderPageTitle.Location = New System.Drawing.Point(24, 22)
            Me.lblHeaderPageTitle.Name = "lblHeaderPageTitle"
            Me.lblHeaderPageTitle.Size = New System.Drawing.Size(109, 25)
            Me.lblHeaderPageTitle.TabIndex = 0
            Me.lblHeaderPageTitle.Text = "Dashboard"
            '
            'pnlContent
            '
            Me.pnlContent.Controls.Add(Me.pnlDashboard)
            Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlContent.Location = New System.Drawing.Point(250, 68)
            Me.pnlContent.Name = "pnlContent"
            Me.pnlContent.Size = New System.Drawing.Size(950, 652)
            Me.pnlContent.TabIndex = 2
            '
            'pnlDashboard
            '
            Me.pnlDashboard.AutoScroll = True
            Me.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.pnlDashboard.Controls.Add(Me.pnlDashboardTableCard)
            Me.pnlDashboard.Controls.Add(Me.pnlBacklog)
            Me.pnlDashboard.Controls.Add(Me.pnlUnpaid)
            Me.pnlDashboard.Controls.Add(Me.pnlReady)
            Me.pnlDashboard.Controls.Add(Me.pnlInProgress)
            Me.pnlDashboard.Controls.Add(Me.pnlActiveStudents)
            Me.pnlDashboard.Controls.Add(Me.pnlDashboardHeader)
            Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDashboard.Location = New System.Drawing.Point(0, 0)
            Me.pnlDashboard.Name = "pnlDashboard"
            Me.pnlDashboard.Padding = New System.Windows.Forms.Padding(24, 16, 24, 24)
            Me.pnlDashboard.Size = New System.Drawing.Size(950, 652)
            Me.pnlDashboard.TabIndex = 0
            '
            'pnlDashboardTableCard
            '
            Me.pnlDashboardTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlDashboardTableCard.BackColor = System.Drawing.Color.White
            Me.pnlDashboardTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlDashboardTableCard.Controls.Add(Me.lblDashboardRecordCount)
            Me.pnlDashboardTableCard.Controls.Add(Me.lblDashboardCardTitle)
            Me.pnlDashboardTableCard.Controls.Add(Me.dgvRecentRequests)
            Me.pnlDashboardTableCard.Location = New System.Drawing.Point(24, 214)
            Me.pnlDashboardTableCard.Name = "pnlDashboardTableCard"
            Me.pnlDashboardTableCard.Size = New System.Drawing.Size(902, 410)
            Me.pnlDashboardTableCard.TabIndex = 6
            '
            'lblDashboardRecordCount
            '
            Me.lblDashboardRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblDashboardRecordCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.lblDashboardRecordCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblDashboardRecordCount.Location = New System.Drawing.Point(620, 16)
            Me.lblDashboardRecordCount.Name = "lblDashboardRecordCount"
            Me.lblDashboardRecordCount.Size = New System.Drawing.Size(265, 24)
            Me.lblDashboardRecordCount.TabIndex = 2
            Me.lblDashboardRecordCount.Text = "Showing latest requests"
            Me.lblDashboardRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblDashboardCardTitle
            '
            Me.lblDashboardCardTitle.AutoSize = True
            Me.lblDashboardCardTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblDashboardCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblDashboardCardTitle.Location = New System.Drawing.Point(16, 16)
            Me.lblDashboardCardTitle.Name = "lblDashboardCardTitle"
            Me.lblDashboardCardTitle.Size = New System.Drawing.Size(135, 21)
            Me.lblDashboardCardTitle.TabIndex = 0
            Me.lblDashboardCardTitle.Text = "Recent Requests"
            '
            'dgvRecentRequests
            '
            Me.dgvRecentRequests.AllowUserToAddRows = False
            Me.dgvRecentRequests.AllowUserToDeleteRows = False
            Me.dgvRecentRequests.AllowUserToResizeRows = False
            Me.dgvRecentRequests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvRecentRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRecentRequests.BackgroundColor = System.Drawing.Color.White
            Me.dgvRecentRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRecentRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvRecentRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRecentRequests.ColumnHeadersDefaultCellStyle = dgvCellStyle1
            Me.dgvRecentRequests.ColumnHeadersHeight = 40
            Me.dgvRecentRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvRecentRequests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDashReqNo, Me.colDashStudent, Me.colDashDoc, Me.colDashDate, Me.colDashPayment, Me.colDashStatus})
            dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle2.BackColor = System.Drawing.Color.White
            dgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            dgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRecentRequests.DefaultCellStyle = dgvCellStyle2
            Me.dgvRecentRequests.EnableHeadersVisualStyles = False
            Me.dgvRecentRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvRecentRequests.Location = New System.Drawing.Point(0, 56)
            Me.dgvRecentRequests.MultiSelect = False
            Me.dgvRecentRequests.Name = "dgvRecentRequests"
            Me.dgvRecentRequests.ReadOnly = True
            Me.dgvRecentRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle3.BackColor = System.Drawing.Color.White
            dgvCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dgvCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dgvCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRecentRequests.RowHeadersDefaultCellStyle = dgvCellStyle3
            Me.dgvRecentRequests.RowHeadersVisible = False
            Me.dgvRecentRequests.RowTemplate.Height = 36
            Me.dgvRecentRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRecentRequests.Size = New System.Drawing.Size(900, 352)
            Me.dgvRecentRequests.TabIndex = 1
            '
            'colDashReqNo
            '
            Me.colDashReqNo.DataPropertyName = "RequestNo"
            Me.colDashReqNo.FillWeight = 110.0!
            Me.colDashReqNo.HeaderText = "Request No"
            Me.colDashReqNo.Name = "colDashReqNo"
            Me.colDashReqNo.ReadOnly = True
            '
            'colDashStudent
            '
            Me.colDashStudent.DataPropertyName = "StudentName"
            Me.colDashStudent.FillWeight = 140.0!
            Me.colDashStudent.HeaderText = "Student Name"
            Me.colDashStudent.Name = "colDashStudent"
            Me.colDashStudent.ReadOnly = True
            '
            'colDashDoc
            '
            Me.colDashDoc.DataPropertyName = "DocumentName"
            Me.colDashDoc.FillWeight = 170.0!
            Me.colDashDoc.HeaderText = "Document"
            Me.colDashDoc.Name = "colDashDoc"
            Me.colDashDoc.ReadOnly = True
            '
            'colDashDate
            '
            Me.colDashDate.DataPropertyName = "RequestDate"
            Me.colDashDate.FillWeight = 90.0!
            Me.colDashDate.HeaderText = "Date"
            Me.colDashDate.Name = "colDashDate"
            Me.colDashDate.ReadOnly = True
            '
            'colDashPayment
            '
            Me.colDashPayment.DataPropertyName = "PaymentStatus"
            Me.colDashPayment.FillWeight = 85.0!
            Me.colDashPayment.HeaderText = "Payment"
            Me.colDashPayment.Name = "colDashPayment"
            Me.colDashPayment.ReadOnly = True
            '
            'colDashStatus
            '
            Me.colDashStatus.DataPropertyName = "Status"
            Me.colDashStatus.FillWeight = 95.0!
            Me.colDashStatus.HeaderText = "Status"
            Me.colDashStatus.Name = "colDashStatus"
            Me.colDashStatus.ReadOnly = True
            '
            'pnlBacklog
            '
            Me.pnlBacklog.BackColor = System.Drawing.Color.White
            Me.pnlBacklog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlBacklog.Controls.Add(Me.lblBacklogLabel)
            Me.pnlBacklog.Controls.Add(Me.lblBacklogValue)
            Me.pnlBacklog.Controls.Add(Me.pnlAccent5)
            Me.pnlBacklog.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlBacklog.Location = New System.Drawing.Point(736, 88)
            Me.pnlBacklog.Name = "pnlBacklog"
            Me.pnlBacklog.Size = New System.Drawing.Size(168, 110)
            Me.pnlBacklog.TabIndex = 5
            '
            'lblBacklogLabel
            '
            Me.lblBacklogLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
            Me.lblBacklogLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblBacklogLabel.Location = New System.Drawing.Point(12, 70)
            Me.lblBacklogLabel.Name = "lblBacklogLabel"
            Me.lblBacklogLabel.Size = New System.Drawing.Size(142, 28)
            Me.lblBacklogLabel.TabIndex = 2
            Me.lblBacklogLabel.Text = "PENDING BACKLOG"
            '
            'lblBacklogValue
            '
            Me.lblBacklogValue.AutoSize = True
            Me.lblBacklogValue.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
            Me.lblBacklogValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblBacklogValue.Location = New System.Drawing.Point(10, 16)
            Me.lblBacklogValue.Name = "lblBacklogValue"
            Me.lblBacklogValue.Size = New System.Drawing.Size(40, 47)
            Me.lblBacklogValue.TabIndex = 1
            Me.lblBacklogValue.Text = "6"
            '
            'pnlAccent5
            '
            Me.pnlAccent5.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(193, Byte), Integer))
            Me.pnlAccent5.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent5.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent5.Name = "pnlAccent5"
            Me.pnlAccent5.Size = New System.Drawing.Size(166, 4)
            Me.pnlAccent5.TabIndex = 0
            '
            'pnlUnpaid
            '
            Me.pnlUnpaid.BackColor = System.Drawing.Color.White
            Me.pnlUnpaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlUnpaid.Controls.Add(Me.lblUnpaidLabel)
            Me.pnlUnpaid.Controls.Add(Me.lblUnpaidValue)
            Me.pnlUnpaid.Controls.Add(Me.pnlAccent4)
            Me.pnlUnpaid.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlUnpaid.Location = New System.Drawing.Point(558, 88)
            Me.pnlUnpaid.Name = "pnlUnpaid"
            Me.pnlUnpaid.Size = New System.Drawing.Size(168, 110)
            Me.pnlUnpaid.TabIndex = 4
            '
            'lblUnpaidLabel
            '
            Me.lblUnpaidLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
            Me.lblUnpaidLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblUnpaidLabel.Location = New System.Drawing.Point(12, 70)
            Me.lblUnpaidLabel.Name = "lblUnpaidLabel"
            Me.lblUnpaidLabel.Size = New System.Drawing.Size(142, 28)
            Me.lblUnpaidLabel.TabIndex = 2
            Me.lblUnpaidLabel.Text = "UNPAID REQUESTS"
            '
            'lblUnpaidValue
            '
            Me.lblUnpaidValue.AutoSize = True
            Me.lblUnpaidValue.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
            Me.lblUnpaidValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblUnpaidValue.Location = New System.Drawing.Point(10, 16)
            Me.lblUnpaidValue.Name = "lblUnpaidValue"
            Me.lblUnpaidValue.Size = New System.Drawing.Size(40, 47)
            Me.lblUnpaidValue.TabIndex = 1
            Me.lblUnpaidValue.Text = "4"
            '
            'pnlAccent4
            '
            Me.pnlAccent4.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.pnlAccent4.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent4.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent4.Name = "pnlAccent4"
            Me.pnlAccent4.Size = New System.Drawing.Size(166, 4)
            Me.pnlAccent4.TabIndex = 0
            '
            'pnlReady
            '
            Me.pnlReady.BackColor = System.Drawing.Color.White
            Me.pnlReady.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlReady.Controls.Add(Me.lblReadyLabel)
            Me.pnlReady.Controls.Add(Me.lblReadyValue)
            Me.pnlReady.Controls.Add(Me.pnlAccent3)
            Me.pnlReady.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlReady.Location = New System.Drawing.Point(380, 88)
            Me.pnlReady.Name = "pnlReady"
            Me.pnlReady.Size = New System.Drawing.Size(168, 110)
            Me.pnlReady.TabIndex = 3
            '
            'lblReadyLabel
            '
            Me.lblReadyLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
            Me.lblReadyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblReadyLabel.Location = New System.Drawing.Point(12, 70)
            Me.lblReadyLabel.Name = "lblReadyLabel"
            Me.lblReadyLabel.Size = New System.Drawing.Size(142, 28)
            Me.lblReadyLabel.TabIndex = 2
            Me.lblReadyLabel.Text = "READY FOR RELEASE"
            '
            'lblReadyValue
            '
            Me.lblReadyValue.AutoSize = True
            Me.lblReadyValue.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
            Me.lblReadyValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblReadyValue.Location = New System.Drawing.Point(10, 16)
            Me.lblReadyValue.Name = "lblReadyValue"
            Me.lblReadyValue.Size = New System.Drawing.Size(40, 47)
            Me.lblReadyValue.TabIndex = 1
            Me.lblReadyValue.Text = "8"
            '
            'pnlAccent3
            '
            Me.pnlAccent3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(84, Byte), Integer))
            Me.pnlAccent3.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent3.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent3.Name = "pnlAccent3"
            Me.pnlAccent3.Size = New System.Drawing.Size(166, 4)
            Me.pnlAccent3.TabIndex = 0
            '
            'pnlInProgress
            '
            Me.pnlInProgress.BackColor = System.Drawing.Color.White
            Me.pnlInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInProgress.Controls.Add(Me.lblInProgressLabel)
            Me.pnlInProgress.Controls.Add(Me.lblInProgressValue)
            Me.pnlInProgress.Controls.Add(Me.pnlAccent2)
            Me.pnlInProgress.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlInProgress.Location = New System.Drawing.Point(202, 88)
            Me.pnlInProgress.Name = "pnlInProgress"
            Me.pnlInProgress.Size = New System.Drawing.Size(168, 110)
            Me.pnlInProgress.TabIndex = 2
            '
            'lblInProgressLabel
            '
            Me.lblInProgressLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
            Me.lblInProgressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblInProgressLabel.Location = New System.Drawing.Point(12, 70)
            Me.lblInProgressLabel.Name = "lblInProgressLabel"
            Me.lblInProgressLabel.Size = New System.Drawing.Size(142, 28)
            Me.lblInProgressLabel.TabIndex = 2
            Me.lblInProgressLabel.Text = "IN PROGRESS"
            '
            'lblInProgressValue
            '
            Me.lblInProgressValue.AutoSize = True
            Me.lblInProgressValue.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
            Me.lblInProgressValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblInProgressValue.Location = New System.Drawing.Point(10, 16)
            Me.lblInProgressValue.Name = "lblInProgressValue"
            Me.lblInProgressValue.Size = New System.Drawing.Size(61, 47)
            Me.lblInProgressValue.TabIndex = 1
            Me.lblInProgressValue.Text = "12"
            '
            'pnlAccent2
            '
            Me.pnlAccent2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
            Me.pnlAccent2.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent2.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent2.Name = "pnlAccent2"
            Me.pnlAccent2.Size = New System.Drawing.Size(166, 4)
            Me.pnlAccent2.TabIndex = 0
            '
            'pnlActiveStudents
            '
            Me.pnlActiveStudents.BackColor = System.Drawing.Color.White
            Me.pnlActiveStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlActiveStudents.Controls.Add(Me.lblActiveStudentsLabel)
            Me.pnlActiveStudents.Controls.Add(Me.lblActiveStudentsValue)
            Me.pnlActiveStudents.Controls.Add(Me.pnlAccent1)
            Me.pnlActiveStudents.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlActiveStudents.Location = New System.Drawing.Point(24, 88)
            Me.pnlActiveStudents.Name = "pnlActiveStudents"
            Me.pnlActiveStudents.Size = New System.Drawing.Size(168, 110)
            Me.pnlActiveStudents.TabIndex = 1
            '
            'lblActiveStudentsLabel
            '
            Me.lblActiveStudentsLabel.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
            Me.lblActiveStudentsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblActiveStudentsLabel.Location = New System.Drawing.Point(12, 70)
            Me.lblActiveStudentsLabel.Name = "lblActiveStudentsLabel"
            Me.lblActiveStudentsLabel.Size = New System.Drawing.Size(142, 28)
            Me.lblActiveStudentsLabel.TabIndex = 2
            Me.lblActiveStudentsLabel.Text = "ACTIVE STUDENTS"
            '
            'lblActiveStudentsValue
            '
            Me.lblActiveStudentsValue.AutoSize = True
            Me.lblActiveStudentsValue.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
            Me.lblActiveStudentsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblActiveStudentsValue.Location = New System.Drawing.Point(10, 16)
            Me.lblActiveStudentsValue.Name = "lblActiveStudentsValue"
            Me.lblActiveStudentsValue.Size = New System.Drawing.Size(82, 47)
            Me.lblActiveStudentsValue.TabIndex = 1
            Me.lblActiveStudentsValue.Text = "150"
            '
            'pnlAccent1
            '
            Me.pnlAccent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.pnlAccent1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent1.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent1.Name = "pnlAccent1"
            Me.pnlAccent1.Size = New System.Drawing.Size(166, 4)
            Me.pnlAccent1.TabIndex = 0
            '
            'pnlDashboardHeader
            '
            Me.pnlDashboardHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlDashboardHeader.Controls.Add(Me.lblDashboardSubtitle)
            Me.pnlDashboardHeader.Controls.Add(Me.lblDashboardTitle)
            Me.pnlDashboardHeader.Location = New System.Drawing.Point(24, 16)
            Me.pnlDashboardHeader.Name = "pnlDashboardHeader"
            Me.pnlDashboardHeader.Size = New System.Drawing.Size(902, 60)
            Me.pnlDashboardHeader.TabIndex = 0
            '
            'lblDashboardSubtitle
            '
            Me.lblDashboardSubtitle.AutoSize = True
            Me.lblDashboardSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblDashboardSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblDashboardSubtitle.Location = New System.Drawing.Point(0, 34)
            Me.lblDashboardSubtitle.Name = "lblDashboardSubtitle"
            Me.lblDashboardSubtitle.Size = New System.Drawing.Size(306, 17)
            Me.lblDashboardSubtitle.TabIndex = 1
            Me.lblDashboardSubtitle.Text = "Welcome back! Here's today's registrar overview."
            '
            'lblDashboardTitle
            '
            Me.lblDashboardTitle.AutoSize = True
            Me.lblDashboardTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
            Me.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblDashboardTitle.Location = New System.Drawing.Point(-2, 0)
            Me.lblDashboardTitle.Name = "lblDashboardTitle"
            Me.lblDashboardTitle.Size = New System.Drawing.Size(157, 37)
            Me.lblDashboardTitle.TabIndex = 0
            Me.lblDashboardTitle.Text = "Dashboard"
            '
            'tmrClock
            '
            Me.tmrClock.Enabled = True
            Me.tmrClock.Interval = 1000
            '
            'tmrStats
            '
            Me.tmrStats.Interval = 30000
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1200, 720)
            Me.Controls.Add(Me.pnlContent)
            Me.Controls.Add(Me.pnlTopBar)
            Me.Controls.Add(Me.pnlSidebar)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.MinimumSize = New System.Drawing.Size(1024, 600)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Registrar Document Request System"
            Me.pnlSidebar.ResumeLayout(False)
            Me.pnlUserBadge.ResumeLayout(False)
            Me.pnlUserBadge.PerformLayout()
            Me.pnlBrand.ResumeLayout(False)
            Me.pnlBrand.PerformLayout()
            Me.pnlTopBar.ResumeLayout(False)
            Me.pnlTopBar.PerformLayout()
            Me.pnlContent.ResumeLayout(False)
            Me.pnlDashboard.ResumeLayout(False)
            Me.pnlDashboardTableCard.ResumeLayout(False)
            Me.pnlDashboardTableCard.PerformLayout()
            CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlBacklog.ResumeLayout(False)
            Me.pnlBacklog.PerformLayout()
            Me.pnlUnpaid.ResumeLayout(False)
            Me.pnlUnpaid.PerformLayout()
            Me.pnlReady.ResumeLayout(False)
            Me.pnlReady.PerformLayout()
            Me.pnlInProgress.ResumeLayout(False)
            Me.pnlInProgress.PerformLayout()
            Me.pnlActiveStudents.ResumeLayout(False)
            Me.pnlActiveStudents.PerformLayout()
            Me.pnlDashboardHeader.ResumeLayout(False)
            Me.pnlDashboardHeader.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
        Friend WithEvents pnlBrand As System.Windows.Forms.Panel
        Friend WithEvents picLogo As System.Windows.Forms.PictureBox
        Friend WithEvents lblBrandTitle As System.Windows.Forms.Label
        Friend WithEvents lblBrandSubtitle As System.Windows.Forms.Label
        Friend WithEvents btnNavDashboard As System.Windows.Forms.Button
        Friend WithEvents btnNavStudents As System.Windows.Forms.Button
        Friend WithEvents btnNavDocuments As System.Windows.Forms.Button
        Friend WithEvents btnNavNewRequest As System.Windows.Forms.Button
        Friend WithEvents btnNavRequestList As System.Windows.Forms.Button
        Friend WithEvents btnNavReports As System.Windows.Forms.Button
        Friend WithEvents btnNavUserAccounts As System.Windows.Forms.Button
        Friend WithEvents pnlUserBadge As System.Windows.Forms.Panel
        Friend WithEvents lblUserNameDisplay As System.Windows.Forms.Label
        Friend WithEvents lblUserRoleDisplay As System.Windows.Forms.Label
        Friend WithEvents btnLogout As System.Windows.Forms.Button
        Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
        Friend WithEvents lblHeaderPageTitle As System.Windows.Forms.Label
        Friend WithEvents lblHeaderDateTime As System.Windows.Forms.Label
        Friend WithEvents lblSystemGreeting As System.Windows.Forms.Label
        Friend WithEvents pnlContent As System.Windows.Forms.Panel
        Friend WithEvents pnlDashboard As System.Windows.Forms.Panel
        Friend WithEvents pnlDashboardHeader As System.Windows.Forms.Panel
        Friend WithEvents lblDashboardTitle As System.Windows.Forms.Label
        Friend WithEvents lblDashboardSubtitle As System.Windows.Forms.Label
        Friend WithEvents pnlActiveStudents As System.Windows.Forms.Panel
        Friend WithEvents pnlAccent1 As System.Windows.Forms.Panel
        Friend WithEvents lblActiveStudentsValue As System.Windows.Forms.Label
        Friend WithEvents lblActiveStudentsLabel As System.Windows.Forms.Label
        Friend WithEvents pnlInProgress As System.Windows.Forms.Panel
        Friend WithEvents pnlAccent2 As System.Windows.Forms.Panel
        Friend WithEvents lblInProgressValue As System.Windows.Forms.Label
        Friend WithEvents lblInProgressLabel As System.Windows.Forms.Label
        Friend WithEvents pnlReady As System.Windows.Forms.Panel
        Friend WithEvents pnlAccent3 As System.Windows.Forms.Panel
        Friend WithEvents lblReadyValue As System.Windows.Forms.Label
        Friend WithEvents lblReadyLabel As System.Windows.Forms.Label
        Friend WithEvents pnlUnpaid As System.Windows.Forms.Panel
        Friend WithEvents pnlAccent4 As System.Windows.Forms.Panel
        Friend WithEvents lblUnpaidValue As System.Windows.Forms.Label
        Friend WithEvents lblUnpaidLabel As System.Windows.Forms.Label
        Friend WithEvents pnlBacklog As System.Windows.Forms.Panel
        Friend WithEvents pnlAccent5 As System.Windows.Forms.Panel
        Friend WithEvents lblBacklogValue As System.Windows.Forms.Label
        Friend WithEvents lblBacklogLabel As System.Windows.Forms.Label
        Friend WithEvents pnlDashboardTableCard As System.Windows.Forms.Panel
        Friend WithEvents lblDashboardCardTitle As System.Windows.Forms.Label
        Friend WithEvents lblDashboardRecordCount As System.Windows.Forms.Label
        Friend WithEvents dgvRecentRequests As System.Windows.Forms.DataGridView
        Friend WithEvents colDashReqNo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDashStudent As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDashDoc As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDashDate As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDashPayment As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDashStatus As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents tmrClock As System.Windows.Forms.Timer
        Friend WithEvents tmrStats As System.Windows.Forms.Timer
    End Class
End Namespace
