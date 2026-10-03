Imports System.Data
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace RegistrarDocumentRequestSystem
    Partial Public Class NewRequestForm
        Private ReadOnly mainForm As MainForm
        Private ReadOnly currentUserId As Integer
        Private ReadOnly requestItems As New DataTable()
        Private selectedStudentId As String = String.Empty
        Private isSelectingStudent As Boolean = False

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleTextBox(txtSearchStudent)
            AppTheme.SetPlaceholder(txtSearchStudent, "Search student ID, LRN, or name")
            AppTheme.StyleTextBox(txtPurpose)
            AppTheme.SetPlaceholder(txtPurpose, "Purpose (example: Scholarship or school requirement)")
            AppTheme.StyleComboBox(cboDocument)
            AppTheme.StyleButton(btnAddItem, False)
            AppTheme.StyleButton(btnRemoveItem, True)
            AppTheme.StyleButton(btnSaveRequest, False)
            AppTheme.StyleGrid(dgvRequestItems)
            PrepareRequestItems()
            dgvRequestItems.AutoGenerateColumns = False
            dgvRequestItems.DataSource = requestItems
        End Sub

        Public Sub New(parent As MainForm, userId As Integer)
            Me.New()
            mainForm = parent
            currentUserId = userId
        End Sub

        Private Sub NewRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadNewRequestInitialData()
        End Sub

        Private Sub PrepareRequestItems()
            requestItems.Clear()
            requestItems.Columns.Clear()
            requestItems.Columns.Add("DocumentID", GetType(Integer))
            requestItems.Columns.Add("Document", GetType(String))
            requestItems.Columns.Add("Fee", GetType(Decimal))
            requestItems.Columns.Add("Quantity", GetType(Integer))
            requestItems.Columns.Add("Subtotal", GetType(Decimal))
        End Sub

        Public Sub LoadNewRequestInitialData()
            Try
                isSelectingStudent = True
                selectedStudentId = String.Empty
                txtSearchStudent.Text = String.Empty
                isSelectingStudent = False
                lstStudentResults.Visible = False
                lblStudentInfo.Text = String.Empty
                lblStudentError.Text = String.Empty
                txtPurpose.Text = String.Empty
                PrepareRequestItems()
                UpdateTotal()

                cboDocument.DataSource = Database.GetTable(
                    "SELECT DocumentID, DocumentName, Fee FROM tbldocuments WHERE Status='Active' ORDER BY DocumentName")
                cboDocument.DisplayMember = "DocumentName"
                cboDocument.ValueMember = "DocumentID"
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchStudent_TextChanged(sender As Object, e As EventArgs) Handles txtSearchStudent.TextChanged
            If isSelectingStudent Then Return

            selectedStudentId = String.Empty
            lblStudentInfo.Text = String.Empty
            lblStudentError.Text = String.Empty

            Dim query = txtSearchStudent.Text.Trim()
            If query.Length < 1 Then
                lstStudentResults.Visible = False
                Return
            End If

            Try
                Dim dt = Database.GetTable(
                    "SELECT StudentID, " &
                    "CONCAT(LastName, ', ', FirstName, ' (', StudentID, ') - ', Course, ' ', YearLevel, Section) AS DisplayText, " &
                    "CONCAT(LastName, ', ', FirstName, ' (', StudentID, ')') AS ShortDisplay, " &
                    "Course, YearLevel, Section " &
                    "FROM tblstudents " &
                    "WHERE Status='Active' AND (" &
                    "StudentID LIKE @q OR LRN LIKE @q OR LastName LIKE @q OR FirstName LIKE @q OR " &
                    "CONCAT(FirstName, ' ', LastName) LIKE @q OR CONCAT(LastName, ' ', FirstName) LIKE @q) " &
                    "ORDER BY LastName, FirstName LIMIT 15",
                    New Dictionary(Of String, Object) From {{"@q", "%" & query & "%"}})

                If dt.Rows.Count > 0 Then
                    lstStudentResults.DataSource = dt
                    lstStudentResults.DisplayMember = "DisplayText"
                    lstStudentResults.ValueMember = "StudentID"
                    lstStudentResults.Visible = True
                    lstStudentResults.BringToFront()
                Else
                    lstStudentResults.DataSource = Nothing
                    lstStudentResults.Visible = False
                    lblStudentInfo.Text = "No active student found."
                    lblStudentInfo.ForeColor = AppTheme.DangerColor
                End If
            Catch ex As Exception
                lstStudentResults.Visible = False
            End Try
        End Sub

        Private Sub SelectStudentFromList()
            If lstStudentResults.SelectedItem IsNot Nothing AndAlso TypeOf lstStudentResults.SelectedItem Is DataRowView Then
                Dim row = DirectCast(lstStudentResults.SelectedItem, DataRowView)
                selectedStudentId = row("StudentID").ToString()
                lblStudentInfo.Text = row("Course").ToString() & " • Year " &
                                     row("YearLevel").ToString() & " • " &
                                     row("Section").ToString()
                lblStudentInfo.ForeColor = AppTheme.AccentColor
                lblStudentError.Text = String.Empty

                isSelectingStudent = True
                txtSearchStudent.Text = row("ShortDisplay").ToString()
                isSelectingStudent = False

                lstStudentResults.Visible = False
                txtPurpose.Focus()
            End If
        End Sub

        Private Sub lstStudentResults_Click(sender As Object, e As EventArgs) Handles lstStudentResults.Click
            SelectStudentFromList()
        End Sub

        Private Sub lstStudentResults_KeyDown(sender As Object, e As KeyEventArgs) Handles lstStudentResults.KeyDown
            If e.KeyCode = Keys.Enter Then
                SelectStudentFromList()
                e.Handled = True
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Escape Then
                lstStudentResults.Visible = False
                txtSearchStudent.Focus()
                e.Handled = True
            End If
        End Sub

        Private Sub txtSearchStudent_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchStudent.KeyDown
            If e.KeyCode = Keys.Down AndAlso lstStudentResults.Visible AndAlso lstStudentResults.Items.Count > 0 Then
                lstStudentResults.Focus()
                lstStudentResults.SelectedIndex = 0
                e.Handled = True
            ElseIf e.KeyCode = Keys.Enter Then
                If lstStudentResults.Visible AndAlso lstStudentResults.Items.Count > 0 Then
                    lstStudentResults.SelectedIndex = 0
                    SelectStudentFromList()
                End If
                e.Handled = True
                e.SuppressKeyPress = True
            ElseIf e.KeyCode = Keys.Escape Then
                lstStudentResults.Visible = False
                e.Handled = True
            End If
        End Sub

        Private Sub Controls_HideSuggestions(sender As Object, e As EventArgs) Handles _
            txtPurpose.GotFocus, cboDocument.GotFocus, nudQuantity.GotFocus, btnAddItem.GotFocus, dgvRequestItems.GotFocus
            lstStudentResults.Visible = False
        End Sub

        Private Sub txtPurpose_TextChanged(sender As Object, e As EventArgs) Handles txtPurpose.TextChanged
            lblPurposeError.Text = String.Empty
        End Sub

        Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
            If cboDocument.SelectedItem Is Nothing Then Return
            Dim selected = DirectCast(cboDocument.SelectedItem, DataRowView)
            Dim documentId = Convert.ToInt32(selected("DocumentID"))
            Dim fee = Convert.ToDecimal(selected("Fee"))
            Dim itemQuantity = Convert.ToInt32(nudQuantity.Value)
            Dim existing = requestItems.Select("DocumentID=" & documentId.ToString())
            If existing.Length > 0 Then
                existing(0)("Quantity") = Convert.ToInt32(existing(0)("Quantity")) + itemQuantity
                existing(0)("Subtotal") = Convert.ToDecimal(existing(0)("Fee")) * Convert.ToInt32(existing(0)("Quantity"))
            Else
                requestItems.Rows.Add(documentId, selected("DocumentName").ToString(), fee,
                                      itemQuantity, fee * itemQuantity)
            End If
            lblItemError.Text = String.Empty
            UpdateTotal()
        End Sub

        Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
            If dgvRequestItems.CurrentRow Is Nothing Then Return
            requestItems.Rows.RemoveAt(dgvRequestItems.CurrentRow.Index)
            UpdateTotal()
        End Sub

        Private Sub UpdateTotal()
            Dim total As Decimal = 0D
            For Each row As DataRow In requestItems.Rows
                total += Convert.ToDecimal(row("Subtotal"))
            Next
            lblTotalAmount.Text = "Total Amount: " & total.ToString("N2")
            AppTheme.FitGridToRows(dgvRequestItems, 245)
            lblTotalAmount.Top = dgvRequestItems.Bottom + 16
            btnSaveRequest.Top = lblTotalAmount.Bottom + 14
        End Sub

        Private Sub btnSaveRequest_Click(sender As Object, e As EventArgs) Handles btnSaveRequest.Click
            lblStudentError.Text = String.Empty
            lblPurposeError.Text = String.Empty
            lblItemError.Text = String.Empty
            Dim valid = True
            If String.IsNullOrWhiteSpace(selectedStudentId) Then
                lblStudentError.Text = "Please search and select an active student."
                valid = False
            End If
            If String.IsNullOrWhiteSpace(txtPurpose.Text) Then
                lblPurposeError.Text = "Purpose is required."
                valid = False
            End If
            If requestItems.Rows.Count = 0 Then
                lblItemError.Text = "Add at least one document."
                valid = False
            End If
            If valid Then SaveRequest(txtPurpose.Text.Trim())
        End Sub

        Private Sub SaveRequest(purpose As String)
            Dim total As Decimal = 0D
            For Each row As DataRow In requestItems.Rows
                total += Convert.ToDecimal(row("Subtotal"))
            Next

            Using connection = Database.GetConnection()
                connection.Open()
                Using transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted)
                    Try
                        Dim requestNumber As String
                        Dim requestId As Integer
                        Using command As New MySqlCommand() With {.Connection = connection, .Transaction = transaction}
                            requestNumber = GenerateRequestNumber(command)
                            command.Parameters.Clear()
                            command.CommandText =
                                "INSERT INTO tblrequest " &
                                "(RequestNo,StudentID,RequestDate,Purpose,TotalAmount,PaymentStatus,Status,CreatedBy) " &
                                "VALUES (@number,@studentId,CURDATE(),@purpose,@total,'Unpaid','Pending',@createdBy)"
                            Database.AddParameters(command, New Dictionary(Of String, Object) From {
                                {"@number", requestNumber}, {"@studentId", selectedStudentId},
                                {"@purpose", purpose}, {"@total", total}, {"@createdBy", currentUserId}
                            })
                            command.ExecuteNonQuery()
                            requestId = Convert.ToInt32(command.LastInsertedId)

                            For Each item As DataRow In requestItems.Rows
                                command.Parameters.Clear()
                                command.CommandText =
                                    "INSERT INTO tblrequestdetails " &
                                    "(RequestID,DocumentID,Quantity,Amount,SubTotal) " &
                                    "VALUES (@requestId,@documentId,@quantity,@amount,@subtotal)"
                                Database.AddParameters(command, New Dictionary(Of String, Object) From {
                                    {"@requestId", requestId}, {"@documentId", item("DocumentID")},
                                    {"@quantity", item("Quantity")}, {"@amount", item("Fee")},
                                    {"@subtotal", item("Subtotal")}
                                })
                                command.ExecuteNonQuery()
                            Next
                        End Using
                        transaction.Commit()
                        Using receipt As New ReceiptForm(requestId)
                            receipt.ShowDialog(Me)
                        End Using
                        If mainForm IsNot Nothing Then
                            mainForm.ShowRequests(requestNumber)
                        End If
                    Catch ex As Exception
                        Try
                            transaction.Rollback()
                        Catch
                        End Try
                        MessageBox.Show(ex.Message, "Could not save request", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End Sub

        Private Function GenerateRequestNumber(command As MySqlCommand) As String
            Dim requestYear = Date.Today.Year
            command.Parameters.Clear()
            command.CommandText =
                "INSERT IGNORE INTO tblrequestsequence(RequestYear,LastNumber) VALUES(@year,0)"
            command.Parameters.AddWithValue("@year", requestYear)
            command.ExecuteNonQuery()

            command.CommandText =
                "UPDATE tblrequestsequence " &
                "SET LastNumber=LAST_INSERT_ID(LastNumber+1) WHERE RequestYear=@year"
            command.ExecuteNonQuery()

            command.Parameters.Clear()
            command.CommandText = "SELECT LAST_INSERT_ID()"
            Dim nextNumber = Convert.ToInt32(command.ExecuteScalar())
            Return "REQ-" & requestYear.ToString() & "-" & nextNumber.ToString("D5")
        End Function
    End Class
End Namespace
