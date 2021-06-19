Imports System.Net
Public Class pages
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

    Private Sub btnAddTab_Click(sender As Object, e As EventArgs) Handles btnAddTab.Click

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
End Class
