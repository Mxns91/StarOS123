Public Class FileExplorer
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox2.Image = PictureBox3.Image
        txtPath.Text = "A:\Desktop"
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox2.Image = PictureBox4.Image
        txtPath.Text = "A:\Downloads"
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox2.Image = PictureBox5.Image
        txtPath.Text = "A:\Documents"
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox2.Image = PictureBox6.Image
        txtPath.Text = "A:\Pictures"
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox2.Image = PictureBox7.Image
        txtPath.Text = "A:\Music"
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox2.Image = PictureBox8.Image
        txtPath.Text = "A:\Videos"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        txtPath.Undo()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        txtPath.Redo()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox2.Image = PictureBox1.Image
        txtPath.Text = "Quick access"
    End Sub
End Class