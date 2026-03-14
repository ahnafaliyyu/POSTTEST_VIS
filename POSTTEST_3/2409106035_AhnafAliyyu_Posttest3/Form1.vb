Imports System.IO

Public Class Form1

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNomor.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim hobiList As New List(Of String)
        For Each ctrl As Control In gbHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    hobiList.Add(chk.Text)
                End If
            End If
        Next

        If String.IsNullOrWhiteSpace(txtNama.Text) OrElse
           String.IsNullOrWhiteSpace(txtUmur.Text) OrElse
           String.IsNullOrWhiteSpace(txtNomor.Text) OrElse
           String.IsNullOrWhiteSpace(txtAlamat.Text) OrElse
           (Not rbLaki.Checked AndAlso Not rbPerempuan.Checked) OrElse
           hobiList.Count = 0 OrElse
           PictureBox1.Image Is Nothing Then

            MessageBox.Show("Inputan tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim gender As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")
        Dim hobiTerpilih As String = String.Join(", ", hobiList)
        Dim tgl As String = dtpTanggal.Value.ToString("dd MMMM yyyy")

        Dim frmHasil As New Form2(PictureBox1.Image, txtNama.Text, txtUmur.Text, txtNomor.Text, tgl, txtAlamat.Text, gender & " / " & hobiTerpilih)
        frmHasil.ShowDialog()
    End Sub

End Class