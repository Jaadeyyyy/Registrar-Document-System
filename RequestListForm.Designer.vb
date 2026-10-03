Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class RequestListForm
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
            Me.txtSearchRequests = New System.Windows.Forms.TextBox()
            Me.cboRequestStatusFilter = New System.Windows.Forms.ComboBox()
            Me.cboPaymentStatusFilter = New System.Windows.Forms.ComboBox()
            Me.pnlTableCard = New System.Windows.Forms.Panel()
            Me.lblRecordCount = New System.Windows.Forms.Label()
            Me.btnViewSlipRequest = New System.Windows.Forms.Button()
            Me.btnUpdateStatus = New System.Windows.Forms.Button()
            Me.btnViewDetails = New System.Windows.Forms.Button()
            Me.lblCardTitle = New System.Windows.Forms.Label()
            Me.dgvRequests = New System.Windows.Forms.DataGridView()
            Me.colReqNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colReqDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colReqStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colReqStudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colReqDocuments = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colReqTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colReqPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colReqStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlHeader.SuspendLayout()
            Me.pnlTableCard.SuspendLayout()
            CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.lblSubtitle.Size = New System.Drawing.Size(248, 17)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "View and manage student document requests."
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(-2, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(175, 37)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Request List"
            '
            'txtSearchRequests
            '
            Me.txtSearchRequests.BackColor = System.Drawing.Color.White
            Me.txtSearchRequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearchRequests.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtSearchRequests.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.txtSearchRequests.Location = New System.Drawing.Point(24, 96)
            Me.txtSearchRequests.Name = "txtSearchRequests"
            Me.txtSearchRequests.Size = New System.Drawing.Size(280, 25)
            Me.txtSearchRequests.TabIndex = 1
            '
            'cboRequestStatusFilter
            '
            Me.cboRequestStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboRequestStatusFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboRequestStatusFilter.FormattingEnabled = True
            Me.cboRequestStatusFilter.Items.AddRange(New Object() {"All Statuses", "Pending", "In Progress", "Ready for Pickup", "Completed", "Cancelled"})
            Me.cboRequestStatusFilter.Location = New System.Drawing.Point(316, 96)
            Me.cboRequestStatusFilter.Name = "cboRequestStatusFilter"
            Me.cboRequestStatusFilter.Size = New System.Drawing.Size(170, 25)
            Me.cboRequestStatusFilter.TabIndex = 2
            '
            'cboPaymentStatusFilter
            '
            Me.cboPaymentStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPaymentStatusFilter.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboPaymentStatusFilter.FormattingEnabled = True
            Me.cboPaymentStatusFilter.Items.AddRange(New Object() {"All Payments", "Unpaid", "Paid"})
            Me.cboPaymentStatusFilter.Location = New System.Drawing.Point(498, 96)
            Me.cboPaymentStatusFilter.Name = "cboPaymentStatusFilter"
            Me.cboPaymentStatusFilter.Size = New System.Drawing.Size(140, 25)
            Me.cboPaymentStatusFilter.TabIndex = 3
            '
            'pnlTableCard
            '
            Me.pnlTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTableCard.BackColor = System.Drawing.Color.White
            Me.pnlTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTableCard.Controls.Add(Me.lblRecordCount)
            Me.pnlTableCard.Controls.Add(Me.btnViewSlipRequest)
            Me.pnlTableCard.Controls.Add(Me.btnUpdateStatus)
            Me.pnlTableCard.Controls.Add(Me.btnViewDetails)
            Me.pnlTableCard.Controls.Add(Me.lblCardTitle)
            Me.pnlTableCard.Controls.Add(Me.dgvRequests)
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
            Me.lblRecordCount.Location = New System.Drawing.Point(220, 16)
            Me.lblRecordCount.Name = "lblRecordCount"
            Me.lblRecordCount.Size = New System.Drawing.Size(260, 24)
            Me.lblRecordCount.TabIndex = 1
            Me.lblRecordCount.Text = "Showing requests"
            Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnViewSlipRequest
            '
            Me.btnViewSlipRequest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnViewSlipRequest.BackColor = System.Drawing.Color.White
            Me.btnViewSlipRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewSlipRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewSlipRequest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnViewSlipRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipRequest.Location = New System.Drawing.Point(795, 12)
            Me.btnViewSlipRequest.Name = "btnViewSlipRequest"
            Me.btnViewSlipRequest.Size = New System.Drawing.Size(90, 32)
            Me.btnViewSlipRequest.TabIndex = 4
            Me.btnViewSlipRequest.Text = "View Slip"
            Me.btnViewSlipRequest.UseVisualStyleBackColor = False
            '
            'btnUpdateStatus
            '
            Me.btnUpdateStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnUpdateStatus.BackColor = System.Drawing.Color.White
            Me.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdateStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUpdateStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnUpdateStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnUpdateStatus.Location = New System.Drawing.Point(635, 12)
            Me.btnUpdateStatus.Name = "btnUpdateStatus"
            Me.btnUpdateStatus.Size = New System.Drawing.Size(150, 32)
            Me.btnUpdateStatus.TabIndex = 3
            Me.btnUpdateStatus.Text = "Payment / Status"
            Me.btnUpdateStatus.UseVisualStyleBackColor = False
            '
            'btnViewDetails
            '
            Me.btnViewDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnViewDetails.BackColor = System.Drawing.Color.White
            Me.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewDetails.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnViewDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewDetails.Location = New System.Drawing.Point(515, 12)
            Me.btnViewDetails.Name = "btnViewDetails"
            Me.btnViewDetails.Size = New System.Drawing.Size(110, 32)
            Me.btnViewDetails.TabIndex = 2
            Me.btnViewDetails.Text = "View Details"
            Me.btnViewDetails.UseVisualStyleBackColor = False
            '
            'lblCardTitle
            '
            Me.lblCardTitle.AutoSize = True
            Me.lblCardTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblCardTitle.Location = New System.Drawing.Point(16, 16)
            Me.lblCardTitle.Name = "lblCardTitle"
            Me.lblCardTitle.Size = New System.Drawing.Size(155, 21)
            Me.lblCardTitle.TabIndex = 0
            Me.lblCardTitle.Text = "Document Requests"
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
            Me.dgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRequests.ColumnHeadersDefaultCellStyle = dgvCellStyle1
            Me.dgvRequests.ColumnHeadersHeight = 40
            Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvRequests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReqNo, Me.colReqDate, Me.colReqStudentID, Me.colReqStudentName, Me.colReqDocuments, Me.colReqTotal, Me.colReqPayment, Me.colReqStatus})
            dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle2.BackColor = System.Drawing.Color.White
            dgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            dgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvRequests.DefaultCellStyle = dgvCellStyle2
            Me.dgvRequests.EnableHeadersVisualStyles = False
            Me.dgvRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvRequests.Location = New System.Drawing.Point(0, 56)
            Me.dgvRequests.MultiSelect = False
            Me.dgvRequests.Name = "dgvRequests"
            Me.dgvRequests.ReadOnly = True
            Me.dgvRequests.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle3.BackColor = System.Drawing.Color.White
            dgvCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dgvCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dgvCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvRequests.RowHeadersDefaultCellStyle = dgvCellStyle3
            Me.dgvRequests.RowHeadersVisible = False
            Me.dgvRequests.RowTemplate.Height = 36
            Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequests.Size = New System.Drawing.Size(900, 422)
            Me.dgvRequests.TabIndex = 5
            '
            'colReqNo
            '
            Me.colReqNo.DataPropertyName = "RequestNo"
            Me.colReqNo.FillWeight = 110.0!
            Me.colReqNo.HeaderText = "Request No"
            Me.colReqNo.Name = "colReqNo"
            Me.colReqNo.ReadOnly = True
            '
            'colReqDate
            '
            Me.colReqDate.DataPropertyName = "RequestDate"
            Me.colReqDate.FillWeight = 90.0!
            Me.colReqDate.HeaderText = "Date"
            Me.colReqDate.Name = "colReqDate"
            Me.colReqDate.ReadOnly = True
            '
            'colReqStudentID
            '
            Me.colReqStudentID.DataPropertyName = "StudentID"
            Me.colReqStudentID.FillWeight = 95.0!
            Me.colReqStudentID.HeaderText = "Student ID"
            Me.colReqStudentID.Name = "colReqStudentID"
            Me.colReqStudentID.ReadOnly = True
            '
            'colReqStudentName
            '
            Me.colReqStudentName.DataPropertyName = "StudentName"
            Me.colReqStudentName.FillWeight = 135.0!
            Me.colReqStudentName.HeaderText = "Student Name"
            Me.colReqStudentName.Name = "colReqStudentName"
            Me.colReqStudentName.ReadOnly = True
            '
            'colReqDocuments
            '
            Me.colReqDocuments.DataPropertyName = "DocumentList"
            Me.colReqDocuments.FillWeight = 170.0!
            Me.colReqDocuments.HeaderText = "Documents"
            Me.colReqDocuments.Name = "colReqDocuments"
            Me.colReqDocuments.ReadOnly = True
            '
            'colReqTotal
            '
            Me.colReqTotal.DataPropertyName = "TotalAmount"
            Me.colReqTotal.FillWeight = 85.0!
            Me.colReqTotal.HeaderText = "Total (₱)"
            Me.colReqTotal.Name = "colReqTotal"
            Me.colReqTotal.ReadOnly = True
            '
            'colReqPayment
            '
            Me.colReqPayment.DataPropertyName = "PaymentStatus"
            Me.colReqPayment.FillWeight = 85.0!
            Me.colReqPayment.HeaderText = "Payment"
            Me.colReqPayment.Name = "colReqPayment"
            Me.colReqPayment.ReadOnly = True
            '
            'colReqStatus
            '
            Me.colReqStatus.DataPropertyName = "Status"
            Me.colReqStatus.FillWeight = 95.0!
            Me.colReqStatus.HeaderText = "Status"
            Me.colReqStatus.Name = "colReqStatus"
            Me.colReqStatus.ReadOnly = True
            '
            'RequestListForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(950, 650)
            Me.Controls.Add(Me.pnlTableCard)
            Me.Controls.Add(Me.cboPaymentStatusFilter)
            Me.Controls.Add(Me.cboRequestStatusFilter)
            Me.Controls.Add(Me.txtSearchRequests)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "RequestListForm"
            Me.Text = "Request List"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlTableCard.ResumeLayout(False)
            Me.pnlTableCard.PerformLayout()
            CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As System.Windows.Forms.Label
        Friend WithEvents txtSearchRequests As System.Windows.Forms.TextBox
        Friend WithEvents cboRequestStatusFilter As System.Windows.Forms.ComboBox
        Friend WithEvents cboPaymentStatusFilter As System.Windows.Forms.ComboBox
        Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
        Friend WithEvents lblCardTitle As System.Windows.Forms.Label
        Friend WithEvents lblRecordCount As System.Windows.Forms.Label
        Friend WithEvents btnViewDetails As System.Windows.Forms.Button
        Friend WithEvents btnUpdateStatus As System.Windows.Forms.Button
        Friend WithEvents btnViewSlipRequest As System.Windows.Forms.Button
        Friend WithEvents dgvRequests As System.Windows.Forms.DataGridView
        Friend WithEvents colReqNo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colReqDate As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colReqStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colReqStudentName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colReqDocuments As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colReqTotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colReqPayment As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colReqStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
