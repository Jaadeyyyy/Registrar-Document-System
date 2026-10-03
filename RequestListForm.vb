Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class RequestListForm
        Private ReadOnly mainForm As MainForm
        Private activeDashboardFilter As String = String.Empty

        Public Sub New()
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnViewDetails, True)
            AppTheme.StyleButton(btnUpdateStatus, False)
            AppTheme.StyleButton(btnViewSlipRequest, True)
            AppTheme.StyleTextBox(txtSearchRequests)
            AppTheme.SetPlaceholder(txtSearchRequests, "Search request number, student ID, or name")
            AppTheme.StyleGrid(dgvRequests)
        End Sub

        Public Sub New(parent As MainForm, Optional initialSearch As String = "", Optional dashboardFilter As String = "")
            Me.New()
            mainForm = parent
            activeDashboardFilter = dashboardFilter
            If Not String.IsNullOrEmpty(initialSearch) Then
                txtSearchRequests.Text = initialSearch
            End If
        End Sub

        Private Sub RequestListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                MainForm.ShowDatabaseError(ex)
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
    End Class
End Namespace
