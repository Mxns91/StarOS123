Public Class check
    Private Sub check_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main1.Hide()
        Main1.Panel1.Hide()

        If System.IO.File.Exists("C:\Program Files\starOS\Files\load18293^!(@1.txt") Then
            Form1.Hide()
            Main1.Show()
        Else
            Form1.Show()
            Form1.switchPanel(Instalator)
        End If
        Me.Hide()
    End Sub
End Class