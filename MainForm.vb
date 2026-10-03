Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Namespace RegistrarDocumentRequestSystem
    Partial Public Class MainForm
        Private ReadOnly currentUserId As Integer
        Private ReadOnly currentUserName As String
        Private ReadOnly currentRole As String
        Private activeNavButton As Button

        ' View states
        Private ReadOnly requestItems As New DataTable()
        Private selectedStudentId As String = String.Empty
        Private studentsActiveOnlyFilter As Boolean = False
        Private activeDashboardFilter As String = String.Empty

        Public Sub New(userId As Integer, fullName As String, role As String)
            currentUserId = userId
            currentUserName = fullName
            currentRole = role

            InitializeComponent()
            AppTheme.ApplyForm(Me)

            lblAccount.Text = currentUserName & "  •  " & currentRole
            lblOffice.Text = "OFFICE OF THE" & Environment.NewLine & "REGISTRAR"

            If Not AppTheme.IsAdministrator(currentRole) Then
                btnNavUsers.Visible = False
                btnAddDocument.Visible = False
                btnEditDocument.Visible = False
                btnToggleDocumentStatus.Visible = False
            End If

            ' Initialize controls styling and defaults
            AppTheme.StyleGrid(dgvRecentRequests)

            ' Students panel
            AppTheme.StyleButton(btnAddStudent, False)
            AppTheme.StyleButton(btnEditStudent, True)
            AppTheme.StyleButton(btnToggleStudentStatus, True)
            AppTheme.StyleTextBox(txtSearchStudents)
            AppTheme.SetPlaceholder(txtSearchStudents, "Search student ID, LRN, or name")
            AppTheme.StyleGrid(dgvStudents)

            ' Documents panel
            AppTheme.StyleButton(btnAddDocument, False)
            AppTheme.StyleButton(btnEditDocument, True)
            AppTheme.StyleButton(btnToggleDocumentStatus, True)
            AppTheme.StyleButton(btnViewSlipDocument, True)
            AppTheme.StyleTextBox(txtSearchDocuments)
            AppTheme.SetPlaceholder(txtSearchDocuments, "Search document name")
            AppTheme.StyleGrid(dgvDocuments)
            AppTheme.StyleGrid(dgvRecentSlips)

            ' New Request panel
            AppTheme.StyleComboBox(cboStudent)
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

            ' Requests panel
            AppTheme.StyleButton(btnViewDetails, True)
            AppTheme.StyleButton(btnUpdateStatus, False)
            AppTheme.StyleButton(btnViewSlipRequest, True)
            AppTheme.StyleTextBox(txtSearchRequests)
            AppTheme.SetPlaceholder(txtSearchRequests, "Search request number, student ID, or name")
            AppTheme.StyleGrid(dgvRequests)

            ' Reports panel
            AppTheme.StyleComboBox(cboReportType)
            AppTheme.StyleButton(btnGenerateReport, False)
            AppTheme.StyleGrid(dgvReports)
            If cboReportType.Items.Count > 0 Then cboReportType.SelectedIndex = 0
            dtpFromDate.Value = New Date(Date.Today.Year, 1, 1)
            dtpToDate.Value = Date.Today

            ' Users panel
            AppTheme.StyleButton(btnAddUser, False)
            AppTheme.StyleButton(btnEditUser, True)
            AppTheme.StyleButton(btnToggleUserStatus, True)
            AppTheme.StyleTextBox(txtSearchUsers)
            AppTheme.SetPlaceholder(txtSearchUsers, "Search username or person name")
            AppTheme.StyleGrid(dgvUsers)

            ShowDashboard()
            dashboardTimer.Start()
        End Sub

        Private Sub SetPageHeader(title As String, Optional subtitle As String = "")
            lblPageTitle.Text = title
            lblPageSubtitle.Text = subtitle
            Dim hasSubtitle = Not String.IsNullOrWhiteSpace(subtitle)
            lblPageSubtitle.Visible = hasSubtitle
            pnlHeading.Height = If(hasSubtitle, 92, 72)
            lblPageTitle.Top = If(hasSubtitle, 19, 21)
            pnlPageMarker.Top = If(hasSubtitle, 20, 15)
            pnlPageMarker.Height = If(hasSubtitle, 52, 42)
        End Sub

        Private Sub SetActiveNavButton(button As Button)
            If activeNavButton IsNot Nothing Then
                activeNavButton.BackColor = AppTheme.SurfaceColor
                activeNavButton.ForeColor = If(activeNavButton Is btnNavSignOut, AppTheme.DangerColor, AppTheme.PrimaryColor)
            End If
            activeNavButton = button
            If button IsNot Nothing Then
                button.BackColor = AppTheme.AccentTintColor
                button.ForeColor = AppTheme.PrimaryColor
            End If
        End Sub

        Private Sub SwitchView(activePanel As Panel, navButton As Button, title As String, subtitle As String)
            SetActiveNavButton(navButton)
            SetPageHeader(title, subtitle)

            pnlContent.SuspendLayout()
            pnlDashboard.Visible = (activePanel Is pnlDashboard)
            pnlStudents.Visible = (activePanel Is pnlStudents)
            pnlDocuments.Visible = (activePanel Is pnlDocuments)
            pnlNewRequest.Visible = (activePanel Is pnlNewRequest)
            pnlRequests.Visible = (activePanel Is pnlRequests)
            pnlReports.Visible = (activePanel Is pnlReports)
            pnlUsers.Visible = (activePanel Is pnlUsers)
            activePanel.BringToFront()
            pnlContent.ResumeLayout(True)
        End Sub

        ' =====================================================================
        ' 1. DASHBOARD
        ' =====================================================================
        Public Sub ShowDashboard()
            SwitchView(pnlDashboard, btnNavDashboard, "Dashboard", "Good day, " & currentUserName & ". Here is the current registrar activity.")
            LoadDashboard()
        End Sub

        Public Sub LoadDashboard()
            Try
                Dim stats = Database.GetTable(
                    "SELECT " &
                    "(SELECT COUNT(*) FROM tblstudents WHERE Status='Active') AS ActiveStudents, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE Status IN ('Pending','Processing')) AS InProgress, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE Status='Ready for Release') AS Ready, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE PaymentStatus='Unpaid' AND Status<>'Cancelled') AS Unpaid, " &
                    "(SELECT COUNT(*) FROM tblrequest WHERE Status='Pending') AS Backlog")

                If stats.Rows.Count > 0 Then
                    Dim row = stats.Rows(0)
                    lblActiveStudentsValue.Text = row("ActiveStudents").ToString()
                    lblInProgressValue.Text = row("InProgress").ToString()
                    lblReadyValue.Text = row("Ready").ToString()
                    lblUnpaidValue.Text = row("Unpaid").ToString()
                    lblBacklogValue.Text = row("Backlog").ToString()
                End If

                dgvRecentRequests.DataSource = Database.GetTable(
                    "SELECT r.RequestNo, r.RequestDate, " &
                    "CONCAT(s.LastName, ', ', s.FirstName) AS Student, " &
                    "r.TotalAmount, r.PaymentStatus, r.Status " &
                    "FROM tblrequest r INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                    "ORDER BY r.RequestID DESC LIMIT 8")
                If dgvRecentRequests.Columns.Contains("TotalAmount") Then
                    dgvRecentRequests.Columns("TotalAmount").DefaultCellStyle.Format = "N2"
                End If
                AppTheme.FitGridToRows(dgvRecentRequests, 330)
            Catch ex As Exception
                ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub Card_MouseEnter(sender As Object, e As EventArgs) Handles _
            pnlActiveStudents.MouseEnter, pnlInProgress.MouseEnter, pnlReady.MouseEnter, pnlUnpaid.MouseEnter, pnlBacklog.MouseEnter
            DirectCast(sender, Panel).BackColor = AppTheme.AccentTintColor
        End Sub

        Private Sub Card_MouseLeave(sender As Object, e As EventArgs) Handles _
            pnlActiveStudents.MouseLeave, pnlInProgress.MouseLeave, pnlReady.MouseLeave, pnlUnpaid.MouseLeave, pnlBacklog.MouseLeave
            DirectCast(sender, Panel).BackColor = Color.White
        End Sub

        Private Sub ActiveStudents_Click(sender As Object, e As EventArgs) Handles _
            pnlActiveStudents.Click, lblActiveStudentsValue.Click, lblActiveStudentsLabel.Click
            ShowStudents(True)
        End Sub

        Private Sub InProgress_Click(sender As Object, e As EventArgs) Handles _
            pnlInProgress.Click, lblInProgressValue.Click, lblInProgressLabel.Click
            ShowRequests(String.Empty, "InProgress")
        End Sub

        Private Sub Ready_Click(sender As Object, e As EventArgs) Handles _
            pnlReady.Click, lblReadyValue.Click, lblReadyLabel.Click
            ShowRequests(String.Empty, "Ready")
        End Sub

        Private Sub Unpaid_Click(sender As Object, e As EventArgs) Handles _
            pnlUnpaid.Click, lblUnpaidValue.Click, lblUnpaidLabel.Click
            ShowRequests(String.Empty, "Unpaid")
        End Sub

        Private Sub Backlog_Click(sender As Object, e As EventArgs) Handles _
            pnlBacklog.Click, lblBacklogValue.Click, lblBacklogLabel.Click
            ShowRequests(String.Empty, "Backlog")
        End Sub

        Private Sub dashboardTimer_Tick(sender As Object, e As EventArgs) Handles dashboardTimer.Tick
            If pnlDashboard.Visible Then
                LoadDashboard()
            End If
        End Sub

        ' =====================================================================
        ' 2. STUDENTS
        ' =====================================================================
        Public Sub ShowStudents(Optional activeOnly As Boolean = False)
            studentsActiveOnlyFilter = activeOnly
            Dim subtitle = If(activeOnly, "Showing active students from the dashboard.", String.Empty)
            SwitchView(pnlStudents, btnNavStudents, "Student Management", subtitle)
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
                ShowDatabaseError(ex)
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

        ' =====================================================================
        ' 3. DOCUMENTS
        ' =====================================================================
        Public Sub ShowDocuments()
            SwitchView(pnlDocuments, btnNavDocuments, "Document Management", String.Empty)
            RefreshDocumentsData()
            RefreshRecentSlips()
        End Sub

        Public Sub RefreshDocumentsData()
            Try
                dgvDocuments.DataSource = Database.GetTable(
                    "SELECT DocumentID, DocumentName, Description, Fee, Status FROM tbldocuments " &
                    "WHERE CONCAT_WS(' ',DocumentName,Description) LIKE @search ORDER BY DocumentName",
                    New Dictionary(Of String, Object) From {{"@search", "%" & txtSearchDocuments.Text.Trim() & "%"}})
                If dgvDocuments.Columns.Contains("DocumentID") Then dgvDocuments.Columns("DocumentID").Visible = False
                If dgvDocuments.Columns.Contains("Fee") Then dgvDocuments.Columns("Fee").DefaultCellStyle.Format = "N2"
                AppTheme.FitGridToRows(dgvDocuments, 220)
            Catch ex As Exception
                ShowDatabaseError(ex)
            End Try
        End Sub

        Public Sub RefreshRecentSlips()
            Try
                dgvRecentSlips.DataSource = Database.GetTable(
                    "SELECT r.RequestID, r.RequestNo, r.RequestDate, " &
                    "CONCAT(s.LastName, ', ', s.FirstName) AS Student, " &
                    "r.TotalAmount, r.PaymentStatus, r.Status " &
                    "FROM tblrequest r INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                    "ORDER BY r.RequestID DESC LIMIT 6")
                If dgvRecentSlips.Columns.Contains("RequestID") Then dgvRecentSlips.Columns("RequestID").Visible = False
                If dgvRecentSlips.Columns.Contains("TotalAmount") Then dgvRecentSlips.Columns("TotalAmount").DefaultCellStyle.Format = "N2"
                AppTheme.FitGridToRows(dgvRecentSlips, 215)
            Catch ex As Exception
                ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchDocuments_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDocuments.TextChanged
            RefreshDocumentsData()
        End Sub

        Private Sub btnAddDocument_Click(sender As Object, e As EventArgs) Handles btnAddDocument.Click
            Using dialog As New DocumentEditForm()
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshDocumentsData()
                End If
            End Using
        End Sub

        Private Sub btnEditDocument_Click(sender As Object, e As EventArgs) Handles btnEditDocument.Click
            If dgvDocuments.CurrentRow Is Nothing Then
                MessageBox.Show("Select a document first.", "Document", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvDocuments.CurrentRow.Cells("DocumentID").Value)
            Using dialog As New DocumentEditForm(id)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshDocumentsData()
                End If
            End Using
        End Sub

        Private Sub btnToggleDocumentStatus_Click(sender As Object, e As EventArgs) Handles btnToggleDocumentStatus.Click
            If dgvDocuments.CurrentRow Is Nothing Then
                MessageBox.Show("Select a document first.", "Document", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvDocuments.CurrentRow.Cells("DocumentID").Value)
            Dim currentStatus = dgvDocuments.CurrentRow.Cells("Status").Value.ToString()
            Dim newStatus = If(currentStatus = AppTheme.ActiveStatus, AppTheme.InactiveStatus, AppTheme.ActiveStatus)
            If MessageBox.Show("Set this document to " & newStatus & "?",
                               "Confirm status", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Database.Execute("UPDATE tbldocuments SET Status=@status WHERE DocumentID=@id",
                             New Dictionary(Of String, Object) From {{"@status", newStatus}, {"@id", id}})
            RefreshDocumentsData()
        End Sub

        Private Sub dgvDocuments_DoubleClick(sender As Object, e As EventArgs) Handles dgvDocuments.DoubleClick
            If AppTheme.IsAdministrator(currentRole) Then
                btnEditDocument.PerformClick()
            End If
        End Sub

        Private Sub btnViewSlipDocument_Click(sender As Object, e As EventArgs) Handles btnViewSlipDocument.Click
            If dgvRecentSlips.CurrentRow Is Nothing Then
                MessageBox.Show("Select a request first.", "Slip", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvRecentSlips.CurrentRow.Cells("RequestID").Value)
            Using receipt As New ReceiptForm(id)
                receipt.ShowDialog(Me)
            End Using
        End Sub

        Private Sub dgvRecentSlips_DoubleClick(sender As Object, e As EventArgs) Handles dgvRecentSlips.DoubleClick
            btnViewSlipDocument.PerformClick()
        End Sub

        ' =====================================================================
        ' 4. NEW REQUEST
        ' =====================================================================
        Public Sub ShowNewRequest()
            SwitchView(pnlNewRequest, btnNavNewRequest, "New Document Request", "Select an active student and add one or more document types.")
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
                selectedStudentId = String.Empty
                lblStudentInfo.Text = String.Empty
                txtPurpose.Text = String.Empty
                PrepareRequestItems()
                UpdateTotal()

                Dim studentTable = Database.GetTable(
                    "SELECT StudentID, CONCAT(LastName, ', ', FirstName, ' (', StudentID, ')') AS DisplayText, " &
                    "Course, YearLevel, Section FROM tblstudents WHERE Status='Active' ORDER BY LastName, FirstName")
                cboStudent.DataSource = studentTable
                cboStudent.DisplayMember = "DisplayText"
                cboStudent.ValueMember = "StudentID"
                cboStudent.SelectedIndex = -1
                cboStudent.Text = String.Empty

                cboDocument.DataSource = Database.GetTable(
                    "SELECT DocumentID, DocumentName, Fee FROM tbldocuments WHERE Status='Active' ORDER BY DocumentName")
                cboDocument.DisplayMember = "DocumentName"
                cboDocument.ValueMember = "DocumentID"
            Catch ex As Exception
                ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub cboStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudent.SelectedIndexChanged
            If cboStudent.SelectedItem IsNot Nothing AndAlso TypeOf cboStudent.SelectedItem Is DataRowView Then
                Dim selected = DirectCast(cboStudent.SelectedItem, DataRowView)
                selectedStudentId = selected("StudentID").ToString()
                lblStudentInfo.Text = selected("Course").ToString() & " • Year " &
                                     selected("YearLevel").ToString() & " • " &
                                     selected("Section").ToString()
                lblStudentInfo.ForeColor = AppTheme.AccentColor
                lblStudentError.Text = String.Empty
            End If
        End Sub

        Private Sub cboStudent_TextUpdate(sender As Object, e As EventArgs) Handles cboStudent.TextUpdate
            If cboStudent.SelectedIndex < 0 Then
                selectedStudentId = String.Empty
                lblStudentInfo.Text = "Choose a name from the suggestions."
                lblStudentInfo.ForeColor = AppTheme.MutedTextColor
            End If
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
                lblStudentError.Text = "Select an active student from the dropdown."
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
                        ShowRequests(requestNumber)
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

        ' =====================================================================
        ' 5. REQUESTS
        ' =====================================================================
        Public Sub ShowRequests(Optional initialSearch As String = "", Optional dashboardFilter As String = "")
            Dim filterSubtitle = "Search, review request items, and record valid payment or status changes."
            If dashboardFilter <> String.Empty Then filterSubtitle = "Dashboard filter: " & dashboardFilter & "."
            SwitchView(pnlRequests, btnNavRequests, "Request List", filterSubtitle)
            activeDashboardFilter = dashboardFilter
            txtSearchRequests.Text = initialSearch
            RefreshRequestsData()
        End Sub

        Public Sub RefreshRequestsData()
            Try
                Dim statusFilter As String = String.Empty
                Select Case activeDashboardFilter
                    Case "InProgress" : statusFilter = " AND r.Status IN ('Pending','Processing')"
                    Case "Ready" : statusFilter = " AND r.Status='Ready for Release'"
                    Case "Unpaid" : statusFilter = " AND r.PaymentStatus='Unpaid' AND r.Status<>'Cancelled'"
                    Case "Backlog" : statusFilter = " AND r.Status='Pending'"
                End Select

                dgvRequests.DataSource = Database.GetTable(
                    "SELECT r.RequestID, r.RequestNo, r.RequestDate, s.StudentID, " &
                    "CONCAT(s.LastName, ', ', s.FirstName) AS Student, r.TotalAmount, " &
                    "r.PaymentStatus, r.Status " &
                    "FROM tblrequest r INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                    "WHERE CONCAT_WS(' ',r.RequestNo,s.StudentID,s.LastName,s.FirstName) LIKE @search " & statusFilter &
                    "ORDER BY r.RequestID DESC",
                    New Dictionary(Of String, Object) From {{"@search", "%" & txtSearchRequests.Text.Trim() & "%"}})

                If dgvRequests.Columns.Contains("RequestID") Then dgvRequests.Columns("RequestID").Visible = False
                If dgvRequests.Columns.Contains("TotalAmount") Then dgvRequests.Columns("TotalAmount").DefaultCellStyle.Format = "N2"
                AppTheme.FitGridToRows(dgvRequests)
            Catch ex As Exception
                ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchRequests_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRequests.TextChanged
            RefreshRequestsData()
        End Sub

        Private Sub btnViewDetails_Click(sender As Object, e As EventArgs) Handles btnViewDetails.Click
            If dgvRequests.CurrentRow Is Nothing Then
                MessageBox.Show("Select a request first.", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvRequests.CurrentRow.Cells("RequestID").Value)
            Using dialog As New RequestDetailsForm(id)
                dialog.ShowDialog(Me)
            End Using
        End Sub

        Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
            If dgvRequests.CurrentRow Is Nothing Then
                MessageBox.Show("Select a request first.", "Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvRequests.CurrentRow.Cells("RequestID").Value)
            Using dialog As New UpdateRequestForm(id)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshRequestsData()
                    Using receipt As New ReceiptForm(id)
                        receipt.ShowDialog(Me)
                    End Using
                End If
            End Using
        End Sub

        Private Sub btnViewSlipRequest_Click(sender As Object, e As EventArgs) Handles btnViewSlipRequest.Click
            If dgvRequests.CurrentRow Is Nothing Then
                MessageBox.Show("Select a request first.", "Slip", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvRequests.CurrentRow.Cells("RequestID").Value)
            Using receipt As New ReceiptForm(id)
                receipt.ShowDialog(Me)
            End Using
        End Sub

        Private Sub dgvRequests_DoubleClick(sender As Object, e As EventArgs) Handles dgvRequests.DoubleClick
            btnViewDetails.PerformClick()
        End Sub

        ' =====================================================================
        ' 6. REPORTS
        ' =====================================================================
        Public Sub ShowReports()
            SwitchView(pnlReports, btnNavReports, "Reports", "View request and payment activity for a selected date range.")
            LoadReport()
        End Sub

        Public Sub LoadReport()
            If dtpFromDate.Value.Date > dtpToDate.Value.Date Then
                MessageBox.Show("From date must not be after To date.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim filter As String = String.Empty
            Select Case cboReportType.Text
                Case "Pending Requests"
                    filter = " AND r.Status='Pending'"
                Case "Released Requests"
                    filter = " AND r.Status='Released'"
                Case "Payments Collected"
                    filter = " AND r.PaymentStatus='Paid'"
            End Select
            Dim parameters = New Dictionary(Of String, Object) From {
                {"@fromDate", dtpFromDate.Value.Date}, {"@toDate", dtpToDate.Value.Date}
            }
            Try
                dgvReports.DataSource = Database.GetTable(
                    "SELECT r.RequestNo, r.RequestDate, s.StudentID, " &
                    "CONCAT(s.LastName, ', ', s.FirstName) AS Student, r.TotalAmount, " &
                    "r.PaymentStatus, r.ORNo, r.Status " &
                    "FROM tblrequest r INNER JOIN tblstudents s ON s.StudentID=r.StudentID " &
                    "WHERE r.RequestDate BETWEEN @fromDate AND @toDate" & filter &
                    " ORDER BY r.RequestDate DESC, r.RequestID DESC", parameters)
                Dim totalObject = Database.Scalar(
                    "SELECT COALESCE(SUM(r.TotalAmount),0) FROM tblrequest r " &
                    "WHERE r.RequestDate BETWEEN @fromDate AND @toDate" & filter, parameters)
                lblReportTotal.Text = If(cboReportType.Text = "Payments Collected", "Collected: ", "Report Total: ") &
                                      Convert.ToDecimal(totalObject).ToString("N2")
                If dgvReports.Columns.Contains("TotalAmount") Then dgvReports.Columns("TotalAmount").DefaultCellStyle.Format = "N2"
            Catch ex As Exception
                ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
            LoadReport()
        End Sub

        Private Sub cboReportType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportType.SelectedIndexChanged
            If IsHandleCreated AndAlso pnlReports.Visible Then LoadReport()
        End Sub

        ' =====================================================================
        ' 7. USERS
        ' =====================================================================
        Public Sub ShowUsers()
            If Not AppTheme.IsAdministrator(currentRole) Then
                MessageBox.Show("Only an Administrator can manage user accounts.", "Access denied",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            SwitchView(pnlUsers, btnNavUsers, "User Accounts", String.Empty)
            RefreshUsersData()
        End Sub

        Public Sub RefreshUsersData()
            If Not AppTheme.IsAdministrator(currentRole) Then Return
            Try
                dgvUsers.DataSource = Database.GetTable(
                    "SELECT UserID, Username, FullName, Role, Status FROM tblusers " &
                    "WHERE CONCAT_WS(' ',Username,FullName) LIKE @search ORDER BY FullName",
                    New Dictionary(Of String, Object) From {{"@search", "%" & txtSearchUsers.Text.Trim() & "%"}})
                If dgvUsers.Columns.Contains("UserID") Then dgvUsers.Columns("UserID").Visible = False
                AppTheme.FitGridToRows(dgvUsers)
            Catch ex As Exception
                ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchUsers_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUsers.TextChanged
            RefreshUsersData()
        End Sub

        Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
            Using dialog As New UserEditForm(currentUserId)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshUsersData()
                End If
            End Using
        End Sub

        Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
            If dgvUsers.CurrentRow Is Nothing Then
                MessageBox.Show("Select a user first.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)
            Using dialog As New UserEditForm(currentUserId, id)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshUsersData()
                End If
            End Using
        End Sub

        Private Sub btnToggleUserStatus_Click(sender As Object, e As EventArgs) Handles btnToggleUserStatus.Click
            If dgvUsers.CurrentRow Is Nothing Then
                MessageBox.Show("Select a user first.", "User Account", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim id = Convert.ToInt32(dgvUsers.CurrentRow.Cells("UserID").Value)
            If id = currentUserId Then
                MessageBox.Show("You cannot deactivate the account currently signed in.", "User account",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Dim currentStatus = dgvUsers.CurrentRow.Cells("Status").Value.ToString()
            Dim newStatus = If(currentStatus = AppTheme.ActiveStatus, AppTheme.InactiveStatus, AppTheme.ActiveStatus)
            If MessageBox.Show("Set this user account to " & newStatus & "?", "Confirm status",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Database.Execute("UPDATE tblusers SET Status=@status WHERE UserID=@id",
                                 New Dictionary(Of String, Object) From {{"@status", newStatus}, {"@id", id}})
                RefreshUsersData()
            End If
        End Sub

        Private Sub dgvUsers_DoubleClick(sender As Object, e As EventArgs) Handles dgvUsers.DoubleClick
            btnEditUser.PerformClick()
        End Sub

        ' =====================================================================
        ' DATABASE ERROR HANDLER
        ' =====================================================================
        Public Sub ShowDatabaseError(ex As Exception)
            MessageBox.Show("The database is not available." & Environment.NewLine &
                            "Import registrar_db.sql, start MySQL, and check the REGISTRAR_DB_* settings." &
                            Environment.NewLine & Environment.NewLine & ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub

        ' =====================================================================
        ' NAVIGATION HANDLERS
        ' =====================================================================
        Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
            ShowDashboard()
        End Sub

        Private Sub btnNavStudents_Click(sender As Object, e As EventArgs) Handles btnNavStudents.Click
            ShowStudents()
        End Sub

        Private Sub btnNavDocuments_Click(sender As Object, e As EventArgs) Handles btnNavDocuments.Click
            ShowDocuments()
        End Sub

        Private Sub btnNavNewRequest_Click(sender As Object, e As EventArgs) Handles btnNavNewRequest.Click
            ShowNewRequest()
        End Sub

        Private Sub btnNavRequests_Click(sender As Object, e As EventArgs) Handles btnNavRequests.Click
            ShowRequests()
        End Sub

        Private Sub btnNavReports_Click(sender As Object, e As EventArgs) Handles btnNavReports.Click
            ShowReports()
        End Sub

        Private Sub btnNavUsers_Click(sender As Object, e As EventArgs) Handles btnNavUsers.Click
            ShowUsers()
        End Sub

        Private Sub btnNavSignOut_Click(sender As Object, e As EventArgs) Handles btnNavSignOut.Click
            Close()
        End Sub

        Private Sub NavButton_MouseEnter(sender As Object, e As EventArgs) Handles _
            btnNavDashboard.MouseEnter, btnNavStudents.MouseEnter, btnNavDocuments.MouseEnter,
            btnNavNewRequest.MouseEnter, btnNavRequests.MouseEnter, btnNavReports.MouseEnter,
            btnNavUsers.MouseEnter, btnNavSignOut.MouseEnter
            Dim btn = DirectCast(sender, Button)
            If btn IsNot activeNavButton Then
                btn.BackColor = AppTheme.SoftBlueColor
            End If
        End Sub

        Private Sub NavButton_MouseLeave(sender As Object, e As EventArgs) Handles _
            btnNavDashboard.MouseLeave, btnNavStudents.MouseLeave, btnNavDocuments.MouseLeave,
            btnNavNewRequest.MouseLeave, btnNavRequests.MouseLeave, btnNavReports.MouseLeave,
            btnNavUsers.MouseLeave, btnNavSignOut.MouseLeave
            Dim btn = DirectCast(sender, Button)
            If btn IsNot activeNavButton Then
                btn.BackColor = AppTheme.SurfaceColor
            End If
        End Sub
    End Class
End Namespace
