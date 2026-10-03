Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ReportsForm
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
            Me.pnlFilterCard = New System.Windows.Forms.Panel()
            Me.btnGenerateReport = New System.Windows.Forms.Button()
            Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
            Me.lblTo = New System.Windows.Forms.Label()
            Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
            Me.lblFrom = New System.Windows.Forms.Label()
            Me.cboReportType = New System.Windows.Forms.ComboBox()
            Me.lblReportTypeTitle = New System.Windows.Forms.Label()
            Me.pnlSummaryCard = New System.Windows.Forms.Panel()
            Me.lblReportTotal = New System.Windows.Forms.Label()
            Me.lblSummaryTitle = New System.Windows.Forms.Label()
            Me.pnlTableCard = New System.Windows.Forms.Panel()
            Me.lblCardTitle = New System.Windows.Forms.Label()
            Me.dgvReports = New System.Windows.Forms.DataGridView()
            Me.pnlHeader.SuspendLayout()
            Me.pnlFilterCard.SuspendLayout()
            Me.pnlSummaryCard.SuspendLayout()
            Me.pnlTableCard.SuspendLayout()
            CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.lblSubtitle.Size = New System.Drawing.Size(262, 17)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Generate request, payment, and release reports."
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(-2, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(117, 37)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Reports"
            '
            'pnlFilterCard
            '
            Me.pnlFilterCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlFilterCard.BackColor = System.Drawing.Color.White
            Me.pnlFilterCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlFilterCard.Controls.Add(Me.btnGenerateReport)
            Me.pnlFilterCard.Controls.Add(Me.dtpToDate)
            Me.pnlFilterCard.Controls.Add(Me.lblTo)
            Me.pnlFilterCard.Controls.Add(Me.dtpFromDate)
            Me.pnlFilterCard.Controls.Add(Me.lblFrom)
            Me.pnlFilterCard.Controls.Add(Me.cboReportType)
            Me.pnlFilterCard.Controls.Add(Me.lblReportTypeTitle)
            Me.pnlFilterCard.Location = New System.Drawing.Point(24, 88)
            Me.pnlFilterCard.Name = "pnlFilterCard"
            Me.pnlFilterCard.Size = New System.Drawing.Size(650, 75)
            Me.pnlFilterCard.TabIndex = 1
            '
            'btnGenerateReport
            '
            Me.btnGenerateReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnGenerateReport.FlatAppearance.BorderSize = 0
            Me.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
            Me.btnGenerateReport.Location = New System.Drawing.Point(530, 26)
            Me.btnGenerateReport.Name = "btnGenerateReport"
            Me.btnGenerateReport.Size = New System.Drawing.Size(104, 32)
            Me.btnGenerateReport.TabIndex = 6
            Me.btnGenerateReport.Text = "Generate"
            Me.btnGenerateReport.UseVisualStyleBackColor = False
            '
            'dtpToDate
            '
            Me.dtpToDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpToDate.Location = New System.Drawing.Point(376, 30)
            Me.dtpToDate.Name = "dtpToDate"
            Me.dtpToDate.Size = New System.Drawing.Size(130, 24)
            Me.dtpToDate.TabIndex = 5
            '
            'lblTo
            '
            Me.lblTo.AutoSize = True
            Me.lblTo.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.lblTo.Location = New System.Drawing.Point(374, 12)
            Me.lblTo.Name = "lblTo"
            Me.lblTo.Size = New System.Drawing.Size(22, 13)
            Me.lblTo.TabIndex = 4
            Me.lblTo.Text = "To:"
            '
            'dtpFromDate
            '
            Me.dtpFromDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFromDate.Location = New System.Drawing.Point(226, 30)
            Me.dtpFromDate.Name = "dtpFromDate"
            Me.dtpFromDate.Size = New System.Drawing.Size(130, 24)
            Me.dtpFromDate.TabIndex = 3
            '
            'lblFrom
            '
            Me.lblFrom.AutoSize = True
            Me.lblFrom.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.lblFrom.Location = New System.Drawing.Point(224, 12)
            Me.lblFrom.Name = "lblFrom"
            Me.lblFrom.Size = New System.Drawing.Size(36, 13)
            Me.lblFrom.TabIndex = 2
            Me.lblFrom.Text = "From:"
            '
            'cboReportType
            '
            Me.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboReportType.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.cboReportType.FormattingEnabled = True
            Me.cboReportType.Items.AddRange(New Object() {"Daily Collections", "Monthly Summary", "Requests by Status", "Document Popularity"})
            Me.cboReportType.Location = New System.Drawing.Point(16, 30)
            Me.cboReportType.Name = "cboReportType"
            Me.cboReportType.Size = New System.Drawing.Size(190, 24)
            Me.cboReportType.TabIndex = 1
            '
            'lblReportTypeTitle
            '
            Me.lblReportTypeTitle.AutoSize = True
            Me.lblReportTypeTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblReportTypeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.lblReportTypeTitle.Location = New System.Drawing.Point(16, 12)
            Me.lblReportTypeTitle.Name = "lblReportTypeTitle"
            Me.lblReportTypeTitle.Size = New System.Drawing.Size(72, 13)
            Me.lblReportTypeTitle.TabIndex = 0
            Me.lblReportTypeTitle.Text = "Report Type:"
            '
            'pnlSummaryCard
            '
            Me.pnlSummaryCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlSummaryCard.BackColor = System.Drawing.Color.White
            Me.pnlSummaryCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlSummaryCard.Controls.Add(Me.lblReportTotal)
            Me.pnlSummaryCard.Controls.Add(Me.lblSummaryTitle)
            Me.pnlSummaryCard.Location = New System.Drawing.Point(686, 88)
            Me.pnlSummaryCard.Name = "pnlSummaryCard"
            Me.pnlSummaryCard.Size = New System.Drawing.Size(240, 75)
            Me.pnlSummaryCard.TabIndex = 2
            '
            'lblReportTotal
            '
            Me.lblReportTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblReportTotal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lblReportTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.lblReportTotal.Location = New System.Drawing.Point(10, 32)
            Me.lblReportTotal.Name = "lblReportTotal"
            Me.lblReportTotal.Size = New System.Drawing.Size(218, 32)
            Me.lblReportTotal.TabIndex = 1
            Me.lblReportTotal.Text = "₱0.00"
            Me.lblReportTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblSummaryTitle
            '
            Me.lblSummaryTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSummaryTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
            Me.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblSummaryTitle.Location = New System.Drawing.Point(10, 10)
            Me.lblSummaryTitle.Name = "lblSummaryTitle"
            Me.lblSummaryTitle.Size = New System.Drawing.Size(218, 16)
            Me.lblSummaryTitle.TabIndex = 0
            Me.lblSummaryTitle.Text = "REPORT TOTAL / SUMMARY"
            Me.lblSummaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pnlTableCard
            '
            Me.pnlTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTableCard.BackColor = System.Drawing.Color.White
            Me.pnlTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTableCard.Controls.Add(Me.lblCardTitle)
            Me.pnlTableCard.Controls.Add(Me.dgvReports)
            Me.pnlTableCard.Location = New System.Drawing.Point(24, 175)
            Me.pnlTableCard.Name = "pnlTableCard"
            Me.pnlTableCard.Size = New System.Drawing.Size(902, 450)
            Me.pnlTableCard.TabIndex = 3
            '
            'lblCardTitle
            '
            Me.lblCardTitle.AutoSize = True
            Me.lblCardTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblCardTitle.Location = New System.Drawing.Point(16, 16)
            Me.lblCardTitle.Name = "lblCardTitle"
            Me.lblCardTitle.Size = New System.Drawing.Size(121, 21)
            Me.lblCardTitle.TabIndex = 0
            Me.lblCardTitle.Text = "Report Results"
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
            Me.dgvReports.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvReports.ColumnHeadersDefaultCellStyle = dgvCellStyle1
            Me.dgvReports.ColumnHeadersHeight = 40
            Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle2.BackColor = System.Drawing.Color.White
            dgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            dgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvReports.DefaultCellStyle = dgvCellStyle2
            Me.dgvReports.EnableHeadersVisualStyles = False
            Me.dgvReports.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvReports.Location = New System.Drawing.Point(0, 56)
            Me.dgvReports.MultiSelect = False
            Me.dgvReports.Name = "dgvReports"
            Me.dgvReports.ReadOnly = True
            Me.dgvReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle3.BackColor = System.Drawing.Color.White
            dgvCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dgvCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dgvCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvReports.RowHeadersDefaultCellStyle = dgvCellStyle3
            Me.dgvReports.RowHeadersVisible = False
            Me.dgvReports.RowTemplate.Height = 36
            Me.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvReports.Size = New System.Drawing.Size(900, 392)
            Me.dgvReports.TabIndex = 1
            '
            'ReportsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(950, 650)
            Me.Controls.Add(Me.pnlTableCard)
            Me.Controls.Add(Me.pnlSummaryCard)
            Me.Controls.Add(Me.pnlFilterCard)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "ReportsForm"
            Me.Text = "Reports"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlFilterCard.ResumeLayout(False)
            Me.pnlFilterCard.PerformLayout()
            Me.pnlSummaryCard.ResumeLayout(False)
            Me.pnlTableCard.ResumeLayout(False)
            Me.pnlTableCard.PerformLayout()
            CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As System.Windows.Forms.Label
        Friend WithEvents pnlFilterCard As System.Windows.Forms.Panel
        Friend WithEvents lblReportTypeTitle As System.Windows.Forms.Label
        Friend WithEvents cboReportType As System.Windows.Forms.ComboBox
        Friend WithEvents lblFrom As System.Windows.Forms.Label
        Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblTo As System.Windows.Forms.Label
        Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
        Friend WithEvents pnlSummaryCard As System.Windows.Forms.Panel
        Friend WithEvents lblSummaryTitle As System.Windows.Forms.Label
        Friend WithEvents lblReportTotal As System.Windows.Forms.Label
        Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
        Friend WithEvents lblCardTitle As System.Windows.Forms.Label
        Friend WithEvents dgvReports As System.Windows.Forms.DataGridView
    End Class
End Namespace
