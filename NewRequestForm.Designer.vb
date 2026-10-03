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
            Me.btnSaveRequest = New System.Windows.Forms.Button()
            Me.lblTotalAmount = New System.Windows.Forms.Label()
            Me.dgvRequestItems = New System.Windows.Forms.DataGridView()
            Me.colDocument = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblItemError = New System.Windows.Forms.Label()
            Me.btnRemoveItem = New System.Windows.Forms.Button()
            Me.btnAddItem = New System.Windows.Forms.Button()
            Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
            Me.cboDocument = New System.Windows.Forms.ComboBox()
            Me.lblPurposeError = New System.Windows.Forms.Label()
            Me.txtPurpose = New System.Windows.Forms.TextBox()
            Me.lblStudentError = New System.Windows.Forms.Label()
            Me.lblStudentInfo = New System.Windows.Forms.Label()
            Me.lstStudentResults = New System.Windows.Forms.ListBox()
            Me.txtSearchStudent = New System.Windows.Forms.TextBox()
            CType(Me.dgvRequestItems, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            'dgvRequestItems
            '
            Me.dgvRequestItems.AllowUserToAddRows = False
            Me.dgvRequestItems.AllowUserToDeleteRows = False
            Me.dgvRequestItems.AllowUserToResizeRows = False
            Me.dgvRequestItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvRequestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvRequestItems.BackgroundColor = System.Drawing.Color.White
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
            'lblItemError
            '
            Me.lblItemError.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.lblItemError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblItemError.Location = New System.Drawing.Point(700, 113)
            Me.lblItemError.Name = "lblItemError"
            Me.lblItemError.Size = New System.Drawing.Size(280, 20)
            Me.lblItemError.TabIndex = 9
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
            'cboDocument
            '
            Me.cboDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDocument.FormattingEnabled = True
            Me.cboDocument.Location = New System.Drawing.Point(0, 108)
            Me.cboDocument.Name = "cboDocument"
            Me.cboDocument.Size = New System.Drawing.Size(315, 25)
            Me.cboDocument.TabIndex = 5
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
            'txtPurpose
            '
            Me.txtPurpose.Location = New System.Drawing.Point(0, 56)
            Me.txtPurpose.MaxLength = 150
            Me.txtPurpose.Name = "txtPurpose"
            Me.txtPurpose.Size = New System.Drawing.Size(455, 25)
            Me.txtPurpose.TabIndex = 3
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
            'lblStudentInfo
            '
            Me.lblStudentInfo.AutoSize = True
            Me.lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblStudentInfo.Location = New System.Drawing.Point(475, 9)
            Me.lblStudentInfo.Name = "lblStudentInfo"
            Me.lblStudentInfo.Size = New System.Drawing.Size(0, 19)
            Me.lblStudentInfo.TabIndex = 1
            '
            'lstStudentResults
            '
            Me.lstStudentResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.lstStudentResults.Cursor = System.Windows.Forms.Cursors.Hand
            Me.lstStudentResults.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.lstStudentResults.ItemHeight = 17
            Me.lstStudentResults.Location = New System.Drawing.Point(0, 31)
            Me.lstStudentResults.Name = "lstStudentResults"
            Me.lstStudentResults.Size = New System.Drawing.Size(455, 121)
            Me.lstStudentResults.TabIndex = 1
            Me.lstStudentResults.Visible = False
            '
            'txtSearchStudent
            '
            Me.txtSearchStudent.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchStudent.Name = "txtSearchStudent"
            Me.txtSearchStudent.Size = New System.Drawing.Size(455, 25)
            Me.txtSearchStudent.TabIndex = 0
            '
            'NewRequestForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1085, 522)
            Me.Controls.Add(Me.lstStudentResults)
            Me.Controls.Add(Me.btnSaveRequest)
            Me.Controls.Add(Me.lblTotalAmount)
            Me.Controls.Add(Me.dgvRequestItems)
            Me.Controls.Add(Me.lblItemError)
            Me.Controls.Add(Me.btnRemoveItem)
            Me.Controls.Add(Me.btnAddItem)
            Me.Controls.Add(Me.nudQuantity)
            Me.Controls.Add(Me.cboDocument)
            Me.Controls.Add(Me.lblPurposeError)
            Me.Controls.Add(Me.txtPurpose)
            Me.Controls.Add(Me.lblStudentError)
            Me.Controls.Add(Me.lblStudentInfo)
            Me.Controls.Add(Me.txtSearchStudent)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "NewRequestForm"
            Me.Text = "New Request"
            CType(Me.dgvRequestItems, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btnSaveRequest As System.Windows.Forms.Button
        Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
        Friend WithEvents dgvRequestItems As System.Windows.Forms.DataGridView
        Friend WithEvents colDocument As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFee As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colQuantity As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents lblItemError As System.Windows.Forms.Label
        Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
        Friend WithEvents btnAddItem As System.Windows.Forms.Button
        Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
        Friend WithEvents cboDocument As System.Windows.Forms.ComboBox
        Friend WithEvents lblPurposeError As System.Windows.Forms.Label
        Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
        Friend WithEvents lblStudentError As System.Windows.Forms.Label
        Friend WithEvents lblStudentInfo As System.Windows.Forms.Label
        Friend WithEvents lstStudentResults As System.Windows.Forms.ListBox
        Friend WithEvents txtSearchStudent As System.Windows.Forms.TextBox
    End Class
End Namespace
