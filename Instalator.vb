Imports System.IO
Public Class Instalator
    Private Sub Instalator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Hide()
        rounds(Me)
        Label3.Hide()
        Try
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\starOS")
            My.Computer.FileSystem.CreateDirectory("C:\Program Files\starOS\Files")
        Catch ex As Exception

        End Try
    End Sub

    Sub rounds(obj As Form)
        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        DGP.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        DGP.AddLine(10, 0, obj.Width - 10, 0)
        DGP.AddArc(New Rectangle(obj.Width - 10, 0, 10, 10), -90, 90)
        DGP.AddLine(obj.Width, 10, obj.Width, obj.Height - 10)
        DGP.AddArc(New Rectangle(obj.Width - 10, obj.Height - 10, 10, 10), 0, 90)
        DGP.AddLine(obj.Width - 10, obj.Height, 10, obj.Height)
        DGP.AddArc(New Rectangle(0, obj.Height - 10, 10, 10), 90, 90)
        DGP.CloseFigure()
        obj.Region = New Region(DGP)
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        PictureBox2.Show()
        Label2.Hide()
        Label3.Show()
        BunifuFlatButton1.Hide()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Form1.switchPanel(main)
    End Sub
End Class