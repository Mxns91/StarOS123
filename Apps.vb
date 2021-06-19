Public Class Apps
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub Apps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rounds(Me)
    End Sub

    Private Sub Apps_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

    End Sub

    Private Sub Apps_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Notepad.Show()
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
End Class