<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        lblGenre = New Label()
        txtJudul = New TextBox()
        txtGenre = New TextBox()
        btnTambah = New Button()
        lblJudul2 = New Label()
        txtJudul2 = New TextBox()
        btnHapus = New Button()
        dgvTampil = New DataGridView()
        CType(dgvTampil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(47, 34)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(53, 25)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Judul"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Location = New Point(49, 135)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(58, 25)
        lblGenre.TabIndex = 1
        lblGenre.Text = "Genre"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(187, 28)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(150, 31)
        txtJudul.TabIndex = 2
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(187, 129)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(150, 31)
        txtGenre.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(187, 232)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' lblJudul2
        ' 
        lblJudul2.AutoSize = True
        lblJudul2.Location = New Point(525, 34)
        lblJudul2.Name = "lblJudul2"
        lblJudul2.Size = New Size(53, 25)
        lblJudul2.TabIndex = 5
        lblJudul2.Text = "Judul"
        ' 
        ' txtJudul2
        ' 
        txtJudul2.Location = New Point(616, 28)
        txtJudul2.Name = "txtJudul2"
        txtJudul2.Size = New Size(150, 31)
        txtJudul2.TabIndex = 6
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(612, 154)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' dgvTampil
        ' 
        dgvTampil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTampil.Location = New Point(364, 213)
        dgvTampil.Name = "dgvTampil"
        dgvTampil.RowHeadersWidth = 62
        dgvTampil.Size = New Size(360, 225)
        dgvTampil.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgvTampil)
        Controls.Add(btnHapus)
        Controls.Add(txtJudul2)
        Controls.Add(lblJudul2)
        Controls.Add(btnTambah)
        Controls.Add(txtGenre)
        Controls.Add(txtJudul)
        Controls.Add(lblGenre)
        Controls.Add(lblJudul)
        Name = "Form1"
        Text = "Form1"
        CType(dgvTampil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblJudul2 As Label
    Friend WithEvents txtJudul2 As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvTampil As DataGridView

End Class
