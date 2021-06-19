Imports System.Net
Imports System.IO
Imports System.Net.WebClient
Public Class WebBrowser
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub WebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rounds(Me)
        tools()
    End Sub

    Private Sub tools()
        Dim page As webpage = New webpage
        page.Name = "Page"
        page.Dock = DockStyle.Fill
        Dim TAB As New TabPage
        TAB.Text = "Page"
        TabControl1.Controls.Add(TAB)
        TAB.Controls.Add(page)
    End Sub

    Private Sub WebBrowser_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub WebBrowser_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddTab_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub btnRemoveTab_Click(sender As Object, e As EventArgs)
        If TabControl1.TabPages.Count = 1 Then
            Me.Close()
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)
        End If
    End Sub

    Private Sub AddTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTabToolStripMenuItem.Click
        tools()
    End Sub

    Private Sub RemoveTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem.Click
        TabControl1.TabPages.Remove(TabControl1.SelectedTab)
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