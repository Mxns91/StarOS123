<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pages
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pages))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtUrl = New System.Windows.Forms.TextBox()
        Me.btnBack = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnForward = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnDownloads = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRefresh = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRemoveTab = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnStop = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAddTab = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Browser = New System.Windows.Forms.WebBrowser()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnForward, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDownloads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemoveTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BunifuImageButton2)
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Controls.Add(Me.txtUrl)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Controls.Add(Me.btnForward)
        Me.Panel1.Controls.Add(Me.btnDownloads)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnRemoveTab)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.btnAddTab)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1510, 67)
        Me.Panel1.TabIndex = 2
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(171, 8)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(46, 50)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton2.TabIndex = 23
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1351, 8)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(46, 50)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 22
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'txtUrl
        '
        Me.txtUrl.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtUrl.Location = New System.Drawing.Point(381, 16)
        Me.txtUrl.Multiline = True
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(964, 37)
        Me.txtUrl.TabIndex = 21
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageActive = Nothing
        Me.btnBack.Location = New System.Drawing.Point(14, 8)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 50)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBack.TabIndex = 13
        Me.btnBack.TabStop = False
        Me.btnBack.Zoom = 10
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.Transparent
        Me.btnForward.Image = CType(resources.GetObject("btnForward.Image"), System.Drawing.Image)
        Me.btnForward.ImageActive = Nothing
        Me.btnForward.Location = New System.Drawing.Point(66, 8)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(46, 50)
        Me.btnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnForward.TabIndex = 14
        Me.btnForward.TabStop = False
        Me.btnForward.Zoom = 10
        '
        'btnDownloads
        '
        Me.btnDownloads.BackColor = System.Drawing.Color.Transparent
        Me.btnDownloads.Image = CType(resources.GetObject("btnDownloads.Image"), System.Drawing.Image)
        Me.btnDownloads.ImageActive = Nothing
        Me.btnDownloads.Location = New System.Drawing.Point(1403, 8)
        Me.btnDownloads.Name = "btnDownloads"
        Me.btnDownloads.Size = New System.Drawing.Size(46, 50)
        Me.btnDownloads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDownloads.TabIndex = 19
        Me.btnDownloads.TabStop = False
        Me.btnDownloads.Zoom = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageActive = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(118, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 50)
        Me.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Zoom = 10
        '
        'btnRemoveTab
        '
        Me.btnRemoveTab.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveTab.Image = CType(resources.GetObject("btnRemoveTab.Image"), System.Drawing.Image)
        Me.btnRemoveTab.ImageActive = Nothing
        Me.btnRemoveTab.Location = New System.Drawing.Point(327, 8)
        Me.btnRemoveTab.Name = "btnRemoveTab"
        Me.btnRemoveTab.Size = New System.Drawing.Size(46, 50)
        Me.btnRemoveTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRemoveTab.TabIndex = 18
        Me.btnRemoveTab.TabStop = False
        Me.btnRemoveTab.Zoom = 10
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.ImageActive = Nothing
        Me.btnStop.Location = New System.Drawing.Point(223, 8)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(46, 50)
        Me.btnStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnStop.TabIndex = 16
        Me.btnStop.TabStop = False
        Me.btnStop.Zoom = 10
        '
        'btnAddTab
        '
        Me.btnAddTab.BackColor = System.Drawing.Color.Transparent
        Me.btnAddTab.Image = CType(resources.GetObject("btnAddTab.Image"), System.Drawing.Image)
        Me.btnAddTab.ImageActive = Nothing
        Me.btnAddTab.Location = New System.Drawing.Point(275, 8)
        Me.btnAddTab.Name = "btnAddTab"
        Me.btnAddTab.Size = New System.Drawing.Size(46, 50)
        Me.btnAddTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAddTab.TabIndex = 17
        Me.btnAddTab.TabStop = False
        Me.btnAddTab.Zoom = 10
        '
        'Browser
        '
        Me.Browser.Location = New System.Drawing.Point(0, 116)
        Me.Browser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Browser.Name = "Browser"
        Me.Browser.Size = New System.Drawing.Size(1510, 651)
        Me.Browser.TabIndex = 3
        '
        'pages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1510, 769)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Browser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pages"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnForward, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDownloads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemoveTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtUrl As TextBox
    Friend WithEvents btnBack As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnForward As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnDownloads As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRefresh As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRemoveTab As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnStop As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAddTab As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Browser As Windows.Forms.WebBrowser
End Class
