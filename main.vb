Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rounds(Me)
        BunifuMaterialTextbox1.Hide()
        BunifuMaterialTextbox2.Hide()
        BunifuFlatButton1.Hide()
        PictureBox2.Hide()
        Button1.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        BunifuFlatButton1.Enabled = False
        Label3.Hide()
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

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        PictureBox2.Show()
        BunifuFlatButton3.Hide()
        Label1.Hide()
        Label2.Hide()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuMaterialTextbox1.Show()
        BunifuMaterialTextbox2.Show()
        BunifuFlatButton1.Show()
        Button1.Show()
        PictureBox2.Hide()
        Label5.Show()
        Label6.Show()
        Label3.Show()
        Label4.Show()
        Label1.Show()
        Label1.Text = "Set up a PIN"
    End Sub

    Private Sub BunifuMaterialTextbox1_TextChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.TextChanged

    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress, BunifuMaterialTextbox1.KeyPress

        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BunifuMaterialTextbox1.Clear()
        BunifuMaterialTextbox2.Clear()
        BunifuFlatButton1.Enabled = False
    End Sub

    Private Sub BunifuMaterialTextbox2_TextChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.TextChanged
        If BunifuMaterialTextbox1.Text = "" Then
            BunifuFlatButton1.Enabled = False
        Else
            If BunifuMaterialTextbox2.Text = BunifuMaterialTextbox1.Text Then
                BunifuFlatButton1.Enabled = True
            Else
                BunifuFlatButton1.Enabled = False
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        My.Settings.PIN = BunifuMaterialTextbox1.Text
        My.Settings.Save()
        BunifuMaterialTextbox1.Hide()
        BunifuMaterialTextbox2.Hide()
        BunifuFlatButton1.Hide()
        PictureBox2.Show()
        Button1.Hide()
        Timer1.Enabled = False
        Timer1.Stop()
        Label4.Hide()
        Label5.Hide()
        Label1.Hide()
        Label6.Hide()
        Timer2.Start()
        Label3.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Try
            BunifuMaterialTextbox1.Text = BunifuMaterialTextbox1.Text.Remove(BunifuMaterialTextbox1.Text.Length - 1, 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Try
            BunifuMaterialTextbox2.Text = BunifuMaterialTextbox2.Text.Remove(BunifuMaterialTextbox2.Text.Length - 1, 1)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Form1.switchPanel(User)
    End Sub
End Class