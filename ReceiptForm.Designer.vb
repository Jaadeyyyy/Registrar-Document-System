Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ReceiptForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.pnlToolbar = New System.Windows.Forms.Panel()
            Me.btnClose = New System.Windows.Forms.Button()
            Me.btnPrint = New System.Windows.Forms.Button()
            Me.pnlReceipt = New System.Windows.Forms.Panel()
            Me.receiptBox = New System.Windows.Forms.RichTextBox()
            Me.pnlToolbar.SuspendLayout()
            Me.pnlReceipt.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlToolbar
            '
            Me.pnlToolbar.BackColor = System.Drawing.Color.White
            Me.pnlToolbar.Controls.Add(Me.btnClose)
            Me.pnlToolbar.Controls.Add(Me.btnPrint)
            Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlToolbar.Location = New System.Drawing.Point(0, 0)
            Me.pnlToolbar.Name = "pnlToolbar"
            Me.pnlToolbar.Padding = New System.Windows.Forms.Padding(16, 10, 16, 10)
            Me.pnlToolbar.Size = New System.Drawing.Size(600, 58)
            Me.pnlToolbar.TabIndex = 0
            '
            'btnClose
            '
            Me.btnClose.BackColor = System.Drawing.Color.White
            Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnClose.Location = New System.Drawing.Point(186, 10)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(100, 38)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "Close"
            Me.btnClose.UseVisualStyleBackColor = False
            '
            'btnPrint
            '
            Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnPrint.ForeColor = System.Drawing.Color.White
            Me.btnPrint.Location = New System.Drawing.Point(16, 10)
            Me.btnPrint.Name = "btnPrint"
            Me.btnPrint.Size = New System.Drawing.Size(160, 38)
            Me.btnPrint.TabIndex = 0
            Me.btnPrint.Text = "Print / Save PDF"
            Me.btnPrint.UseVisualStyleBackColor = False
            '
            'pnlReceipt
            '
            Me.pnlReceipt.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(232, Byte), Integer))
            Me.pnlReceipt.Controls.Add(Me.receiptBox)
            Me.pnlReceipt.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlReceipt.Location = New System.Drawing.Point(0, 58)
            Me.pnlReceipt.Name = "pnlReceipt"
            Me.pnlReceipt.Padding = New System.Windows.Forms.Padding(64, 18, 64, 28)
            Me.pnlReceipt.Size = New System.Drawing.Size(600, 662)
            Me.pnlReceipt.TabIndex = 1
            '
            'receiptBox
            '
            Me.receiptBox.BackColor = System.Drawing.Color.White
            Me.receiptBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.receiptBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.receiptBox.Font = New System.Drawing.Font("Consolas", 10.0!)
            Me.receiptBox.ForeColor = System.Drawing.Color.Black
            Me.receiptBox.Location = New System.Drawing.Point(64, 18)
            Me.receiptBox.Name = "receiptBox"
            Me.receiptBox.ReadOnly = True
            Me.receiptBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
            Me.receiptBox.Size = New System.Drawing.Size(472, 616)
            Me.receiptBox.TabIndex = 0
            Me.receiptBox.Text = ""
            Me.receiptBox.WordWrap = False
            '
            'ReceiptForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(600, 720)
            Me.Controls.Add(Me.pnlReceipt)
            Me.Controls.Add(Me.pnlToolbar)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.MinimumSize = New System.Drawing.Size(540, 600)
            Me.Name = "ReceiptForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Document Request Slip"
            Me.pnlToolbar.ResumeLayout(False)
            Me.pnlReceipt.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents pnlToolbar As System.Windows.Forms.Panel
        Friend WithEvents btnPrint As System.Windows.Forms.Button
        Friend WithEvents btnClose As System.Windows.Forms.Button
        Friend WithEvents pnlReceipt As System.Windows.Forms.Panel
        Friend WithEvents receiptBox As System.Windows.Forms.RichTextBox
    End Class
End Namespace
