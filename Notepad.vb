Public Class Notepad
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub Notepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rounds(Me)
        Label1.Hide()
        Main1.file1.Show()
        Main1.file1.Image = My.Resources.notepad_48px
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

    Private Sub NowyToolStripButton1_Click(sender As Object, e As EventArgs) Handles NowyToolStripButton1.Click
        TextBox1.Clear()
    End Sub

    Private Sub OtwórzToolStripButton1_Click(sender As Object, e As EventArgs) Handles OtwórzToolStripButton1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub ZapiszToolStripButton1_Click(sender As Object, e As EventArgs) Handles ZapiszToolStripButton1.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        My.Computer.FileSystem.WriteAllText(Label1.Text, TextBox1.Text, True)
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        Label1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub DrukujToolStripButton1_Click(sender As Object, e As EventArgs) Handles DrukujToolStripButton1.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub WytnijToolStripButton1_Click(sender As Object, e As EventArgs) Handles WytnijToolStripButton1.Click
        TextBox1.Cut()
    End Sub

    Private Sub KopiujToolStripButton1_Click(sender As Object, e As EventArgs) Handles KopiujToolStripButton1.Click
        TextBox1.Copy()
    End Sub

    Private Sub ToolStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStrip1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub ToolStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles ToolStrip1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Main1.file1.Hide()
    End Sub

    Private Sub WklejToolStripButton1_Click(sender As Object, e As EventArgs) Handles WklejToolStripButton1.Click
        TextBox1.Paste()
    End Sub
End Class