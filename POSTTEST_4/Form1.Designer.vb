<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblJudul = New Label()
        PicLogo = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        cbKomunitas = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        dtpLahir = New DateTimePicker()
        txtUmur = New TextBox()
        txtID = New TextBox()
        txtNama = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        txtEmail = New TextBox()
        mtbTelepon = New MaskedTextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TabPage3 = New TabPage()
        btnCetak = New Button()
        gbHobi = New GroupBox()
        chk8 = New CheckBox()
        chk7 = New CheckBox()
        chk6 = New CheckBox()
        chk5 = New CheckBox()
        chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        gbPeran = New GroupBox()
        rbAnggota = New RadioButton()
        rbAdmin = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        PicProfil = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbHobi.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(PicProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(10, 4, 0, 4)
        MenuStrip1.Size = New Size(973, 37)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(112, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(111, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(130, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(108, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(76, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(150, 77)
        lblJudul.Margin = New Padding(5, 0, 5, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(682, 45)
        lblJudul.TabIndex = 1
        lblJudul.Text = "APLIKASI PEMBUATAN KARTU KOMUNITAS"
        ' 
        ' PicLogo
        ' 
        PicLogo.BackColor = Color.LightGray
        PicLogo.Location = New Point(33, 67)
        PicLogo.Margin = New Padding(5, 6, 5, 6)
        PicLogo.Name = "PicLogo"
        PicLogo.Size = New Size(83, 96)
        PicLogo.TabIndex = 2
        PicLogo.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(33, 192)
        TabControl1.Margin = New Padding(5, 6, 5, 6)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(900, 654)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(cbKomunitas)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(dtpLahir)
        TabPage1.Controls.Add(txtUmur)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Margin = New Padding(5, 6, 5, 6)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(5, 6, 5, 6)
        TabPage1.Size = New Size(892, 616)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' cbKomunitas
        ' 
        cbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cbKomunitas.FormattingEnabled = True
        cbKomunitas.Items.AddRange(New Object() {"Divisi IT", "Divisi Seni", "Divisi Olahraga", "Divisi Humas"})
        cbKomunitas.Location = New Point(250, 442)
        cbKomunitas.Margin = New Padding(5, 6, 5, 6)
        cbKomunitas.Name = "cbKomunitas"
        cbKomunitas.Size = New Size(331, 33)
        cbKomunitas.TabIndex = 12
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(400, 365)
        rbPerempuan.Margin = New Padding(5, 6, 5, 6)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(126, 29)
        rbPerempuan.TabIndex = 11
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(250, 365)
        rbLaki.Margin = New Padding(5, 6, 5, 6)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(114, 29)
        rbLaki.TabIndex = 10
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' dtpLahir
        ' 
        dtpLahir.Location = New Point(250, 288)
        dtpLahir.Margin = New Padding(5, 6, 5, 6)
        dtpLahir.Name = "dtpLahir"
        dtpLahir.Size = New Size(331, 31)
        dtpLahir.TabIndex = 9
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(250, 212)
        txtUmur.Margin = New Padding(5, 6, 5, 6)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(331, 31)
        txtUmur.TabIndex = 8
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(250, 135)
        txtID.Margin = New Padding(5, 6, 5, 6)
        txtID.Name = "txtID"
        txtID.Size = New Size(331, 31)
        txtID.TabIndex = 7
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(250, 58)
        txtNama.Margin = New Padding(5, 6, 5, 6)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(331, 31)
        txtNama.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 448)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 25)
        Label6.TabIndex = 5
        Label6.Text = "Divisi / Kategori"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 369)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 25)
        Label5.TabIndex = 4
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(33, 300)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 3
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(33, 217)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 25)
        Label3.TabIndex = 2
        Label3.Text = "Umur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 140)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 25)
        Label2.TabIndex = 1
        Label2.Text = "ID Anggota"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 63)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 0
        Label1.Text = "Nama Lengkap"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label7)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(5, 6, 5, 6)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(5, 6, 5, 6)
        TabPage2.Size = New Size(892, 616)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(250, 212)
        txtAlamat.Margin = New Padding(5, 6, 5, 6)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(414, 112)
        txtAlamat.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(250, 135)
        txtEmail.Margin = New Padding(5, 6, 5, 6)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(331, 31)
        txtEmail.TabIndex = 4
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(250, 58)
        mtbTelepon.Margin = New Padding(5, 6, 5, 6)
        mtbTelepon.Mask = "0000-0000-00000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(331, 31)
        mtbTelepon.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(33, 217)
        Label9.Margin = New Padding(5, 0, 5, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(68, 25)
        Label9.TabIndex = 2
        Label9.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(33, 140)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(54, 25)
        Label8.TabIndex = 1
        Label8.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(33, 63)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 25)
        Label7.TabIndex = 0
        Label7.Text = "Nomor Telepon"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnCetak)
        TabPage3.Controls.Add(gbHobi)
        TabPage3.Controls.Add(gbPeran)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(PicProfil)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Margin = New Padding(5, 6, 5, 6)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(892, 616)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.LightGreen
        btnCetak.Location = New Point(33, 500)
        btnCetak.Margin = New Padding(5, 6, 5, 6)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(817, 77)
        btnCetak.TabIndex = 4
        btnCetak.Text = "SIMPAN & CETAK KARTU"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(chk8)
        gbHobi.Controls.Add(chk7)
        gbHobi.Controls.Add(chk6)
        gbHobi.Controls.Add(chk5)
        gbHobi.Controls.Add(chk4)
        gbHobi.Controls.Add(chk3)
        gbHobi.Controls.Add(chk2)
        gbHobi.Controls.Add(chk1)
        gbHobi.Location = New Point(233, 231)
        gbHobi.Margin = New Padding(5, 6, 5, 6)
        gbHobi.Name = "gbHobi"
        gbHobi.Padding = New Padding(5, 6, 5, 6)
        gbHobi.Size = New Size(617, 231)
        gbHobi.TabIndex = 3
        gbHobi.TabStop = False
        gbHobi.Text = "Pilih Minat / Aktivitas"
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(333, 173)
        chk8.Margin = New Padding(5, 6, 5, 6)
        chk8.Name = "chk8"
        chk8.Size = New Size(95, 29)
        chk8.TabIndex = 7
        chk8.Text = "Koding"
        chk8.UseVisualStyleBackColor = True
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(167, 173)
        chk7.Margin = New Padding(5, 6, 5, 6)
        chk7.Name = "chk7"
        chk7.Size = New Size(102, 29)
        chk7.TabIndex = 6
        chk7.Text = "Bermain"
        chk7.UseVisualStyleBackColor = True
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(33, 173)
        chk6.Margin = New Padding(5, 6, 5, 6)
        chk6.Name = "chk6"
        chk6.Size = New Size(94, 29)
        chk6.TabIndex = 5
        chk6.Text = "Diskusi"
        chk6.UseVisualStyleBackColor = True
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(333, 115)
        chk5.Margin = New Padding(5, 6, 5, 6)
        chk5.Name = "chk5"
        chk5.Size = New Size(91, 29)
        chk5.TabIndex = 4
        chk5.Text = "Desain"
        chk5.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(167, 115)
        chk4.Margin = New Padding(5, 6, 5, 6)
        chk4.Name = "chk4"
        chk4.Size = New Size(111, 29)
        chk4.TabIndex = 3
        chk4.Text = "Fotografi"
        chk4.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(33, 115)
        chk3.Margin = New Padding(5, 6, 5, 6)
        chk3.Name = "chk3"
        chk3.Size = New Size(85, 29)
        chk3.TabIndex = 2
        chk3.Text = "Musik"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(167, 58)
        chk2.Margin = New Padding(5, 6, 5, 6)
        chk2.Name = "chk2"
        chk2.Size = New Size(99, 29)
        chk2.TabIndex = 1
        chk2.Text = "Menulis"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(33, 58)
        chk1.Margin = New Padding(5, 6, 5, 6)
        chk1.Name = "chk1"
        chk1.Size = New Size(116, 29)
        chk1.TabIndex = 0
        chk1.Text = "Membaca"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(233, 38)
        gbPeran.Margin = New Padding(5, 6, 5, 6)
        gbPeran.Name = "gbPeran"
        gbPeran.Padding = New Padding(5, 6, 5, 6)
        gbPeran.Size = New Size(617, 154)
        gbPeran.TabIndex = 2
        gbPeran.TabStop = False
        gbPeran.Text = "Pilih Peran"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(367, 58)
        rbAnggota.Margin = New Padding(5, 6, 5, 6)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(107, 29)
        rbAnggota.TabIndex = 2
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(200, 58)
        rbAdmin.Margin = New Padding(5, 6, 5, 6)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(90, 29)
        rbAdmin.TabIndex = 1
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(33, 58)
        rbKetua.Margin = New Padding(5, 6, 5, 6)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(81, 29)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(33, 288)
        btnBrowse.Margin = New Padding(5, 6, 5, 6)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(167, 48)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' PicProfil
        ' 
        PicProfil.BackColor = Color.WhiteSmoke
        PicProfil.BorderStyle = BorderStyle.FixedSingle
        PicProfil.Location = New Point(33, 38)
        PicProfil.Margin = New Padding(5, 6, 5, 6)
        PicProfil.Name = "PicProfil"
        PicProfil.Size = New Size(165, 229)
        PicProfil.SizeMode = PictureBoxSizeMode.StretchImage
        PicProfil.TabIndex = 0
        PicProfil.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.Filter = "Text Files|*.txt|CSV Files|*.csv"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(973, 887)
        Controls.Add(TabControl1)
        Controls.Add(PicLogo)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(5, 6, 5, 6)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Input Komunitas"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PicLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(PicProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblJudul As Label
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents cbKomunitas As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PicProfil As PictureBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class