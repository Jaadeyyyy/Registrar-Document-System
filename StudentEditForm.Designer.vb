Namespace RegistrarDocumentRequestSystem
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class StudentEditForm
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
            Me.lblStudentID = New System.Windows.Forms.Label()
            Me.txtStudentID = New System.Windows.Forms.TextBox()
            Me.lblStudentIDError = New System.Windows.Forms.Label()
            Me.lblLRN = New System.Windows.Forms.Label()
            Me.txtLRN = New System.Windows.Forms.TextBox()
            Me.lblLRNError = New System.Windows.Forms.Label()
            Me.lblLastName = New System.Windows.Forms.Label()
            Me.txtLastName = New System.Windows.Forms.TextBox()
            Me.lblLastNameError = New System.Windows.Forms.Label()
            Me.lblFirstName = New System.Windows.Forms.Label()
            Me.txtFirstName = New System.Windows.Forms.TextBox()
            Me.lblFirstNameError = New System.Windows.Forms.Label()
            Me.lblMiddleName = New System.Windows.Forms.Label()
            Me.txtMiddleName = New System.Windows.Forms.TextBox()
            Me.lblMiddleNameError = New System.Windows.Forms.Label()
            Me.lblCourse = New System.Windows.Forms.Label()
            Me.cboCourse = New System.Windows.Forms.ComboBox()
            Me.lblCourseError = New System.Windows.Forms.Label()
            Me.lblYearLevel = New System.Windows.Forms.Label()
            Me.cboYearLevel = New System.Windows.Forms.ComboBox()
            Me.lblYearLevelError = New System.Windows.Forms.Label()
            Me.lblSection = New System.Windows.Forms.Label()
            Me.cboSection = New System.Windows.Forms.ComboBox()
            Me.lblSectionError = New System.Windows.Forms.Label()
            Me.lblContactNo = New System.Windows.Forms.Label()
            Me.txtContactNo = New System.Windows.Forms.TextBox()
            Me.lblContactNoError = New System.Windows.Forms.Label()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'lblStudentID
            '
            Me.lblStudentID.AutoSize = True
            Me.lblStudentID.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblStudentID.Location = New System.Drawing.Point(24, 25)
            Me.lblStudentID.Name = "lblStudentID"
            Me.lblStudentID.Size = New System.Drawing.Size(73, 17)
            Me.lblStudentID.TabIndex = 0
            Me.lblStudentID.Text = "Student ID"
            '
            'txtStudentID
            '
            Me.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtStudentID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtStudentID.Location = New System.Drawing.Point(175, 16)
            Me.txtStudentID.MaxLength = 7
            Me.txtStudentID.Name = "txtStudentID"
            Me.txtStudentID.Size = New System.Drawing.Size(310, 25)
            Me.txtStudentID.TabIndex = 1
            '
            'lblStudentIDError
            '
            Me.lblStudentIDError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblStudentIDError.Location = New System.Drawing.Point(175, 42)
            Me.lblStudentIDError.Name = "lblStudentIDError"
            Me.lblStudentIDError.Size = New System.Drawing.Size(310, 17)
            Me.lblStudentIDError.TabIndex = 2
            '
            'lblLRN
            '
            Me.lblLRN.AutoSize = True
            Me.lblLRN.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblLRN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblLRN.Location = New System.Drawing.Point(24, 83)
            Me.lblLRN.Name = "lblLRN"
            Me.lblLRN.Size = New System.Drawing.Size(34, 17)
            Me.lblLRN.TabIndex = 3
            Me.lblLRN.Text = "LRN"
            '
            'txtLRN
            '
            Me.txtLRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtLRN.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtLRN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtLRN.Location = New System.Drawing.Point(175, 74)
            Me.txtLRN.MaxLength = 12
            Me.txtLRN.Name = "txtLRN"
            Me.txtLRN.Size = New System.Drawing.Size(310, 25)
            Me.txtLRN.TabIndex = 4
            '
            'lblLRNError
            '
            Me.lblLRNError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblLRNError.Location = New System.Drawing.Point(175, 100)
            Me.lblLRNError.Name = "lblLRNError"
            Me.lblLRNError.Size = New System.Drawing.Size(310, 17)
            Me.lblLRNError.TabIndex = 5
            '
            'lblLastName
            '
            Me.lblLastName.AutoSize = True
            Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblLastName.Location = New System.Drawing.Point(24, 141)
            Me.lblLastName.Name = "lblLastName"
            Me.lblLastName.Size = New System.Drawing.Size(73, 17)
            Me.lblLastName.TabIndex = 6
            Me.lblLastName.Text = "Last Name"
            '
            'txtLastName
            '
            Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtLastName.Location = New System.Drawing.Point(175, 132)
            Me.txtLastName.Name = "txtLastName"
            Me.txtLastName.Size = New System.Drawing.Size(310, 25)
            Me.txtLastName.TabIndex = 7
            '
            'lblLastNameError
            '
            Me.lblLastNameError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblLastNameError.Location = New System.Drawing.Point(175, 158)
            Me.lblLastNameError.Name = "lblLastNameError"
            Me.lblLastNameError.Size = New System.Drawing.Size(310, 17)
            Me.lblLastNameError.TabIndex = 8
            '
            'lblFirstName
            '
            Me.lblFirstName.AutoSize = True
            Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblFirstName.Location = New System.Drawing.Point(24, 199)
            Me.lblFirstName.Name = "lblFirstName"
            Me.lblFirstName.Size = New System.Drawing.Size(75, 17)
            Me.lblFirstName.TabIndex = 9
            Me.lblFirstName.Text = "First Name"
            '
            'txtFirstName
            '
            Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtFirstName.Location = New System.Drawing.Point(175, 190)
            Me.txtFirstName.Name = "txtFirstName"
            Me.txtFirstName.Size = New System.Drawing.Size(310, 25)
            Me.txtFirstName.TabIndex = 10
            '
            'lblFirstNameError
            '
            Me.lblFirstNameError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblFirstNameError.Location = New System.Drawing.Point(175, 216)
            Me.lblFirstNameError.Name = "lblFirstNameError"
            Me.lblFirstNameError.Size = New System.Drawing.Size(310, 17)
            Me.lblFirstNameError.TabIndex = 11
            '
            'lblMiddleName
            '
            Me.lblMiddleName.AutoSize = True
            Me.lblMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblMiddleName.Location = New System.Drawing.Point(24, 257)
            Me.lblMiddleName.Name = "lblMiddleName"
            Me.lblMiddleName.Size = New System.Drawing.Size(91, 17)
            Me.lblMiddleName.TabIndex = 12
            Me.lblMiddleName.Text = "Middle Name"
            '
            'txtMiddleName
            '
            Me.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtMiddleName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtMiddleName.Location = New System.Drawing.Point(175, 248)
            Me.txtMiddleName.Name = "txtMiddleName"
            Me.txtMiddleName.Size = New System.Drawing.Size(310, 25)
            Me.txtMiddleName.TabIndex = 13
            '
            'lblMiddleNameError
            '
            Me.lblMiddleNameError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblMiddleNameError.Location = New System.Drawing.Point(175, 274)
            Me.lblMiddleNameError.Name = "lblMiddleNameError"
            Me.lblMiddleNameError.Size = New System.Drawing.Size(310, 17)
            Me.lblMiddleNameError.TabIndex = 14
            '
            'lblCourse
            '
            Me.lblCourse.AutoSize = True
            Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblCourse.Location = New System.Drawing.Point(24, 315)
            Me.lblCourse.Name = "lblCourse"
            Me.lblCourse.Size = New System.Drawing.Size(51, 17)
            Me.lblCourse.TabIndex = 15
            Me.lblCourse.Text = "Course"
            '
            'cboCourse
            '
            Me.cboCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboCourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.cboCourse.FormattingEnabled = True
            Me.cboCourse.Items.AddRange(New Object() {"BS Information Technology", "BS Business Administration", "BS Education", "BS Accountancy"})
            Me.cboCourse.Location = New System.Drawing.Point(175, 306)
            Me.cboCourse.Name = "cboCourse"
            Me.cboCourse.Size = New System.Drawing.Size(310, 25)
            Me.cboCourse.TabIndex = 16
            '
            'lblCourseError
            '
            Me.lblCourseError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblCourseError.Location = New System.Drawing.Point(175, 332)
            Me.lblCourseError.Name = "lblCourseError"
            Me.lblCourseError.Size = New System.Drawing.Size(310, 17)
            Me.lblCourseError.TabIndex = 17
            '
            'lblYearLevel
            '
            Me.lblYearLevel.AutoSize = True
            Me.lblYearLevel.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblYearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblYearLevel.Location = New System.Drawing.Point(24, 373)
            Me.lblYearLevel.Name = "lblYearLevel"
            Me.lblYearLevel.Size = New System.Drawing.Size(69, 17)
            Me.lblYearLevel.TabIndex = 18
            Me.lblYearLevel.Text = "Year Level"
            '
            'cboYearLevel
            '
            Me.cboYearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboYearLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboYearLevel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboYearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.cboYearLevel.FormattingEnabled = True
            Me.cboYearLevel.Items.AddRange(New Object() {"1", "2", "3", "4"})
            Me.cboYearLevel.Location = New System.Drawing.Point(175, 364)
            Me.cboYearLevel.Name = "cboYearLevel"
            Me.cboYearLevel.Size = New System.Drawing.Size(310, 25)
            Me.cboYearLevel.TabIndex = 19
            '
            'lblYearLevelError
            '
            Me.lblYearLevelError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblYearLevelError.Location = New System.Drawing.Point(175, 390)
            Me.lblYearLevelError.Name = "lblYearLevelError"
            Me.lblYearLevelError.Size = New System.Drawing.Size(310, 17)
            Me.lblYearLevelError.TabIndex = 20
            '
            'lblSection
            '
            Me.lblSection.AutoSize = True
            Me.lblSection.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblSection.Location = New System.Drawing.Point(24, 431)
            Me.lblSection.Name = "lblSection"
            Me.lblSection.Size = New System.Drawing.Size(53, 17)
            Me.lblSection.TabIndex = 21
            Me.lblSection.Text = "Section"
            '
            'cboSection
            '
            Me.cboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.cboSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.cboSection.FormattingEnabled = True
            Me.cboSection.Location = New System.Drawing.Point(175, 422)
            Me.cboSection.Name = "cboSection"
            Me.cboSection.Size = New System.Drawing.Size(310, 25)
            Me.cboSection.TabIndex = 22
            '
            'lblSectionError
            '
            Me.lblSectionError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblSectionError.Location = New System.Drawing.Point(175, 448)
            Me.lblSectionError.Name = "lblSectionError"
            Me.lblSectionError.Size = New System.Drawing.Size(310, 17)
            Me.lblSectionError.TabIndex = 23
            '
            'lblContactNo
            '
            Me.lblContactNo.AutoSize = True
            Me.lblContactNo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.lblContactNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblContactNo.Location = New System.Drawing.Point(24, 489)
            Me.lblContactNo.Name = "lblContactNo"
            Me.lblContactNo.Size = New System.Drawing.Size(109, 17)
            Me.lblContactNo.TabIndex = 24
            Me.lblContactNo.Text = "Contact Number"
            '
            'txtContactNo
            '
            Me.txtContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtContactNo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
            Me.txtContactNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.txtContactNo.Location = New System.Drawing.Point(175, 480)
            Me.txtContactNo.MaxLength = 11
            Me.txtContactNo.Name = "txtContactNo"
            Me.txtContactNo.Size = New System.Drawing.Size(310, 25)
            Me.txtContactNo.TabIndex = 25
            '
            'lblContactNoError
            '
            Me.lblContactNoError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
            Me.lblContactNoError.Location = New System.Drawing.Point(175, 506)
            Me.lblContactNoError.Name = "lblContactNoError"
            Me.lblContactNoError.Size = New System.Drawing.Size(310, 17)
            Me.lblContactNoError.TabIndex = 26
            '
            'btnSave
            '
            Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(112, Byte), Integer))
            Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            Me.btnSave.ForeColor = System.Drawing.Color.White
            Me.btnSave.Location = New System.Drawing.Point(175, 592)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(170, 38)
            Me.btnSave.TabIndex = 27
            Me.btnSave.Text = "Save Student"
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
            Me.btnCancel.Location = New System.Drawing.Point(355, 592)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(130, 38)
            Me.btnCancel.TabIndex = 28
            Me.btnCancel.Text = "Cancel"
            Me.btnCancel.UseVisualStyleBackColor = False
            '
            'StudentEditForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(520, 655)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.lblContactNoError)
            Me.Controls.Add(Me.txtContactNo)
            Me.Controls.Add(Me.lblContactNo)
            Me.Controls.Add(Me.lblSectionError)
            Me.Controls.Add(Me.cboSection)
            Me.Controls.Add(Me.lblSection)
            Me.Controls.Add(Me.lblYearLevelError)
            Me.Controls.Add(Me.cboYearLevel)
            Me.Controls.Add(Me.lblYearLevel)
            Me.Controls.Add(Me.lblCourseError)
            Me.Controls.Add(Me.cboCourse)
            Me.Controls.Add(Me.lblCourse)
            Me.Controls.Add(Me.lblMiddleNameError)
            Me.Controls.Add(Me.txtMiddleName)
            Me.Controls.Add(Me.lblMiddleName)
            Me.Controls.Add(Me.lblFirstNameError)
            Me.Controls.Add(Me.txtFirstName)
            Me.Controls.Add(Me.lblFirstName)
            Me.Controls.Add(Me.lblLastNameError)
            Me.Controls.Add(Me.txtLastName)
            Me.Controls.Add(Me.lblLastName)
            Me.Controls.Add(Me.lblLRNError)
            Me.Controls.Add(Me.txtLRN)
            Me.Controls.Add(Me.lblLRN)
            Me.Controls.Add(Me.lblStudentIDError)
            Me.Controls.Add(Me.txtStudentID)
            Me.Controls.Add(Me.lblStudentID)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.Font = New System.Drawing.Font("Segoe UI", 9.5!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.Name = "StudentEditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Student Details"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblStudentID As System.Windows.Forms.Label
        Friend WithEvents txtStudentID As System.Windows.Forms.TextBox
        Friend WithEvents lblStudentIDError As System.Windows.Forms.Label
        Friend WithEvents lblLRN As System.Windows.Forms.Label
        Friend WithEvents txtLRN As System.Windows.Forms.TextBox
        Friend WithEvents lblLRNError As System.Windows.Forms.Label
        Friend WithEvents lblLastName As System.Windows.Forms.Label
        Friend WithEvents txtLastName As System.Windows.Forms.TextBox
        Friend WithEvents lblLastNameError As System.Windows.Forms.Label
        Friend WithEvents lblFirstName As System.Windows.Forms.Label
        Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
        Friend WithEvents lblFirstNameError As System.Windows.Forms.Label
        Friend WithEvents lblMiddleName As System.Windows.Forms.Label
        Friend WithEvents txtMiddleName As System.Windows.Forms.TextBox
        Friend WithEvents lblMiddleNameError As System.Windows.Forms.Label
        Friend WithEvents lblCourse As System.Windows.Forms.Label
        Friend WithEvents cboCourse As System.Windows.Forms.ComboBox
        Friend WithEvents lblCourseError As System.Windows.Forms.Label
        Friend WithEvents lblYearLevel As System.Windows.Forms.Label
        Friend WithEvents cboYearLevel As System.Windows.Forms.ComboBox
        Friend WithEvents lblYearLevelError As System.Windows.Forms.Label
        Friend WithEvents lblSection As System.Windows.Forms.Label
        Friend WithEvents cboSection As System.Windows.Forms.ComboBox
        Friend WithEvents lblSectionError As System.Windows.Forms.Label
        Friend WithEvents lblContactNo As System.Windows.Forms.Label
        Friend WithEvents txtContactNo As System.Windows.Forms.TextBox
        Friend WithEvents lblContactNoError As System.Windows.Forms.Label
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class
End Namespace
