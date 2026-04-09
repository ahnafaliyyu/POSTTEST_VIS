Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiInput(ep As ErrorProvider, ctrl As Control, pesan As String) As Boolean
        If ctrl.Text.Trim() = "" Then
            ep.SetError(ctrl, pesan)
            Return False
        Else
            ep.SetError(ctrl, "")
            Return True
        End If
    End Function

    Public Function ValidasiBarangSembako(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, cbKat As ComboBox, txtStok As TextBox, cbSat As ComboBox, txtHrg As TextBox) As Boolean
        Dim vKode = ValidasiInput(ep, txtKode, "Kode Barang wajib diisi")
        Dim vNama = ValidasiInput(ep, txtNama, "Nama Barang wajib diisi")
        Dim vKat = ValidasiInput(ep, cbKat, "Kategori wajib dipilih")
        Dim vStok = ValidasiInput(ep, txtStok, "Stok wajib diisi")
        Dim vSat = ValidasiInput(ep, cbSat, "Satuan wajib dipilih")
        Dim vHrg = ValidasiInput(ep, txtHrg, "Harga wajib diisi")

        Return vKode And vNama And vKat And vStok And vSat And vHrg
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function
End Module