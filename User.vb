Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Gif.Hide()
        rounds(Me)
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        My.Settings.User = TextBox1.Text
        My.Settings.Save()
        System.IO.File.Create("C:\Program Files\starOS\Files\load18293^!(@1.txt")
        Label2.Hide()
        TextBox1.Hide()
        Label3.Hide()
        Gif.Show()
        Timer1.Start()
        Button1.Hide()
        Label1.Hide()
        BunifuFlatButton1.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 0 Then
            BunifuFlatButton1.Enabled = False
        Else
            BunifuFlatButton1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Form1.Hide()
        Main1.Show()
    End Sub
End Class