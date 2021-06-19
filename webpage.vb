Imports System.Net
Public Class webpage
    Private Sub webpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Browser.Navigate("https://google.com")
        txtUrl.Text = ("https://google.com")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Browser.GoBack()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        Browser.GoForward()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Browser.Refresh()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Browser.Stop()
    End Sub
    Private Sub tools()
        Dim page As webpage = New webpage
        page.Name = "Page"
        page.Dock = DockStyle.Fill
        Dim TAB As New TabPage
        TAB.Text = "Page"
        WebBrowser.TabControl1.Controls.Add(TAB)
        TAB.Controls.Add(page)
    End Sub
    Private Sub btnAddTab_Click(sender As Object, e As EventArgs) Handles btnAddTab.Click
        tools()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Browser.Navigate(txtUrl.Text)
    End Sub

    Private Sub btnDownloads_Click(sender As Object, e As EventArgs) Handles btnDownloads.Click
        Process.Start("C:\Users\" + SystemInformation.UserName + "\Downloads")
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Browser.Navigate("https://google.com")
        txtUrl.Text = ("https://google.com")
    End Sub

    Private Sub txtUrl_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUrl.KeyDown
        If e.KeyCode = Keys.Enter Then
            Browser.Navigate(txtUrl.Text)
            txtUrl.Text = txtUrl.Text
        End If
    End Sub

    Private Sub txtUrl_TextChanged(sender As Object, e As EventArgs) Handles txtUrl.TextChanged

    End Sub

    Private Sub btnRemoveTab_Click(sender As Object, e As EventArgs) Handles btnRemoveTab.Click
        WebBrowser.TabControl1.TabPages.Remove(WebBrowser.TabControl1.SelectedTab)
    End Sub

    Private Sub Browser_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles Browser.Navigating

    End Sub
End Class
