Public Class frmAlarm1
    Dim Alarm As Integer = 0
    Private Sub frmAlarm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr2.Enabled = True
        DateTimePicker1.Format = DateTimePickerFormat.Time

    End Sub

    Private Sub tmr2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr2.Tick

    End Sub
End Class