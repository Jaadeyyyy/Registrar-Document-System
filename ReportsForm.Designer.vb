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
            Me.dgvReports = New System.Windows.Forms.DataGridView()
            Me.lblReportTotal = New System.Windows.Forms.Label()
            Me.btnGenerateReport = New System.Windows.Forms.Button()
            Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
            Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
            Me.cboReportType = New System.Windows.Forms.ComboBox()
            CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.dgvReports.ColumnHeadersHeight = 38
            Me.dgvReports.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvReports.Location = New System.Drawing.Point(0, 50)
            Me.dgvReports.MultiSelect = False
            Me.dgvReports.Name = "dgvReports"
            Me.dgvReports.ReadOnly = True
            Me.dgvReports.RowHeadersVisible = False
            Me.dgvReports.RowTemplate.Height = 34
            Me.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvReports.Size = New System.Drawing.Size(1085, 472)
            Me.dgvReports.TabIndex = 5
            '
            'lblReportTotal
            '
            Me.lblReportTotal.AutoSize = True
            Me.lblReportTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.lblReportTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblReportTotal.Location = New System.Drawing.Point(675, 10)
            Me.lblReportTotal.Name = "lblReportTotal"
            Me.lblReportTotal.Size = New System.Drawing.Size(128, 19)
            Me.lblReportTotal.TabIndex = 4
            Me.lblReportTotal.Text = "Report Total: 0.00"
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
            'dtpToDate
            '
            Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpToDate.Location = New System.Drawing.Point(390, 4)
            Me.dtpToDate.Name = "dtpToDate"
            Me.dtpToDate.Size = New System.Drawing.Size(135, 25)
            Me.dtpToDate.TabIndex = 2
            '
            'dtpFromDate
            '
            Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFromDate.Location = New System.Drawing.Point(245, 4)
            Me.dtpFromDate.Name = "dtpFromDate"
            Me.dtpFromDate.Size = New System.Drawing.Size(135, 25)
            Me.dtpFromDate.TabIndex = 1
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
            'ReportsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1085, 522)
            Me.Controls.Add(Me.dgvReports)
            Me.Controls.Add(Me.lblReportTotal)
            Me.Controls.Add(Me.btnGenerateReport)
            Me.Controls.Add(Me.dtpToDate)
            Me.Controls.Add(Me.dtpFromDate)
            Me.Controls.Add(Me.cboReportType)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "ReportsForm"
            Me.Text = "Reports"
            CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents dgvReports As System.Windows.Forms.DataGridView
        Friend WithEvents lblReportTotal As System.Windows.Forms.Label
        Friend WithEvents btnGenerateReport As System.Windows.Forms.Button
        Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents cboReportType As System.Windows.Forms.ComboBox
    End Class
End Namespace
