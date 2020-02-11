Public Class frmManu
    'MaYu Blessing Software - Malik Alamsyah & Bayu Muhammad Yamin (15083000060)

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim FormSplash As New frmSplash
        'MaYu Blessings Software
        Alarm1.Close()
        FormSplash.Show()
        Me.Hide()

    End Sub

    Private Sub AboutMaYuProject1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMaYuProject1ToolStripMenuItem.Click
        Dim About As New AboutBox1
        About.Show()
    End Sub





    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tanggal2.Text = Format(Now, "dd/MMM/yyyy")
        'MaYu Blessing Software - Malik Alamsyah & Bayu Muhammad Yamin (15083000060)
        jam2.Text = Format(Now, "HH:mmm:ss")
    End Sub

    Private Sub WebBrowserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebBrowserToolStripMenuItem.Click
        Dim wb As New webBrowser
        wb.MdiParent = Me
        wb.Show()

    End Sub

    Private Sub JamPertamaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JamPertamaToolStripMenuItem.Click
        Dim alarm1 As New Alarm1
        alarm1.MdiParent = Me
        alarm1.Show()


    End Sub



    Private Sub ALARMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ALARMToolStripMenuItem.Click

    End Sub

    Private Sub frmManu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KalenderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KalenderToolStripMenuItem.Click
        Dim Kalendr As New kalender
        Kalendr.MdiParent = Me
        Kalendr.Show()
    End Sub

    Private Sub LihatJadwalAlarmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LihatJadwalAlarmToolStripMenuItem.Click
        Dim JD As New Jadwal
        JD.Show()
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportBugToolStripMenuItem.Click
        Dim rBug As New ReportBug
        rBug.Show()

    End Sub
End Class