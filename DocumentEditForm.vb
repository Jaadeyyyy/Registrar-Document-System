Imports System.Data
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Partial Public Class DocumentEditForm
        Private ReadOnly targetDocumentId As Integer?
        Private ReadOnly isEditing As Boolean

        Public Sub New(Optional documentId As Integer? = Nothing)
            InitializeComponent()
            AppTheme.ApplyForm(Me)
            AppTheme.StyleButton(btnSave, False)
            AppTheme.StyleButton(btnCancel, True)
            AppTheme.StyleTextBox(txtDocumentName)
            AppTheme.StyleTextBox(txtDescription)
            AppTheme.StyleTextBox(txtFee)

            targetDocumentId = documentId
            isEditing = documentId.HasValue
            Text = If(isEditing, "Edit Document", "Add Document")

            If isEditing Then
                LoadDocumentData()
            End If
        End Sub

        Private Sub LoadDocumentData()
            Dim table = Database.GetTable("SELECT * FROM tbldocuments WHERE DocumentID=@id",
                                          New Dictionary(Of String, Object) From {{"@id", targetDocumentId.Value}})
            If table.Rows.Count = 0 Then Return
            Dim row = table.Rows(0)
            txtDocumentName.Text = row("DocumentName").ToString()
            txtDescription.Text = row("Description").ToString()
            txtFee.Text = Convert.ToDecimal(row("Fee")).ToString("0.00")
        End Sub

        Private Function NullIfBlank(value As String) As Object
            If String.IsNullOrWhiteSpace(value) Then Return DBNull.Value
            Return value.Trim()
        End Function

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Dim fee As Decimal
            If String.IsNullOrWhiteSpace(txtDocumentName.Text) OrElse
               Not Decimal.TryParse(txtFee.Text.Trim(), fee) OrElse fee < 0D Then
                MessageBox.Show("Enter a document name and a valid non-negative fee.", "Document",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim parameters = New Dictionary(Of String, Object) From {
                {"@name", txtDocumentName.Text.Trim()},
                {"@description", NullIfBlank(txtDescription.Text)},
                {"@fee", fee}
            }
            Dim duplicateSql = "SELECT COUNT(*) FROM tbldocuments WHERE DocumentName=@name"
            If targetDocumentId.HasValue Then
                duplicateSql &= " AND DocumentID<>@id"
                parameters.Add("@id", targetDocumentId.Value)
            End If
            If Convert.ToInt32(Database.Scalar(duplicateSql, parameters)) > 0 Then
                MessageBox.Show("A document with that name already exists.", "Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If targetDocumentId.HasValue Then
                Database.Execute("UPDATE tbldocuments SET DocumentName=@name, Description=@description, Fee=@fee WHERE DocumentID=@id", parameters)
            Else
                Database.Execute("INSERT INTO tbldocuments(DocumentName,Description,Fee,Status) VALUES(@name,@description,@fee,'Active')", parameters)
            End If

            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            DialogResult = DialogResult.Cancel
            Close()
        End Sub
    End Class
End Namespace
