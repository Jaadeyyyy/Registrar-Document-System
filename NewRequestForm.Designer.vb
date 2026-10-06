Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class NewRequestForm
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.pnlStudentCard = New System.Windows.Forms.Panel()
            Me.cboStudentSearchResults = New System.Windows.Forms.ComboBox()
            Me.lblSelectStudentPrompt = New System.Windows.Forms.Label()
            Me.lblStudentYearSectionVal = New System.Windows.Forms.Label()
            Me.lblStudentCourseVal = New System.Windows.Forms.Label()
            Me.lblStudentNameVal = New System.Windows.Forms.Label()
            Me.lblStudentIdVal = New System.Windows.Forms.Label()
            Me.txtSearchStudent = New System.Windows.Forms.TextBox()
            Me.lblSearchStudentTitle = New System.Windows.Forms.Label()
            Me.lblStudentCardTitle = New System.Windows.Forms.Label()
            Me.pnlPurposeCard = New System.Windows.Forms.Panel()
            Me.txtPurpose = New System.Windows.Forms.TextBox()
            Me.lblPurposeTitle = New System.Windows.Forms.Label()
            Me.pnlDocumentCard = New System.Windows.Forms.Panel()
            Me.lblUnitFee = New System.Windows.Forms.Label()
            Me.btnAddItem = New System.Windows.Forms.Button()
            Me.numQuantity = New System.Windows.Forms.NumericUpDown()
            Me.lblQtyTitle = New System.Windows.Forms.Label()
            Me.cboDocument = New System.Windows.Forms.ComboBox()
            Me.lblDocSelectTitle = New System.Windows.Forms.Label()
            Me.lblDocCardTitle = New System.Windows.Forms.Label()
            Me.pnlItemsCard = New System.Windows.Forms.Panel()
            Me.btnRemoveItem = New System.Windows.Forms.Button()
            Me.lblItemsCardTitle = New System.Windows.Forms.Label()
            Me.dgvRequestItems = New System.Windows.Forms.DataGridView()
            Me.colItemDocID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colItemDocName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colItemFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colItemQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colItemSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlTotalCard = New System.Windows.Forms.Panel()
            Me.btnReset = New System.Windows.Forms.Button()
            Me.btnSaveRequest = New System.Windows.Forms.Button()
            Me.lblTotalAmount = New System.Windows.Forms.Label()
            Me.lblTotalTitle = New System.Windows.Forms.Label()
            Me.pnlHeader.SuspendLayout()
            Me.pnlStudentCard.SuspendLayout()
            Me.pnlPurposeCard.SuspendLayout()
            Me.pnlDocumentCard.SuspendLayout()
            CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlItemsCard.SuspendLayout()
            CType(Me.dgvRequestItems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTotalCard.SuspendLayout()
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
            Me.lblSubtitle.Size = New System.Drawing.Size(293, 17)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Create a document request for an active student."
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(-2, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(325, 37)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "New Document Request"
            '
            'pnlStudentCard
            '
            Me.pnlStudentCard.BackColor = System.Drawing.Color.White
            Me.pnlStudentCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlStudentCard.Controls.Add(Me.cboStudentSearchResults)
            Me.pnlStudentCard.Controls.Add(Me.lblSelectStudentPrompt)
            Me.pnlStudentCard.Controls.Add(Me.lblStudentYearSectionVal)
            Me.pnlStudentCard.Controls.Add(Me.lblStudentCourseVal)
            Me.pnlStudentCard.Controls.Add(Me.lblStudentNameVal)
            Me.pnlStudentCard.Controls.Add(Me.lblStudentIdVal)
            Me.pnlStudentCard.Controls.Add(Me.txtSearchStudent)
            Me.pnlStudentCard.Controls.Add(Me.lblSearchStudentTitle)
            Me.pnlStudentCard.Controls.Add(Me.lblStudentCardTitle)
            Me.pnlStudentCard.Location = New System.Drawing.Point(24, 88)
            Me.pnlStudentCard.Name = "pnlStudentCard"
            Me.pnlStudentCard.Size = New System.Drawing.Size(460, 200)
            Me.pnlStudentCard.TabIndex = 1
            '
            'cboStudentSearchResults
            '
            Me.cboStudentSearchResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboStudentSearchResults.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.cboStudentSearchResults.FormattingEnabled = True
            Me.cboStudentSearchResults.Location = New System.Drawing.Point(16, 102)
            Me.cboStudentSearchResults.Name = "cboStudentSearchResults"
            Me.cboStudentSearchResults.Size = New System.Drawing.Size(424, 23)
            Me.cboStudentSearchResults.TabIndex = 8
            '
            'lblSelectStudentPrompt
            '
            Me.lblSelectStudentPrompt.AutoSize = True
            Me.lblSelectStudentPrompt.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblSelectStudentPrompt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblSelectStudentPrompt.Location = New System.Drawing.Point(16, 86)
            Me.lblSelectStudentPrompt.Name = "lblSelectStudentPrompt"
            Me.lblSelectStudentPrompt.Size = New System.Drawing.Size(108, 13)
            Me.lblSelectStudentPrompt.TabIndex = 7
            Me.lblSelectStudentPrompt.Text = "Matching Students:"
            '
            'lblStudentYearSectionVal
            '
            Me.lblStudentYearSectionVal.AutoSize = True
            Me.lblStudentYearSectionVal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.lblStudentYearSectionVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblStudentYearSectionVal.Location = New System.Drawing.Point(230, 168)
            Me.lblStudentYearSectionVal.Name = "lblStudentYearSectionVal"
            Me.lblStudentYearSectionVal.Size = New System.Drawing.Size(85, 15)
            Me.lblStudentYearSectionVal.TabIndex = 6
            Me.lblStudentYearSectionVal.Text = "Year & Section: -"
            '
            'lblStudentCourseVal
            '
            Me.lblStudentCourseVal.AutoSize = True
            Me.lblStudentCourseVal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            Me.lblStudentCourseVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
            Me.lblStudentCourseVal.Location = New System.Drawing.Point(16, 168)
            Me.lblStudentCourseVal.Name = "lblStudentCourseVal"
            Me.lblStudentCourseVal.Size = New System.Drawing.Size(55, 15)
            Me.lblStudentCourseVal.TabIndex = 5
            Me.lblStudentCourseVal.Text = "Course: -"
            '
            'lblStudentNameVal
            '
            Me.lblStudentNameVal.AutoSize = True
            Me.lblStudentNameVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblStudentNameVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            Me.lblStudentNameVal.Location = New System.Drawing.Point(230, 142)
            Me.lblStudentNameVal.Name = "lblStudentNameVal"
            Me.lblStudentNameVal.Size = New System.Drawing.Size(51, 15)
            Me.lblStudentNameVal.TabIndex = 4
            Me.lblStudentNameVal.Text = "Name: -"
            '
            'lblStudentIdVal
            '
            Me.lblStudentIdVal.AutoSize = True
            Me.lblStudentIdVal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblStudentIdVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblStudentIdVal.Location = New System.Drawing.Point(16, 142)
            Me.lblStudentIdVal.Name = "lblStudentIdVal"
            Me.lblStudentIdVal.Size = New System.Drawing.Size(154, 15)
            Me.lblStudentIdVal.TabIndex = 3
            Me.lblStudentIdVal.Text = "Student ID: None selected"
            '
            'txtSearchStudent
            '
            Me.txtSearchStudent.BackColor = System.Drawing.Color.White
            Me.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearchStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtSearchStudent.Location = New System.Drawing.Point(16, 58)
            Me.txtSearchStudent.Name = "txtSearchStudent"
            Me.txtSearchStudent.Size = New System.Drawing.Size(424, 24)
            Me.txtSearchStudent.TabIndex = 2
            '
            'lblSearchStudentTitle
            '
            Me.lblSearchStudentTitle.AutoSize = True
            Me.lblSearchStudentTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblSearchStudentTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.lblSearchStudentTitle.Location = New System.Drawing.Point(16, 40)
            Me.lblSearchStudentTitle.Name = "lblSearchStudentTitle"
            Me.lblSearchStudentTitle.Size = New System.Drawing.Size(192, 15)
            Me.lblSearchStudentTitle.TabIndex = 1
            Me.lblSearchStudentTitle.Text = "Search by Student ID, LRN, Name"
            '
            'lblStudentCardTitle
            '
            Me.lblStudentCardTitle.AutoSize = True
            Me.lblStudentCardTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblStudentCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblStudentCardTitle.Location = New System.Drawing.Point(16, 12)
            Me.lblStudentCardTitle.Name = "lblStudentCardTitle"
            Me.lblStudentCardTitle.Size = New System.Drawing.Size(153, 20)
            Me.lblStudentCardTitle.TabIndex = 0
            Me.lblStudentCardTitle.Text = "Student Information"
            '
            'pnlPurposeCard
            '
            Me.pnlPurposeCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlPurposeCard.BackColor = System.Drawing.Color.White
            Me.pnlPurposeCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlPurposeCard.Controls.Add(Me.txtPurpose)
            Me.pnlPurposeCard.Controls.Add(Me.lblPurposeTitle)
            Me.pnlPurposeCard.Location = New System.Drawing.Point(500, 88)
            Me.pnlPurposeCard.Name = "pnlPurposeCard"
            Me.pnlPurposeCard.Size = New System.Drawing.Size(426, 92)
            Me.pnlPurposeCard.TabIndex = 2
            '
            'txtPurpose
            '
            Me.txtPurpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPurpose.BackColor = System.Drawing.Color.White
            Me.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtPurpose.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.txtPurpose.Location = New System.Drawing.Point(16, 42)
            Me.txtPurpose.Name = "txtPurpose"
            Me.txtPurpose.Size = New System.Drawing.Size(392, 24)
            Me.txtPurpose.TabIndex = 1
            '
            'lblPurposeTitle
            '
            Me.lblPurposeTitle.AutoSize = True
            Me.lblPurposeTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblPurposeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblPurposeTitle.Location = New System.Drawing.Point(16, 12)
            Me.lblPurposeTitle.Name = "lblPurposeTitle"
            Me.lblPurposeTitle.Size = New System.Drawing.Size(146, 20)
            Me.lblPurposeTitle.TabIndex = 0
            Me.lblPurposeTitle.Text = "Purpose of Request"
            '
            'pnlDocumentCard
            '
            Me.pnlDocumentCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlDocumentCard.BackColor = System.Drawing.Color.White
            Me.pnlDocumentCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlDocumentCard.Controls.Add(Me.lblUnitFee)
            Me.pnlDocumentCard.Controls.Add(Me.btnAddItem)
            Me.pnlDocumentCard.Controls.Add(Me.numQuantity)
            Me.pnlDocumentCard.Controls.Add(Me.lblQtyTitle)
            Me.pnlDocumentCard.Controls.Add(Me.cboDocument)
            Me.pnlDocumentCard.Controls.Add(Me.lblDocSelectTitle)
            Me.pnlDocumentCard.Controls.Add(Me.lblDocCardTitle)
            Me.pnlDocumentCard.Location = New System.Drawing.Point(500, 190)
            Me.pnlDocumentCard.Name = "pnlDocumentCard"
            Me.pnlDocumentCard.Size = New System.Drawing.Size(426, 98)
            Me.pnlDocumentCard.TabIndex = 3
            '
            'lblUnitFee
            '
            Me.lblUnitFee.AutoSize = True
            Me.lblUnitFee.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
            Me.lblUnitFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.lblUnitFee.Location = New System.Drawing.Point(16, 72)
            Me.lblUnitFee.Name = "lblUnitFee"
            Me.lblUnitFee.Size = New System.Drawing.Size(65, 15)
            Me.lblUnitFee.TabIndex = 6
            Me.lblUnitFee.Text = "Fee: ₱0.00"
            '
            'btnAddItem
            '
            Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddItem.FlatAppearance.BorderSize = 0
            Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnAddItem.ForeColor = System.Drawing.Color.White
            Me.btnAddItem.Location = New System.Drawing.Point(316, 38)
            Me.btnAddItem.Name = "btnAddItem"
            Me.btnAddItem.Size = New System.Drawing.Size(92, 30)
            Me.btnAddItem.TabIndex = 5
            Me.btnAddItem.Text = "+ Add Item"
            Me.btnAddItem.UseVisualStyleBackColor = False
            '
            'numQuantity
            '
            Me.numQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numQuantity.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.numQuantity.Location = New System.Drawing.Point(236, 42)
            Me.numQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numQuantity.Name = "numQuantity"
            Me.numQuantity.Size = New System.Drawing.Size(64, 24)
            Me.numQuantity.TabIndex = 4
            Me.numQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'lblQtyTitle
            '
            Me.lblQtyTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblQtyTitle.AutoSize = True
            Me.lblQtyTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblQtyTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.lblQtyTitle.Location = New System.Drawing.Point(234, 26)
            Me.lblQtyTitle.Name = "lblQtyTitle"
            Me.lblQtyTitle.Size = New System.Drawing.Size(51, 13)
            Me.lblQtyTitle.TabIndex = 3
            Me.lblQtyTitle.Text = "Quantity"
            '
            'cboDocument
            '
            Me.cboDocument.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.cboDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDocument.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.cboDocument.FormattingEnabled = True
            Me.cboDocument.Location = New System.Drawing.Point(16, 42)
            Me.cboDocument.Name = "cboDocument"
            Me.cboDocument.Size = New System.Drawing.Size(204, 25)
            Me.cboDocument.TabIndex = 2
            '
            'lblDocSelectTitle
            '
            Me.lblDocSelectTitle.AutoSize = True
            Me.lblDocSelectTitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblDocSelectTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            Me.lblDocSelectTitle.Location = New System.Drawing.Point(16, 26)
            Me.lblDocSelectTitle.Name = "lblDocSelectTitle"
            Me.lblDocSelectTitle.Size = New System.Drawing.Size(93, 13)
            Me.lblDocSelectTitle.TabIndex = 1
            Me.lblDocSelectTitle.Text = "Select Document"
            '
            'lblDocCardTitle
            '
            Me.lblDocCardTitle.AutoSize = True
            Me.lblDocCardTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblDocCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblDocCardTitle.Location = New System.Drawing.Point(16, 6)
            Me.lblDocCardTitle.Name = "lblDocCardTitle"
            Me.lblDocCardTitle.Size = New System.Drawing.Size(195, 20)
            Me.lblDocCardTitle.TabIndex = 0
            Me.lblDocCardTitle.Text = "Add Document to Request"
            '
            'pnlItemsCard
            '
            Me.pnlItemsCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlItemsCard.BackColor = System.Drawing.Color.White
            Me.pnlItemsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlItemsCard.Controls.Add(Me.btnRemoveItem)
            Me.pnlItemsCard.Controls.Add(Me.lblItemsCardTitle)
            Me.pnlItemsCard.Controls.Add(Me.dgvRequestItems)
            Me.pnlItemsCard.Location = New System.Drawing.Point(24, 300)
            Me.pnlItemsCard.Name = "pnlItemsCard"
            Me.pnlItemsCard.Size = New System.Drawing.Size(650, 335)
            Me.pnlItemsCard.TabIndex = 4
            '
            'btnRemoveItem
            '
            Me.btnRemoveItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnRemoveItem.BackColor = System.Drawing.Color.White
            Me.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRemoveItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.btnRemoveItem.Location = New System.Drawing.Point(530, 10)
            Me.btnRemoveItem.Name = "btnRemoveItem"
            Me.btnRemoveItem.Size = New System.Drawing.Size(105, 30)
            Me.btnRemoveItem.TabIndex = 2
            Me.btnRemoveItem.Text = "Remove Item"
            Me.btnRemoveItem.UseVisualStyleBackColor = False
            '
            'lblItemsCardTitle
            '
            Me.lblItemsCardTitle.AutoSize = True
            Me.lblItemsCardTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
            Me.lblItemsCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblItemsCardTitle.Location = New System.Drawing.Point(16, 14)
            Me.lblItemsCardTitle.Name = "lblItemsCardTitle"
            Me.lblItemsCardTitle.Size = New System.Drawing.Size(127, 20)
            Me.lblItemsCardTitle.TabIndex = 0
            Me.lblItemsCardTitle.Text = "Requested Items"
            '
            'dgvRequestItems
            '
            Me.dgvRequestItems.AllowUserToAddRows = False
            Me.dgvRequestItems.AllowUserToDeleteRows = False
            Me.dgvRequestItems.AllowUserToResizeRows = False
            Me.dgvRequestItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvRequestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRequestItems.BackgroundColor = System.Drawing.Color.White
            Me.dgvRequestItems.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRequestItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvRequestItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRequestItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvRequestItems.ColumnHeadersHeight = 36
            Me.dgvRequestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvRequestItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItemDocID, Me.colItemDocName, Me.colItemFee, Me.colItemQty, Me.colItemSubtotal})
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRequestItems.DefaultCellStyle = DataGridViewCellStyle2
            Me.dgvRequestItems.EnableHeadersVisualStyles = False
            Me.dgvRequestItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvRequestItems.Location = New System.Drawing.Point(0, 50)
            Me.dgvRequestItems.MultiSelect = False
            Me.dgvRequestItems.Name = "dgvRequestItems"
            Me.dgvRequestItems.ReadOnly = True
            Me.dgvRequestItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRequestItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
            Me.dgvRequestItems.RowHeadersVisible = False
            Me.dgvRequestItems.RowTemplate.Height = 34
            Me.dgvRequestItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequestItems.Size = New System.Drawing.Size(648, 283)
            Me.dgvRequestItems.TabIndex = 1
            '
            'colItemDocID
            '
            Me.colItemDocID.DataPropertyName = "DocumentID"
            Me.colItemDocID.FillWeight = 50.0!
            Me.colItemDocID.HeaderText = "ID"
            Me.colItemDocID.Name = "colItemDocID"
            Me.colItemDocID.ReadOnly = True
            '
            'colItemDocName
            '
            Me.colItemDocName.DataPropertyName = "DocumentName"
            Me.colItemDocName.FillWeight = 180.0!
            Me.colItemDocName.HeaderText = "Document"
            Me.colItemDocName.Name = "colItemDocName"
            Me.colItemDocName.ReadOnly = True
            '
            'colItemFee
            '
            Me.colItemFee.DataPropertyName = "Fee"
            Me.colItemFee.FillWeight = 80.0!
            Me.colItemFee.HeaderText = "Fee (₱)"
            Me.colItemFee.Name = "colItemFee"
            Me.colItemFee.ReadOnly = True
            '
            'colItemQty
            '
            Me.colItemQty.DataPropertyName = "Quantity"
            Me.colItemQty.FillWeight = 60.0!
            Me.colItemQty.HeaderText = "Qty"
            Me.colItemQty.Name = "colItemQty"
            Me.colItemQty.ReadOnly = True
            '
            'colItemSubtotal
            '
            Me.colItemSubtotal.DataPropertyName = "Subtotal"
            Me.colItemSubtotal.FillWeight = 90.0!
            Me.colItemSubtotal.HeaderText = "Subtotal (₱)"
            Me.colItemSubtotal.Name = "colItemSubtotal"
            Me.colItemSubtotal.ReadOnly = True
            '
            'pnlTotalCard
            '
            Me.pnlTotalCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTotalCard.BackColor = System.Drawing.Color.White
            Me.pnlTotalCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTotalCard.Controls.Add(Me.btnReset)
            Me.pnlTotalCard.Controls.Add(Me.btnSaveRequest)
            Me.pnlTotalCard.Controls.Add(Me.lblTotalAmount)
            Me.pnlTotalCard.Controls.Add(Me.lblTotalTitle)
            Me.pnlTotalCard.Location = New System.Drawing.Point(686, 300)
            Me.pnlTotalCard.Name = "pnlTotalCard"
            Me.pnlTotalCard.Size = New System.Drawing.Size(240, 335)
            Me.pnlTotalCard.TabIndex = 5
            '
            'btnReset
            '
            Me.btnReset.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReset.BackColor = System.Drawing.Color.White
            Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
            Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnReset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.btnReset.Location = New System.Drawing.Point(16, 276)
            Me.btnReset.Name = "btnReset"
            Me.btnReset.Size = New System.Drawing.Size(206, 40)
            Me.btnReset.TabIndex = 3
            Me.btnReset.Text = "Reset Form"
            Me.btnReset.UseVisualStyleBackColor = False
            '
            'btnSaveRequest
            '
            Me.btnSaveRequest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSaveRequest.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSaveRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSaveRequest.FlatAppearance.BorderSize = 0
            Me.btnSaveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSaveRequest.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.btnSaveRequest.ForeColor = System.Drawing.Color.White
            Me.btnSaveRequest.Location = New System.Drawing.Point(16, 224)
            Me.btnSaveRequest.Name = "btnSaveRequest"
            Me.btnSaveRequest.Size = New System.Drawing.Size(206, 46)
            Me.btnSaveRequest.TabIndex = 2
            Me.btnSaveRequest.Text = "Save & Submit Request"
            Me.btnSaveRequest.UseVisualStyleBackColor = False
            '
            'lblTotalAmount
            '
            Me.lblTotalAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTotalAmount.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(52, Byte), Integer))
            Me.lblTotalAmount.Location = New System.Drawing.Point(16, 56)
            Me.lblTotalAmount.Name = "lblTotalAmount"
            Me.lblTotalAmount.Size = New System.Drawing.Size(206, 50)
            Me.lblTotalAmount.TabIndex = 1
            Me.lblTotalAmount.Text = "₱0.00"
            Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblTotalTitle
            '
            Me.lblTotalTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblTotalTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblTotalTitle.Location = New System.Drawing.Point(16, 24)
            Me.lblTotalTitle.Name = "lblTotalTitle"
            Me.lblTotalTitle.Size = New System.Drawing.Size(206, 20)
            Me.lblTotalTitle.TabIndex = 0
            Me.lblTotalTitle.Text = "TOTAL AMOUNT"
            Me.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'NewRequestForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(950, 650)
            Me.Controls.Add(Me.pnlTotalCard)
            Me.Controls.Add(Me.pnlItemsCard)
            Me.Controls.Add(Me.pnlDocumentCard)
            Me.Controls.Add(Me.pnlPurposeCard)
            Me.Controls.Add(Me.pnlStudentCard)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "NewRequestForm"
            Me.Text = "New Document Request"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlStudentCard.ResumeLayout(False)
            Me.pnlStudentCard.PerformLayout()
            Me.pnlPurposeCard.ResumeLayout(False)
            Me.pnlPurposeCard.PerformLayout()
            Me.pnlDocumentCard.ResumeLayout(False)
            Me.pnlDocumentCard.PerformLayout()
            CType(Me.numQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlItemsCard.ResumeLayout(False)
            Me.pnlItemsCard.PerformLayout()
            CType(Me.dgvRequestItems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTotalCard.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As System.Windows.Forms.Label
        Friend WithEvents pnlStudentCard As System.Windows.Forms.Panel
        Friend WithEvents lblStudentCardTitle As System.Windows.Forms.Label
        Friend WithEvents lblSearchStudentTitle As System.Windows.Forms.Label
        Friend WithEvents txtSearchStudent As System.Windows.Forms.TextBox
        Friend WithEvents lblSelectStudentPrompt As System.Windows.Forms.Label
        Friend WithEvents cboStudentSearchResults As System.Windows.Forms.ComboBox
        Friend WithEvents lblStudentIdVal As System.Windows.Forms.Label
        Friend WithEvents lblStudentNameVal As System.Windows.Forms.Label
        Friend WithEvents lblStudentCourseVal As System.Windows.Forms.Label
        Friend WithEvents lblStudentYearSectionVal As System.Windows.Forms.Label
        Friend WithEvents pnlPurposeCard As System.Windows.Forms.Panel
        Friend WithEvents lblPurposeTitle As System.Windows.Forms.Label
        Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
        Friend WithEvents pnlDocumentCard As System.Windows.Forms.Panel
        Friend WithEvents lblDocCardTitle As System.Windows.Forms.Label
        Friend WithEvents lblDocSelectTitle As System.Windows.Forms.Label
        Friend WithEvents cboDocument As System.Windows.Forms.ComboBox
        Friend WithEvents lblQtyTitle As System.Windows.Forms.Label
        Friend WithEvents numQuantity As System.Windows.Forms.NumericUpDown
        Friend WithEvents btnAddItem As System.Windows.Forms.Button
        Friend WithEvents lblUnitFee As System.Windows.Forms.Label
        Friend WithEvents pnlItemsCard As System.Windows.Forms.Panel
        Friend WithEvents lblItemsCardTitle As System.Windows.Forms.Label
        Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
        Friend WithEvents dgvRequestItems As System.Windows.Forms.DataGridView
        Friend WithEvents colItemDocID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colItemDocName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colItemFee As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colItemQty As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colItemSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents pnlTotalCard As System.Windows.Forms.Panel
        Friend WithEvents lblTotalTitle As System.Windows.Forms.Label
        Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
        Friend WithEvents btnSaveRequest As System.Windows.Forms.Button
        Friend WithEvents btnReset As System.Windows.Forms.Button
    End Class
End Namespace
