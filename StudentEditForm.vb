Imports System.Data
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class StudentEditForm
        Private ReadOnly originalStudentId As String
        Private ReadOnly isEditing As Boolean

        Public Sub New(Optional studentId As String = Nothing)
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnSave, False)
            AppTheme.StyleButton(btnCancel, True)

            For Each txt In {txtStudentID, txtLRN, txtLastName, txtFirstName, txtMiddleName, txtContactNo}
                AppTheme.StyleTextBox(txt)
            Next
            For Each cbo In {cboCourse, cboYearLevel, cboSection}
                AppTheme.StyleComboBox(cbo)
            Next

            originalStudentId = studentId
            isEditing = Not String.IsNullOrWhiteSpace(studentId)
            Text = If(isEditing, "Edit Student", "Add Student")

            If isEditing Then
                txtStudentID.ReadOnly = True
                LoadStudentData()
            Else
                cboYearLevel.SelectedIndex = 0
                PopulateSectionChoices("1")
                If cboSection.Items.Count > 0 Then cboSection.SelectedIndex = 0
            End If
        End Sub

        Private Sub LoadStudentData()
            Dim table = Database.GetTable("SELECT * FROM tblstudents WHERE StudentID=@id",
                                          New Dictionary(Of String, Object) From {{"@id", originalStudentId}})
            If table.Rows.Count = 0 Then Return
            Dim row = table.Rows(0)
            txtStudentID.Text = row("StudentID").ToString()
            txtLRN.Text = row("LRN").ToString()
            txtLastName.Text = row("LastName").ToString()
            txtFirstName.Text = row("FirstName").ToString()
            txtMiddleName.Text = row("MiddleName").ToString()
            cboCourse.Text = row("Course").ToString()
            cboYearLevel.Text = row("YearLevel").ToString()
            PopulateSectionChoices(cboYearLevel.Text)
            cboSection.Text = row("Section").ToString()
            txtContactNo.Text = row("ContactNo").ToString()
        End Sub

        Private Sub cboYearLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYearLevel.SelectedIndexChanged
            Dim previousSection = cboSection.Text
            PopulateSectionChoices(cboYearLevel.Text)
            If cboSection.Items.Contains(previousSection) Then
                cboSection.Text = previousSection
            ElseIf cboSection.Items.Count > 0 Then
                cboSection.SelectedIndex = 0
            End If
        End Sub

        Private Sub PopulateSectionChoices(yearLevel As String)
            cboSection.Items.Clear()
            Dim level = If(yearLevel = "1" OrElse yearLevel = "2" OrElse yearLevel = "3" OrElse yearLevel = "4", yearLevel, "1")
            For Each semester As String In {"1", "2"}
                For Each schedule As String In {"E", "M", "A"}
                    For sectionNumber = 1 To 3
                        cboSection.Items.Add(level & semester & schedule & sectionNumber.ToString())
                    Next
                Next
            Next
        End Sub

        Private Sub ClearErrors()
            For Each lbl In {lblStudentIDError, lblLRNError, lblLastNameError, lblFirstNameError,
                             lblMiddleNameError, lblCourseError, lblYearLevelError, lblSectionError, lblContactNoError}
                lbl.Text = String.Empty
            Next
        End Sub

        Private Function ValidateInput() As Boolean
            ClearErrors()
            Dim valid = True

            If Not Regex.IsMatch(txtStudentID.Text.Trim(), "^\d{4}-\d{2}$") Then
                lblStudentIDError.Text = "Use the format 1724-24."
                valid = False
            End If
            If Not Regex.IsMatch(txtLRN.Text.Trim(), "^\d{12}$") Then
                lblLRNError.Text = "LRN must contain exactly 12 digits."
                valid = False
            End If
            If String.IsNullOrWhiteSpace(txtLastName.Text) Then
                lblLastNameError.Text = "Last name is required."
                valid = False
            End If
            If String.IsNullOrWhiteSpace(txtFirstName.Text) Then
                lblFirstNameError.Text = "First name is required."
                valid = False
            End If
            If String.IsNullOrWhiteSpace(cboCourse.Text) Then
                lblCourseError.Text = "Course is required."
                valid = False
            End If
            If Not Regex.IsMatch(cboYearLevel.Text.Trim(), "^[1-4]$") Then
                lblYearLevelError.Text = "Enter a year level from 1 to 4."
                valid = False
            End If
            If Not Regex.IsMatch(cboSection.Text.Trim(), "^[1-4][1-2][EeMmAa]\d{1,2}$") Then
                lblSectionError.Text = "Choose a valid section, such as 31A1."
                valid = False
            End If
            If Not Regex.IsMatch(txtContactNo.Text.Trim(), "^\d{11}$") Then
                lblContactNoError.Text = "Contact number must contain exactly 11 digits."
                valid = False
            End If
            Return valid
        End Function

        Private Function NullIfBlank(value As String) As Object
            If String.IsNullOrWhiteSpace(value) Then Return DBNull.Value
            Return value.Trim()
        End Function

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            If Not ValidateInput() Then Return
            Dim studentDisplayName = txtFirstName.Text.Trim() & " " & txtLastName.Text.Trim()
            If MessageBox.Show("Are you sure you want to save " & studentDisplayName &
                               " (" & txtStudentID.Text.Trim() & ")?", "Confirm student save",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                Dim parameters = New Dictionary(Of String, Object) From {
                    {"@studentId", txtStudentID.Text.Trim()},
                    {"@lrn", NullIfBlank(txtLRN.Text)},
                    {"@lastName", txtLastName.Text.Trim()},
                    {"@firstName", txtFirstName.Text.Trim()},
                    {"@middleName", NullIfBlank(txtMiddleName.Text)},
                    {"@course", NullIfBlank(cboCourse.Text)},
                    {"@yearLevel", NullIfBlank(cboYearLevel.Text)},
                    {"@section", cboSection.Text.Trim().ToUpperInvariant()},
                    {"@contact", NullIfBlank(txtContactNo.Text)}
                }
                If isEditing Then
                    parameters.Add("@originalId", originalStudentId)
                    Database.Execute(
                        "UPDATE tblstudents SET LRN=@lrn, LastName=@lastName, FirstName=@firstName, " &
                        "MiddleName=@middleName, Course=@course, YearLevel=@yearLevel, " &
                        "Section=@section, ContactNo=@contact WHERE StudentID=@originalId", parameters)
                Else
                    Dim exists = Convert.ToInt32(Database.Scalar(
                        "SELECT COUNT(*) FROM tblstudents WHERE StudentID=@studentId", parameters)) > 0
                    If exists Then
                        lblStudentIDError.Text = "That Student ID already exists."
                        Return
                    End If
                    Database.Execute(
                        "INSERT INTO tblstudents " &
                        "(StudentID,LRN,LastName,FirstName,MiddleName,Course,YearLevel,Section,ContactNo,Status) " &
                        "VALUES (@studentId,@lrn,@lastName,@firstName,@middleName,@course,@yearLevel,@section,@contact,'Active')",
                        parameters)
                End If
                DialogResult = DialogResult.OK
                Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Could not save student", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub

        Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles _
            txtStudentID.TextChanged, txtLRN.TextChanged, txtLastName.TextChanged,
            txtFirstName.TextChanged, txtMiddleName.TextChanged, cboCourse.SelectedIndexChanged,
            cboSection.SelectedIndexChanged, txtContactNo.TextChanged
            ' Clear corresponding error
            If sender Is txtStudentID Then lblStudentIDError.Text = String.Empty
            If sender Is txtLRN Then lblLRNError.Text = String.Empty
            If sender Is txtLastName Then lblLastNameError.Text = String.Empty
            If sender Is txtFirstName Then lblFirstNameError.Text = String.Empty
            If sender Is txtMiddleName Then lblMiddleNameError.Text = String.Empty
            If sender Is cboCourse Then lblCourseError.Text = String.Empty
            If sender Is cboSection Then lblSectionError.Text = String.Empty
            If sender Is txtContactNo Then lblContactNoError.Text = String.Empty
        End Sub
    End Class
End Namespace
