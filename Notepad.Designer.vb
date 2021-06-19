<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notepad
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notepad))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NowyToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.OtwórzToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ZapiszToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.DrukujToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.WytnijToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.KopiujToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.WklejToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NowyToolStripButton1, Me.OtwórzToolStripButton1, Me.ZapiszToolStripButton1, Me.ToolStripButton1, Me.DrukujToolStripButton1, Me.toolStripSeparator1, Me.WytnijToolStripButton1, Me.KopiujToolStripButton1, Me.WklejToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 33)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 61)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(800, 389)
        Me.TextBox1.TabIndex = 1
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text Files | *.txt"
        Me.OpenFileDialog1.Title = "Select Text Files"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Text Files | *.txt"
        Me.SaveFileDialog1.Title = "Select Text Files"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(561, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(780, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "X"
        '
        'NowyToolStripButton1
        '
        Me.NowyToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NowyToolStripButton1.Image = CType(resources.GetObject("NowyToolStripButton1.Image"), System.Drawing.Image)
        Me.NowyToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NowyToolStripButton1.Name = "NowyToolStripButton1"
        Me.NowyToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.NowyToolStripButton1.Text = "&Nowy"
        '
        'OtwórzToolStripButton1
        '
        Me.OtwórzToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OtwórzToolStripButton1.Image = CType(resources.GetObject("OtwórzToolStripButton1.Image"), System.Drawing.Image)
        Me.OtwórzToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OtwórzToolStripButton1.Name = "OtwórzToolStripButton1"
        Me.OtwórzToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.OtwórzToolStripButton1.Text = "&Otwórz"
        '
        'ZapiszToolStripButton1
        '
        Me.ZapiszToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZapiszToolStripButton1.Image = CType(resources.GetObject("ZapiszToolStripButton1.Image"), System.Drawing.Image)
        Me.ZapiszToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZapiszToolStripButton1.Name = "ZapiszToolStripButton1"
        Me.ZapiszToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.ZapiszToolStripButton1.Text = "&Zapisz"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton1.Text = "&SaveInFile"
        '
        'DrukujToolStripButton1
        '
        Me.DrukujToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DrukujToolStripButton1.Image = CType(resources.GetObject("DrukujToolStripButton1.Image"), System.Drawing.Image)
        Me.DrukujToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DrukujToolStripButton1.Name = "DrukujToolStripButton1"
        Me.DrukujToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.DrukujToolStripButton1.Text = "&Drukuj"
        '
        'WytnijToolStripButton1
        '
        Me.WytnijToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WytnijToolStripButton1.Image = CType(resources.GetObject("WytnijToolStripButton1.Image"), System.Drawing.Image)
        Me.WytnijToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WytnijToolStripButton1.Name = "WytnijToolStripButton1"
        Me.WytnijToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.WytnijToolStripButton1.Text = "&Wytnij"
        '
        'KopiujToolStripButton1
        '
        Me.KopiujToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KopiujToolStripButton1.Image = CType(resources.GetObject("KopiujToolStripButton1.Image"), System.Drawing.Image)
        Me.KopiujToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopiujToolStripButton1.Name = "KopiujToolStripButton1"
        Me.KopiujToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.KopiujToolStripButton1.Text = "&Kopiuj"
        '
        'WklejToolStripButton1
        '
        Me.WklejToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WklejToolStripButton1.Image = CType(resources.GetObject("WklejToolStripButton1.Image"), System.Drawing.Image)
        Me.WklejToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.WklejToolStripButton1.Name = "WklejToolStripButton1"
        Me.WklejToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.WklejToolStripButton1.Text = "&Wklej"
        '
        'Notepad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Notepad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notepad"
        Me.TopMost = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents NowyToolStripButton1 As ToolStripButton
    Friend WithEvents OtwórzToolStripButton1 As ToolStripButton
    Friend WithEvents ZapiszToolStripButton1 As ToolStripButton
    Friend WithEvents DrukujToolStripButton1 As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents WytnijToolStripButton1 As ToolStripButton
    Friend WithEvents KopiujToolStripButton1 As ToolStripButton
    Friend WithEvents WklejToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label2 As Label
End Class
