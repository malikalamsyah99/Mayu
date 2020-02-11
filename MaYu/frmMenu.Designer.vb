<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KalenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ALARMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JamPertamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatJadwalAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbouthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMaYuProject1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.jam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.jam2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tanggal2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ALARMToolStripMenuItem, Me.AbouthToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(888, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KalenderToolStripMenuItem, Me.WebBrowserToolStripMenuItem, Me.ExitToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'KalenderToolStripMenuItem
        '
        Me.KalenderToolStripMenuItem.Image = CType(resources.GetObject("KalenderToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KalenderToolStripMenuItem.Name = "KalenderToolStripMenuItem"
        Me.KalenderToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.KalenderToolStripMenuItem.Text = "Kalender"
        '
        'WebBrowserToolStripMenuItem
        '
        Me.WebBrowserToolStripMenuItem.Image = CType(resources.GetObject("WebBrowserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WebBrowserToolStripMenuItem.Name = "WebBrowserToolStripMenuItem"
        Me.WebBrowserToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.WebBrowserToolStripMenuItem.Text = "Web Browser"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ALARMToolStripMenuItem
        '
        Me.ALARMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JamPertamaToolStripMenuItem, Me.LihatJadwalAlarmToolStripMenuItem})
        Me.ALARMToolStripMenuItem.Image = CType(resources.GetObject("ALARMToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ALARMToolStripMenuItem.Name = "ALARMToolStripMenuItem"
        Me.ALARMToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ALARMToolStripMenuItem.Text = "Alarm"
        '
        'JamPertamaToolStripMenuItem
        '
        Me.JamPertamaToolStripMenuItem.Image = CType(resources.GetObject("JamPertamaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JamPertamaToolStripMenuItem.Name = "JamPertamaToolStripMenuItem"
        Me.JamPertamaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.JamPertamaToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.JamPertamaToolStripMenuItem.Text = "Buat Alarm"
        '
        'LihatJadwalAlarmToolStripMenuItem
        '
        Me.LihatJadwalAlarmToolStripMenuItem.Image = CType(resources.GetObject("LihatJadwalAlarmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LihatJadwalAlarmToolStripMenuItem.Name = "LihatJadwalAlarmToolStripMenuItem"
        Me.LihatJadwalAlarmToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.LihatJadwalAlarmToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LihatJadwalAlarmToolStripMenuItem.Text = "Lihat Jadwal Alarm"
        '
        'AbouthToolStripMenuItem
        '
        Me.AbouthToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutMaYuProject1ToolStripMenuItem})
        Me.AbouthToolStripMenuItem.Image = CType(resources.GetObject("AbouthToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbouthToolStripMenuItem.Name = "AbouthToolStripMenuItem"
        Me.AbouthToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AbouthToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportBugToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.Image = CType(resources.GetObject("ReportBugToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ReportBugToolStripMenuItem.Text = "Report Bug"
        '
        'AboutMaYuProject1ToolStripMenuItem
        '
        Me.AboutMaYuProject1ToolStripMenuItem.Image = CType(resources.GetObject("AboutMaYuProject1ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutMaYuProject1ToolStripMenuItem.Name = "AboutMaYuProject1ToolStripMenuItem"
        Me.AboutMaYuProject1ToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AboutMaYuProject1ToolStripMenuItem.Text = "About MaYu Project 1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.jam, Me.jam2, Me.ToolStripStatusLabel1, Me.tanggal2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 510)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(888, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'jam
        '
        Me.jam.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jam.Name = "jam"
        Me.jam.Size = New System.Drawing.Size(16, 17)
        Me.jam.Text = ".."
        '
        'jam2
        '
        Me.jam2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jam2.Name = "jam2"
        Me.jam2.Size = New System.Drawing.Size(31, 17)
        Me.jam2.Text = "jam"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'tanggal2
        '
        Me.tanggal2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal2.Name = "tanggal2"
        Me.tanggal2.Size = New System.Drawing.Size(55, 17)
        Me.tanggal2.Text = "tanggal"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmManu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 532)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmManu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm Sekolah 1.0 MaYu Software"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbouthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents AboutMaYuProject1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents jam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents jam2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tanggal2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents WebBrowserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ALARMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JamPertamaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KalenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LihatJadwalAlarmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
