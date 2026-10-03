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
            Dim dgvCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim dgvCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.lblSubtitle = New System.Windows.Forms.Label()
            Me.lblTitle = New System.Windows.Forms.Label()
            Me.txtSearchStudents = New System.Windows.Forms.TextBox()
            Me.cboStudentsStatus = New System.Windows.Forms.ComboBox()
            Me.btnAddStudent = New System.Windows.Forms.Button()
            Me.pnlTableCard = New System.Windows.Forms.Panel()
            Me.lblRecordCount = New System.Windows.Forms.Label()
            Me.btnToggleStudentStatus = New System.Windows.Forms.Button()
            Me.btnEditStudent = New System.Windows.Forms.Button()
            Me.lblCardTitle = New System.Windows.Forms.Label()
            Me.dgvStudents = New System.Windows.Forms.DataGridView()
            Me.colStudentID = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colLRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colLastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colMiddleName = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colCourse = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colYearLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colSection = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colContactNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.pnlHeader.SuspendLayout()
            Me.pnlTableCard.SuspendLayout()
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.lblSubtitle.Size = New System.Drawing.Size(273, 17)
            Me.lblSubtitle.TabIndex = 1
            Me.lblSubtitle.Text = "Manage student records and enrollment status."
            '
            'lblTitle
            '
            Me.lblTitle.AutoSize = True
            Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
            Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblTitle.Location = New System.Drawing.Point(-2, 0)
            Me.lblTitle.Name = "lblTitle"
            Me.lblTitle.Size = New System.Drawing.Size(129, 37)
            Me.lblTitle.TabIndex = 0
            Me.lblTitle.Text = "Students"
            '
            'txtSearchStudents
            '
            Me.txtSearchStudents.BackColor = System.Drawing.Color.White
            Me.txtSearchStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtSearchStudents.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtSearchStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
            Me.txtSearchStudents.Location = New System.Drawing.Point(24, 96)
            Me.txtSearchStudents.Name = "txtSearchStudents"
            Me.txtSearchStudents.Size = New System.Drawing.Size(320, 25)
            Me.txtSearchStudents.TabIndex = 1
            '
            'cboStudentsStatus
            '
            Me.cboStudentsStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboStudentsStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboStudentsStatus.FormattingEnabled = True
            Me.cboStudentsStatus.Items.AddRange(New Object() {"All Statuses", "Active", "Inactive"})
            Me.cboStudentsStatus.Location = New System.Drawing.Point(356, 96)
            Me.cboStudentsStatus.Name = "cboStudentsStatus"
            Me.cboStudentsStatus.Size = New System.Drawing.Size(160, 25)
            Me.cboStudentsStatus.TabIndex = 2
            '
            'btnAddStudent
            '
            Me.btnAddStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnAddStudent.FlatAppearance.BorderSize = 0
            Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnAddStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnAddStudent.ForeColor = System.Drawing.Color.White
            Me.btnAddStudent.Location = New System.Drawing.Point(776, 90)
            Me.btnAddStudent.Name = "btnAddStudent"
            Me.btnAddStudent.Size = New System.Drawing.Size(150, 36)
            Me.btnAddStudent.TabIndex = 3
            Me.btnAddStudent.Text = "+ Add Student"
            Me.btnAddStudent.UseVisualStyleBackColor = False
            '
            'pnlTableCard
            '
            Me.pnlTableCard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTableCard.BackColor = System.Drawing.Color.White
            Me.pnlTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlTableCard.Controls.Add(Me.lblRecordCount)
            Me.pnlTableCard.Controls.Add(Me.btnToggleStudentStatus)
            Me.pnlTableCard.Controls.Add(Me.btnEditStudent)
            Me.pnlTableCard.Controls.Add(Me.lblCardTitle)
            Me.pnlTableCard.Controls.Add(Me.dgvStudents)
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
            Me.lblRecordCount.Location = New System.Drawing.Point(340, 16)
            Me.lblRecordCount.Name = "lblRecordCount"
            Me.lblRecordCount.Size = New System.Drawing.Size(250, 24)
            Me.lblRecordCount.TabIndex = 1
            Me.lblRecordCount.Text = "Showing student records"
            Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'btnToggleStudentStatus
            '
            Me.btnToggleStudentStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnToggleStudentStatus.BackColor = System.Drawing.Color.White
            Me.btnToggleStudentStatus.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnToggleStudentStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleStudentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnToggleStudentStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnToggleStudentStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnToggleStudentStatus.Location = New System.Drawing.Point(725, 12)
            Me.btnToggleStudentStatus.Name = "btnToggleStudentStatus"
            Me.btnToggleStudentStatus.Size = New System.Drawing.Size(160, 32)
            Me.btnToggleStudentStatus.TabIndex = 3
            Me.btnToggleStudentStatus.Text = "Activate / Deactivate"
            Me.btnToggleStudentStatus.UseVisualStyleBackColor = False
            '
            'btnEditStudent
            '
            Me.btnEditStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnEditStudent.BackColor = System.Drawing.Color.White
            Me.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnEditStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnEditStudent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.btnEditStudent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnEditStudent.Location = New System.Drawing.Point(625, 12)
            Me.btnEditStudent.Name = "btnEditStudent"
            Me.btnEditStudent.Size = New System.Drawing.Size(90, 32)
            Me.btnEditStudent.TabIndex = 2
            Me.btnEditStudent.Text = "Edit"
            Me.btnEditStudent.UseVisualStyleBackColor = False
            '
            'lblCardTitle
            '
            Me.lblCardTitle.AutoSize = True
            Me.lblCardTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
            Me.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(68, Byte), Integer))
            Me.lblCardTitle.Location = New System.Drawing.Point(16, 16)
            Me.lblCardTitle.Name = "lblCardTitle"
            Me.lblCardTitle.Size = New System.Drawing.Size(131, 21)
            Me.lblCardTitle.TabIndex = 0
            Me.lblCardTitle.Text = "Student Records"
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
            Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dgvStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
            Me.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
            dgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
            dgvCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvStudents.ColumnHeadersDefaultCellStyle = dgvCellStyle1
            Me.dgvStudents.ColumnHeadersHeight = 40
            Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            Me.dgvStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colStudentID, Me.colLRN, Me.colLastName, Me.colFirstName, Me.colMiddleName, Me.colCourse, Me.colYearLevel, Me.colSection, Me.colContactNo, Me.colStatus})
            dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle2.BackColor = System.Drawing.Color.White
            dgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
            dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
            dgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
            dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.dgvStudents.DefaultCellStyle = dgvCellStyle2
            Me.dgvStudents.EnableHeadersVisualStyles = False
            Me.dgvStudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
            Me.dgvStudents.Location = New System.Drawing.Point(0, 56)
            Me.dgvStudents.MultiSelect = False
            Me.dgvStudents.Name = "dgvStudents"
            Me.dgvStudents.ReadOnly = True
            Me.dgvStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
            dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            dgvCellStyle3.BackColor = System.Drawing.Color.White
            dgvCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            dgvCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            dgvCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            dgvCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.dgvStudents.RowHeadersDefaultCellStyle = dgvCellStyle3
            Me.dgvStudents.RowHeadersVisible = False
            Me.dgvStudents.RowTemplate.Height = 36
            Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
            Me.dgvStudents.Size = New System.Drawing.Size(900, 422)
            Me.dgvStudents.TabIndex = 4
            '
            'colStudentID
            '
            Me.colStudentID.DataPropertyName = "StudentID"
            Me.colStudentID.FillWeight = 85.0!
            Me.colStudentID.HeaderText = "Student ID"
            Me.colStudentID.Name = "colStudentID"
            Me.colStudentID.ReadOnly = True
            '
            'colLRN
            '
            Me.colLRN.DataPropertyName = "LRN"
            Me.colLRN.FillWeight = 95.0!
            Me.colLRN.HeaderText = "LRN"
            Me.colLRN.Name = "colLRN"
            Me.colLRN.ReadOnly = True
            '
            'colLastName
            '
            Me.colLastName.DataPropertyName = "LastName"
            Me.colLastName.FillWeight = 100.0!
            Me.colLastName.HeaderText = "Last Name"
            Me.colLastName.Name = "colLastName"
            Me.colLastName.ReadOnly = True
            '
            'colFirstName
            '
            Me.colFirstName.DataPropertyName = "FirstName"
            Me.colFirstName.FillWeight = 100.0!
            Me.colFirstName.HeaderText = "First Name"
            Me.colFirstName.Name = "colFirstName"
            Me.colFirstName.ReadOnly = True
            '
            'colMiddleName
            '
            Me.colMiddleName.DataPropertyName = "MiddleName"
            Me.colMiddleName.FillWeight = 90.0!
            Me.colMiddleName.HeaderText = "Middle Name"
            Me.colMiddleName.Name = "colMiddleName"
            Me.colMiddleName.ReadOnly = True
            '
            'colCourse
            '
            Me.colCourse.DataPropertyName = "Course"
            Me.colCourse.FillWeight = 75.0!
            Me.colCourse.HeaderText = "Course"
            Me.colCourse.Name = "colCourse"
            Me.colCourse.ReadOnly = True
            '
            'colYearLevel
            '
            Me.colYearLevel.DataPropertyName = "YearLevel"
            Me.colYearLevel.FillWeight = 55.0!
            Me.colYearLevel.HeaderText = "Year"
            Me.colYearLevel.Name = "colYearLevel"
            Me.colYearLevel.ReadOnly = True
            '
            'colSection
            '
            Me.colSection.DataPropertyName = "Section"
            Me.colSection.FillWeight = 65.0!
            Me.colSection.HeaderText = "Section"
            Me.colSection.Name = "colSection"
            Me.colSection.ReadOnly = True
            '
            'colContactNo
            '
            Me.colContactNo.DataPropertyName = "ContactNo"
            Me.colContactNo.FillWeight = 95.0!
            Me.colContactNo.HeaderText = "Contact No"
            Me.colContactNo.Name = "colContactNo"
            Me.colContactNo.ReadOnly = True
            '
            'colStatus
            '
            Me.colStatus.DataPropertyName = "Status"
            Me.colStatus.FillWeight = 75.0!
            Me.colStatus.HeaderText = "Status"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.ReadOnly = True
            '
            'StudentsForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(950, 650)
            Me.Controls.Add(Me.pnlTableCard)
            Me.Controls.Add(Me.btnAddStudent)
            Me.Controls.Add(Me.cboStudentsStatus)
            Me.Controls.Add(Me.txtSearchStudents)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "StudentsForm"
            Me.Text = "Students"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlTableCard.ResumeLayout(False)
            Me.pnlTableCard.PerformLayout()
            CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents pnlHeader As System.Windows.Forms.Panel
        Friend WithEvents lblTitle As System.Windows.Forms.Label
        Friend WithEvents lblSubtitle As System.Windows.Forms.Label
        Friend WithEvents txtSearchStudents As System.Windows.Forms.TextBox
        Friend WithEvents cboStudentsStatus As System.Windows.Forms.ComboBox
        Friend WithEvents btnAddStudent As System.Windows.Forms.Button
        Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
        Friend WithEvents lblCardTitle As System.Windows.Forms.Label
        Friend WithEvents lblRecordCount As System.Windows.Forms.Label
        Friend WithEvents btnEditStudent As System.Windows.Forms.Button
        Friend WithEvents btnToggleStudentStatus As System.Windows.Forms.Button
        Friend WithEvents dgvStudents As System.Windows.Forms.DataGridView
        Friend WithEvents colStudentID As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colLRN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colLastName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colMiddleName As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colCourse As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colYearLevel As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colSection As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colContactNo As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace
