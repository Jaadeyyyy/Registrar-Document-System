Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Public Module AppTheme
        Private Const EM_SETCUEBANNER As Integer = &H1501

        <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
        Private Function SendMessage(controlHandle As IntPtr, message As Integer,
                                     wParam As IntPtr, text As String) As IntPtr
        End Function
        Public Const AppTitle As String = "Registrar Document Request System"
        Public Const SchoolName As String = "LYCEUM OF ALABANG"
        Public Const SchoolAddress As String = "KM 30 National Road, Tunasan, Muntinlupa City"
        Public Const RegistrarOffice As String = "OFFICE OF THE REGISTRAR"
        Public Const AdministratorRole As String = "Administrator"
        Public Const StaffRole As String = "Registrar Staff"
        Public Const ActiveStatus As String = "Active"
        Public Const InactiveStatus As String = "Inactive"

        ' Inspired by the EmpowerED student portal: deep school navy,
        ' warm gold accents, clean white cards, and soft blue backgrounds.
        Public ReadOnly PrimaryColor As Color = Color.FromArgb(8, 52, 112)
        Public ReadOnly PrimaryHoverColor As Color = Color.FromArgb(5, 39, 84)
        Public ReadOnly AccentColor As Color = Color.FromArgb(247, 193, 52)
        Public ReadOnly AccentTintColor As Color = Color.FromArgb(255, 247, 218)
        Public ReadOnly SoftBlueColor As Color = Color.FromArgb(232, 240, 250)
        Public ReadOnly BackgroundColor As Color = Color.FromArgb(244, 247, 251)
        Public ReadOnly SurfaceColor As Color = Color.White
        Public ReadOnly TextColor As Color = Color.FromArgb(31, 42, 55)
        Public ReadOnly MutedTextColor As Color = Color.FromArgb(101, 116, 139)
        Public ReadOnly BorderColor As Color = Color.FromArgb(221, 228, 237)
        Public ReadOnly DangerColor As Color = Color.FromArgb(190, 55, 55)

        Public Sub ApplyForm(form As Form)
            form.Font = New Font("Segoe UI", 10.0F)
            form.BackColor = BackgroundColor
            form.ForeColor = TextColor
        End Sub

        Public Sub StyleTextBox(input As TextBox)
            input.Font = New Font("Segoe UI", 10.0F)
            input.BackColor = SurfaceColor
            input.ForeColor = TextColor
            input.BorderStyle = BorderStyle.FixedSingle
        End Sub

        ' TextBox.PlaceholderText was introduced after .NET Framework.
        ' This Windows cue-banner API provides the same visual hint on Windows 7 and later.
        Public Sub SetPlaceholder(input As TextBox, text As String)
            If input Is Nothing Then Throw New ArgumentNullException(NameOf(input))
            SendMessage(input.Handle, EM_SETCUEBANNER, IntPtr.Zero, text)
        End Sub

        Public Sub StyleComboBox(input As ComboBox)
            input.Font = New Font("Segoe UI", 10.0F)
            input.BackColor = SurfaceColor
            input.ForeColor = TextColor
            input.FlatStyle = FlatStyle.Flat
        End Sub

        Public Sub StyleButton(button As Button, Optional secondary As Boolean = False)
            button.FlatStyle = FlatStyle.Flat
            button.Cursor = Cursors.Hand
            button.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
            button.BackColor = If(secondary, SurfaceColor, PrimaryColor)
            button.ForeColor = If(secondary, PrimaryColor, Color.White)
            button.FlatAppearance.BorderColor = If(secondary, PrimaryColor, PrimaryColor)
            button.FlatAppearance.BorderSize = 1
        End Sub

        Public Function CreateButton(caption As String, left As Integer, top As Integer,
                                     Optional width As Integer = 150,
                                     Optional secondary As Boolean = False) As Button
            Dim button As New Button With {
                .Text = caption,
                .Location = New Point(left, top),
                .Size = New Size(width, 38)
            }
            StyleButton(button, secondary)
            Return button
        End Function

        Public Sub StyleGrid(grid As DataGridView)
            grid.ReadOnly = True
            grid.AllowUserToAddRows = False
            grid.AllowUserToDeleteRows = False
            grid.AllowUserToResizeRows = False
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            grid.MultiSelect = False
            grid.BackgroundColor = SurfaceColor
            grid.BorderStyle = BorderStyle.FixedSingle
            grid.GridColor = BorderColor
            grid.RowHeadersVisible = False
            grid.EnableHeadersVisualStyles = False
            grid.ColumnHeadersHeight = 38
            grid.RowTemplate.Height = 34
            grid.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
                .BackColor = PrimaryColor,
                .ForeColor = Color.White,
                .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                .Alignment = DataGridViewContentAlignment.MiddleLeft,
                .Padding = New Padding(5, 0, 0, 0)
            }
            grid.DefaultCellStyle = New DataGridViewCellStyle With {
                .BackColor = SurfaceColor,
                .ForeColor = TextColor,
                .SelectionBackColor = AccentTintColor,
                .SelectionForeColor = TextColor,
                .Padding = New Padding(5, 0, 0, 0)
            }
            grid.AlternatingRowsDefaultCellStyle = New DataGridViewCellStyle With {
                .BackColor = Color.FromArgb(248, 250, 252),
                .ForeColor = TextColor,
                .SelectionBackColor = AccentTintColor,
                .SelectionForeColor = TextColor
            }
            ApplyGridFormatting(grid)
        End Sub

        Public Sub ApplyGridFormatting(grid As DataGridView)
            AddHandler grid.CellFormatting,
                Sub(sender As Object, e As DataGridViewCellFormattingEventArgs)
                    If e.Value Is Nothing Then Return
                    Dim value = e.Value.ToString()
                    Select Case value
                        Case "Active", "Paid", "Released"
                            e.CellStyle.ForeColor = Color.FromArgb(24, 132, 96)
                            e.CellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                        Case "Inactive", "Unpaid", "Cancelled"
                            e.CellStyle.ForeColor = DangerColor
                            e.CellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                        Case "Pending", "Processing", "Ready for Release"
                            e.CellStyle.ForeColor = Color.FromArgb(164, 103, 14)
                            e.CellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                    End Select
                End Sub
            AddHandler grid.DataBindingComplete,
                Sub(sender As Object, e As DataGridViewBindingCompleteEventArgs)
                    For Each column As DataGridViewColumn In grid.Columns
                        Dim header = Regex.Replace(column.Name, "([a-z])([A-Z])", "$1 $2")
                        header = header.Replace("ORNo", "OR No.").Replace("Sub Total", "Subtotal")
                        column.HeaderText = header
                    Next
                End Sub
        End Sub

        Public Sub FitGridToRows(grid As DataGridView, Optional maximumHeight As Integer = 440)
            Dim visibleRows = Math.Max(1, grid.Rows.Count)
            Dim wantedHeight = grid.ColumnHeadersHeight + (visibleRows * grid.RowTemplate.Height) + 3
            grid.Height = Math.Min(maximumHeight, wantedHeight)
            grid.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            grid.ScrollBars = If(wantedHeight > maximumHeight, ScrollBars.Vertical, ScrollBars.None)
        End Sub

        Public Function CreateGrid(top As Integer) As DataGridView
            Dim grid As New DataGridView With {
                .Location = New Point(0, top),
                .Size = New Size(1000, 440),
                .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right,
                .ReadOnly = True,
                .AllowUserToAddRows = False,
                .AllowUserToDeleteRows = False,
                .AllowUserToResizeRows = False,
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                .MultiSelect = False,
                .BackgroundColor = SurfaceColor,
                .BorderStyle = BorderStyle.FixedSingle,
                .GridColor = BorderColor,
                .RowHeadersVisible = False,
                .EnableHeadersVisualStyles = False
            }
            grid.ColumnHeadersHeight = 38
            grid.RowTemplate.Height = 34
            grid.ColumnHeadersDefaultCellStyle = New DataGridViewCellStyle With {
                .BackColor = PrimaryColor,
                .ForeColor = Color.White,
                .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                .Alignment = DataGridViewContentAlignment.MiddleLeft,
                .Padding = New Padding(5, 0, 0, 0)
            }
            grid.DefaultCellStyle = New DataGridViewCellStyle With {
                .BackColor = SurfaceColor,
                .ForeColor = TextColor,
                .SelectionBackColor = AccentTintColor,
                .SelectionForeColor = TextColor,
                .Padding = New Padding(5, 0, 0, 0)
            }
            grid.AlternatingRowsDefaultCellStyle = New DataGridViewCellStyle With {
                .BackColor = Color.FromArgb(248, 250, 252),
                .ForeColor = TextColor,
                .SelectionBackColor = AccentTintColor,
                .SelectionForeColor = TextColor
            }
            AddHandler grid.CellFormatting,
                Sub(sender As Object, e As DataGridViewCellFormattingEventArgs)
                    If e.Value Is Nothing Then Return
                    Dim value = e.Value.ToString()
                    Select Case value
                        Case "Active", "Paid", "Released"
                            e.CellStyle.ForeColor = Color.FromArgb(24, 132, 96)
                            e.CellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                        Case "Inactive", "Unpaid", "Cancelled"
                            e.CellStyle.ForeColor = DangerColor
                            e.CellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                        Case "Pending", "Processing", "Ready for Release"
                            e.CellStyle.ForeColor = Color.FromArgb(164, 103, 14)
                            e.CellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
                    End Select
                End Sub
            AddHandler grid.DataBindingComplete,
                Sub(sender As Object, e As DataGridViewBindingCompleteEventArgs)
                    For Each column As DataGridViewColumn In grid.Columns
                        Dim header = Regex.Replace(column.Name, "([a-z])([A-Z])", "$1 $2")
                        header = header.Replace("ORNo", "OR No.").Replace("Sub Total", "Subtotal")
                        column.HeaderText = header
                    Next
                End Sub
            Return grid
        End Function

        Public Function CreateFieldLabel(caption As String, top As Integer) As Label
            Return New Label With {
                .Text = caption,
                .Location = New Point(24, top + 5),
                .AutoSize = True,
                .ForeColor = TextColor
            }
        End Function

        Public Function IsAdministrator(role As String) As Boolean
            Return String.Equals(role, AdministratorRole, StringComparison.OrdinalIgnoreCase)
        End Function
    End Module
End Namespace
