<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUmur = New System.Windows.Forms.Label()
        Me.lblNomor = New System.Windows.Forms.Label()
        Me.lblHobi = New System.Windows.Forms.Label()
        Me.lblTanggal = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtNomor = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.gbGender = New System.Windows.Forms.GroupBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.gbHobi = New System.Windows.Forms.GroupBox()
        Me.chkHobi10 = New System.Windows.Forms.CheckBox()
        Me.chkHobi9 = New System.Windows.Forms.CheckBox()
        Me.chkHobi8 = New System.Windows.Forms.CheckBox()
        Me.chkHobi7 = New System.Windows.Forms.CheckBox()
        Me.chkHobi6 = New System.Windows.Forms.CheckBox()
        Me.chkHobi5 = New System.Windows.Forms.CheckBox()
        Me.chkHobi4 = New System.Windows.Forms.CheckBox()
        Me.chkHobi3 = New System.Windows.Forms.CheckBox()
        Me.chkHobi2 = New System.Windows.Forms.CheckBox()
        Me.chkHobi1 = New System.Windows.Forms.CheckBox()
        Me.LabelJudul = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGender.SuspendLayout()
        Me.gbHobi.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(40, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 260)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.Location = New System.Drawing.Point(40, 350)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(200, 40)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Pilih Foto"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelJudul.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelJudul.Location = New System.Drawing.Point(35, 20)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(394, 45)
        Me.LabelJudul.TabIndex = 16
        Me.LabelJudul.Text = "Form Pendaftaran Anggota"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblNama.Location = New System.Drawing.Point(280, 80)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(64, 28)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblUmur
        '
        Me.lblUmur.AutoSize = True
        Me.lblUmur.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblUmur.Location = New System.Drawing.Point(280, 130)
        Me.lblUmur.Name = "lblUmur"
        Me.lblUmur.Size = New System.Drawing.Size(60, 28)
        Me.lblUmur.TabIndex = 3
        Me.lblUmur.Text = "Umur"
        '
        'lblNomor
        '
        Me.lblNomor.AutoSize = True
        Me.lblNomor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblNomor.Location = New System.Drawing.Point(280, 180)
        Me.lblNomor.Name = "lblNomor"
        Me.lblNomor.Size = New System.Drawing.Size(83, 28)
        Me.lblNomor.TabIndex = 4
        Me.lblNomor.Text = "No. Telp"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTanggal.Location = New System.Drawing.Point(280, 230)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(87, 28)
        Me.lblTanggal.TabIndex = 6
        Me.lblTanggal.Text = "Tgl Lahir"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAlamat.Location = New System.Drawing.Point(280, 280)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(74, 28)
        Me.lblAlamat.TabIndex = 7
        Me.lblAlamat.Text = "Alamat"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNama.Location = New System.Drawing.Point(390, 77)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(300, 34)
        Me.txtNama.TabIndex = 8
        '
        'txtUmur
        '
        Me.txtUmur.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtUmur.Location = New System.Drawing.Point(390, 127)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(300, 34)
        Me.txtUmur.TabIndex = 9
        '
        'txtNomor
        '
        Me.txtNomor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNomor.Location = New System.Drawing.Point(390, 177)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(300, 34)
        Me.txtNomor.TabIndex = 10
        '
        'dtpTanggal
        '
        Me.dtpTanggal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dtpTanggal.Location = New System.Drawing.Point(390, 225)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(300, 34)
        Me.dtpTanggal.TabIndex = 12
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAlamat.Location = New System.Drawing.Point(390, 277)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(300, 60)
        Me.txtAlamat.TabIndex = 11
        '
        'gbGender
        '
        Me.gbGender.Controls.Add(Me.rbPerempuan)
        Me.gbGender.Controls.Add(Me.rbLaki)
        Me.gbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gbGender.Location = New System.Drawing.Point(280, 350)
        Me.gbGender.Name = "gbGender"
        Me.gbGender.Size = New System.Drawing.Size(410, 80)
        Me.gbGender.TabIndex = 14
        Me.gbGender.TabStop = False
        Me.gbGender.Text = "Jenis Kelamin"
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(20, 35)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(107, 32)
        Me.rbLaki.TabIndex = 0
        Me.rbLaki.Text = "Laki-laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(150, 35)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(137, 32)
        Me.rbPerempuan.TabIndex = 1
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'gbHobi
        '
        Me.gbHobi.Controls.Add(Me.chkHobi10)
        Me.gbHobi.Controls.Add(Me.chkHobi9)
        Me.gbHobi.Controls.Add(Me.chkHobi8)
        Me.gbHobi.Controls.Add(Me.chkHobi7)
        Me.gbHobi.Controls.Add(Me.chkHobi6)
        Me.gbHobi.Controls.Add(Me.chkHobi5)
        Me.gbHobi.Controls.Add(Me.chkHobi4)
        Me.gbHobi.Controls.Add(Me.chkHobi3)
        Me.gbHobi.Controls.Add(Me.chkHobi2)
        Me.gbHobi.Controls.Add(Me.chkHobi1)
        Me.gbHobi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.gbHobi.Location = New System.Drawing.Point(730, 80)
        Me.gbHobi.Name = "gbHobi"
        Me.gbHobi.Size = New System.Drawing.Size(300, 350)
        Me.gbHobi.TabIndex = 15
        Me.gbHobi.TabStop = False
        Me.gbHobi.Text = "Pilih Hobi (Bisa Lebih Dari 1)"
        '
        'chkHobi1
        '
        Me.chkHobi1.AutoSize = True
        Me.chkHobi1.Location = New System.Drawing.Point(20, 40)
        Me.chkHobi1.Name = "chkHobi1"
        Me.chkHobi1.Size = New System.Drawing.Size(123, 32)
        Me.chkHobi1.TabIndex = 0
        Me.chkHobi1.Text = "Membaca"
        '
        'chkHobi2
        '
        Me.chkHobi2.AutoSize = True
        Me.chkHobi2.Location = New System.Drawing.Point(20, 80)
        Me.chkHobi2.Name = "chkHobi2"
        Me.chkHobi2.Size = New System.Drawing.Size(107, 32)
        Me.chkHobi2.TabIndex = 1
        Me.chkHobi2.Text = "Menulis"
        '
        'chkHobi3
        '
        Me.chkHobi3.AutoSize = True
        Me.chkHobi3.Location = New System.Drawing.Point(20, 120)
        Me.chkHobi3.Name = "chkHobi3"
        Me.chkHobi3.Size = New System.Drawing.Size(117, 32)
        Me.chkHobi3.TabIndex = 2
        Me.chkHobi3.Text = "Olahraga"
        '
        'chkHobi4
        '
        Me.chkHobi4.AutoSize = True
        Me.chkHobi4.Location = New System.Drawing.Point(20, 160)
        Me.chkHobi4.Name = "chkHobi4"
        Me.chkHobi4.Size = New System.Drawing.Size(120, 32)
        Me.chkHobi4.TabIndex = 3
        Me.chkHobi4.Text = "Berenang"
        '
        'chkHobi5
        '
        Me.chkHobi5.AutoSize = True
        Me.chkHobi5.Location = New System.Drawing.Point(20, 200)
        Me.chkHobi5.Name = "chkHobi5"
        Me.chkHobi5.Size = New System.Drawing.Size(91, 32)
        Me.chkHobi5.TabIndex = 4
        Me.chkHobi5.Text = "Musik"
        '
        'chkHobi6
        '
        Me.chkHobi6.AutoSize = True
        Me.chkHobi6.Location = New System.Drawing.Point(160, 40)
        Me.chkHobi6.Name = "chkHobi6"
        Me.chkHobi6.Size = New System.Drawing.Size(106, 32)
        Me.chkHobi6.TabIndex = 5
        Me.chkHobi6.Text = "Gaming"
        '
        'chkHobi7
        '
        Me.chkHobi7.AutoSize = True
        Me.chkHobi7.Location = New System.Drawing.Point(160, 80)
        Me.chkHobi7.Name = "chkHobi7"
        Me.chkHobi7.Size = New System.Drawing.Size(115, 32)
        Me.chkHobi7.TabIndex = 6
        Me.chkHobi7.Text = "Traveling"
        '
        'chkHobi8
        '
        Me.chkHobi8.AutoSize = True
        Me.chkHobi8.Location = New System.Drawing.Point(160, 120)
        Me.chkHobi8.Name = "chkHobi8"
        Me.chkHobi8.Size = New System.Drawing.Size(120, 32)
        Me.chkHobi8.TabIndex = 7
        Me.chkHobi8.Text = "Memasak"
        '
        'chkHobi9
        '
        Me.chkHobi9.AutoSize = True
        Me.chkHobi9.Location = New System.Drawing.Point(160, 160)
        Me.chkHobi9.Name = "chkHobi9"
        Me.chkHobi9.Size = New System.Drawing.Size(118, 32)
        Me.chkHobi9.TabIndex = 8
        Me.chkHobi9.Text = "Fotografi"
        '
        'chkHobi10
        '
        Me.chkHobi10.AutoSize = True
        Me.chkHobi10.Location = New System.Drawing.Point(160, 200)
        Me.chkHobi10.Name = "chkHobi10"
        Me.chkHobi10.Size = New System.Drawing.Size(117, 32)
        Me.chkHobi10.TabIndex = 9
        Me.chkHobi10.Text = "Otomotif"
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(40, 410)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(200, 50)
        Me.btnCetak.TabIndex = 13
        Me.btnCetak.Text = "Cetak Kartu"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1080, 500)
        Me.Controls.Add(Me.LabelJudul)
        Me.Controls.Add(Me.gbHobi)
        Me.Controls.Add(Me.gbGender)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.dtpTanggal)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNomor)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblTanggal)
        Me.Controls.Add(Me.lblNomor)
        Me.Controls.Add(Me.lblUmur)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Pendaftaran"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGender.ResumeLayout(False)
        Me.gbGender.PerformLayout()
        Me.gbHobi.ResumeLayout(False)
        Me.gbHobi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNomor As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents btnCetak As Button
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents chkHobi1 As CheckBox
    Friend WithEvents chkHobi10 As CheckBox
    Friend WithEvents chkHobi9 As CheckBox
    Friend WithEvents chkHobi8 As CheckBox
    Friend WithEvents chkHobi7 As CheckBox
    Friend WithEvents chkHobi6 As CheckBox
    Friend WithEvents chkHobi5 As CheckBox
    Friend WithEvents chkHobi4 As CheckBox
    Friend WithEvents chkHobi3 As CheckBox
    Friend WithEvents chkHobi2 As CheckBox
    Friend WithEvents LabelJudul As Label

End Class