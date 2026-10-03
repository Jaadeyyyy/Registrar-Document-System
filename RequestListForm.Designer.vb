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
            Me.dgvRequests = New System.Windows.Forms.DataGridView()
            Me.btnViewSlipRequest = New System.Windows.Forms.Button()
            Me.btnUpdateStatus = New System.Windows.Forms.Button()
            Me.btnViewDetails = New System.Windows.Forms.Button()
            Me.txtSearchRequests = New System.Windows.Forms.TextBox()
            CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.dgvRequests.ColumnHeadersHeight = 38
            Me.dgvRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvRequests.Location = New System.Drawing.Point(0, 50)
            Me.dgvRequests.MultiSelect = False
            Me.dgvRequests.Name = "dgvRequests"
            Me.dgvRequests.ReadOnly = True
            Me.dgvRequests.RowHeadersVisible = False
            Me.dgvRequests.RowTemplate.Height = 34
            Me.dgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvRequests.Size = New System.Drawing.Size(1085, 472)
            Me.dgvRequests.TabIndex = 4
            '
            'btnViewSlipRequest
            '
            Me.btnViewSlipRequest.BackColor = System.Drawing.Color.White
            Me.btnViewSlipRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewSlipRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewSlipRequest.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnViewSlipRequest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewSlipRequest.Location = New System.Drawing.Point(630, 1)
            Me.btnViewSlipRequest.Name = "btnViewSlipRequest"
            Me.btnViewSlipRequest.Size = New System.Drawing.Size(135, 38)
            Me.btnViewSlipRequest.TabIndex = 3
            Me.btnViewSlipRequest.Text = "View Slip"
            Me.btnViewSlipRequest.UseVisualStyleBackColor = False
            '
            'btnUpdateStatus
            '
            Me.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnUpdateStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnUpdateStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnUpdateStatus.ForeColor = System.Drawing.Color.White
            Me.btnUpdateStatus.Location = New System.Drawing.Point(465, 1)
            Me.btnUpdateStatus.Name = "btnUpdateStatus"
            Me.btnUpdateStatus.Size = New System.Drawing.Size(155, 38)
            Me.btnUpdateStatus.TabIndex = 2
            Me.btnUpdateStatus.Text = "Payment / Status"
            Me.btnUpdateStatus.UseVisualStyleBackColor = False
            '
            'btnViewDetails
            '
            Me.btnViewDetails.BackColor = System.Drawing.Color.White
            Me.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnViewDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnViewDetails.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnViewDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnViewDetails.Location = New System.Drawing.Point(325, 1)
            Me.btnViewDetails.Name = "btnViewDetails"
            Me.btnViewDetails.Size = New System.Drawing.Size(130, 38)
            Me.btnViewDetails.TabIndex = 1
            Me.btnViewDetails.Text = "View Details"
            Me.btnViewDetails.UseVisualStyleBackColor = False
            '
            'txtSearchRequests
            '
            Me.txtSearchRequests.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchRequests.Name = "txtSearchRequests"
            Me.txtSearchRequests.Size = New System.Drawing.Size(310, 24)
            Me.txtSearchRequests.TabIndex = 0
            '
            'RequestListForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1085, 522)
            Me.Controls.Add(Me.dgvRequests)
            Me.Controls.Add(Me.btnViewSlipRequest)
            Me.Controls.Add(Me.btnUpdateStatus)
            Me.Controls.Add(Me.btnViewDetails)
            Me.Controls.Add(Me.txtSearchRequests)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "RequestListForm"
            Me.Text = "Requests"
            CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents dgvRequests As System.Windows.Forms.DataGridView
        Friend WithEvents btnViewSlipRequest As System.Windows.Forms.Button
        Friend WithEvents btnUpdateStatus As System.Windows.Forms.Button
        Friend WithEvents btnViewDetails As System.Windows.Forms.Button
        Friend WithEvents txtSearchRequests As System.Windows.Forms.TextBox
    End Class
End Namespace
