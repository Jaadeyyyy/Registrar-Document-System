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
            Me.dgvRecentSlips = New System.Windows.Forms.DataGridView()
            Me.btnViewSlipDocument = New System.Windows.Forms.Button()
            Me.lblRecentSlips = New System.Windows.Forms.Label()
            Me.dgvDocuments = New System.Windows.Forms.DataGridView()
            Me.btnToggleDocumentStatus = New System.Windows.Forms.Button()
            Me.btnEditDocument = New System.Windows.Forms.Button()
            Me.btnAddDocument = New System.Windows.Forms.Button()
            Me.txtSearchDocuments = New System.Windows.Forms.TextBox()
            CType(Me.dgvRecentSlips, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.dgvRecentSlips.ColumnHeadersHeight = 38
            Me.dgvRecentSlips.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvRecentSlips.Location = New System.Drawing.Point(0, 325)
            Me.dgvRecentSlips.MultiSelect = False
            Me.dgvRecentSlips.Name = "dgvRecentSlips"
            Me.dgvRecentSlips.ReadOnly = True
            Me.dgvRecentSlips.RowHeadersVisible = False
            Me.dgvRecentSlips.RowTemplate.Height = 34
            Me.dgvRecentSlips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRecentSlips.Size = New System.Drawing.Size(1085, 190)
            Me.dgvRecentSlips.TabIndex = 7
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
            'dgvDocuments
            '
            Me.dgvDocuments.AllowUserToAddRows = False
            Me.dgvDocuments.AllowUserToDeleteRows = False
            Me.dgvDocuments.AllowUserToResizeRows = False
            Me.dgvDocuments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvDocuments.BackgroundColor = System.Drawing.Color.White
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
            'txtSearchDocuments
            '
            Me.txtSearchDocuments.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchDocuments.Name = "txtSearchDocuments"
            Me.txtSearchDocuments.Size = New System.Drawing.Size(310, 24)
            Me.txtSearchDocuments.TabIndex = 0
            '
            'DocumentsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1085, 522)
            Me.Controls.Add(Me.dgvRecentSlips)
            Me.Controls.Add(Me.btnViewSlipDocument)
            Me.Controls.Add(Me.lblRecentSlips)
            Me.Controls.Add(Me.dgvDocuments)
            Me.Controls.Add(Me.btnToggleDocumentStatus)
            Me.Controls.Add(Me.btnEditDocument)
            Me.Controls.Add(Me.btnAddDocument)
            Me.Controls.Add(Me.txtSearchDocuments)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "DocumentsForm"
            Me.Text = "Documents"
            CType(Me.dgvRecentSlips, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dgvDocuments, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents dgvRecentSlips As System.Windows.Forms.DataGridView
        Friend WithEvents btnViewSlipDocument As System.Windows.Forms.Button
        Friend WithEvents lblRecentSlips As System.Windows.Forms.Label
        Friend WithEvents dgvDocuments As System.Windows.Forms.DataGridView
        Friend WithEvents btnToggleDocumentStatus As System.Windows.Forms.Button
        Friend WithEvents btnEditDocument As System.Windows.Forms.Button
        Friend WithEvents btnAddDocument As System.Windows.Forms.Button
        Friend WithEvents txtSearchDocuments As System.Windows.Forms.TextBox
    End Class
End Namespace
