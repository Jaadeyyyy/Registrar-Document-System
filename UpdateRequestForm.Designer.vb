Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UpdateRequestForm
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
            Me.lblPayment = New System.Windows.Forms.Label()
            Me.cboPayment = New System.Windows.Forms.ComboBox()
            Me.lblStatus = New System.Windows.Forms.Label()
            Me.cboStatus = New System.Windows.Forms.ComboBox()
            Me.lblORNo = New System.Windows.Forms.Label()
            Me.txtORNo = New System.Windows.Forms.TextBox()
            Me.lblORDate = New System.Windows.Forms.Label()
            Me.dtpORDate = New System.Windows.Forms.DateTimePicker()
            Me.lblRule = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblPayment
            '
            Me.lblPayment.AutoSize = True
            Me.lblPayment.Location = New System.Drawing.Point(24, 38)
            Me.lblPayment.Name = "lblPayment"
            Me.lblPayment.Size = New System.Drawing.Size(96, 17)
            Me.lblPayment.TabIndex = 0
            Me.lblPayment.Text = "Payment Status"
            '
            'cboPayment
            '
            Me.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboPayment.FormattingEnabled = True
            Me.cboPayment.Items.AddRange(New Object() {"Unpaid", "Paid"})
            Me.cboPayment.Location = New System.Drawing.Point(175, 35)
            Me.cboPayment.Name = "cboPayment"
            Me.cboPayment.Size = New System.Drawing.Size(250, 25)
            Me.cboPayment.TabIndex = 1
            '
            'lblStatus
            '
            Me.lblStatus.AutoSize = True
            Me.lblStatus.Location = New System.Drawing.Point(24, 88)
            Me.lblStatus.Name = "lblStatus"
            Me.lblStatus.Size = New System.Drawing.Size(91, 17)
            Me.lblStatus.TabIndex = 2
            Me.lblStatus.Text = "Request Status"
            '
            'cboStatus
            '
            Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboStatus.FormattingEnabled = True
            Me.cboStatus.Location = New System.Drawing.Point(175, 85)
            Me.cboStatus.Name = "cboStatus"
            Me.cboStatus.Size = New System.Drawing.Size(250, 25)
            Me.cboStatus.TabIndex = 3
            '
            'lblORNo
            '
            Me.lblORNo.AutoSize = True
            Me.lblORNo.Location = New System.Drawing.Point(24, 138)
            Me.lblORNo.Name = "lblORNo"
            Me.lblORNo.Size = New System.Drawing.Size(76, 17)
            Me.lblORNo.TabIndex = 4
            Me.lblORNo.Text = "OR Number"
            '
            'txtORNo
            '
            Me.txtORNo.Location = New System.Drawing.Point(175, 135)
            Me.txtORNo.Name = "txtORNo"
            Me.txtORNo.Size = New System.Drawing.Size(250, 25)
            Me.txtORNo.TabIndex = 5
            '
            'lblORDate
            '
            Me.lblORDate.AutoSize = True
            Me.lblORDate.Location = New System.Drawing.Point(24, 188)
            Me.lblORDate.Name = "lblORDate"
            Me.lblORDate.Size = New System.Drawing.Size(56, 17)
            Me.lblORDate.TabIndex = 6
            Me.lblORDate.Text = "OR Date"
            '
            'dtpORDate
            '
            Me.dtpORDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpORDate.Location = New System.Drawing.Point(175, 185)
            Me.dtpORDate.Name = "dtpORDate"
            Me.dtpORDate.Size = New System.Drawing.Size(250, 25)
            Me.dtpORDate.TabIndex = 7
            '
            'lblRule
            '
            Me.lblRule.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.lblRule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.lblRule.Location = New System.Drawing.Point(24, 230)
            Me.lblRule.Name = "lblRule"
            Me.lblRule.Size = New System.Drawing.Size(410, 40)
            Me.lblRule.TabIndex = 8
            Me.lblRule.Text = "Enter official receipt details when recording payment as Paid. Requests must be " &
    "paid before release."
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(175, 282)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(145, 38)
            Me.btnSave.TabIndex = 9
            Me.btnSave.Text = "Save Changes"
            Me.btnSave.UseVisualStyleBackColor = False
            '
            'btnCancel
            '
            Me.btnCancel.BackColor = System.Drawing.Color.White
            Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnCancel.Location = New System.Drawing.Point(330, 282)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(95, 38)
            Me.btnCancel.TabIndex = 10
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'UpdateRequestForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(470, 350)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.lblRule)
            Me.Controls.Add(Me.dtpORDate)
            Me.Controls.Add(Me.lblORDate)
            Me.Controls.Add(Me.txtORNo)
            Me.Controls.Add(Me.lblORNo)
            Me.Controls.Add(Me.cboStatus)
            Me.Controls.Add(Me.lblStatus)
            Me.Controls.Add(Me.cboPayment)
            Me.Controls.Add(Me.lblPayment)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "UpdateRequestForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Update Request"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblPayment As System.Windows.Forms.Label
        Friend WithEvents cboPayment As System.Windows.Forms.ComboBox
        Friend WithEvents lblStatus As System.Windows.Forms.Label
        Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
        Friend WithEvents lblORNo As System.Windows.Forms.Label
        Friend WithEvents txtORNo As System.Windows.Forms.TextBox
        Friend WithEvents lblORDate As System.Windows.Forms.Label
        Friend WithEvents dtpORDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents lblRule As System.Windows.Forms.Label
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace
