Public Class Alarm1
    Dim Alarm As Integer = 0

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlilih.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtNada.Text = ""
            txtNada.Text = OpenFileDialog1.FileName
            Alarm = 1
        End If
    End Sub

    Private Sub Alarm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr2.Enabled = True
        DateTimePicker1.Format = DateTimePickerFormat.Time

    End Sub

    Private Sub tmr2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr2.Tick
        lblTanggal.Text = Format(Now, "dd/MMM/yyyy")
        lblJam.Text = DateTime.Now.ToLongTimeString
    End Sub


    Private Sub tmr1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        Try
            If TimeOfDay = DateTimePicker1.Text Then
                If Alarm = 1 Then
                    'MaYu Blessing Software - Malik Alamsyah & Bayu Muhammad Yamin (15083000060)
                    AxWindowsMediaPlayer1.URL = txtNada.Text.ToString
                Else
                    MsgBox(DateTimePicker1.Value)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkON.CheckedChanged
        If chkON.Checked = True Then
            chkON.Text = "ON"
            tmr1.Enabled = True
        Else
            chkON.Text = "OFF"
            tmr1.Enabled = False

        End If
    End Sub

    Private Sub btnMati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMati.Click
        chkON.Text = "OFF"
        chkON.Checked = False
        tmr1.Enabled = False
        AxWindowsMediaPlayer1.close()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub


End Class