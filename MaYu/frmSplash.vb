Public Class frmSplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call Animation()
    End Sub

    Sub Animation()
        Me.Opacity += 0.25
        Me.ProgressBar1.Value += 2

        If Me.ProgressBar1.Value = Me.ProgressBar1.Maximum Then
            Me.Timer1.Enabled = False

            Dim FormLogin As New frmLogin
            FormLogin.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub frmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
    End Sub
End Class