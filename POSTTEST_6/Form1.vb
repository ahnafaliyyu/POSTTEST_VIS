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
        dgvBarang.DataSource = DataModule.GetAllBarang()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiBarangSembako(ErrorProvider1, txtKodeBarang, txtNamaBarang, cbKategori, txtStok, cbSatuan, txtHarga) Then Exit Sub

        If DataModule.SimpanBarang(txtKodeBarang.Text, txtNamaBarang.Text, cbKategori.Text, Val(txtStok.Text), cbSatuan.Text, Val(txtHarga.Text)) Then
            MessageBox.Show("Data Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If DataModule.UbahBarang(txtKodeBarang.Text, txtNamaBarang.Text, cbKategori.Text, Val(txtStok.Text), cbSatuan.Text, Val(txtHarga.Text)) Then
            MessageBox.Show("Data Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DataModule.HapusBarang(txtKodeBarang.Text)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Keluar dari Akun Admin?", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FormLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvBarang.DataSource = DataModule.SearchBarang(txtSearch.Text)
    End Sub

    Private Sub dgvBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBarang.CellClick
        If e.RowIndex >= 0 Then
            txtKodeBarang.Text = dgvBarang.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamaBarang.Text = dgvBarang.Rows(e.RowIndex).Cells(1).Value.ToString()
            cbKategori.Text = dgvBarang.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtStok.Text = dgvBarang.Rows(e.RowIndex).Cells(3).Value.ToString()
            cbSatuan.Text = dgvBarang.Rows(e.RowIndex).Cells(4).Value.ToString()
            txtHarga.Text = dgvBarang.Rows(e.RowIndex).Cells(5).Value.ToString()
            txtKodeBarang.ReadOnly = True
        End If
    End Sub
End Class