Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class RequestDetailsForm
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
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.lblSummary = New System.Windows.Forms.Label()
            Me.dgvItems = New System.Windows.Forms.DataGridView()
            Me.colDocName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDocFee = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDocQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colDocSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.lblTotal = New System.Windows.Forms.Label()
            Me.btnClose = New System.Windows.Forms.Button()
            CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblSummary
            '
            Me.lblSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblSummary.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.lblSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblSummary.Location = New System.Drawing.Point(24, 20)
            Me.lblSummary.Name = "lblSummary"
            Me.lblSummary.Size = New System.Drawing.Size(735, 100)
            Me.lblSummary.TabIndex = 0
            Me.lblSummary.Text = "REQ-2026-00001  |  Request Information" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Student ID: 1137-24 - Dela Cruz, Juan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Purpose: School Requirement" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Payment: Unpaid  |  Status: Pending"
            '
            '
            'colDocName
            '
            Me.colDocName.DataPropertyName = "DocumentName"
            Me.colDocName.FillWeight = 160.0!
            Me.colDocName.HeaderText = "Document"
            Me.colDocName.Name = "colDocName"
            Me.colDocName.ReadOnly = True
            '
            'colDocFee
            '
            Me.colDocFee.DataPropertyName = "Amount"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle4.Format = "N2"
            Me.colDocFee.DefaultCellStyle = DataGridViewCellStyle4
            Me.colDocFee.FillWeight = 60.0!
            Me.colDocFee.HeaderText = "Fee"
            Me.colDocFee.Name = "colDocFee"
            Me.colDocFee.ReadOnly = True
            '
            'colDocQty
            '
            Me.colDocQty.DataPropertyName = "Quantity"
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.colDocQty.DefaultCellStyle = DataGridViewCellStyle5
            Me.colDocQty.FillWeight = 50.0!
            Me.colDocQty.HeaderText = "Quantity"
            Me.colDocQty.Name = "colDocQty"
            Me.colDocQty.ReadOnly = True
            '
            'colDocSubtotal
            '
            Me.colDocSubtotal.DataPropertyName = "SubTotal"
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle4.Format = "N2"
            Me.colDocSubtotal.DefaultCellStyle = DataGridViewCellStyle4
            Me.colDocSubtotal.FillWeight = 70.0!
            Me.colDocSubtotal.HeaderText = "Subtotal"
            Me.colDocSubtotal.Name = "colDocSubtotal"
            Me.colDocSubtotal.ReadOnly = True
            '
            'dgvItems
            '
            Me.dgvItems.AllowUserToAddRows = False
            Me.dgvItems.AllowUserToDeleteRows = False
            Me.dgvItems.AllowUserToResizeRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(218, Byte), Integer))
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.dgvItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.dgvItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvItems.AutoGenerateColumns = False
            Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvItems.BackgroundColor = System.Drawing.Color.White
            Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvItems.ColumnHeadersHeight = 38
            Me.dgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDocName, Me.colDocFee, Me.colDocQty, Me.colDocSubtotal})
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(218, Byte), Integer))
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvItems.DefaultCellStyle = DataGridViewCellStyle3
            Me.dgvItems.EnableHeadersVisualStyles = False
            Me.dgvItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvItems.Location = New System.Drawing.Point(24, 130)
            Me.dgvItems.MultiSelect = False
            Me.dgvItems.Name = "dgvItems"
            Me.dgvItems.ReadOnly = True
            Me.dgvItems.RowHeadersVisible = False
            Me.dgvItems.RowTemplate.Height = 34
            Me.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvItems.Size = New System.Drawing.Size(735, 285)
            Me.dgvItems.TabIndex = 1
            Me.dgvItems.Rows.Add(New Object() {"Transcript of Records (TOR)", "150.00", 1, "150.00"})
            Me.dgvItems.Rows.Add(New Object() {"Certificate of Good Moral", "50.00", 2, "100.00"})
            '
            'lblTotal
            '
            Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTotal.Location = New System.Drawing.Point(24, 430)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(126, 25)
            Me.lblTotal.TabIndex = 2
            Me.lblTotal.Text = "Total: 250.00"
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnClose.BackColor = System.Drawing.Color.White
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(649, 425)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(110, 38)
            Me.btnClose.TabIndex = 3
            Me.btnClose.Text = "Close"
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'RequestDetailsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(790, 500)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.lblTotal)
            Me.Controls.Add(Me.dgvItems)
            Me.Controls.Add(Me.lblSummary)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.MinimumSize = New System.Drawing.Size(650, 450)
            Me.Name = "RequestDetailsForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Request Details"
            CType(Me.dgvItems, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblSummary As System.Windows.Forms.Label
        Friend WithEvents dgvItems As System.Windows.Forms.DataGridView
        Friend WithEvents colDocName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDocFee As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDocQty As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colDocSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
    End Class
End Namespace
