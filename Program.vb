Imports System.Windows.Forms

Namespace RegistrarDocumentRequestSystem
    Module Program
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New LoginForm())
        End Sub
    End Module
End Namespace
