Public Class frmLogin

    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        txtUser.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If UCase(txtUser.Text) = "ADMIN" And UCase(txtPassword.Text) = "123" Then
            Dim FormMenu As New frmManu
            FormMenu.Show()
            Me.Hide()
        Else
            MsgBox("Maaf User dan Password yang anda masukkan salah.", MsgBoxStyle.Exclamation)
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End


    End Sub
End Class