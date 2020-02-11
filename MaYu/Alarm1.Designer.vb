<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alarm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alarm1))
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblJam = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.chkON = New System.Windows.Forms.CheckBox()
        Me.txtNada = New System.Windows.Forms.TextBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnMati = New System.Windows.Forms.Button()
        Me.btnPlilih = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Location = New System.Drawing.Point(109, 72)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(49, 15)
        Me.lblTanggal.TabIndex = 0
        Me.lblTanggal.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jam Sekarang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Set Alarm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nada"
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.Location = New System.Drawing.Point(109, 116)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(28, 15)
        Me.lblJam.TabIndex = 4
        Me.lblJam.Text = "Jam"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 156)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(78, 23)
        Me.DateTimePicker1.TabIndex = 5
        '
        'chkON
        '
        Me.chkON.Location = New System.Drawing.Point(196, 162)
        Me.chkON.Name = "chkON"
        Me.chkON.Size = New System.Drawing.Size(81, 17)
        Me.chkON.TabIndex = 6
        Me.chkON.Text = "ON"
        Me.chkON.UseVisualStyleBackColor = True
        '
        'txtNada
        '
        Me.txtNada.Location = New System.Drawing.Point(112, 191)
        Me.txtNada.Name = "txtNada"
        Me.txtNada.Size = New System.Drawing.Size(131, 23)
        Me.txtNada.TabIndex = 7
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(16, 252)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(308, 37)
        Me.AxWindowsMediaPlayer1.TabIndex = 8
        '
        'btnMati
        '
        Me.btnMati.Location = New System.Drawing.Point(249, 158)
        Me.btnMati.Name = "btnMati"
        Me.btnMati.Size = New System.Drawing.Size(75, 23)
        Me.btnMati.TabIndex = 9
        Me.btnMati.Text = "Stop"
        Me.btnMati.UseVisualStyleBackColor = True
        '
        'btnPlilih
        '
        Me.btnPlilih.Location = New System.Drawing.Point(249, 190)
        Me.btnPlilih.Name = "btnPlilih"
        Me.btnPlilih.Size = New System.Drawing.Size(75, 23)
        Me.btnPlilih.TabIndex = 10
        Me.btnPlilih.Text = "Pilih"
        Me.btnPlilih.UseVisualStyleBackColor = True
        '
        'tmr1
        '
        Me.tmr1.Interval = 1000
        '
        'tmr2
        '
        Me.tmr2.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Jam Pertama 07.00 - 07.45", "Jam Kedua 07.45 - 08.30", "Jam Ketiga 08.30 - 9.15", "Jam Istirahat 09.15 - 9.30", "Jam Keempat 09.30 - 10.15", "Jam Kelima 10.15 - 11.00", "Jam Keenam 11.00 - 11.45", "Jam Istirahat 11.45 - 12.00", "Jam Ketujuh 12.00 - 12.45", "Jam Kedelaan 12.45 - 01.30", "Jam Pelajaran Selesai 01.30"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 23)
        Me.ComboBox1.TabIndex = 25
        Me.ComboBox1.Text = "Jadwal Alarm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Hari ini"
        '
        'Alarm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 301)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btnPlilih)
        Me.Controls.Add(Me.btnMati)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.txtNada)
        Me.Controls.Add(Me.chkON)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblJam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTanggal)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alarm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm Sekolah"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblJam As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkON As System.Windows.Forms.CheckBox
    Friend WithEvents txtNada As System.Windows.Forms.TextBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnMati As System.Windows.Forms.Button
    Friend WithEvents btnPlilih As System.Windows.Forms.Button
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
