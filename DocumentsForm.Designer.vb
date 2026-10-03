Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DocumentsForm
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
            Dim dgvCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.txtSearchDocuments = New System.Windows.Forms.TextBox()
            Me.cboDocumentsStatus = New System.Windows.Forms.ComboBox()
            Me.btnAddDocument = New System.Windows.Forms.Button()
            Me.pnlTableCard = New System.Windows.Forms.Panel()
            Me.lblRecordCount = New System.Windows.Forms.Label()
            Me.btnToggleDocumentStatus = New System.Windows.Forms.Button()
            Me.btnEditDocument = New System.Windows.Forms.Button()
            Me.lblCardTitle = New System.Windows.Forms.Label()
            Me.dgvDocuments = New System.Windows.Forms.DataGridView()
            Me.colDocID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDocName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDocStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlSlipsCard = New System.Windows.Forms.Panel()
            Me.btnViewSlip = New System.Windows.Forms.Button()
            Me.lblSlipsCardTitle = New System.Windows.Forms.Label()
            Me.dgvRecentSlips = New System.Windows.Forms.DataGridView()
            Me.colSlipRequestNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSlipStudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSlipDocument = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSlipDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSlipStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlHeader.SuspendLayout()
            Me.pnlTableCard.SuspendLayout()
            CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlSlipsCard.SuspendLayout()
            CType(Me.dgvRecentSlips, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.lblSubtitle.Text = "Manage available registrar documents and fees."
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(-2, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(161, 37)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Documents"
            '
            'txtSearchDocuments
            '
            Me.txtSearchDocuments.BackColor = System.Drawing.Color.White
            Me.txtSearchDocuments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearchDocuments.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtSearchDocuments.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.txtSearchDocuments.Location = New System.Drawing.Point(24, 96)
            Me.txtSearchDocuments.Name = "txtSearchDocuments"
            Me.txtSearchDocuments.Size = New System.Drawing.Size(320, 25)
            Me.txtSearchDocuments.TabIndex = 1
            '
            'cboDocumentsStatus
            '
            Me.cboDocumentsStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDocumentsStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboDocumentsStatus.FormattingEnabled = True
            Me.cboDocumentsStatus.Items.AddRange(New Object() {"All Statuses", "Active", "Inactive"})
            Me.cboDocumentsStatus.Location = New System.Drawing.Point(356, 96)
            Me.cboDocumentsStatus.Name = "cboDocumentsStatus"
            Me.cboDocumentsStatus.Size = New System.Drawing.Size(160, 25)
            Me.cboDocumentsStatus.TabIndex = 2
            '
            'btnAddDocument
            '
            Me.btnAddDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddDocument.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddDocument.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddDocument.FlatAppearance.BorderSize = 0
            Me.btnAddDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddDocument.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddDocument.ForeColor = System.Drawing.Color.White
            Me.btnAddDocument.Location = New System.Drawing.Point(776, 90)
            Me.btnAddDocument.Name = "btnAddDocument"
            Me.btnAddDocument.Size = New System.Drawing.Size(150, 36)
            Me.btnAddDocument.TabIndex = 3
            Me.btnAddDocument.Text = "+ Add Document"
            Me.btnAddDocument.UseVisualStyleBackColor = False
            '
            'pnlTableCard
            '
            Me.pnlTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTableCard.BackColor = System.Drawing.Color.White
            Me.pnlTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTableCard.Controls.Add(Me.lblRecordCount)
            Me.pnlTableCard.Controls.Add(Me.btnToggleDocumentStatus)
            Me.pnlTableCard.Controls.Add(Me.btnEditDocument)
            Me.pnlTableCard.Controls.Add(Me.lblCardTitle)
            Me.pnlTableCard.Controls.Add(Me.dgvDocuments)
            Me.pnlTableCard.Location = New System.Drawing.Point(24, 145)
            Me.pnlTableCard.Name = "pnlTableCard"
            Me.pnlTableCard.Size = New System.Drawing.Size(902, 310)
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
            Me.lblRecordCount.Text = "Showing document records"
            Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnToggleDocumentStatus
            '
            Me.btnToggleDocumentStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnToggleDocumentStatus.BackColor = System.Drawing.Color.White
            Me.btnToggleDocumentStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToggleDocumentStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleDocumentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToggleDocumentStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnToggleDocumentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleDocumentStatus.Location = New System.Drawing.Point(725, 12)
            Me.btnToggleDocumentStatus.Name = "btnToggleDocumentStatus"
            Me.btnToggleDocumentStatus.Size = New System.Drawing.Size(160, 32)
            Me.btnToggleDocumentStatus.TabIndex = 3
            Me.btnToggleDocumentStatus.Text = "Activate / Deactivate"
            Me.btnToggleDocumentStatus.UseVisualStyleBackColor = False
            '
            'btnEditDocument
            '
            Me.btnEditDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEditDocument.BackColor = System.Drawing.Color.White
            Me.btnEditDocument.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditDocument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditDocument.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnEditDocument.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditDocument.Location = New System.Drawing.Point(625, 12)
            Me.btnEditDocument.Name = "btnEditDocument"
            Me.btnEditDocument.Size = New System.Drawing.Size(90, 32)
            Me.btnEditDocument.TabIndex = 2
            Me.btnEditDocument.Text = "Edit"
            Me.btnEditDocument.UseVisualStyleBackColor = False
            '
            'lblCardTitle
            '
            Me.lblCardTitle.AutoSize = True
            Me.lblCardTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblCardTitle.Location = New System.Drawing.Point(16, 16)
            Me.lblCardTitle.Name = "lblCardTitle"
            Me.lblCardTitle.Size = New System.Drawing.Size(134, 21)
            Me.lblCardTitle.TabIndex = 0
            Me.lblCardTitle.Text = "Document Types"
            '
            'dgvDocuments
            '
            Me.dgvDocuments.AllowUserToAddRows = False
            Me.dgvDocuments.AllowUserToDeleteRows = False
            Me.dgvDocuments.AllowUserToResizeRows = False
            Me.dgvDocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDocuments.BackgroundColor = System.Drawing.Color.White
            Me.dgvDocuments.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvDocuments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvDocuments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDocuments.ColumnHeadersDefaultCellStyle = dgvCellStyle1
            Me.dgvDocuments.ColumnHeadersHeight = 40
            Me.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvDocuments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocID, Me.colDocName, Me.colDescription, Me.colFee, Me.colDocStatus})
            dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle2.BackColor = System.Drawing.Color.White
            dgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            dgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvDocuments.DefaultCellStyle = dgvCellStyle2
            Me.dgvDocuments.EnableHeadersVisualStyles = False
            Me.dgvDocuments.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvDocuments.Location = New System.Drawing.Point(0, 56)
            Me.dgvDocuments.MultiSelect = False
            Me.dgvDocuments.Name = "dgvDocuments"
            Me.dgvDocuments.ReadOnly = True
            Me.dgvDocuments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle3.BackColor = System.Drawing.Color.White
            dgvCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dgvCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dgvCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvDocuments.RowHeadersDefaultCellStyle = dgvCellStyle3
            Me.dgvDocuments.RowHeadersVisible = False
            Me.dgvDocuments.RowTemplate.Height = 36
            Me.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvDocuments.Size = New System.Drawing.Size(900, 252)
            Me.dgvDocuments.TabIndex = 4
            '
            'colDocID
            '
            Me.colDocID.DataPropertyName = "DocumentID"
            Me.colDocID.FillWeight = 60.0!
            Me.colDocID.HeaderText = "ID"
            Me.colDocID.Name = "colDocID"
            Me.colDocID.ReadOnly = True
            '
            'colDocName
            '
            Me.colDocName.DataPropertyName = "DocumentName"
            Me.colDocName.FillWeight = 160.0!
            Me.colDocName.HeaderText = "Document Name"
            Me.colDocName.Name = "colDocName"
            Me.colDocName.ReadOnly = True
            '
            'colDescription
            '
            Me.colDescription.DataPropertyName = "Description"
            Me.colDescription.FillWeight = 200.0!
            Me.colDescription.HeaderText = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.ReadOnly = True
            '
            'colFee
            '
            Me.colFee.DataPropertyName = "Fee"
            Me.colFee.FillWeight = 80.0!
            Me.colFee.HeaderText = "Fee (₱)"
            Me.colFee.Name = "colFee"
            Me.colFee.ReadOnly = True
            '
            'colDocStatus
            '
            Me.colDocStatus.DataPropertyName = "Status"
            Me.colDocStatus.FillWeight = 80.0!
            Me.colDocStatus.HeaderText = "Status"
            Me.colDocStatus.Name = "colDocStatus"
            Me.colDocStatus.ReadOnly = True
            '
            'pnlSlipsCard
            '
            Me.pnlSlipsCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlSlipsCard.BackColor = System.Drawing.Color.White
            Me.pnlSlipsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlSlipsCard.Controls.Add(Me.btnViewSlip)
            Me.pnlSlipsCard.Controls.Add(Me.lblSlipsCardTitle)
            Me.pnlSlipsCard.Controls.Add(Me.dgvRecentSlips)
            Me.pnlSlipsCard.Location = New System.Drawing.Point(24, 465)
            Me.pnlSlipsCard.Name = "pnlSlipsCard"
            Me.pnlSlipsCard.Size = New System.Drawing.Size(902, 170)
            Me.pnlSlipsCard.TabIndex = 5
            '
            'btnViewSlip
            '
            Me.btnViewSlip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnViewSlip.BackColor = System.Drawing.Color.White
            Me.btnViewSlip.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewSlip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewSlip.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnViewSlip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlip.Location = New System.Drawing.Point(785, 10)
            Me.btnViewSlip.Name = "btnViewSlip"
            Me.btnViewSlip.Size = New System.Drawing.Size(100, 30)
            Me.btnViewSlip.TabIndex = 1
            Me.btnViewSlip.Text = "View Slip"
            Me.btnViewSlip.UseVisualStyleBackColor = False
            '
            'lblSlipsCardTitle
            '
            Me.lblSlipsCardTitle.AutoSize = True
            Me.lblSlipsCardTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblSlipsCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblSlipsCardTitle.Location = New System.Drawing.Point(16, 14)
            Me.lblSlipsCardTitle.Name = "lblSlipsCardTitle"
            Me.lblSlipsCardTitle.Size = New System.Drawing.Size(152, 20)
            Me.lblSlipsCardTitle.TabIndex = 0
            Me.lblSlipsCardTitle.Text = "Recent Request Slips"
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
            Me.dgvRecentSlips.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRecentSlips.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvRecentSlips.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            dgvCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle4.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRecentSlips.ColumnHeadersDefaultCellStyle = dgvCellStyle4
            Me.dgvRecentSlips.ColumnHeadersHeight = 34
            Me.dgvRecentSlips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvRecentSlips.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSlipRequestNo, Me.colSlipStudent, Me.colSlipDocument, Me.colSlipDate, Me.colSlipStatus})
            dgvCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle5.BackColor = System.Drawing.Color.White
            dgvCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle5.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            dgvCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRecentSlips.DefaultCellStyle = dgvCellStyle5
            Me.dgvRecentSlips.EnableHeadersVisualStyles = False
            Me.dgvRecentSlips.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvRecentSlips.Location = New System.Drawing.Point(0, 48)
            Me.dgvRecentSlips.MultiSelect = False
            Me.dgvRecentSlips.Name = "dgvRecentSlips"
            Me.dgvRecentSlips.ReadOnly = True
            Me.dgvRecentSlips.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle6.BackColor = System.Drawing.Color.White
            dgvCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            dgvCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dgvCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dgvCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRecentSlips.RowHeadersDefaultCellStyle = dgvCellStyle6
            Me.dgvRecentSlips.RowHeadersVisible = False
            Me.dgvRecentSlips.RowTemplate.Height = 32
            Me.dgvRecentSlips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRecentSlips.Size = New System.Drawing.Size(900, 120)
            Me.dgvRecentSlips.TabIndex = 2
            '
            'colSlipRequestNo
            '
            Me.colSlipRequestNo.DataPropertyName = "RequestNo"
            Me.colSlipRequestNo.FillWeight = 110.0!
            Me.colSlipRequestNo.HeaderText = "Request No"
            Me.colSlipRequestNo.Name = "colSlipRequestNo"
            Me.colSlipRequestNo.ReadOnly = True
            '
            'colSlipStudent
            '
            Me.colSlipStudent.DataPropertyName = "StudentName"
            Me.colSlipStudent.FillWeight = 140.0!
            Me.colSlipStudent.HeaderText = "Student"
            Me.colSlipStudent.Name = "colSlipStudent"
            Me.colSlipStudent.ReadOnly = True
            '
            'colSlipDocument
            '
            Me.colSlipDocument.DataPropertyName = "DocumentName"
            Me.colSlipDocument.FillWeight = 150.0!
            Me.colSlipDocument.HeaderText = "Document"
            Me.colSlipDocument.Name = "colSlipDocument"
            Me.colSlipDocument.ReadOnly = True
            '
            'colSlipDate
            '
            Me.colSlipDate.DataPropertyName = "RequestDate"
            Me.colSlipDate.FillWeight = 90.0!
            Me.colSlipDate.HeaderText = "Date"
            Me.colSlipDate.Name = "colSlipDate"
            Me.colSlipDate.ReadOnly = True
            '
            'colSlipStatus
            '
            Me.colSlipStatus.DataPropertyName = "Status"
            Me.colSlipStatus.FillWeight = 90.0!
            Me.colSlipStatus.HeaderText = "Status"
            Me.colSlipStatus.Name = "colSlipStatus"
            Me.colSlipStatus.ReadOnly = True
            '
            'DocumentsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(950, 650)
            Me.Controls.Add(Me.pnlSlipsCard)
            Me.Controls.Add(Me.pnlTableCard)
            Me.Controls.Add(Me.btnAddDocument)
            Me.Controls.Add(Me.cboDocumentsStatus)
            Me.Controls.Add(Me.txtSearchDocuments)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "DocumentsForm"
            Me.Text = "Documents"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlTableCard.ResumeLayout(False)
            Me.pnlTableCard.PerformLayout()
            CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlSlipsCard.ResumeLayout(False)
            Me.pnlSlipsCard.PerformLayout()
            CType(Me.dgvRecentSlips, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As System.Windows.Forms.Label
        Friend WithEvents txtSearchDocuments As System.Windows.Forms.TextBox
        Friend WithEvents cboDocumentsStatus As System.Windows.Forms.ComboBox
        Friend WithEvents btnAddDocument As System.Windows.Forms.Button
        Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
        Friend WithEvents lblCardTitle As System.Windows.Forms.Label
        Friend WithEvents lblRecordCount As System.Windows.Forms.Label
        Friend WithEvents btnEditDocument As System.Windows.Forms.Button
        Friend WithEvents btnToggleDocumentStatus As System.Windows.Forms.Button
        Friend WithEvents dgvDocuments As System.Windows.Forms.DataGridView
        Friend WithEvents colDocID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDocName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFee As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDocStatus As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlSlipsCard As System.Windows.Forms.Panel
        Friend WithEvents lblSlipsCardTitle As System.Windows.Forms.Label
        Friend WithEvents btnViewSlip As System.Windows.Forms.Button
        Friend WithEvents dgvRecentSlips As System.Windows.Forms.DataGridView
        Friend WithEvents colSlipRequestNo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSlipStudent As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSlipDocument As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSlipDate As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSlipStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
