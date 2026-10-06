Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace RegistrarDocumentRequestSystem
    Partial Public Class NewRequestForm
        Private ReadOnly mainForm As MainForm
        Private selectedStudentId As String = String.Empty
        Private documentsTable As DataTable
        Private ReadOnly requestItems As New DataTable()

        Public Sub New()
            InitializeComponent()
            InitializeItemsTable()
            AppTheme.SetPlaceholder(txtSearchStudent, "Type student ID, LRN, or name to search...")
            AppTheme.SetPlaceholder(txtPurpose, "Enter purpose (e.g., Employment, Scholarship, Transfer)...")
        End Sub

        Public Sub New(parent As MainForm)
            Me.New()
            mainForm = parent
        End Sub

        Private Sub InitializeItemsTable()
            requestItems.Columns.Clear()
            requestItems.Columns.Add("DocumentID", GetType(Integer))
            requestItems.Columns.Add("DocumentName", GetType(String))
            requestItems.Columns.Add("Fee", GetType(Decimal))
            requestItems.Columns.Add("Quantity", GetType(Integer))
            requestItems.Columns.Add("Subtotal", GetType(Decimal))
            dgvRequestItems.DataSource = requestItems
        End Sub

        Private Sub NewRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            LoadDocuments()
        End Sub

        Private Sub LoadDocuments()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                documentsTable = Database.GetTable("SELECT DocumentID, DocumentName, Fee FROM tbldocuments WHERE Status='Active' ORDER BY DocumentName")
                cboDocument.DataSource = documentsTable
                cboDocument.DisplayMember = "DocumentName"
                cboDocument.ValueMember = "DocumentID"
                UpdateUnitFee()
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchStudent_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudent.TextChanged
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Dim search = txtSearchStudent.Text.Trim()
            If search.Length < 1 Then
                cboStudentSearchResults.DataSource = Nothing
                Return
            End If

            Try
                Dim dt = Database.GetTable(
                    "SELECT StudentID, LRN, LastName, FirstName, Course, YearLevel, Section " &
                    "FROM tblstudents " &
                    "WHERE Status='Active' AND (StudentID LIKE @s OR LRN LIKE @s OR LastName LIKE @s OR FirstName LIKE @s) " &
                    "ORDER BY LastName, FirstName LIMIT 15",
                    New Dictionary(Of String, Object) From {{"@s", "%" & search & "%"}})

                dt.Columns.Add("DisplayText", GetType(String))
                For Each row As DataRow In dt.Rows
                    row("DisplayText") = $"{row("StudentID")} - {row("LastName")}, {row("FirstName")} ({row("Course")} {row("YearLevel")}-{row("Section")})"
                Next

                cboStudentSearchResults.DataSource = dt
                cboStudentSearchResults.DisplayMember = "DisplayText"
                cboStudentSearchResults.ValueMember = "StudentID"

                If dt.Rows.Count > 0 Then
                    cboStudentSearchResults.SelectedIndex = 0
                    SelectStudent(dt.Rows(0))
                Else
                    ClearSelectedStudent()
                End If
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub cboStudentSearchResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentSearchResults.SelectedIndexChanged
            If cboStudentSearchResults.SelectedItem IsNot Nothing AndAlso TypeOf cboStudentSearchResults.SelectedItem Is DataRowView Then
                Dim row = DirectCast(cboStudentSearchResults.SelectedItem, DataRowView).Row
                SelectStudent(row)
            End If
        End Sub

        Private Sub SelectStudent(row As DataRow)
            selectedStudentId = row("StudentID").ToString()
            lblStudentIdVal.Text = "Student ID: " & selectedStudentId
            lblStudentNameVal.Text = "Name: " & $"{row("FirstName")} {row("LastName")}"
            lblStudentCourseVal.Text = "Course: " & row("Course").ToString()
            lblStudentYearSectionVal.Text = "Year & Section: " & $"{row("YearLevel")} - {row("Section")}"
        End Sub

        Private Sub ClearSelectedStudent()
            selectedStudentId = String.Empty
            lblStudentIdVal.Text = "Student ID: None selected"
            lblStudentNameVal.Text = "Name: -"
            lblStudentCourseVal.Text = "Course: -"
            lblStudentYearSectionVal.Text = "Year & Section: -"
        End Sub

        Private Sub cboDocument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocument.SelectedIndexChanged
            UpdateUnitFee()
        End Sub

        Private Sub UpdateUnitFee()
            If cboDocument.SelectedItem IsNot Nothing AndAlso TypeOf cboDocument.SelectedItem Is DataRowView Then
                Dim row = DirectCast(cboDocument.SelectedItem, DataRowView).Row
                Dim fee = Convert.ToDecimal(row("Fee"))
                lblUnitFee.Text = "Fee: ₱" & fee.ToString("N2")
            Else
                lblUnitFee.Text = "Fee: ₱0.00"
            End If
        End Sub

        Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
            If cboDocument.SelectedItem Is Nothing Then
                MessageBox.Show("Please select a document.", "New Request", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim row = DirectCast(cboDocument.SelectedItem, DataRowView).Row
            Dim docId = Convert.ToInt32(row("DocumentID"))
            Dim docName = row("DocumentName").ToString()
            Dim fee = Convert.ToDecimal(row("Fee"))
            Dim qty = Convert.ToInt32(numQuantity.Value)

            For Each r As DataRow In requestItems.Rows
                If Convert.ToInt32(r("DocumentID")) = docId Then
                    r("Quantity") = Convert.ToInt32(r("Quantity")) + qty
                    r("Subtotal") = Convert.ToDecimal(r("Quantity")) * fee
                    CalculateTotal()
                    numQuantity.Value = 1
                    Return
                End If
            Next

            requestItems.Rows.Add(docId, docName, fee, qty, fee * qty)
            CalculateTotal()
            numQuantity.Value = 1
        End Sub

        Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
            If dgvRequestItems.CurrentRow Is Nothing Then
                MessageBox.Show("Select an item to remove.", "New Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim index = dgvRequestItems.CurrentRow.Index
            requestItems.Rows.RemoveAt(index)
            CalculateTotal()
        End Sub

        Private Sub CalculateTotal()
            Dim total As Decimal = 0
            For Each r As DataRow In requestItems.Rows
                total += Convert.ToDecimal(r("Subtotal"))
            Next
            lblTotalAmount.Text = "₱" & total.ToString("N2")
        End Sub

        Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
            ResetForm()
        End Sub

        Private Sub ResetForm()
            txtSearchStudent.Clear()
            cboStudentSearchResults.DataSource = Nothing
            ClearSelectedStudent()
            txtPurpose.Clear()
            requestItems.Rows.Clear()
            numQuantity.Value = 1
            CalculateTotal()
        End Sub

        Private Sub btnSaveRequest_Click(sender As Object, e As EventArgs) Handles btnSaveRequest.Click
            If String.IsNullOrEmpty(selectedStudentId) Then
                MessageBox.Show("Please select an active student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSearchStudent.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(txtPurpose.Text) Then
                MessageBox.Show("Please enter the purpose of request.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPurpose.Focus()
                Return
            End If

            If requestItems.Rows.Count = 0 Then
                MessageBox.Show("Please add at least one document to the request.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim total As Decimal = 0
            For Each r As DataRow In requestItems.Rows
                total += Convert.ToDecimal(r("Subtotal"))
            Next

            Dim requestNo = GenerateRequestNumber()
            Dim userId = If(mainForm IsNot Nothing, mainForm.CurrentUserID, 1)

            Using conn = Database.GetConnection()
                conn.Open()
                Using trans = conn.BeginTransaction()
                    Try
                        Dim insertReq = "INSERT INTO tblrequest (RequestNo, StudentID, RequestDate, Purpose, TotalAmount, PaymentStatus, Status, CreatedBy) " &
                                        "VALUES (@no, @sid, NOW(), @purp, @total, 'Unpaid', 'Pending', @uid);"
                        Using cmd As New MySqlCommand(insertReq, conn, trans)
                            cmd.Parameters.AddWithValue("@no", requestNo)
                            cmd.Parameters.AddWithValue("@sid", selectedStudentId)
                            cmd.Parameters.AddWithValue("@purp", txtPurpose.Text.Trim())
                            cmd.Parameters.AddWithValue("@total", total)
                            cmd.Parameters.AddWithValue("@uid", userId)
                            cmd.ExecuteNonQuery()
                        End Using

                        Dim requestId As Long
                        Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID();", conn, trans)
                            requestId = Convert.ToInt64(cmd.ExecuteScalar())
                        End Using

                        Dim insertItem = "INSERT INTO tblrequestdetails (RequestID, DocumentID, Quantity, Amount, SubTotal) " &
                                         "VALUES (@rid, @did, @qty, @price, @subtotal);"
                        For Each r As DataRow In requestItems.Rows
                            Using cmd As New MySqlCommand(insertItem, conn, trans)
                                cmd.Parameters.AddWithValue("@rid", requestId)
                                cmd.Parameters.AddWithValue("@did", r("DocumentID"))
                                cmd.Parameters.AddWithValue("@qty", r("Quantity"))
                                cmd.Parameters.AddWithValue("@price", r("Fee"))
                                cmd.Parameters.AddWithValue("@subtotal", r("Subtotal"))
                                cmd.ExecuteNonQuery()
                            End Using
                        Next

                        trans.Commit()

                        MessageBox.Show($"Request {requestNo} has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        If MessageBox.Show("Would you like to print or view the request slip / receipt now?", "Print Slip", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Using rec As New ReceiptForm(requestNo)
                                rec.ShowDialog(Me)
                            End Using
                        End If

                        ResetForm()
                    Catch ex As Exception
                        trans.Rollback()
                        MessageBox.Show("Failed to save request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End Sub

        Private Function GenerateRequestNumber() As String
            Dim year = DateTime.Now.Year.ToString()
            Dim prefix = "REQ-" & year & "-"
            Try
                Dim result = Database.Scalar("SELECT RequestNo FROM tblrequest WHERE RequestNo LIKE @p ORDER BY RequestID DESC LIMIT 1",
                                             New Dictionary(Of String, Object) From {{"@p", prefix & "%"}})
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Dim lastNo = result.ToString()
                    Dim parts = lastNo.Split("-"c)
                    If parts.Length = 3 Then
                        Dim num As Integer
                        If Integer.TryParse(parts(2), num) Then
                            Return prefix & (num + 1).ToString("D4")
                        End If
                    End If
                End If
            Catch ex As Exception
                ' Fallback
            End Try
            Return prefix & "0001"
        End Function

        Private Sub dgvRequestItems_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRequestItems.CellFormatting
            If e.RowIndex < 0 Then Return
            If (dgvRequestItems.Columns(e.ColumnIndex).Name = "colItemFee" OrElse dgvRequestItems.Columns(e.ColumnIndex).Name = "colItemSubtotal") AndAlso e.Value IsNot Nothing Then
                Dim val As Decimal
                If Decimal.TryParse(e.Value.ToString(), val) Then
                    e.Value = val.ToString("N2")
                    e.FormattingApplied = True
                End If
            End If
        End Sub

        Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

        End Sub
    End Class
End Namespace
