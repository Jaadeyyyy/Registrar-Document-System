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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlSidebar = New System.Windows.Forms.Panel()
            Me.btnNavSignOut = New System.Windows.Forms.Button()
            Me.btnNavUsers = New System.Windows.Forms.Button()
            Me.btnNavReports = New System.Windows.Forms.Button()
            Me.btnNavRequests = New System.Windows.Forms.Button()
            Me.btnNavNewRequest = New System.Windows.Forms.Button()
            Me.btnNavDocuments = New System.Windows.Forms.Button()
            Me.btnNavStudents = New System.Windows.Forms.Button()
            Me.btnNavDashboard = New System.Windows.Forms.Button()
            Me.pnlBrand = New System.Windows.Forms.Panel()
            Me.lblOffice = New System.Windows.Forms.Label()
            Me.lblBadge = New System.Windows.Forms.Label()
            Me.pnlMainArea = New System.Windows.Forms.Panel()
            Me.pnlContent = New System.Windows.Forms.Panel()
            Me.pnlDashboard = New System.Windows.Forms.Panel()
            Me.pnlActiveStudents = New System.Windows.Forms.Panel()
            Me.lblActiveStudentsLabel = New System.Windows.Forms.Label()
            Me.lblActiveStudentsValue = New System.Windows.Forms.Label()
            Me.pnlAccent1 = New System.Windows.Forms.Panel()
            Me.pnlInProgress = New System.Windows.Forms.Panel()
            Me.lblInProgressLabel = New System.Windows.Forms.Label()
            Me.lblInProgressValue = New System.Windows.Forms.Label()
            Me.pnlAccent2 = New System.Windows.Forms.Panel()
            Me.pnlReady = New System.Windows.Forms.Panel()
            Me.lblReadyLabel = New System.Windows.Forms.Label()
            Me.lblReadyValue = New System.Windows.Forms.Label()
            Me.pnlAccent3 = New System.Windows.Forms.Panel()
            Me.pnlUnpaid = New System.Windows.Forms.Panel()
            Me.lblUnpaidLabel = New System.Windows.Forms.Label()
            Me.lblUnpaidValue = New System.Windows.Forms.Label()
            Me.pnlAccent4 = New System.Windows.Forms.Panel()
            Me.pnlBacklog = New System.Windows.Forms.Panel()
            Me.lblBacklogLabel = New System.Windows.Forms.Label()
            Me.lblBacklogValue = New System.Windows.Forms.Label()
            Me.pnlAccent5 = New System.Windows.Forms.Panel()
            Me.lblRecentTitle = New System.Windows.Forms.Label()
            Me.dgvRecentRequests = New System.Windows.Forms.DataGridView()
            Me.pnlStudents = New System.Windows.Forms.Panel()
            Me.txtSearchStudents = New System.Windows.Forms.TextBox()
            Me.btnAddStudent = New System.Windows.Forms.Button()
            Me.btnEditStudent = New System.Windows.Forms.Button()
            Me.btnToggleStudentStatus = New System.Windows.Forms.Button()
            Me.dgvStudents = New System.Windows.Forms.DataGridView()
            Me.pnlDocuments = New System.Windows.Forms.Panel()
            Me.txtSearchDocuments = New System.Windows.Forms.TextBox()
            Me.btnAddDocument = New System.Windows.Forms.Button()
            Me.btnEditDocument = New System.Windows.Forms.Button()
            Me.btnToggleDocumentStatus = New System.Windows.Forms.Button()
            Me.dgvDocuments = New System.Windows.Forms.DataGridView()
            Me.lblRecentSlips = New System.Windows.Forms.Label()
            Me.btnViewSlipDocument = New System.Windows.Forms.Button()
            Me.dgvRecentSlips = New System.Windows.Forms.DataGridView()
            Me.pnlNewRequest = New System.Windows.Forms.Panel()
            Me.cboStudent = New System.Windows.Forms.ComboBox()
            Me.lblStudentInfo = New System.Windows.Forms.Label()
            Me.lblStudentError = New System.Windows.Forms.Label()
            Me.txtPurpose = New System.Windows.Forms.TextBox()
            Me.lblPurposeError = New System.Windows.Forms.Label()
            Me.cboDocument = New System.Windows.Forms.ComboBox()
            Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
            Me.btnAddItem = New System.Windows.Forms.Button()
            Me.btnRemoveItem = New System.Windows.Forms.Button()
            Me.lblItemError = New System.Windows.Forms.Label()
            Me.dgvRequestItems = New System.Windows.Forms.DataGridView()
            Me.colDocument = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblTotalAmount = New System.Windows.Forms.Label()
            Me.btnSaveRequest = New System.Windows.Forms.Button()
            Me.pnlRequests = New System.Windows.Forms.Panel()
            Me.txtSearchRequests = New System.Windows.Forms.TextBox()
            Me.btnViewDetails = New System.Windows.Forms.Button()
            Me.btnUpdateStatus = New System.Windows.Forms.Button()
            Me.btnViewSlipRequest = New System.Windows.Forms.Button()
            Me.dgvRequests = New System.Windows.Forms.DataGridView()
            Me.pnlReports = New System.Windows.Forms.Panel()
            Me.cboReportType = New System.Windows.Forms.ComboBox()
            Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
            Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
            Me.btnGenerateReport = New System.Windows.Forms.Button()
            Me.lblReportTotal = New System.Windows.Forms.Label()
            Me.dgvReports = New System.Windows.Forms.DataGridView()
            Me.pnlUsers = New System.Windows.Forms.Panel()
            Me.txtSearchUsers = New System.Windows.Forms.TextBox()
            Me.btnAddUser = New System.Windows.Forms.Button()
            Me.btnEditUser = New System.Windows.Forms.Button()
            Me.btnToggleUserStatus = New System.Windows.Forms.Button()
            Me.dgvUsers = New System.Windows.Forms.DataGridView()
            Me.pnlHeading = New System.Windows.Forms.Panel()
            Me.pnlPageMarker = New System.Windows.Forms.Panel()
            Me.lblPageSubtitle = New System.Windows.Forms.Label()
            Me.lblPageTitle = New System.Windows.Forms.Label()
            Me.pnlTopBar = New System.Windows.Forms.Panel()
            Me.lblAccount = New System.Windows.Forms.Label()
            Me.pnlTopAccent = New System.Windows.Forms.Panel()
            Me.dashboardTimer = New System.Windows.Forms.Timer(Me.components)
            Me.pnlSidebar.SuspendLayout()
            Me.pnlBrand.SuspendLayout()
            Me.pnlMainArea.SuspendLayout()
            Me.pnlContent.SuspendLayout()
            Me.pnlDashboard.SuspendLayout()
            Me.pnlActiveStudents.SuspendLayout()
            Me.pnlInProgress.SuspendLayout()
            Me.pnlReady.SuspendLayout()
            Me.pnlUnpaid.SuspendLayout()
            Me.pnlBacklog.SuspendLayout()
            CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlStudents.SuspendLayout()
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlDocuments.SuspendLayout()
            CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvRecentSlips, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlNewRequest.SuspendLayout()
            CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvRequestItems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlRequests.SuspendLayout()
            CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlReports.SuspendLayout()
            CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlUsers.SuspendLayout()
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlHeading.SuspendLayout()
            Me.pnlTopBar.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlSidebar
            '
            Me.pnlSidebar.BackColor = System.Drawing.Color.White
            Me.pnlSidebar.Controls.Add(Me.btnNavSignOut)
            Me.pnlSidebar.Controls.Add(Me.btnNavUsers)
            Me.pnlSidebar.Controls.Add(Me.btnNavReports)
            Me.pnlSidebar.Controls.Add(Me.btnNavRequests)
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
            'btnNavSignOut
            '
            Me.btnNavSignOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnNavSignOut.BackColor = System.Drawing.Color.White
            Me.btnNavSignOut.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavSignOut.FlatAppearance.BorderSize = 0
            Me.btnNavSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavSignOut.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavSignOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.btnNavSignOut.Location = New System.Drawing.Point(12, 662)
            Me.btnNavSignOut.Name = "btnNavSignOut"
            Me.btnNavSignOut.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavSignOut.Size = New System.Drawing.Size(211, 40)
            Me.btnNavSignOut.TabIndex = 8
            Me.btnNavSignOut.Text = "Sign Out"
            Me.btnNavSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavSignOut.UseVisualStyleBackColor = False
            '
            'btnNavUsers
            '
            Me.btnNavUsers.BackColor = System.Drawing.Color.White
            Me.btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavUsers.FlatAppearance.BorderSize = 0
            Me.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavUsers.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnNavUsers.Location = New System.Drawing.Point(12, 376)
            Me.btnNavUsers.Name = "btnNavUsers"
            Me.btnNavUsers.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavUsers.Size = New System.Drawing.Size(211, 40)
            Me.btnNavUsers.TabIndex = 7
            Me.btnNavUsers.Text = "User Accounts"
            Me.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavUsers.UseVisualStyleBackColor = False
            '
            'btnNavReports
            '
            Me.btnNavReports.BackColor = System.Drawing.Color.White
            Me.btnNavReports.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavReports.FlatAppearance.BorderSize = 0
            Me.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavReports.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnNavReports.Location = New System.Drawing.Point(12, 330)
            Me.btnNavReports.Name = "btnNavReports"
            Me.btnNavReports.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavReports.Size = New System.Drawing.Size(211, 40)
            Me.btnNavReports.TabIndex = 6
            Me.btnNavReports.Text = "Reports"
            Me.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavReports.UseVisualStyleBackColor = False
            '
            'btnNavRequests
            '
            Me.btnNavRequests.BackColor = System.Drawing.Color.White
            Me.btnNavRequests.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavRequests.FlatAppearance.BorderSize = 0
            Me.btnNavRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavRequests.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavRequests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnNavRequests.Location = New System.Drawing.Point(12, 284)
            Me.btnNavRequests.Name = "btnNavRequests"
            Me.btnNavRequests.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavRequests.Size = New System.Drawing.Size(211, 40)
            Me.btnNavRequests.TabIndex = 5
            Me.btnNavRequests.Text = "Request List"
            Me.btnNavRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavRequests.UseVisualStyleBackColor = False
            '
            'btnNavNewRequest
            '
            Me.btnNavNewRequest.BackColor = System.Drawing.Color.White
            Me.btnNavNewRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavNewRequest.FlatAppearance.BorderSize = 0
            Me.btnNavNewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavNewRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavNewRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnNavNewRequest.Location = New System.Drawing.Point(12, 238)
            Me.btnNavNewRequest.Name = "btnNavNewRequest"
            Me.btnNavNewRequest.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavNewRequest.Size = New System.Drawing.Size(211, 40)
            Me.btnNavNewRequest.TabIndex = 4
            Me.btnNavNewRequest.Text = "New Request"
            Me.btnNavNewRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavNewRequest.UseVisualStyleBackColor = False
            '
            'btnNavDocuments
            '
            Me.btnNavDocuments.BackColor = System.Drawing.Color.White
            Me.btnNavDocuments.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavDocuments.FlatAppearance.BorderSize = 0
            Me.btnNavDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavDocuments.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavDocuments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnNavDocuments.Location = New System.Drawing.Point(12, 192)
            Me.btnNavDocuments.Name = "btnNavDocuments"
            Me.btnNavDocuments.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavDocuments.Size = New System.Drawing.Size(211, 40)
            Me.btnNavDocuments.TabIndex = 3
            Me.btnNavDocuments.Text = "Documents"
            Me.btnNavDocuments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavDocuments.UseVisualStyleBackColor = False
            '
            'btnNavStudents
            '
            Me.btnNavStudents.BackColor = System.Drawing.Color.White
            Me.btnNavStudents.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavStudents.FlatAppearance.BorderSize = 0
            Me.btnNavStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavStudents.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnNavStudents.Location = New System.Drawing.Point(12, 146)
            Me.btnNavStudents.Name = "btnNavStudents"
            Me.btnNavStudents.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavStudents.Size = New System.Drawing.Size(211, 40)
            Me.btnNavStudents.TabIndex = 2
            Me.btnNavStudents.Text = "Students"
            Me.btnNavStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavStudents.UseVisualStyleBackColor = False
            '
            'btnNavDashboard
            '
            Me.btnNavDashboard.BackColor = System.Drawing.Color.White
            Me.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnNavDashboard.FlatAppearance.BorderSize = 0
            Me.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnNavDashboard.Location = New System.Drawing.Point(12, 100)
            Me.btnNavDashboard.Name = "btnNavDashboard"
            Me.btnNavDashboard.Padding = New System.Windows.Forms.Padding(18, 0, 0, 0)
            Me.btnNavDashboard.Size = New System.Drawing.Size(211, 40)
            Me.btnNavDashboard.TabIndex = 1
            Me.btnNavDashboard.Text = "Dashboard"
            Me.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNavDashboard.UseVisualStyleBackColor = False
            '
            'pnlBrand
            '
            Me.pnlBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.pnlBrand.Controls.Add(Me.lblOffice)
            Me.pnlBrand.Controls.Add(Me.lblBadge)
            Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
            Me.pnlBrand.Name = "pnlBrand"
            Me.pnlBrand.Size = New System.Drawing.Size(250, 92)
            Me.pnlBrand.TabIndex = 0
            '
            'lblOffice
            '
            Me.lblOffice.AutoSize = True
            Me.lblOffice.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblOffice.ForeColor = System.Drawing.Color.White
            Me.lblOffice.Location = New System.Drawing.Point(74, 22)
            Me.lblOffice.Name = "lblOffice"
            Me.lblOffice.Size = New System.Drawing.Size(107, 38)
            Me.lblOffice.TabIndex = 1
            Me.lblOffice.Text = "OFFICE OF THE REGISTRAR"
            '
            'lblBadge
            '
            Me.lblBadge.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.lblBadge.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
            Me.lblBadge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblBadge.Location = New System.Drawing.Point(22, 20)
            Me.lblBadge.Name = "lblBadge"
            Me.lblBadge.Size = New System.Drawing.Size(42, 42)
            Me.lblBadge.TabIndex = 0
            Me.lblBadge.Text = "R"
            Me.lblBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlMainArea
            '
            Me.pnlMainArea.Controls.Add(Me.pnlContent)
            Me.pnlMainArea.Controls.Add(Me.pnlHeading)
            Me.pnlMainArea.Controls.Add(Me.pnlTopBar)
            Me.pnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlMainArea.Location = New System.Drawing.Point(250, 0)
            Me.pnlMainArea.Name = "pnlMainArea"
            Me.pnlMainArea.Size = New System.Drawing.Size(950, 720)
            Me.pnlMainArea.TabIndex = 1
            '
            'pnlContent
            '
            Me.pnlContent.AutoScroll = True
            Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.pnlContent.Controls.Add(Me.pnlDashboard)
            Me.pnlContent.Controls.Add(Me.pnlStudents)
            Me.pnlContent.Controls.Add(Me.pnlDocuments)
            Me.pnlContent.Controls.Add(Me.pnlNewRequest)
            Me.pnlContent.Controls.Add(Me.pnlRequests)
            Me.pnlContent.Controls.Add(Me.pnlReports)
            Me.pnlContent.Controls.Add(Me.pnlUsers)
            Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlContent.Location = New System.Drawing.Point(0, 160)
            Me.pnlContent.Name = "pnlContent"
            Me.pnlContent.Padding = New System.Windows.Forms.Padding(28, 10, 28, 28)
            Me.pnlContent.Size = New System.Drawing.Size(950, 560)
            Me.pnlContent.TabIndex = 2
            '
            'pnlDashboard
            '
            Me.pnlDashboard.Controls.Add(Me.dgvRecentRequests)
            Me.pnlDashboard.Controls.Add(Me.lblRecentTitle)
            Me.pnlDashboard.Controls.Add(Me.pnlBacklog)
            Me.pnlDashboard.Controls.Add(Me.pnlUnpaid)
            Me.pnlDashboard.Controls.Add(Me.pnlReady)
            Me.pnlDashboard.Controls.Add(Me.pnlInProgress)
            Me.pnlDashboard.Controls.Add(Me.pnlActiveStudents)
            Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDashboard.Location = New System.Drawing.Point(28, 10)
            Me.pnlDashboard.Name = "pnlDashboard"
            Me.pnlDashboard.Size = New System.Drawing.Size(894, 522)
            Me.pnlDashboard.TabIndex = 0
            '
            'pnlActiveStudents
            '
            Me.pnlActiveStudents.BackColor = System.Drawing.Color.White
            Me.pnlActiveStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlActiveStudents.Controls.Add(Me.lblActiveStudentsLabel)
            Me.pnlActiveStudents.Controls.Add(Me.lblActiveStudentsValue)
            Me.pnlActiveStudents.Controls.Add(Me.pnlAccent1)
            Me.pnlActiveStudents.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlActiveStudents.Location = New System.Drawing.Point(0, 5)
            Me.pnlActiveStudents.Name = "pnlActiveStudents"
            Me.pnlActiveStudents.Size = New System.Drawing.Size(205, 105)
            Me.pnlActiveStudents.TabIndex = 0
            '
            'lblActiveStudentsLabel
            '
            Me.lblActiveStudentsLabel.AutoSize = True
            Me.lblActiveStudentsLabel.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblActiveStudentsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblActiveStudentsLabel.Location = New System.Drawing.Point(19, 66)
            Me.lblActiveStudentsLabel.Name = "lblActiveStudentsLabel"
            Me.lblActiveStudentsLabel.Size = New System.Drawing.Size(96, 17)
            Me.lblActiveStudentsLabel.TabIndex = 2
            Me.lblActiveStudentsLabel.Text = "Active Students"
            '
            'lblActiveStudentsValue
            '
            Me.lblActiveStudentsValue.AutoSize = True
            Me.lblActiveStudentsValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
            Me.lblActiveStudentsValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblActiveStudentsValue.Location = New System.Drawing.Point(17, 14)
            Me.lblActiveStudentsValue.Name = "lblActiveStudentsValue"
            Me.lblActiveStudentsValue.Size = New System.Drawing.Size(38, 45)
            Me.lblActiveStudentsValue.TabIndex = 1
            Me.lblActiveStudentsValue.Text = "0"
            '
            'pnlAccent1
            '
            Me.pnlAccent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.pnlAccent1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent1.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent1.Name = "pnlAccent1"
            Me.pnlAccent1.Size = New System.Drawing.Size(203, 4)
            Me.pnlAccent1.TabIndex = 0
            '
            'pnlInProgress
            '
            Me.pnlInProgress.BackColor = System.Drawing.Color.White
            Me.pnlInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlInProgress.Controls.Add(Me.lblInProgressLabel)
            Me.pnlInProgress.Controls.Add(Me.lblInProgressValue)
            Me.pnlInProgress.Controls.Add(Me.pnlAccent2)
            Me.pnlInProgress.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlInProgress.Location = New System.Drawing.Point(220, 5)
            Me.pnlInProgress.Name = "pnlInProgress"
            Me.pnlInProgress.Size = New System.Drawing.Size(205, 105)
            Me.pnlInProgress.TabIndex = 1
            '
            'lblInProgressLabel
            '
            Me.lblInProgressLabel.AutoSize = True
            Me.lblInProgressLabel.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblInProgressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblInProgressLabel.Location = New System.Drawing.Point(19, 66)
            Me.lblInProgressLabel.Name = "lblInProgressLabel"
            Me.lblInProgressLabel.Size = New System.Drawing.Size(134, 17)
            Me.lblInProgressLabel.TabIndex = 2
            Me.lblInProgressLabel.Text = "Requests In Progress"
            '
            'lblInProgressValue
            '
            Me.lblInProgressValue.AutoSize = True
            Me.lblInProgressValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
            Me.lblInProgressValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(30, Byte), Integer))
            Me.lblInProgressValue.Location = New System.Drawing.Point(17, 14)
            Me.lblInProgressValue.Name = "lblInProgressValue"
            Me.lblInProgressValue.Size = New System.Drawing.Size(38, 45)
            Me.lblInProgressValue.TabIndex = 1
            Me.lblInProgressValue.Text = "0"
            '
            'pnlAccent2
            '
            Me.pnlAccent2.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(30, Byte), Integer))
            Me.pnlAccent2.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent2.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent2.Name = "pnlAccent2"
            Me.pnlAccent2.Size = New System.Drawing.Size(203, 4)
            Me.pnlAccent2.TabIndex = 0
            '
            'pnlReady
            '
            Me.pnlReady.BackColor = System.Drawing.Color.White
            Me.pnlReady.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlReady.Controls.Add(Me.lblReadyLabel)
            Me.pnlReady.Controls.Add(Me.lblReadyValue)
            Me.pnlReady.Controls.Add(Me.pnlAccent3)
            Me.pnlReady.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlReady.Location = New System.Drawing.Point(440, 5)
            Me.pnlReady.Name = "pnlReady"
            Me.pnlReady.Size = New System.Drawing.Size(205, 105)
            Me.pnlReady.TabIndex = 2
            '
            'lblReadyLabel
            '
            Me.lblReadyLabel.AutoSize = True
            Me.lblReadyLabel.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblReadyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblReadyLabel.Location = New System.Drawing.Point(19, 66)
            Me.lblReadyLabel.Name = "lblReadyLabel"
            Me.lblReadyLabel.Size = New System.Drawing.Size(115, 17)
            Me.lblReadyLabel.TabIndex = 2
            Me.lblReadyLabel.Text = "Ready for Release"
            '
            'lblReadyValue
            '
            Me.lblReadyValue.AutoSize = True
            Me.lblReadyValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
            Me.lblReadyValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(96, Byte), Integer))
            Me.lblReadyValue.Location = New System.Drawing.Point(17, 14)
            Me.lblReadyValue.Name = "lblReadyValue"
            Me.lblReadyValue.Size = New System.Drawing.Size(38, 45)
            Me.lblReadyValue.TabIndex = 1
            Me.lblReadyValue.Text = "0"
            '
            'pnlAccent3
            '
            Me.pnlAccent3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(96, Byte), Integer))
            Me.pnlAccent3.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent3.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent3.Name = "pnlAccent3"
            Me.pnlAccent3.Size = New System.Drawing.Size(203, 4)
            Me.pnlAccent3.TabIndex = 0
            '
            'pnlUnpaid
            '
            Me.pnlUnpaid.BackColor = System.Drawing.Color.White
            Me.pnlUnpaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlUnpaid.Controls.Add(Me.lblUnpaidLabel)
            Me.pnlUnpaid.Controls.Add(Me.lblUnpaidValue)
            Me.pnlUnpaid.Controls.Add(Me.pnlAccent4)
            Me.pnlUnpaid.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlUnpaid.Location = New System.Drawing.Point(660, 5)
            Me.pnlUnpaid.Name = "pnlUnpaid"
            Me.pnlUnpaid.Size = New System.Drawing.Size(205, 105)
            Me.pnlUnpaid.TabIndex = 3
            '
            'lblUnpaidLabel
            '
            Me.lblUnpaidLabel.AutoSize = True
            Me.lblUnpaidLabel.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblUnpaidLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblUnpaidLabel.Location = New System.Drawing.Point(19, 66)
            Me.lblUnpaidLabel.Name = "lblUnpaidLabel"
            Me.lblUnpaidLabel.Size = New System.Drawing.Size(107, 17)
            Me.lblUnpaidLabel.TabIndex = 2
            Me.lblUnpaidLabel.Text = "Unpaid Requests"
            '
            'lblUnpaidValue
            '
            Me.lblUnpaidValue.AutoSize = True
            Me.lblUnpaidValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
            Me.lblUnpaidValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblUnpaidValue.Location = New System.Drawing.Point(17, 14)
            Me.lblUnpaidValue.Name = "lblUnpaidValue"
            Me.lblUnpaidValue.Size = New System.Drawing.Size(38, 45)
            Me.lblUnpaidValue.TabIndex = 1
            Me.lblUnpaidValue.Text = "0"
            '
            'pnlAccent4
            '
            Me.pnlAccent4.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.pnlAccent4.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent4.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent4.Name = "pnlAccent4"
            Me.pnlAccent4.Size = New System.Drawing.Size(203, 4)
            Me.pnlAccent4.TabIndex = 0
            '
            'pnlBacklog
            '
            Me.pnlBacklog.BackColor = System.Drawing.Color.White
            Me.pnlBacklog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlBacklog.Controls.Add(Me.lblBacklogLabel)
            Me.pnlBacklog.Controls.Add(Me.lblBacklogValue)
            Me.pnlBacklog.Controls.Add(Me.pnlAccent5)
            Me.pnlBacklog.Cursor = System.Windows.Forms.Cursors.Hand
            Me.pnlBacklog.Location = New System.Drawing.Point(880, 5)
            Me.pnlBacklog.Name = "pnlBacklog"
            Me.pnlBacklog.Size = New System.Drawing.Size(205, 105)
            Me.pnlBacklog.TabIndex = 4
            '
            'lblBacklogLabel
            '
            Me.lblBacklogLabel.AutoSize = True
            Me.lblBacklogLabel.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblBacklogLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblBacklogLabel.Location = New System.Drawing.Point(19, 66)
            Me.lblBacklogLabel.Name = "lblBacklogLabel"
            Me.lblBacklogLabel.Size = New System.Drawing.Size(53, 17)
            Me.lblBacklogLabel.TabIndex = 2
            Me.lblBacklogLabel.Text = "Backlog"
            '
            'lblBacklogValue
            '
            Me.lblBacklogValue.AutoSize = True
            Me.lblBacklogValue.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
            Me.lblBacklogValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(160, Byte), Integer))
            Me.lblBacklogValue.Location = New System.Drawing.Point(17, 14)
            Me.lblBacklogValue.Name = "lblBacklogValue"
            Me.lblBacklogValue.Size = New System.Drawing.Size(38, 45)
            Me.lblBacklogValue.TabIndex = 1
            Me.lblBacklogValue.Text = "0"
            '
            'pnlAccent5
            '
            Me.pnlAccent5.BackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(160, Byte), Integer))
            Me.pnlAccent5.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlAccent5.Location = New System.Drawing.Point(0, 0)
            Me.pnlAccent5.Name = "pnlAccent5"
            Me.pnlAccent5.Size = New System.Drawing.Size(203, 4)
            Me.pnlAccent5.TabIndex = 0
            '
            'lblRecentTitle
            '
            Me.lblRecentTitle.AutoSize = True
            Me.lblRecentTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblRecentTitle.Location = New System.Drawing.Point(0, 138)
            Me.lblRecentTitle.Name = "lblRecentTitle"
            Me.lblRecentTitle.Size = New System.Drawing.Size(149, 25)
            Me.lblRecentTitle.TabIndex = 5
            Me.lblRecentTitle.Text = "Recent Requests"
            '
            'dgvRecentRequests
            '
            Me.dgvRecentRequests.AllowUserToAddRows = False
            Me.dgvRecentRequests.AllowUserToDeleteRows = False
            Me.dgvRecentRequests.AllowUserToResizeRows = False
            Me.dgvRecentRequests.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvRecentRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRecentRequests.BackgroundColor = System.Drawing.Color.White
            Me.dgvRecentRequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvRecentRequests.ColumnHeadersHeight = 38
            Me.dgvRecentRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvRecentRequests.Location = New System.Drawing.Point(0, 174)
            Me.dgvRecentRequests.MultiSelect = False
            Me.dgvRecentRequests.Name = "dgvRecentRequests"
            Me.dgvRecentRequests.ReadOnly = True
            Me.dgvRecentRequests.RowHeadersVisible = False
            Me.dgvRecentRequests.RowTemplate.Height = 34
            Me.dgvRecentRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRecentRequests.Size = New System.Drawing.Size(1085, 330)
            Me.dgvRecentRequests.TabIndex = 6
            '
            'pnlStudents
            '
            Me.pnlStudents.Controls.Add(Me.dgvStudents)
            Me.pnlStudents.Controls.Add(Me.btnToggleStudentStatus)
            Me.pnlStudents.Controls.Add(Me.btnEditStudent)
            Me.pnlStudents.Controls.Add(Me.btnAddStudent)
            Me.pnlStudents.Controls.Add(Me.txtSearchStudents)
            Me.pnlStudents.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlStudents.Location = New System.Drawing.Point(28, 10)
            Me.pnlStudents.Name = "pnlStudents"
            Me.pnlStudents.Size = New System.Drawing.Size(894, 522)
            Me.pnlStudents.TabIndex = 1
            Me.pnlStudents.Visible = False
            '
            'txtSearchStudents
            '
            Me.txtSearchStudents.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchStudents.Name = "txtSearchStudents"
            Me.txtSearchStudents.Size = New System.Drawing.Size(310, 25)
            Me.txtSearchStudents.TabIndex = 0
            '
            'btnAddStudent
            '
            Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddStudent.ForeColor = System.Drawing.Color.White
            Me.btnAddStudent.Location = New System.Drawing.Point(325, 1)
            Me.btnAddStudent.Name = "btnAddStudent"
            Me.btnAddStudent.Size = New System.Drawing.Size(150, 38)
            Me.btnAddStudent.TabIndex = 1
            Me.btnAddStudent.Text = "Add Student"
            Me.btnAddStudent.UseVisualStyleBackColor = False
            '
            'btnEditStudent
            '
            Me.btnEditStudent.BackColor = System.Drawing.Color.White
            Me.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnEditStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditStudent.Location = New System.Drawing.Point(485, 1)
            Me.btnEditStudent.Name = "btnEditStudent"
            Me.btnEditStudent.Size = New System.Drawing.Size(105, 38)
            Me.btnEditStudent.TabIndex = 2
            Me.btnEditStudent.Text = "Edit"
            Me.btnEditStudent.UseVisualStyleBackColor = False
            '
            'btnToggleStudentStatus
            '
            Me.btnToggleStudentStatus.BackColor = System.Drawing.Color.White
            Me.btnToggleStudentStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToggleStudentStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleStudentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToggleStudentStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnToggleStudentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleStudentStatus.Location = New System.Drawing.Point(600, 1)
            Me.btnToggleStudentStatus.Name = "btnToggleStudentStatus"
            Me.btnToggleStudentStatus.Size = New System.Drawing.Size(180, 38)
            Me.btnToggleStudentStatus.TabIndex = 3
            Me.btnToggleStudentStatus.Text = "Activate / Deactivate"
            Me.btnToggleStudentStatus.UseVisualStyleBackColor = False
            '
            'dgvStudents
            '
            Me.dgvStudents.AllowUserToAddRows = False
            Me.dgvStudents.AllowUserToDeleteRows = False
            Me.dgvStudents.AllowUserToResizeRows = False
            Me.dgvStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
            Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvStudents.ColumnHeadersHeight = 38
            Me.dgvStudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvStudents.Location = New System.Drawing.Point(0, 50)
            Me.dgvStudents.MultiSelect = False
            Me.dgvStudents.Name = "dgvStudents"
            Me.dgvStudents.ReadOnly = True
            Me.dgvStudents.RowHeadersVisible = False
            Me.dgvStudents.RowTemplate.Height = 34
            Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvStudents.Size = New System.Drawing.Size(1085, 440)
            Me.dgvStudents.TabIndex = 4
            '
            'pnlDocuments
            '
            Me.pnlDocuments.Controls.Add(Me.dgvRecentSlips)
            Me.pnlDocuments.Controls.Add(Me.btnViewSlipDocument)
            Me.pnlDocuments.Controls.Add(Me.lblRecentSlips)
            Me.pnlDocuments.Controls.Add(Me.dgvDocuments)
            Me.pnlDocuments.Controls.Add(Me.btnToggleDocumentStatus)
            Me.pnlDocuments.Controls.Add(Me.btnEditDocument)
            Me.pnlDocuments.Controls.Add(Me.btnAddDocument)
            Me.pnlDocuments.Controls.Add(Me.txtSearchDocuments)
            Me.pnlDocuments.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlDocuments.Location = New System.Drawing.Point(28, 10)
            Me.pnlDocuments.Name = "pnlDocuments"
            Me.pnlDocuments.Size = New System.Drawing.Size(894, 522)
            Me.pnlDocuments.TabIndex = 2
            Me.pnlDocuments.Visible = False
            '
            'txtSearchDocuments
            '
            Me.txtSearchDocuments.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchDocuments.Name = "txtSearchDocuments"
            Me.txtSearchDocuments.Size = New System.Drawing.Size(310, 25)
            Me.txtSearchDocuments.TabIndex = 0
            '
            'btnAddDocument
            '
            Me.btnAddDocument.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddDocument.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddDocument.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddDocument.ForeColor = System.Drawing.Color.White
            Me.btnAddDocument.Location = New System.Drawing.Point(325, 1)
            Me.btnAddDocument.Name = "btnAddDocument"
            Me.btnAddDocument.Size = New System.Drawing.Size(150, 38)
            Me.btnAddDocument.TabIndex = 1
            Me.btnAddDocument.Text = "Add Document"
            Me.btnAddDocument.UseVisualStyleBackColor = False
            '
            'btnEditDocument
            '
            Me.btnEditDocument.BackColor = System.Drawing.Color.White
            Me.btnEditDocument.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditDocument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditDocument.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnEditDocument.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditDocument.Location = New System.Drawing.Point(485, 1)
            Me.btnEditDocument.Name = "btnEditDocument"
            Me.btnEditDocument.Size = New System.Drawing.Size(105, 38)
            Me.btnEditDocument.TabIndex = 2
            Me.btnEditDocument.Text = "Edit"
            Me.btnEditDocument.UseVisualStyleBackColor = False
            '
            'btnToggleDocumentStatus
            '
            Me.btnToggleDocumentStatus.BackColor = System.Drawing.Color.White
            Me.btnToggleDocumentStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToggleDocumentStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleDocumentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToggleDocumentStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnToggleDocumentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleDocumentStatus.Location = New System.Drawing.Point(600, 1)
            Me.btnToggleDocumentStatus.Name = "btnToggleDocumentStatus"
            Me.btnToggleDocumentStatus.Size = New System.Drawing.Size(180, 38)
            Me.btnToggleDocumentStatus.TabIndex = 3
            Me.btnToggleDocumentStatus.Text = "Activate / Deactivate"
            Me.btnToggleDocumentStatus.UseVisualStyleBackColor = False
            '
            'dgvDocuments
            '
            Me.dgvDocuments.AllowUserToAddRows = False
            Me.dgvDocuments.AllowUserToDeleteRows = False
            Me.dgvDocuments.AllowUserToResizeRows = False
            Me.dgvDocuments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDocuments.BackgroundColor = System.Drawing.Color.White
            Me.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvDocuments.ColumnHeadersHeight = 38
            Me.dgvDocuments.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvDocuments.Location = New System.Drawing.Point(0, 50)
            Me.dgvDocuments.MultiSelect = False
            Me.dgvDocuments.Name = "dgvDocuments"
            Me.dgvDocuments.ReadOnly = True
            Me.dgvDocuments.RowHeadersVisible = False
            Me.dgvDocuments.RowTemplate.Height = 34
            Me.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDocuments.Size = New System.Drawing.Size(1085, 220)
            Me.dgvDocuments.TabIndex = 4
            '
            'lblRecentSlips
            '
            Me.lblRecentSlips.AutoSize = True
            Me.lblRecentSlips.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblRecentSlips.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblRecentSlips.Location = New System.Drawing.Point(0, 285)
            Me.lblRecentSlips.Name = "lblRecentSlips"
            Me.lblRecentSlips.Size = New System.Drawing.Size(189, 25)
            Me.lblRecentSlips.TabIndex = 5
            Me.lblRecentSlips.Text = "Recent Request Slips"
            '
            'btnViewSlipDocument
            '
            Me.btnViewSlipDocument.BackColor = System.Drawing.Color.White
            Me.btnViewSlipDocument.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewSlipDocument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewSlipDocument.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnViewSlipDocument.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipDocument.Location = New System.Drawing.Point(215, 279)
            Me.btnViewSlipDocument.Name = "btnViewSlipDocument"
            Me.btnViewSlipDocument.Size = New System.Drawing.Size(135, 38)
            Me.btnViewSlipDocument.TabIndex = 6
            Me.btnViewSlipDocument.Text = "View Slip"
            Me.btnViewSlipDocument.UseVisualStyleBackColor = False
            '
            'dgvRecentSlips
            '
            Me.dgvRecentSlips.AllowUserToAddRows = False
            Me.dgvRecentSlips.AllowUserToDeleteRows = False
            Me.dgvRecentSlips.AllowUserToResizeRows = False
            Me.dgvRecentSlips.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvRecentSlips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRecentSlips.BackgroundColor = System.Drawing.Color.White
            Me.dgvRecentSlips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvRecentSlips.ColumnHeadersHeight = 38
            Me.dgvRecentSlips.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvRecentSlips.Location = New System.Drawing.Point(0, 325)
            Me.dgvRecentSlips.MultiSelect = False
            Me.dgvRecentSlips.Name = "dgvRecentSlips"
            Me.dgvRecentSlips.ReadOnly = True
            Me.dgvRecentSlips.RowHeadersVisible = False
            Me.dgvRecentSlips.RowTemplate.Height = 34
            Me.dgvRecentSlips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRecentSlips.Size = New System.Drawing.Size(1085, 215)
            Me.dgvRecentSlips.TabIndex = 7
            '
            'pnlNewRequest
            '
            Me.pnlNewRequest.Controls.Add(Me.btnSaveRequest)
            Me.pnlNewRequest.Controls.Add(Me.lblTotalAmount)
            Me.pnlNewRequest.Controls.Add(Me.dgvRequestItems)
            Me.pnlNewRequest.Controls.Add(Me.lblItemError)
            Me.pnlNewRequest.Controls.Add(Me.btnRemoveItem)
            Me.pnlNewRequest.Controls.Add(Me.btnAddItem)
            Me.pnlNewRequest.Controls.Add(Me.nudQuantity)
            Me.pnlNewRequest.Controls.Add(Me.cboDocument)
            Me.pnlNewRequest.Controls.Add(Me.lblPurposeError)
            Me.pnlNewRequest.Controls.Add(Me.txtPurpose)
            Me.pnlNewRequest.Controls.Add(Me.lblStudentError)
            Me.pnlNewRequest.Controls.Add(Me.lblStudentInfo)
            Me.pnlNewRequest.Controls.Add(Me.cboStudent)
            Me.pnlNewRequest.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlNewRequest.Location = New System.Drawing.Point(28, 10)
            Me.pnlNewRequest.Name = "pnlNewRequest"
            Me.pnlNewRequest.Size = New System.Drawing.Size(894, 522)
            Me.pnlNewRequest.TabIndex = 3
            Me.pnlNewRequest.Visible = False
            '
            'cboStudent
            '
            Me.cboStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.cboStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboStudent.DropDownHeight = 220
            Me.cboStudent.IntegralHeight = False
            Me.cboStudent.Location = New System.Drawing.Point(0, 4)
            Me.cboStudent.MaxDropDownItems = 10
            Me.cboStudent.Name = "cboStudent"
            Me.cboStudent.Size = New System.Drawing.Size(455, 25)
            Me.cboStudent.TabIndex = 0
            '
            'lblStudentInfo
            '
            Me.lblStudentInfo.AutoSize = True
            Me.lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblStudentInfo.Location = New System.Drawing.Point(475, 9)
            Me.lblStudentInfo.Name = "lblStudentInfo"
            Me.lblStudentInfo.Size = New System.Drawing.Size(0, 17)
            Me.lblStudentInfo.TabIndex = 1
            '
            'lblStudentError
            '
            Me.lblStudentError.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblStudentError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblStudentError.Location = New System.Drawing.Point(0, 31)
            Me.lblStudentError.Name = "lblStudentError"
            Me.lblStudentError.Size = New System.Drawing.Size(455, 17)
            Me.lblStudentError.TabIndex = 2
            '
            'txtPurpose
            '
            Me.txtPurpose.Location = New System.Drawing.Point(0, 56)
            Me.txtPurpose.MaxLength = 150
            Me.txtPurpose.Name = "txtPurpose"
            Me.txtPurpose.Size = New System.Drawing.Size(455, 25)
            Me.txtPurpose.TabIndex = 3
            '
            'lblPurposeError
            '
            Me.lblPurposeError.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblPurposeError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblPurposeError.Location = New System.Drawing.Point(0, 83)
            Me.lblPurposeError.Name = "lblPurposeError"
            Me.lblPurposeError.Size = New System.Drawing.Size(455, 17)
            Me.lblPurposeError.TabIndex = 4
            '
            'cboDocument
            '
            Me.cboDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDocument.FormattingEnabled = True
            Me.cboDocument.Location = New System.Drawing.Point(0, 108)
            Me.cboDocument.Name = "cboDocument"
            Me.cboDocument.Size = New System.Drawing.Size(315, 25)
            Me.cboDocument.TabIndex = 5
            '
            'nudQuantity
            '
            Me.nudQuantity.Location = New System.Drawing.Point(330, 108)
            Me.nudQuantity.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.nudQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudQuantity.Name = "nudQuantity"
            Me.nudQuantity.Size = New System.Drawing.Size(75, 25)
            Me.nudQuantity.TabIndex = 6
            Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'btnAddItem
            '
            Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddItem.ForeColor = System.Drawing.Color.White
            Me.btnAddItem.Location = New System.Drawing.Point(420, 104)
            Me.btnAddItem.Name = "btnAddItem"
            Me.btnAddItem.Size = New System.Drawing.Size(120, 38)
            Me.btnAddItem.TabIndex = 7
            Me.btnAddItem.Text = "Add Item"
            Me.btnAddItem.UseVisualStyleBackColor = False
            '
            'btnRemoveItem
            '
            Me.btnRemoveItem.BackColor = System.Drawing.Color.White
            Me.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnRemoveItem.Location = New System.Drawing.Point(550, 104)
            Me.btnRemoveItem.Name = "btnRemoveItem"
            Me.btnRemoveItem.Size = New System.Drawing.Size(130, 38)
            Me.btnRemoveItem.TabIndex = 8
            Me.btnRemoveItem.Text = "Remove Item"
            Me.btnRemoveItem.UseVisualStyleBackColor = False
            '
            'lblItemError
            '
            Me.lblItemError.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblItemError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblItemError.Location = New System.Drawing.Point(700, 113)
            Me.lblItemError.Name = "lblItemError"
            Me.lblItemError.Size = New System.Drawing.Size(280, 20)
            Me.lblItemError.TabIndex = 9
            '
            'dgvRequestItems
            '
            Me.dgvRequestItems.AllowUserToAddRows = False
            Me.dgvRequestItems.AllowUserToDeleteRows = False
            Me.dgvRequestItems.AllowUserToResizeRows = False
            Me.dgvRequestItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvRequestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRequestItems.BackgroundColor = System.Drawing.Color.White
            Me.dgvRequestItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvRequestItems.ColumnHeadersHeight = 38
            Me.dgvRequestItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocument, Me.colFee, Me.colQuantity, Me.colSubtotal})
            Me.dgvRequestItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvRequestItems.Location = New System.Drawing.Point(0, 154)
            Me.dgvRequestItems.MultiSelect = False
            Me.dgvRequestItems.Name = "dgvRequestItems"
            Me.dgvRequestItems.ReadOnly = True
            Me.dgvRequestItems.RowHeadersVisible = False
            Me.dgvRequestItems.RowTemplate.Height = 34
            Me.dgvRequestItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequestItems.Size = New System.Drawing.Size(1085, 180)
            Me.dgvRequestItems.TabIndex = 10
            '
            'colDocument
            '
            Me.colDocument.DataPropertyName = "Document"
            Me.colDocument.HeaderText = "Document"
            Me.colDocument.Name = "colDocument"
            Me.colDocument.ReadOnly = True
            '
            'colFee
            '
            Me.colFee.DataPropertyName = "Fee"
            DataGridViewCellStyle1.Format = "N2"
            Me.colFee.DefaultCellStyle = DataGridViewCellStyle1
            Me.colFee.HeaderText = "Fee"
            Me.colFee.Name = "colFee"
            Me.colFee.ReadOnly = True
            '
            'colQuantity
            '
            Me.colQuantity.DataPropertyName = "Quantity"
            Me.colQuantity.HeaderText = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.ReadOnly = True
            '
            'colSubtotal
            '
            Me.colSubtotal.DataPropertyName = "Subtotal"
            DataGridViewCellStyle2.Format = "N2"
            Me.colSubtotal.DefaultCellStyle = DataGridViewCellStyle2
            Me.colSubtotal.HeaderText = "Subtotal"
            Me.colSubtotal.Name = "colSubtotal"
            Me.colSubtotal.ReadOnly = True
            '
            'lblTotalAmount
            '
            Me.lblTotalAmount.AutoSize = True
            Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTotalAmount.Location = New System.Drawing.Point(0, 345)
            Me.lblTotalAmount.Name = "lblTotalAmount"
            Me.lblTotalAmount.Size = New System.Drawing.Size(193, 28)
            Me.lblTotalAmount.TabIndex = 11
            Me.lblTotalAmount.Text = "Total Amount: 0.00"
            '
            'btnSaveRequest
            '
            Me.btnSaveRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSaveRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveRequest.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSaveRequest.ForeColor = System.Drawing.Color.White
            Me.btnSaveRequest.Location = New System.Drawing.Point(0, 390)
            Me.btnSaveRequest.Name = "btnSaveRequest"
            Me.btnSaveRequest.Size = New System.Drawing.Size(160, 38)
            Me.btnSaveRequest.TabIndex = 12
            Me.btnSaveRequest.Text = "Save Request"
            Me.btnSaveRequest.UseVisualStyleBackColor = False
            '
            'pnlRequests
            '
            Me.pnlRequests.Controls.Add(Me.dgvRequests)
            Me.pnlRequests.Controls.Add(Me.btnViewSlipRequest)
            Me.pnlRequests.Controls.Add(Me.btnUpdateStatus)
            Me.pnlRequests.Controls.Add(Me.btnViewDetails)
            Me.pnlRequests.Controls.Add(Me.txtSearchRequests)
            Me.pnlRequests.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRequests.Location = New System.Drawing.Point(28, 10)
            Me.pnlRequests.Name = "pnlRequests"
            Me.pnlRequests.Size = New System.Drawing.Size(894, 522)
            Me.pnlRequests.TabIndex = 4
            Me.pnlRequests.Visible = False
            '
            'txtSearchRequests
            '
            Me.txtSearchRequests.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchRequests.Name = "txtSearchRequests"
            Me.txtSearchRequests.Size = New System.Drawing.Size(310, 25)
            Me.txtSearchRequests.TabIndex = 0
            '
            'btnViewDetails
            '
            Me.btnViewDetails.BackColor = System.Drawing.Color.White
            Me.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewDetails.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnViewDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewDetails.Location = New System.Drawing.Point(325, 1)
            Me.btnViewDetails.Name = "btnViewDetails"
            Me.btnViewDetails.Size = New System.Drawing.Size(130, 38)
            Me.btnViewDetails.TabIndex = 1
            Me.btnViewDetails.Text = "View Details"
            Me.btnViewDetails.UseVisualStyleBackColor = False
            '
            'btnUpdateStatus
            '
            Me.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUpdateStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnUpdateStatus.ForeColor = System.Drawing.Color.White
            Me.btnUpdateStatus.Location = New System.Drawing.Point(465, 1)
            Me.btnUpdateStatus.Name = "btnUpdateStatus"
            Me.btnUpdateStatus.Size = New System.Drawing.Size(155, 38)
            Me.btnUpdateStatus.TabIndex = 2
            Me.btnUpdateStatus.Text = "Payment / Status"
            Me.btnUpdateStatus.UseVisualStyleBackColor = False
            '
            'btnViewSlipRequest
            '
            Me.btnViewSlipRequest.BackColor = System.Drawing.Color.White
            Me.btnViewSlipRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewSlipRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewSlipRequest.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnViewSlipRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipRequest.Location = New System.Drawing.Point(630, 1)
            Me.btnViewSlipRequest.Name = "btnViewSlipRequest"
            Me.btnViewSlipRequest.Size = New System.Drawing.Size(135, 38)
            Me.btnViewSlipRequest.TabIndex = 3
            Me.btnViewSlipRequest.Text = "View Slip"
            Me.btnViewSlipRequest.UseVisualStyleBackColor = False
            '
            'dgvRequests
            '
            Me.dgvRequests.AllowUserToAddRows = False
            Me.dgvRequests.AllowUserToDeleteRows = False
            Me.dgvRequests.AllowUserToResizeRows = False
            Me.dgvRequests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRequests.BackgroundColor = System.Drawing.Color.White
            Me.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvRequests.ColumnHeadersHeight = 38
            Me.dgvRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvRequests.Location = New System.Drawing.Point(0, 50)
            Me.dgvRequests.MultiSelect = False
            Me.dgvRequests.Name = "dgvRequests"
            Me.dgvRequests.ReadOnly = True
            Me.dgvRequests.RowHeadersVisible = False
            Me.dgvRequests.RowTemplate.Height = 34
            Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequests.Size = New System.Drawing.Size(1085, 440)
            Me.dgvRequests.TabIndex = 4
            '
            'pnlReports
            '
            Me.pnlReports.Controls.Add(Me.dgvReports)
            Me.pnlReports.Controls.Add(Me.lblReportTotal)
            Me.pnlReports.Controls.Add(Me.btnGenerateReport)
            Me.pnlReports.Controls.Add(Me.dtpToDate)
            Me.pnlReports.Controls.Add(Me.dtpFromDate)
            Me.pnlReports.Controls.Add(Me.cboReportType)
            Me.pnlReports.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlReports.Location = New System.Drawing.Point(28, 10)
            Me.pnlReports.Name = "pnlReports"
            Me.pnlReports.Size = New System.Drawing.Size(894, 522)
            Me.pnlReports.TabIndex = 5
            Me.pnlReports.Visible = False
            '
            'cboReportType
            '
            Me.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboReportType.FormattingEnabled = True
            Me.cboReportType.Items.AddRange(New Object() {"All Requests", "Pending Requests", "Released Requests", "Payments Collected"})
            Me.cboReportType.Location = New System.Drawing.Point(0, 4)
            Me.cboReportType.Name = "cboReportType"
            Me.cboReportType.Size = New System.Drawing.Size(230, 25)
            Me.cboReportType.TabIndex = 0
            '
            'dtpFromDate
            '
            Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFromDate.Location = New System.Drawing.Point(245, 4)
            Me.dtpFromDate.Name = "dtpFromDate"
            Me.dtpFromDate.Size = New System.Drawing.Size(135, 25)
            Me.dtpFromDate.TabIndex = 1
            '
            'dtpToDate
            '
            Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpToDate.Location = New System.Drawing.Point(390, 4)
            Me.dtpToDate.Name = "dtpToDate"
            Me.dtpToDate.Size = New System.Drawing.Size(135, 25)
            Me.dtpToDate.TabIndex = 2
            '
            'btnGenerateReport
            '
            Me.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
            Me.btnGenerateReport.Location = New System.Drawing.Point(540, 1)
            Me.btnGenerateReport.Name = "btnGenerateReport"
            Me.btnGenerateReport.Size = New System.Drawing.Size(115, 38)
            Me.btnGenerateReport.TabIndex = 3
            Me.btnGenerateReport.Text = "Generate"
            Me.btnGenerateReport.UseVisualStyleBackColor = False
            '
            'lblReportTotal
            '
            Me.lblReportTotal.AutoSize = True
            Me.lblReportTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblReportTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblReportTotal.Location = New System.Drawing.Point(675, 10)
            Me.lblReportTotal.Name = "lblReportTotal"
            Me.lblReportTotal.Size = New System.Drawing.Size(126, 19)
            Me.lblReportTotal.TabIndex = 4
            Me.lblReportTotal.Text = "Report Total: 0.00"
            '
            'dgvReports
            '
            Me.dgvReports.AllowUserToAddRows = False
            Me.dgvReports.AllowUserToDeleteRows = False
            Me.dgvReports.AllowUserToResizeRows = False
            Me.dgvReports.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvReports.BackgroundColor = System.Drawing.Color.White
            Me.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvReports.ColumnHeadersHeight = 38
            Me.dgvReports.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvReports.Location = New System.Drawing.Point(0, 50)
            Me.dgvReports.MultiSelect = False
            Me.dgvReports.Name = "dgvReports"
            Me.dgvReports.ReadOnly = True
            Me.dgvReports.RowHeadersVisible = False
            Me.dgvReports.RowTemplate.Height = 34
            Me.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvReports.Size = New System.Drawing.Size(1085, 440)
            Me.dgvReports.TabIndex = 5
            '
            'pnlUsers
            '
            Me.pnlUsers.Controls.Add(Me.dgvUsers)
            Me.pnlUsers.Controls.Add(Me.btnToggleUserStatus)
            Me.pnlUsers.Controls.Add(Me.btnEditUser)
            Me.pnlUsers.Controls.Add(Me.btnAddUser)
            Me.pnlUsers.Controls.Add(Me.txtSearchUsers)
            Me.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlUsers.Location = New System.Drawing.Point(28, 10)
            Me.pnlUsers.Name = "pnlUsers"
            Me.pnlUsers.Size = New System.Drawing.Size(894, 522)
            Me.pnlUsers.TabIndex = 6
            Me.pnlUsers.Visible = False
            '
            'txtSearchUsers
            '
            Me.txtSearchUsers.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchUsers.Name = "txtSearchUsers"
            Me.txtSearchUsers.Size = New System.Drawing.Size(310, 25)
            Me.txtSearchUsers.TabIndex = 0
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
            Me.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvUsers.ColumnHeadersHeight = 38
            Me.dgvUsers.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvUsers.Location = New System.Drawing.Point(0, 50)
            Me.dgvUsers.MultiSelect = False
            Me.dgvUsers.Name = "dgvUsers"
            Me.dgvUsers.ReadOnly = True
            Me.dgvUsers.RowHeadersVisible = False
            Me.dgvUsers.RowTemplate.Height = 34
            Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvUsers.Size = New System.Drawing.Size(1085, 440)
            Me.dgvUsers.TabIndex = 4
            '
            'pnlHeading
            '
            Me.pnlHeading.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.pnlHeading.Controls.Add(Me.pnlPageMarker)
            Me.pnlHeading.Controls.Add(Me.lblPageSubtitle)
            Me.pnlHeading.Controls.Add(Me.lblPageTitle)
            Me.pnlHeading.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeading.Location = New System.Drawing.Point(0, 68)
            Me.pnlHeading.Name = "pnlHeading"
            Me.pnlHeading.Size = New System.Drawing.Size(950, 92)
            Me.pnlHeading.TabIndex = 1
            '
            'pnlPageMarker
            '
            Me.pnlPageMarker.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.pnlPageMarker.Location = New System.Drawing.Point(18, 20)
            Me.pnlPageMarker.Name = "pnlPageMarker"
            Me.pnlPageMarker.Size = New System.Drawing.Size(5, 52)
            Me.pnlPageMarker.TabIndex = 2
            '
            'lblPageSubtitle
            '
            Me.lblPageSubtitle.AutoSize = True
            Me.lblPageSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblPageSubtitle.Location = New System.Drawing.Point(31, 58)
            Me.lblPageSubtitle.Name = "lblPageSubtitle"
            Me.lblPageSubtitle.Size = New System.Drawing.Size(0, 17)
            Me.lblPageSubtitle.TabIndex = 1
            '
            'lblPageTitle
            '
            Me.lblPageTitle.AutoSize = True
            Me.lblPageTitle.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
            Me.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblPageTitle.Location = New System.Drawing.Point(28, 19)
            Me.lblPageTitle.Name = "lblPageTitle"
            Me.lblPageTitle.Size = New System.Drawing.Size(161, 38)
            Me.lblPageTitle.TabIndex = 0
            Me.lblPageTitle.Text = "Dashboard"
            '
            'pnlTopBar
            '
            Me.pnlTopBar.BackColor = System.Drawing.Color.White
            Me.pnlTopBar.Controls.Add(Me.lblAccount)
            Me.pnlTopBar.Controls.Add(Me.pnlTopAccent)
            Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
            Me.pnlTopBar.Name = "pnlTopBar"
            Me.pnlTopBar.Size = New System.Drawing.Size(950, 68)
            Me.pnlTopBar.TabIndex = 0
            '
            'lblAccount
            '
            Me.lblAccount.Dock = System.Windows.Forms.DockStyle.Right
            Me.lblAccount.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lblAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblAccount.Location = New System.Drawing.Point(630, 0)
            Me.lblAccount.Name = "lblAccount"
            Me.lblAccount.Padding = New System.Windows.Forms.Padding(0, 0, 24, 0)
            Me.lblAccount.Size = New System.Drawing.Size(320, 65)
            Me.lblAccount.TabIndex = 1
            Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'pnlTopAccent
            '
            Me.pnlTopAccent.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.pnlTopAccent.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlTopAccent.Location = New System.Drawing.Point(0, 65)
            Me.pnlTopAccent.Name = "pnlTopAccent"
            Me.pnlTopAccent.Size = New System.Drawing.Size(950, 3)
            Me.pnlTopAccent.TabIndex = 0
            '
            'dashboardTimer
            '
            Me.dashboardTimer.Interval = 30000
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1200, 720)
            Me.Controls.Add(Me.pnlMainArea)
            Me.Controls.Add(Me.pnlSidebar)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.MinimumSize = New System.Drawing.Size(1120, 700)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Registrar Document Request System"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.pnlSidebar.ResumeLayout(False)
            Me.pnlBrand.ResumeLayout(False)
            Me.pnlBrand.PerformLayout()
            Me.pnlMainArea.ResumeLayout(False)
            Me.pnlContent.ResumeLayout(False)
            Me.pnlDashboard.ResumeLayout(False)
            Me.pnlDashboard.PerformLayout()
            Me.pnlActiveStudents.ResumeLayout(False)
            Me.pnlActiveStudents.PerformLayout()
            Me.pnlInProgress.ResumeLayout(False)
            Me.pnlInProgress.PerformLayout()
            Me.pnlReady.ResumeLayout(False)
            Me.pnlReady.PerformLayout()
            Me.pnlUnpaid.ResumeLayout(False)
            Me.pnlUnpaid.PerformLayout()
            Me.pnlBacklog.ResumeLayout(False)
            Me.pnlBacklog.PerformLayout()
            CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlStudents.ResumeLayout(False)
            Me.pnlStudents.PerformLayout()
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlDocuments.ResumeLayout(False)
            Me.pnlDocuments.PerformLayout()
            CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvRecentSlips, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlNewRequest.ResumeLayout(False)
            Me.pnlNewRequest.PerformLayout()
            CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvRequestItems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlRequests.ResumeLayout(False)
            Me.pnlRequests.PerformLayout()
            CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlReports.ResumeLayout(False)
            Me.pnlReports.PerformLayout()
            CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlUsers.ResumeLayout(False)
            Me.pnlUsers.PerformLayout()
            CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlHeading.ResumeLayout(False)
            Me.pnlHeading.PerformLayout()
            Me.pnlTopBar.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
        Friend WithEvents pnlBrand As System.Windows.Forms.Panel
        Friend WithEvents lblBadge As System.Windows.Forms.Label
        Friend WithEvents lblOffice As System.Windows.Forms.Label
        Friend WithEvents btnNavDashboard As System.Windows.Forms.Button
        Friend WithEvents btnNavStudents As System.Windows.Forms.Button
        Friend WithEvents btnNavDocuments As System.Windows.Forms.Button
        Friend WithEvents btnNavNewRequest As System.Windows.Forms.Button
        Friend WithEvents btnNavRequests As System.Windows.Forms.Button
        Friend WithEvents btnNavReports As System.Windows.Forms.Button
        Friend WithEvents btnNavUsers As System.Windows.Forms.Button
        Friend WithEvents btnNavSignOut As System.Windows.Forms.Button
        Friend WithEvents pnlMainArea As System.Windows.Forms.Panel
        Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
        Friend WithEvents lblAccount As System.Windows.Forms.Label
        Friend WithEvents pnlTopAccent As System.Windows.Forms.Panel
        Friend WithEvents pnlHeading As System.Windows.Forms.Panel
        Friend WithEvents lblPageTitle As System.Windows.Forms.Label
        Friend WithEvents lblPageSubtitle As System.Windows.Forms.Label
        Friend WithEvents pnlPageMarker As System.Windows.Forms.Panel
        Friend WithEvents pnlContent As System.Windows.Forms.Panel
        Friend WithEvents dashboardTimer As System.Windows.Forms.Timer
        Friend WithEvents pnlDashboard As System.Windows.Forms.Panel
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
        Friend WithEvents lblRecentTitle As System.Windows.Forms.Label
        Friend WithEvents dgvRecentRequests As System.Windows.Forms.DataGridView
        Friend WithEvents pnlStudents As System.Windows.Forms.Panel
        Friend WithEvents txtSearchStudents As System.Windows.Forms.TextBox
        Friend WithEvents btnAddStudent As System.Windows.Forms.Button
        Friend WithEvents btnEditStudent As System.Windows.Forms.Button
        Friend WithEvents btnToggleStudentStatus As System.Windows.Forms.Button
        Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
        Friend WithEvents pnlDocuments As System.Windows.Forms.Panel
        Friend WithEvents txtSearchDocuments As System.Windows.Forms.TextBox
        Friend WithEvents btnAddDocument As System.Windows.Forms.Button
        Friend WithEvents btnEditDocument As System.Windows.Forms.Button
        Friend WithEvents btnToggleDocumentStatus As System.Windows.Forms.Button
        Friend WithEvents dgvDocuments As System.Windows.Forms.DataGridView
        Friend WithEvents lblRecentSlips As System.Windows.Forms.Label
        Friend WithEvents btnViewSlipDocument As System.Windows.Forms.Button
        Friend WithEvents dgvRecentSlips As System.Windows.Forms.DataGridView
        Friend WithEvents pnlNewRequest As System.Windows.Forms.Panel
        Friend WithEvents cboStudent As System.Windows.Forms.ComboBox
        Friend WithEvents lblStudentInfo As System.Windows.Forms.Label
        Friend WithEvents lblStudentError As System.Windows.Forms.Label
        Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
        Friend WithEvents lblPurposeError As System.Windows.Forms.Label
        Friend WithEvents cboDocument As System.Windows.Forms.ComboBox
        Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnAddItem As System.Windows.Forms.Button
        Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
        Friend WithEvents lblItemError As System.Windows.Forms.Label
        Friend WithEvents dgvRequestItems As System.Windows.Forms.DataGridView
        Friend WithEvents colDocument As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFee As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
        Friend WithEvents btnSaveRequest As System.Windows.Forms.Button
        Friend WithEvents pnlRequests As System.Windows.Forms.Panel
        Friend WithEvents txtSearchRequests As System.Windows.Forms.TextBox
        Friend WithEvents btnViewDetails As System.Windows.Forms.Button
        Friend WithEvents btnUpdateStatus As System.Windows.Forms.Button
        Friend WithEvents btnViewSlipRequest As System.Windows.Forms.Button
        Friend WithEvents dgvRequests As System.Windows.Forms.DataGridView
        Friend WithEvents pnlReports As System.Windows.Forms.Panel
        Friend WithEvents cboReportType As System.Windows.Forms.ComboBox
        Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
        Friend WithEvents lblReportTotal As System.Windows.Forms.Label
        Friend WithEvents dgvReports As System.Windows.Forms.DataGridView
        Friend WithEvents pnlUsers As System.Windows.Forms.Panel
        Friend WithEvents txtSearchUsers As System.Windows.Forms.TextBox
        Friend WithEvents btnAddUser As System.Windows.Forms.Button
        Friend WithEvents btnEditUser As System.Windows.Forms.Button
        Friend WithEvents btnToggleUserStatus As System.Windows.Forms.Button
        Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    End Class
End Namespace
