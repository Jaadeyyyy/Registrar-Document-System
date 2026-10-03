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
            Me.lblSummary = New System.Windows.Forms.Label()
            Me.dgvItems = New System.Windows.Forms.DataGridView()
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
            '
            'dgvItems
            '
            Me.dgvItems.AllowUserToAddRows = False
            Me.dgvItems.AllowUserToDeleteRows = False
            Me.dgvItems.AllowUserToResizeRows = False
            Me.dgvItems.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvItems.BackgroundColor = System.Drawing.Color.White
            Me.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dgvItems.ColumnHeadersHeight = 38
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
            '
            'lblTotal
            '
            Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTotal.AutoSize = True
            Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
            Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.lblTotal.Location = New System.Drawing.Point(24, 430)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(109, 25)
            Me.lblTotal.TabIndex = 2
            Me.lblTotal.Text = "Total: 0.00"
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
        Friend WithEvents lblTotal As System.Windows.Forms.Label
        Friend WithEvents btnClose As System.Windows.Forms.Button
    End Class
End Namespace
