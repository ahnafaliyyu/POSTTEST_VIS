Public Class Form1
    Dim judulHapus As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTampil.ColumnCount = 2
        dgvTampil.Columns(0).Name = "Judul"
        dgvTampil.Columns(1).Name = "Genre"
        dgvTampil.AllowUserToAddRows = False
    End Sub

    Private Sub TambahBukuKeArray(ByVal judulBaru As String, ByVal genreBaru As String)
        If JumlahBuku < 100 Then
            DaftarBuku(JumlahBuku).Judul = judulBaru
            DaftarBuku(JumlahBuku).Genre = genreBaru
            JumlahBuku += 1
        Else
            MessageBox.Show("Kapasitas penyimpanan buku penuh!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Function CariIndexBuku(ByVal judulDicari As String) As Integer
        For i As Integer = 0 To JumlahBuku - 1
            If DaftarBuku(i).Judul.ToLower() = judulDicari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub RefreshDataGrid()
        dgvTampil.Rows.Clear()
        For i As Integer = 0 To JumlahBuku - 1
            dgvTampil.Rows.Add(DaftarBuku(i).Judul, DaftarBuku(i).Genre)
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Judul dan Genre harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        TambahBukuKeArray(txtJudul.Text, txtGenre.Text)

        RefreshDataGrid()
        txtJudul.Clear()
        txtGenre.Clear()
        txtJudul.Focus()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulHapus As String = txtJudul2.Text

        If judulHapus = "" Then
            MessageBox.Show("Masukkan judul buku yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim indeks As Integer = CariIndexBuku(judulHapus)

        If indeks <> -1 Then
            For i As Integer = indeks To JumlahBuku - 2
                DaftarBuku(i) = DaftarBuku(i + 1)
            Next

            DaftarBuku(JumlahBuku - 1) = New Buku()
            JumlahBuku -= 1

            MessageBox.Show("Buku berhasil dihapus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshDataGrid()
            txtJudul2.Clear()
        Else
            MessageBox.Show("Buku tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class