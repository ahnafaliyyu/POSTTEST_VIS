Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "123" Then
            MessageBox.Show("Selamat datang, Admin Gudang!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Me.Hide()
        ElseIf txtUsername.Text = "user" And txtPassword.Text = "123" Then
            MessageBox.Show("Selamat datang, Pengguna!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()

        Else
            MessageBox.Show("Username atau Password salah!", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Clear()
            txtPassword.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub
End Class