Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module DataModule
    Public Function GetAllBarang() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kode_barang, nama_barang, kategori, stok, satuan, harga FROM tb_barang ORDER BY kode_barang ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchBarang(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tb_barang WHERE kode_barang LIKE @keyword OR nama_barang LIKE @keyword ORDER BY kode_barang ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetBarangByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tb_barang WHERE kode_barang = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_barang WHERE kode_barang = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanBarang(kode As String, nama As String, kategori As String, stok As Integer, satuan As String, harga As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_barang (kode_barang, nama_barang, kategori, stok, satuan, harga) VALUES (@kode, @nama, @kategori, @stok, @satuan, @harga)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kategori", kategori)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@satuan", satuan)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahBarang(kode As String, nama As String, kategori As String, stok As Integer, satuan As String, harga As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tb_barang SET nama_barang = @nama, kategori = @kategori, stok = @stok, satuan = @satuan, harga = @harga WHERE kode_barang = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kategori", kategori)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@satuan", satuan)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusBarang(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_barang WHERE kode_barang = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try


    End Function
    ' ==========================================
    ' FUNGSI UNTUK TABEL TRANSAKSI (FORM 2)
    ' ==========================================

    Public Function GetAllTransaksi() As DataTable
        Dim dt As New DataTable()
        Try
            ' INNER JOIN untuk menggabungkan tabel transaksi dan tabel barang
            Dim query As String = "SELECT tb_transaksi.kode_transaksi, tb_barang.nama_barang AS 'Nama Barang', " &
                                  "tb_transaksi.tanggal, tb_transaksi.jumlah_masuk, tb_transaksi.supplier, tb_transaksi.keterangan " &
                                  "FROM tb_transaksi " &
                                  "INNER JOIN tb_barang ON tb_transaksi.kode_barang = tb_barang.kode_barang " &
                                  "ORDER BY tb_transaksi.kode_transaksi ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchTransaksi(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT tb_transaksi.kode_transaksi, tb_barang.nama_barang AS 'Nama Barang', " &
                                  "tb_transaksi.tanggal, tb_transaksi.jumlah_masuk, tb_transaksi.supplier, tb_transaksi.keterangan " &
                                  "FROM tb_transaksi " &
                                  "INNER JOIN tb_barang ON tb_transaksi.kode_barang = tb_barang.kode_barang " &
                                  "WHERE tb_transaksi.kode_transaksi LIKE @keyword OR tb_barang.nama_barang LIKE @keyword OR tb_transaksi.supplier LIKE @keyword " &
                                  "ORDER BY tb_transaksi.kode_transaksi ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeTransaksiSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_transaksi WHERE kode_transaksi = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanTransaksi(kode As String, kode_brg As String, tgl As Date, jumlah As Integer, supplier As String, ket As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_transaksi (kode_transaksi, kode_barang, tanggal, jumlah_masuk, supplier, keterangan) " &
                                  "VALUES (@kode, @kode_brg, @tgl, @jumlah, @supplier, @ket)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kode_brg", kode_brg)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@supplier", supplier)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahTransaksi(kode As String, kode_brg As String, tgl As Date, jumlah As Integer, supplier As String, ket As String) As Boolean
        Try
            Dim query As String = "UPDATE tb_transaksi SET kode_barang = @kode_brg, tanggal = @tgl, jumlah_masuk = @jumlah, " &
                                  "supplier = @supplier, keterangan = @ket WHERE kode_transaksi = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@kode_brg", kode_brg)
                    cmd.Parameters.AddWithValue("@tgl", tgl)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@supplier", supplier)
                    cmd.Parameters.AddWithValue("@ket", ket)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTransaksi(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_transaksi WHERE kode_transaksi = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module