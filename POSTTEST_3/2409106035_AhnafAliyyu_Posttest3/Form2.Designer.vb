<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PanelCard = New Panel()
        lblValInfo = New Label()
        lblValAlamat = New Label()
        lblValTanggal = New Label()
        lblValNomor = New Label()
        lblValUmur = New Label()
        lblValNama = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBoxFoto = New PictureBox()
        LabelHeader = New Label()
        PanelCard.SuspendLayout()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelCard
        ' 
        PanelCard.BackColor = Color.White
        PanelCard.BorderStyle = BorderStyle.FixedSingle
        PanelCard.Controls.Add(lblValInfo)
        PanelCard.Controls.Add(lblValAlamat)
        PanelCard.Controls.Add(lblValTanggal)
        PanelCard.Controls.Add(lblValNomor)
        PanelCard.Controls.Add(lblValUmur)
        PanelCard.Controls.Add(lblValNama)
        PanelCard.Controls.Add(Label6)
        PanelCard.Controls.Add(Label5)
        PanelCard.Controls.Add(Label4)
        PanelCard.Controls.Add(Label3)
        PanelCard.Controls.Add(Label2)
        PanelCard.Controls.Add(Label1)
        PanelCard.Controls.Add(PictureBoxFoto)
        PanelCard.Controls.Add(LabelHeader)
        PanelCard.Location = New Point(30, 30)
        PanelCard.Name = "PanelCard"
        PanelCard.Size = New Size(700, 360)
        PanelCard.TabIndex = 0
        ' 
        ' lblValInfo
        ' 
        lblValInfo.Font = New Font("Segoe UI", 10.0F)
        lblValInfo.Location = New Point(390, 280)
        lblValInfo.Name = "lblValInfo"
        lblValInfo.Size = New Size(290, 60)
        lblValInfo.TabIndex = 13
        lblValInfo.Text = "-"
        ' 
        ' lblValAlamat
        ' 
        lblValAlamat.AutoSize = True
        lblValAlamat.Font = New Font("Segoe UI", 10.0F)
        lblValAlamat.Location = New Point(390, 240)
        lblValAlamat.Name = "lblValAlamat"
        lblValAlamat.Size = New Size(20, 28)
        lblValAlamat.TabIndex = 12
        lblValAlamat.Text = "-"
        ' 
        ' lblValTanggal
        ' 
        lblValTanggal.AutoSize = True
        lblValTanggal.Font = New Font("Segoe UI", 10.0F)
        lblValTanggal.Location = New Point(390, 200)
        lblValTanggal.Name = "lblValTanggal"
        lblValTanggal.Size = New Size(20, 28)
        lblValTanggal.TabIndex = 11
        lblValTanggal.Text = "-"
        ' 
        ' lblValNomor
        ' 
        lblValNomor.AutoSize = True
        lblValNomor.Font = New Font("Segoe UI", 10.0F)
        lblValNomor.Location = New Point(390, 160)
        lblValNomor.Name = "lblValNomor"
        lblValNomor.Size = New Size(20, 28)
        lblValNomor.TabIndex = 10
        lblValNomor.Text = "-"
        ' 
        ' lblValUmur
        ' 
        lblValUmur.AutoSize = True
        lblValUmur.Font = New Font("Segoe UI", 10.0F)
        lblValUmur.Location = New Point(390, 120)
        lblValUmur.Name = "lblValUmur"
        lblValUmur.Size = New Size(20, 28)
        lblValUmur.TabIndex = 9
        lblValUmur.Text = "-"
        ' 
        ' lblValNama
        ' 
        lblValNama.AutoSize = True
        lblValNama.Font = New Font("Segoe UI", 10.0F)
        lblValNama.Location = New Point(390, 80)
        lblValNama.Name = "lblValNama"
        lblValNama.Size = New Size(20, 28)
        lblValNama.TabIndex = 8
        lblValNama.Text = "-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(240, 280)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 28)
        Label6.TabIndex = 7
        Label6.Text = "Gender/Hobi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label5.ForeColor = Color.DimGray
        Label5.Location = New Point(240, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 28)
        Label5.TabIndex = 6
        Label5.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label4.ForeColor = Color.DimGray
        Label4.Location = New Point(240, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 28)
        Label4.TabIndex = 5
        Label4.Text = "Tgl. Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(240, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 28)
        Label3.TabIndex = 4
        Label3.Text = "No. Telp"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(240, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(240, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 28)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' PictureBoxFoto
        ' 
        PictureBoxFoto.BorderStyle = BorderStyle.FixedSingle
        PictureBoxFoto.Location = New Point(30, 80)
        PictureBoxFoto.Name = "PictureBoxFoto"
        PictureBoxFoto.Size = New Size(180, 240)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxFoto.TabIndex = 1
        PictureBoxFoto.TabStop = False
        ' 
        ' LabelHeader
        ' 
        LabelHeader.BackColor = Color.DarkSlateBlue
        LabelHeader.Dock = DockStyle.Top
        LabelHeader.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        LabelHeader.ForeColor = Color.White
        LabelHeader.Location = New Point(0, 0)
        LabelHeader.Name = "LabelHeader"
        LabelHeader.Size = New Size(698, 50)
        LabelHeader.TabIndex = 0
        LabelHeader.Text = "KARTU ANGGOTA KOMUNITAS"
        LabelHeader.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(760, 420)
        Controls.Add(PanelCard)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form2"
        StartPosition = FormStartPosition.CenterParent
        Text = "Hasil Kartu"
        PanelCard.ResumeLayout(False)
        PanelCard.PerformLayout()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCard As Panel
    Friend WithEvents LabelHeader As Label
    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblValNama As Label
    Friend WithEvents lblValUmur As Label
    Friend WithEvents lblValNomor As Label
    Friend WithEvents lblValTanggal As Label
    Friend WithEvents lblValAlamat As Label
    Friend WithEvents lblValInfo As Label

End Class