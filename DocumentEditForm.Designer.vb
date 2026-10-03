Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DocumentEditForm
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
            Me.lblDocumentName = New System.Windows.Forms.Label()
            Me.txtDocumentName = New System.Windows.Forms.TextBox()
            Me.lblDescription = New System.Windows.Forms.Label()
            Me.txtDescription = New System.Windows.Forms.TextBox()
            Me.lblFee = New System.Windows.Forms.Label()
            Me.txtFee = New System.Windows.Forms.TextBox()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblDocumentName
            '
            Me.lblDocumentName.AutoSize = True
            Me.lblDocumentName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblDocumentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblDocumentName.Location = New System.Drawing.Point(24, 28)
            Me.lblDocumentName.Name = "lblDocumentName"
            Me.lblDocumentName.Size = New System.Drawing.Size(110, 17)
            Me.lblDocumentName.TabIndex = 0
            Me.lblDocumentName.Text = "Document Name"
            '
            'txtDocumentName
            '
            Me.txtDocumentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDocumentName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtDocumentName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtDocumentName.Location = New System.Drawing.Point(160, 24)
            Me.txtDocumentName.Name = "txtDocumentName"
            Me.txtDocumentName.Size = New System.Drawing.Size(265, 25)
            Me.txtDocumentName.TabIndex = 1
            '
            'lblDescription
            '
            Me.lblDescription.AutoSize = True
            Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblDescription.Location = New System.Drawing.Point(24, 78)
            Me.lblDescription.Name = "lblDescription"
            Me.lblDescription.Size = New System.Drawing.Size(79, 17)
            Me.lblDescription.TabIndex = 2
            Me.lblDescription.Text = "Description"
            '
            'txtDescription
            '
            Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtDescription.Location = New System.Drawing.Point(160, 75)
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.Size = New System.Drawing.Size(265, 60)
            Me.txtDescription.TabIndex = 3
            '
            'lblFee
            '
            Me.lblFee.AutoSize = True
            Me.lblFee.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblFee.Location = New System.Drawing.Point(24, 158)
            Me.lblFee.Name = "lblFee"
            Me.lblFee.Size = New System.Drawing.Size(29, 17)
            Me.lblFee.TabIndex = 4
            Me.lblFee.Text = "Fee"
            '
            'txtFee
            '
            Me.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFee.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtFee.Location = New System.Drawing.Point(160, 155)
            Me.txtFee.Name = "txtFee"
            Me.txtFee.Size = New System.Drawing.Size(150, 25)
            Me.txtFee.TabIndex = 5
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSave.FlatAppearance.BorderSize = 1
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(160, 220)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(150, 38)
            Me.btnSave.TabIndex = 6
            Me.btnSave.Text = "Save Document"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.White
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnCancel.FlatAppearance.BorderSize = 1
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(320, 220)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(105, 38)
            Me.btnCancel.TabIndex = 7
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'DocumentEditForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(460, 305)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.txtFee)
            Me.Controls.Add(Me.lblFee)
            Me.Controls.Add(Me.txtDescription)
            Me.Controls.Add(Me.lblDescription)
            Me.Controls.Add(Me.txtDocumentName)
            Me.Controls.Add(Me.lblDocumentName)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "DocumentEditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Document Details"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblDocumentName As System.Windows.Forms.Label
        Friend WithEvents txtDocumentName As System.Windows.Forms.TextBox
        Friend WithEvents lblDescription As System.Windows.Forms.Label
        Friend WithEvents txtDescription As System.Windows.Forms.TextBox
        Friend WithEvents lblFee As System.Windows.Forms.Label
        Friend WithEvents txtFee As System.Windows.Forms.TextBox
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace
