Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DashboardForm
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
            Me.dgvRecentRequests = New System.Windows.Forms.DataGridView()
            Me.lblRecentTitle = New System.Windows.Forms.Label()
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
            Me.dashboardTimer = New System.Windows.Forms.Timer(Me.components)
            CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlBacklog.SuspendLayout()
            Me.pnlUnpaid.SuspendLayout()
            Me.pnlReady.SuspendLayout()
            Me.pnlInProgress.SuspendLayout()
            Me.pnlActiveStudents.SuspendLayout()
            Me.SuspendLayout()
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
            'lblRecentTitle
            '
            Me.lblRecentTitle.AutoSize = True
            Me.lblRecentTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblRecentTitle.Location = New System.Drawing.Point(0, 138)
            Me.lblRecentTitle.Name = "lblRecentTitle"
            Me.lblRecentTitle.Size = New System.Drawing.Size(153, 25)
            Me.lblRecentTitle.TabIndex = 5
            Me.lblRecentTitle.Text = "Recent Requests"
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
            Me.lblReadyLabel.Size = New System.Drawing.Size(114, 17)
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
            Me.lblInProgressLabel.Size = New System.Drawing.Size(131, 17)
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
            'dashboardTimer
            '
            Me.dashboardTimer.Interval = 15000
            '
            'DashboardForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1085, 522)
            Me.Controls.Add(Me.dgvRecentRequests)
            Me.Controls.Add(Me.lblRecentTitle)
            Me.Controls.Add(Me.pnlBacklog)
            Me.Controls.Add(Me.pnlUnpaid)
            Me.Controls.Add(Me.pnlReady)
            Me.Controls.Add(Me.pnlInProgress)
            Me.Controls.Add(Me.pnlActiveStudents)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "DashboardForm"
            Me.Text = "Dashboard"
            CType(Me.dgvRecentRequests, System.ComponentModel.ISupportInitialize).EndInit()
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
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents dgvRecentRequests As System.Windows.Forms.DataGridView
        Friend WithEvents lblRecentTitle As System.Windows.Forms.Label
        Friend WithEvents pnlBacklog As System.Windows.Forms.Panel
        Friend WithEvents lblBacklogLabel As System.Windows.Forms.Label
        Friend WithEvents lblBacklogValue As System.Windows.Forms.Label
        Friend WithEvents pnlAccent5 As System.Windows.Forms.Panel
        Friend WithEvents pnlUnpaid As System.Windows.Forms.Panel
        Friend WithEvents lblUnpaidLabel As System.Windows.Forms.Label
        Friend WithEvents lblUnpaidValue As System.Windows.Forms.Label
        Friend WithEvents pnlAccent4 As System.Windows.Forms.Panel
        Friend WithEvents pnlReady As System.Windows.Forms.Panel
        Friend WithEvents lblReadyLabel As System.Windows.Forms.Label
        Friend WithEvents lblReadyValue As System.Windows.Forms.Label
        Friend WithEvents pnlAccent3 As System.Windows.Forms.Panel
        Friend WithEvents pnlInProgress As System.Windows.Forms.Panel
        Friend WithEvents lblInProgressLabel As System.Windows.Forms.Label
        Friend WithEvents lblInProgressValue As System.Windows.Forms.Label
        Friend WithEvents pnlAccent2 As System.Windows.Forms.Panel
        Friend WithEvents pnlActiveStudents As System.Windows.Forms.Panel
        Friend WithEvents lblActiveStudentsLabel As System.Windows.Forms.Label
        Friend WithEvents lblActiveStudentsValue As System.Windows.Forms.Label
        Friend WithEvents pnlAccent1 As System.Windows.Forms.Panel
        Friend WithEvents dashboardTimer As System.Windows.Forms.Timer
    End Class
End Namespace
