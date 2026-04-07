Imports System.IO

Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Space)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PicProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
            ErrorProvider1.SetError(btnBrowse, "")
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        ErrorProvider1.Clear()
        Dim isInputValid As Boolean = True

        If txtNama.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            isInputValid = False
        End If

        If txtID.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtID, "Inputan tidak boleh kosong")
            isInputValid = False
        End If

        If txtUmur.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtUmur, "Inputan tidak boleh kosong")
            isInputValid = False
        End If

        If cbKomunitas.Text.Trim() = "" Then
            ErrorProvider1.SetError(cbKomunitas, "Inputan tidak boleh kosong")
            isInputValid = False
        End If

        If txtEmail.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
            isInputValid = False
        End If

        If txtAlamat.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
            isInputValid = False
        End If

        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon, "Format nomor telepon belum lengkap")
            isInputValid = False
        End If

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            ErrorProvider1.SetError(rbPerempuan, "Pilih salah satu jenis kelamin")
            isInputValid = False
        End If

        If Not rbKetua.Checked AndAlso Not rbAdmin.Checked AndAlso Not rbAnggota.Checked Then
            ErrorProvider1.SetError(gbPeran, "Pilih salah satu peran")
            isInputValid = False
        End If

        Dim hobiChecked As Boolean = False
        For Each ctrl As Control In gbHobi.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                hobiChecked = True
                Exit For
            End If
        Next

        If Not hobiChecked Then
            ErrorProvider1.SetError(gbHobi, "Pilih minimal 1 aktivitas / minat")
            isInputValid = False
        End If

        If PicProfil.Image Is Nothing Then
            ErrorProvider1.SetError(btnBrowse, "Foto profil belum ditambahkan")
            isInputValid = False
        End If

        If Not isInputValid Then
            MessageBox.Show("Inputan tidak boleh kosong. Periksa ikon peringatan berwarna merah pada form.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If MessageBox.Show("Apakah Anda yakin ingin mencetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Form2.lblNama.Text = "Nama : " & txtNama.Text
            Form2.lblID.Text = "ID Anggota : " & txtID.Text
            Form2.lblKomunitas.Text = "Divisi : " & cbKomunitas.Text
            Form2.lblKontak.Text = "Kontak : " & mtbTelepon.Text & " / " & txtEmail.Text
            Form2.PicProfilHasil.Image = PicProfil.Image

            Dim strHobi As String = ""
            For Each ctrl As Control In gbHobi.Controls
                If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                    strHobi &= DirectCast(ctrl, CheckBox).Text & ", "
                End If
            Next
            Form2.lblHobi.Text = "Aktivitas : " & strHobi.TrimEnd(","c, " "c)

            Form2.Show()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If Form2.lblNama.Text <> "Nama" Then
            Form2.Show()
        Else
            MessageBox.Show("Anda belum membuat kartu!", "Info")
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim textData As String = $"Nama: {txtNama.Text}{vbCrLf}ID: {txtID.Text}{vbCrLf}Email: {txtEmail.Text}"
            File.WriteAllText(SaveFileDialog1.FileName, textData)
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim openFile As New OpenFileDialog With {.Filter = "Text Files|*.txt"}
        If openFile.ShowDialog() = DialogResult.OK Then
            Dim content As String = File.ReadAllText(openFile.FileName)
            MessageBox.Show(content, "Isi Data")
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class