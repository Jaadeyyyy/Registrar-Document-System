Imports System.Drawing
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class DocumentsForm
        Private ReadOnly mainForm As MainForm

        Public Sub New()
            InitializeComponent()
            cboDocumentsStatus.SelectedIndex = 0
            AppTheme.SetPlaceholder(txtSearchDocuments, "Search document name or description...")
        End Sub

        Public Sub New(parent As MainForm)
            Me.New()
            mainForm = parent
        End Sub

        Private Sub DocumentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            RefreshDocumentsData()
            LoadRecentSlips()
        End Sub

        Public Sub RefreshDocumentsData()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim statusCondition As String = String.Empty
                If cboDocumentsStatus.SelectedIndex = 1 Then
                    statusCondition = "AND Status = 'Active' "
                ElseIf cboDocumentsStatus.SelectedIndex = 2 Then
                    statusCondition = "AND Status = 'Inactive' "
                End If

                Dim query = "SELECT DocumentID, DocumentName, Description, Fee, Status " &
                            "FROM tbldocuments " &
                            "WHERE (DocumentName LIKE @search OR Description LIKE @search) " &
                            statusCondition &
                            "ORDER BY DocumentName"

                Dim dt = Database.GetTable(query, New Dictionary(Of String, Object) From {{"@search", "%" & txtSearchDocuments.Text.Trim() & "%"}})
                dgvDocuments.DataSource = dt
                lblRecordCount.Text = $"{dt.Rows.Count} documents"
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub LoadRecentSlips()
            If DesignMode OrElse System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Designtime Then Return
            Try
                Dim query = "SELECT r.RequestNo, " &
                            "CONCAT(s.FirstName, ' ', s.LastName) AS StudentName, " &
                            "COALESCE(GROUP_CONCAT(d.DocumentName SEPARATOR ', '), 'No items') AS DocumentName, " &
                            "DATE_FORMAT(r.RequestDate, '%Y-%m-%d') AS RequestDate, " &
                            "r.Status " &
                            "FROM tblrequest r " &
                            "INNER JOIN tblstudents s ON r.StudentID = s.StudentID " &
                            "LEFT JOIN tblrequestdetails rd ON r.RequestID = rd.RequestID " &
                            "LEFT JOIN tbldocuments d ON rd.DocumentID = d.DocumentID " &
                            "GROUP BY r.RequestID, r.RequestNo, s.FirstName, s.LastName, r.RequestDate, r.Status " &
                            "ORDER BY r.RequestDate DESC LIMIT 10"

                dgvRecentSlips.DataSource = Database.GetTable(query)
            Catch ex As Exception
                MainForm.ShowDatabaseError(ex)
            End Try
        End Sub

        Private Sub txtSearchDocuments_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDocuments.TextChanged
            RefreshDocumentsData()
        End Sub

        Private Sub cboDocumentsStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDocumentsStatus.SelectedIndexChanged
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
                MessageBox.Show("Select a document first.", "Documents", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim documentId = Convert.ToInt32(dgvDocuments.CurrentRow.Cells("colDocID").Value)
            Using dialog As New DocumentEditForm(documentId)
                If dialog.ShowDialog(Me) = DialogResult.OK Then
                    RefreshDocumentsData()
                End If
            End Using
        End Sub

        Private Sub btnToggleDocumentStatus_Click(sender As Object, e As EventArgs) Handles btnToggleDocumentStatus.Click
            If dgvDocuments.CurrentRow Is Nothing Then
                MessageBox.Show("Select a document first.", "Documents", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim documentId = Convert.ToInt32(dgvDocuments.CurrentRow.Cells("colDocID").Value)
            Dim currentStatus = dgvDocuments.CurrentRow.Cells("colDocStatus").Value.ToString()
            Dim newStatus = If(currentStatus = "Active", "Inactive", "Active")
            If MessageBox.Show("Set document to " & newStatus & "?", "Confirm status", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Database.Execute("UPDATE tbldocuments SET Status=@status WHERE DocumentID=@id",
                             New Dictionary(Of String, Object) From {{"@status", newStatus}, {"@id", documentId}})
            RefreshDocumentsData()
        End Sub

        Private Sub btnViewSlip_Click(sender As Object, e As EventArgs) Handles btnViewSlip.Click
            If dgvRecentSlips.CurrentRow Is Nothing Then
                MessageBox.Show("Select a recent request slip first.", "Request Slip", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            Dim reqNo = dgvRecentSlips.CurrentRow.Cells("colSlipRequestNo").Value.ToString()
            Using rec As New ReceiptForm(reqNo)
                rec.ShowDialog(Me)
            End Using
        End Sub

        Private Sub dgvDocuments_DoubleClick(sender As Object, e As EventArgs) Handles dgvDocuments.DoubleClick
            btnEditDocument.PerformClick()
        End Sub

        Private Sub dgvDocuments_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocuments.CellFormatting
            If e.RowIndex < 0 Then Return
            If dgvDocuments.Columns(e.ColumnIndex).Name = "colDocStatus" AndAlso e.Value IsNot Nothing Then
                If e.Value.ToString() = "Active" Then
                    e.CellStyle.ForeColor = Color.FromArgb(22, 101, 52)
                    e.CellStyle.Font = New Font(dgvDocuments.Font, FontStyle.Bold)
                Else
                    e.CellStyle.ForeColor = Color.FromArgb(148, 163, 184)
                End If
            ElseIf dgvDocuments.Columns(e.ColumnIndex).Name = "colFee" AndAlso e.Value IsNot Nothing Then
                Dim fee As Decimal
                If Decimal.TryParse(e.Value.ToString(), fee) Then
                    e.Value = fee.ToString("N2")
                    e.FormattingApplied = True
                End If
            End If
        End Sub

        Private Sub dgvRecentSlips_DoubleClick(sender As Object, e As EventArgs) Handles dgvRecentSlips.DoubleClick
            btnViewSlip.PerformClick()
        End Sub
    End Class
End Namespace
