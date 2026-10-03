Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class StudentsForm
        Private ReadOnly mainForm As MainForm
        Private studentsActiveOnlyFilter As Boolean = False

        Public Sub New()
            InitializeComponent()
            cboStudentsStatus.SelectedIndex = 0
            AppTheme.SetPlaceholder(txtSearchStudents, "Search student ID, LRN, or name...")
        End Sub

        Public Sub New(parent As MainForm, Optional activeOnly As Boolean = False)
            Me.New()
            mainForm = parent
            studentsActiveOnlyFilter = activeOnly
            If activeOnly Then
                cboStudentsStatus.SelectedIndex = 1 ' Active
            End If
        End Sub

        Private Sub StudentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            RefreshStudentsData()
        End Sub

        Public Sub RefreshStudentsData()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim statusCondition As String = String.Empty
                If cboStudentsStatus.SelectedIndex = 1 Then
                    statusCondition = "AND Status = 'Active' "
                ElseIf cboStudentsStatus.SelectedIndex = 2 Then
                    statusCondition = "AND Status = 'Inactive' "
                ElseIf studentsActiveOnlyFilter Then
                    statusCondition = "AND Status = 'Active' "
                End If

                Dim query = "SELECT StudentID, LRN, LastName, FirstName, MiddleName, Course, YearLevel, Section, ContactNo, Status " &
                            "FROM tblstudents " &
                            "WHERE (StudentID LIKE @search OR LRN LIKE @search OR LastName LIKE @search OR FirstName LIKE @search OR MiddleName LIKE @search) " &
                            statusCondition &
                            "ORDER BY LastName, FirstName"

                Dim dt = Database.GetTable(query, New Dictionary(Of String, Object) From {{"@search", "%" & txtSearchStudents.Text.Trim() & "%"}})
                dgvStudents.DataSource = dt
                lblRecordCount.Text = $"{dt.Rows.Count} student records"
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchStudents_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudents.TextChanged
            RefreshStudentsData()
        End Sub

        Private Sub cboStudentsStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentsStatus.SelectedIndexChanged
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
            Dim studentId = dgvStudents.CurrentRow.Cells("colStudentID").Value.ToString()
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
            Dim studentId = dgvStudents.CurrentRow.Cells("colStudentID").Value.ToString()
            Dim currentStatus = dgvStudents.CurrentRow.Cells("colStatus").Value.ToString()
            Dim newStatus = If(currentStatus = "Active", "Inactive", "Active")
            If MessageBox.Show("Set student " & studentId & " to " & newStatus & "?",
                               "Confirm status", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Database.Execute("UPDATE tblstudents SET Status=@status WHERE StudentID=@id",
                             New Dictionary(Of String, Object) From {{"@status", newStatus}, {"@id", studentId}})
            RefreshStudentsData()
        End Sub

        Private Sub dgvStudents_DoubleClick(sender As Object, e As EventArgs) Handles dgvStudents.DoubleClick
            btnEditStudent.PerformClick()
        End Sub

        Private Sub dgvStudents_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvStudents.CellFormatting
            If e.RowIndex < 0 Then Return
            If dgvStudents.Columns(e.ColumnIndex).Name = "colStatus" AndAlso e.Value IsNot Nothing Then
                Dim val = e.Value.ToString()
                If val = "Active" Then
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52)
                    e.CellStyle.Font = New Font(dgvStudents.Font, FontStyle.Bold)
                Else
                    e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184)
                End If
            End If
        End Sub
    End Class
End Namespace
