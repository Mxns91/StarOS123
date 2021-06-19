Imports System.Net
Imports System.IO
Imports System.Runtime.InteropServices
Public Class Main1
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Const DESKTOPVERTRES As Integer = &H75
    Private Const DESKTOPHORZRES As Integer = &H76
    <Runtime.InteropServices.DllImport("gdi32.dll")> Private Shared Function GetDeviceCaps(ByVal hdc As IntPtr, ByVal nIndex As Integer) As Integer
    End Function
    Private Sub Main1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Main1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()
        Start1.Hide()
        file1.Hide()
        file2.Hide()
        file3.Hide()
        file4.Hide()
        file5.Hide()
        Label3.Text = "Welcome, " + My.Settings.User + "!"
        Panel1.Hide()
        Me.BackgroundImage = My.Resources.WallpaperLight
        Using g As Graphics = Graphics.FromHwnd(IntPtr.Zero)
            Dim hdc As IntPtr = g.GetHdc
            Dim TrueScreenSize As New Size(GetDeviceCaps(hdc, DESKTOPHORZRES), GetDeviceCaps(hdc, DESKTOPVERTRES))
            Dim sclX As Single = CSng(Math.Round((TrueScreenSize.Width / Screen.PrimaryScreen.Bounds.Width), 2))
            Dim sclY As Single = CSng(Math.Round((TrueScreenSize.Height / Screen.PrimaryScreen.Bounds.Height), 2))
            g.ReleaseHdc(hdc)

            'show the true screen size
            Label1.Text = sclY.ToString
        End Using

        If Label1.Text = "1" Then
            Me.Hide()
            MsgBox("Program error! change scale the system to 150%. Your scale is: 100%", MsgBoxStyle.Information, "Info")
            Application.Exit()
        ElseIf Label1.Text = "1,25" Then
            Me.Hide()
            MsgBox("Program error! change scale the system to 150%. Your scale is: 125%", MsgBoxStyle.Information, "Info")
            Application.Exit()
        ElseIf Label1.Text = "1,5" Then

        ElseIf Label1.Text = "1,75" Then
            Me.Hide()
            MsgBox("Program error! change scale the system to 150%. Your scale is: 175%", MsgBoxStyle.Information, "Info")
            Application.Exit()
        Else
            Me.Hide()
            MsgBox("Not supported scale & res!", MsgBoxStyle.OkOnly, "Info")
            Application.Exit()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Stop()
        Timer1.Start()
        Me.BackgroundImage = My.Resources.WallpaperLight
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer2.Start()
        Me.BackgroundImage = My.Resources.img32
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        Timer3.Start()
        Me.BackgroundImage = My.Resources.img33
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        Timer4.Start()
        Me.BackgroundImage = My.Resources.img34
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Stop()
        Timer5.Start()
        Me.BackgroundImage = My.Resources.img35
    End Sub

    Private Sub Main1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            Timer1.Start()
        End If
        If e.KeyCode = Keys.F2 Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Timer6.Stop()
        Me.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        FileExplorer.Show()
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Start.Hide()
        Start1.Show()
        Panel1.Show()
        switchPanel(Apps)
    End Sub

    Private Sub Start1_Click(sender As Object, e As EventArgs) Handles Start1.Click
        Start.Show()
        Start1.Hide()
        Panel1.Hide()
        Apps.Hide()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown

    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Label2.Text = Date.Now.ToString("  H:mm" + Environment.NewLine +
Date.Now.ToString("dd.MM.yyyy"))

    End Sub

    Private Sub Main1_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.White
        Start.BackColor = Color.White
        file1.BackColor = Color.White
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.BackColor = Color.DimGray
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.White
        Start.BackColor = Color.White
        file1.BackColor = Color.White
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave

    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.DimGray
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.White
        Start.BackColor = Color.White
        file1.BackColor = Color.White
    End Sub

    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.White
        Start.BackColor = Color.White
        file1.BackColor = Color.White
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.DimGray
        Start1.BackColor = Color.White
        Start.BackColor = Color.White
        file1.BackColor = Color.White
    End Sub

    Private Sub Start1_MouseHover(sender As Object, e As EventArgs) Handles Start1.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.DimGray
        Start.BackColor = Color.DimGray
        file1.BackColor = Color.White
    End Sub

    Private Sub Start_MouseHover(sender As Object, e As EventArgs) Handles Start.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.DimGray
        Start.BackColor = Color.DimGray
        file1.BackColor = Color.White
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.White
        Start.BackColor = Color.White
        file1.BackColor = Color.White
    End Sub

    Private Sub file1_Click(sender As Object, e As EventArgs) Handles file1.Click
        Notepad.Show()
    End Sub

    Private Sub file1_MouseHover(sender As Object, e As EventArgs) Handles file1.MouseHover
        Label2.BackColor = Color.White
        PictureBox3.BackColor = Color.White
        PictureBox2.BackColor = Color.White
        Start1.BackColor = Color.White
        Start.BackColor = Color.White
        file1.BackColor = Color.DimGray
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        WebBrowser.Show()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

    End Sub
End Class