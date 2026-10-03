Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StudentsForm
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
            Me.dgvStudents = New System.Windows.Forms.DataGridView()
            Me.btnToggleStudentStatus = New System.Windows.Forms.Button()
            Me.btnEditStudent = New System.Windows.Forms.Button()
            Me.btnAddStudent = New System.Windows.Forms.Button()
            Me.txtSearchStudents = New System.Windows.Forms.TextBox()
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dgvStudents
            '
            Me.dgvStudents.AllowUserToAddRows = False
            Me.dgvStudents.AllowUserToDeleteRows = False
            Me.dgvStudents.AllowUserToResizeRows = False
            Me.dgvStudents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
            Me.dgvStudents.ColumnHeadersHeight = 38
            Me.dgvStudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.dgvStudents.Location = New System.Drawing.Point(0, 50)
            Me.dgvStudents.MultiSelect = False
            Me.dgvStudents.Name = "dgvStudents"
            Me.dgvStudents.ReadOnly = True
            Me.dgvStudents.RowHeadersVisible = False
            Me.dgvStudents.RowTemplate.Height = 34
            Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvStudents.Size = New System.Drawing.Size(1085, 472)
            Me.dgvStudents.TabIndex = 4
            '
            'btnToggleStudentStatus
            '
            Me.btnToggleStudentStatus.BackColor = System.Drawing.Color.White
            Me.btnToggleStudentStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToggleStudentStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleStudentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToggleStudentStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnToggleStudentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleStudentStatus.Location = New System.Drawing.Point(600, 1)
            Me.btnToggleStudentStatus.Name = "btnToggleStudentStatus"
            Me.btnToggleStudentStatus.Size = New System.Drawing.Size(180, 38)
            Me.btnToggleStudentStatus.TabIndex = 3
            Me.btnToggleStudentStatus.Text = "Activate / Deactivate"
            Me.btnToggleStudentStatus.UseVisualStyleBackColor = False
            '
            'btnEditStudent
            '
            Me.btnEditStudent.BackColor = System.Drawing.Color.White
            Me.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnEditStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditStudent.Location = New System.Drawing.Point(485, 1)
            Me.btnEditStudent.Name = "btnEditStudent"
            Me.btnEditStudent.Size = New System.Drawing.Size(105, 38)
            Me.btnEditStudent.TabIndex = 2
            Me.btnEditStudent.Text = "Edit"
            Me.btnEditStudent.UseVisualStyleBackColor = False
            '
            'btnAddStudent
            '
            Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddStudent.ForeColor = System.Drawing.Color.White
            Me.btnAddStudent.Location = New System.Drawing.Point(325, 1)
            Me.btnAddStudent.Name = "btnAddStudent"
            Me.btnAddStudent.Size = New System.Drawing.Size(150, 38)
            Me.btnAddStudent.TabIndex = 1
            Me.btnAddStudent.Text = "Add Student"
            Me.btnAddStudent.UseVisualStyleBackColor = False
            '
            'txtSearchStudents
            '
            Me.txtSearchStudents.Location = New System.Drawing.Point(0, 4)
            Me.txtSearchStudents.Name = "txtSearchStudents"
            Me.txtSearchStudents.Size = New System.Drawing.Size(310, 24)
            Me.txtSearchStudents.TabIndex = 0
            '
            'StudentsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1085, 522)
            Me.Controls.Add(Me.dgvStudents)
            Me.Controls.Add(Me.btnToggleStudentStatus)
            Me.Controls.Add(Me.btnEditStudent)
            Me.Controls.Add(Me.btnAddStudent)
            Me.Controls.Add(Me.txtSearchStudents)
            Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "StudentsForm"
            Me.Text = "Students"
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
        Friend WithEvents btnToggleStudentStatus As System.Windows.Forms.Button
        Friend WithEvents btnEditStudent As System.Windows.Forms.Button
        Friend WithEvents btnAddStudent As System.Windows.Forms.Button
        Friend WithEvents txtSearchStudents As System.Windows.Forms.TextBox
    End Class
End Namespace
