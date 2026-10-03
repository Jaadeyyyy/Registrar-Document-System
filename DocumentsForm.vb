Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class DocumentsForm
        Private ReadOnly mainForm As MainForm
        Private userRole As String = String.Empty

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnAddDocument, False)
            AppTheme.StyleButton(btnEditDocument, True)
            AppTheme.StyleButton(btnToggleDocumentStatus, True)
            AppTheme.StyleButton(btnViewSlipDocument, True)
            AppTheme.StyleTextBox(txtSearchDocuments)
            AppTheme.SetPlaceholder(txtSearchDocuments, "Search document name")
            AppTheme.StyleGrid(dgvDocuments)
            AppTheme.StyleGrid(dgvRecentSlips)
        End Sub

        Public Sub New(parent As MainForm, role As String)
            Me.New()
            mainForm = parent
            userRole = role
            If Not AppTheme.IsAdministrator(userRole) Then
                btnAddDocument.Visible = False
                btnEditDocument.Visible = False
                btnToggleDocumentStatus.Visible = False
            End If
        End Sub

        Private Sub DocumentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                MainForm.ShowDatabaseError(ex)
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
                MainForm.ShowDatabaseError(ex)
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
            If AppTheme.IsAdministrator(userRole) Then
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
    End Class
End Namespace
