Public Class Form1
    Private Sub Kosong()
        txtKodeBarang.Clear()
        txtNamaBarang.Clear()
        cbKategori.SelectedIndex = -1
        txtStok.Clear()
        cbSatuan.SelectedIndex = -1
        txtHarga.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()

        txtKodeBarang.ReadOnly = False
        txtKodeBarang.Focus()
    End Sub

    Private Sub TampilData()
        dgvBarang.DataSource = GetAllBarang()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiBarangSembako(ErrorProvider1, txtKodeBarang, txtNamaBarang, cbKategori, txtStok, cbSatuan, txtHarga) Then Exit Sub

        Dim kode As String = txtKodeBarang.Text.Trim()
        Dim nama As String = txtNamaBarang.Text.Trim()
        Dim kategori As String = cbKategori.Text.Trim()
        Dim stok As Integer = Convert.ToInt32(txtStok.Text.Trim())
        Dim satuan As String = cbSatuan.Text.Trim()
        Dim harga As Integer = Convert.ToInt32(txtHarga.Text.Trim())

        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Barang sudah terdaftar di Gudang", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeBarang.Focus()
            Exit Sub
        End If

        If SimpanBarang(kode, nama, kategori, stok, satuan, harga) Then
            MessageBox.Show("Data Barang Sembako berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiBarangSembako(ErrorProvider1, txtKodeBarang, txtNamaBarang, cbKategori, txtStok, cbSatuan, txtHarga) Then Exit Sub

        Dim kode As String = txtKodeBarang.Text.Trim()
        Dim nama As String = txtNamaBarang.Text.Trim()
        Dim kategori As String = cbKategori.Text.Trim()
        Dim stok As Integer = Convert.ToInt32(txtStok.Text.Trim())
        Dim satuan As String = cbSatuan.Text.Trim()
        Dim harga As Integer = Convert.ToInt32(txtHarga.Text.Trim())

        If UbahBarang(kode, nama, kategori, stok, satuan, harga) Then
            MessageBox.Show("Data Gudang berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan atau tidak ada perubahan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeBarang.Text.Trim() = "" Then
            MessageBox.Show("Pilih data barang yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeBarang.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah barang " & txtNamaBarang.Text & " ingin dihapus dari gudang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            If HapusBarang(txtKodeBarang.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        If e.RowIndex >= 0 Then
            txtKodeBarang.Text = dgvBarang.Rows(e.RowIndex).Cells("kode_barang").Value.ToString()
            txtNamaBarang.Text = dgvBarang.Rows(e.RowIndex).Cells("nama_barang").Value.ToString()
            cbKategori.Text = dgvBarang.Rows(e.RowIndex).Cells("kategori").Value.ToString()
            txtStok.Text = dgvBarang.Rows(e.RowIndex).Cells("stok").Value.ToString()
            cbSatuan.Text = dgvBarang.Rows(e.RowIndex).Cells("satuan").Value.ToString()
            txtHarga.Text = dgvBarang.Rows(e.RowIndex).Cells("harga").Value.ToString()

            txtKodeBarang.ReadOnly = True
        End If
    End Sub

    Private Sub txtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStok.KeyPress, txtHarga.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvBarang.DataSource = SearchBarang(txtSearch.Text.Trim())
        End If
    End Sub
End Class