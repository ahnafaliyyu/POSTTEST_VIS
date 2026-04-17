Public Class Form2
    Private Sub TampilData()
        dgvBarang.DataSource = DataModule.GetAllBarang()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        dgvBarang.ReadOnly = True
        dgvBarang.AllowUserToAddRows = False
        dgvBarang.AllowUserToDeleteRows = False
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dgvBarang.DataSource = DataModule.SearchBarang(txtSearch.Text.Trim())
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Keluar dari Akun Pengguna?", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            FormLogin.Show()
            Me.Close()
        End If
    End Sub
End Class