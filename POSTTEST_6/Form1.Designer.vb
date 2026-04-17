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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKodeBarang = New System.Windows.Forms.TextBox()
        Me.txtNamaBarang = New System.Windows.Forms.TextBox()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.cbSatuan = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvBarang = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        Me.Label1.AutoSize = True : Me.Label1.Location = New System.Drawing.Point(30, 30) : Me.Label1.Text = "Kode Barang"
        Me.Label2.AutoSize = True : Me.Label2.Location = New System.Drawing.Point(30, 65) : Me.Label2.Text = "Nama Barang"
        Me.Label3.AutoSize = True : Me.Label3.Location = New System.Drawing.Point(30, 100) : Me.Label3.Text = "Kategori"
        Me.Label4.AutoSize = True : Me.Label4.Location = New System.Drawing.Point(350, 30) : Me.Label4.Text = "Jumlah Stok"
        Me.Label5.AutoSize = True : Me.Label5.Location = New System.Drawing.Point(350, 65) : Me.Label5.Text = "Satuan"
        Me.Label6.AutoSize = True : Me.Label6.Location = New System.Drawing.Point(350, 100) : Me.Label6.Text = "Harga Beli"
        Me.Label7.AutoSize = True : Me.Label7.Location = New System.Drawing.Point(30, 210) : Me.Label7.Text = "Cari Data Sembako"
        '
        '
        Me.txtKodeBarang.Location = New System.Drawing.Point(120, 27) : Me.txtKodeBarang.Size = New System.Drawing.Size(180, 20)
        Me.txtNamaBarang.Location = New System.Drawing.Point(120, 62) : Me.txtNamaBarang.Size = New System.Drawing.Size(180, 20)
        Me.cbKategori.Location = New System.Drawing.Point(120, 97) : Me.cbKategori.Size = New System.Drawing.Size(180, 21) : Me.cbKategori.Items.AddRange(New Object() {"Beras", "Minyak", "Gula", "Tepung", "Lainnya"})
        Me.txtStok.Location = New System.Drawing.Point(430, 27) : Me.txtStok.Size = New System.Drawing.Size(180, 20)
        Me.cbSatuan.Location = New System.Drawing.Point(430, 62) : Me.cbSatuan.Size = New System.Drawing.Size(180, 21) : Me.cbSatuan.Items.AddRange(New Object() {"Kg", "Liter", "Pcs", "Dus"})
        Me.txtHarga.Location = New System.Drawing.Point(430, 97) : Me.txtHarga.Size = New System.Drawing.Size(180, 20)
        Me.txtSearch.Location = New System.Drawing.Point(140, 207) : Me.txtSearch.Size = New System.Drawing.Size(470, 20)
        '
        '
        Me.btnSimpan.Location = New System.Drawing.Point(120, 140) : Me.btnSimpan.Size = New System.Drawing.Size(80, 35) : Me.btnSimpan.Text = "Simpan"
        Me.btnUbah.Location = New System.Drawing.Point(210, 140) : Me.btnUbah.Size = New System.Drawing.Size(80, 35) : Me.btnUbah.Text = "Ubah"
        Me.btnHapus.Location = New System.Drawing.Point(300, 140) : Me.btnHapus.Size = New System.Drawing.Size(80, 35) : Me.btnHapus.Text = "Hapus"
        Me.btnBatal.Location = New System.Drawing.Point(390, 140) : Me.btnBatal.Size = New System.Drawing.Size(80, 35) : Me.btnBatal.Text = "Batal"

        '
        Me.btnLogout.Location = New System.Drawing.Point(530, 140) : Me.btnLogout.Size = New System.Drawing.Size(80, 35) : Me.btnLogout.Text = "Logout" : Me.btnLogout.BackColor = System.Drawing.Color.LightCoral
        '
        '
        Me.dgvBarang.Location = New System.Drawing.Point(33, 240) : Me.dgvBarang.Size = New System.Drawing.Size(650, 250) : Me.dgvBarang.ReadOnly = True : Me.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        '
        Me.ClientSize = New System.Drawing.Size(714, 521)
        Me.Controls.Add(Me.btnLogout) : Me.Controls.Add(Me.btnBatal) : Me.Controls.Add(Me.btnHapus) : Me.Controls.Add(Me.btnUbah) : Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.dgvBarang) : Me.Controls.Add(Me.txtSearch) : Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHarga) : Me.Controls.Add(Me.cbSatuan) : Me.Controls.Add(Me.txtStok) : Me.Controls.Add(Me.cbKategori) : Me.Controls.Add(Me.txtNamaBarang) : Me.Controls.Add(Me.txtKodeBarang)
        Me.Controls.Add(Me.Label6) : Me.Controls.Add(Me.Label5) : Me.Controls.Add(Me.Label4) : Me.Controls.Add(Me.Label3) : Me.Controls.Add(Me.Label2) : Me.Controls.Add(Me.Label1)
        Me.Text = "Panel Admin Gudang Sembako" : Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents Label1, Label2, Label3, Label4, Label5, Label6, Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKodeBarang, txtNamaBarang, txtStok, txtHarga, txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbKategori, cbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents btnSimpan, btnUbah, btnHapus, btnBatal, btnLogout As System.Windows.Forms.Button
    Friend WithEvents dgvBarang As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class