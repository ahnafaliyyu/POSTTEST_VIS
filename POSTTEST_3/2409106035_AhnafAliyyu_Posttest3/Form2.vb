Public Class Form2

    Public Sub New(foto As Image, nama As String, umur As String, nomor As String, tglLahir As String, alamat As String, infoGabungan As String)

        InitializeComponent()

        If foto IsNot Nothing Then
            PictureBoxFoto.Image = foto
        End If

        lblValNama.Text = ": " & nama.ToUpper()
        lblValUmur.Text = ": " & umur & " Tahun"
        lblValNomor.Text = ": " & nomor
        lblValTanggal.Text = ": " & tglLahir
        lblValAlamat.Text = ": " & alamat
        lblValInfo.Text = ": " & infoGabungan

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class