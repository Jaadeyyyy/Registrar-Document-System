Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class StudentsForm
        Private ReadOnly mainForm As MainForm
        Private studentsActiveOnlyFilter As Boolean = False

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnAddStudent, False)
            AppTheme.StyleButton(btnEditStudent, True)
            AppTheme.StyleButton(btnToggleStudentStatus, True)
            AppTheme.StyleTextBox(txtSearchStudents)
            AppTheme.SetPlaceholder(txtSearchStudents, "Search student ID, LRN, or name")
            AppTheme.StyleGrid(dgvStudents)
        End Sub

        Public Sub New(parent As MainForm, Optional activeOnly As Boolean = False)
            Me.New()
            mainForm = parent
            studentsActiveOnlyFilter = activeOnly
        End Sub

        Private Sub StudentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            RefreshStudentsData()
        End Sub

        Public Sub RefreshStudentsData()
            Try
                dgvStudents.DataSource = Database.GetTable(
                    "SELECT StudentID, LRN, LastName, FirstName, MiddleName, Course, " &
                    "YearLevel, Section, ContactNo, Status " &
                    "FROM tblstudents " &
                    "WHERE CONCAT_WS(' ',StudentID,LRN,LastName,FirstName,MiddleName) LIKE @search " &
                    If(studentsActiveOnlyFilter, "AND Status='Active' ", String.Empty) &
                    "ORDER BY LastName, FirstName",
                    New Dictionary(Of String, Object) From {{"@search", "%" & txtSearchStudents.Text.Trim() & "%"}})
                AppTheme.FitGridToRows(dgvStudents)
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchStudents_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudents.TextChanged
            RefreshStudentsData()
        End Sub

        Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
            Using dialog As New StudentEditForm()
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshStudentsData()
                End If
            End Using
        End Sub

        Private Sub btnEditStudent_Click(sender As Object, e As EventArgs) Handles btnEditStudent.Click
            If dgvStudents.CurrentRow Is Nothing Then
                MessageBox.Show("Select a student first.", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim studentId = dgvStudents.CurrentRow.Cells("StudentID").Value.ToString()
            Using dialog As New StudentEditForm(studentId)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshStudentsData()
                End If
            End Using
        End Sub

        Private Sub btnToggleStudentStatus_Click(sender As Object, e As EventArgs) Handles btnToggleStudentStatus.Click
            If dgvStudents.CurrentRow Is Nothing Then
                MessageBox.Show("Select a student first.", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim studentId = dgvStudents.CurrentRow.Cells("StudentID").Value.ToString()
            Dim currentStatus = dgvStudents.CurrentRow.Cells("Status").Value.ToString()
            Dim newStatus = If(currentStatus = AppTheme.ActiveStatus, AppTheme.InactiveStatus, AppTheme.ActiveStatus)
            If MessageBox.Show("Set student " & studentId & " to " & newStatus & "?",
                               "Confirm status", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Database.Execute("UPDATE tblstudents SET Status=@status WHERE StudentID=@id",
                             New Dictionary(Of String, Object) From {{"@status", newStatus}, {"@id", studentId}})
            RefreshStudentsData()
        End Sub

        Private Sub dgvStudents_DoubleClick(sender As Object, e As EventArgs) Handles dgvStudents.DoubleClick
            btnEditStudent.PerformClick()
        End Sub
    End Class
End Namespace
