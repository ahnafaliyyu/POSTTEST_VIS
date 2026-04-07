<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.PicProfilHasil = New System.Windows.Forms.PictureBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblKomunitas = New System.Windows.Forms.Label()
        Me.lblKontak = New System.Windows.Forms.Label()
        Me.lblHobi = New System.Windows.Forms.Label()
        CType(Me.PicProfilHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicProfilHasil
        '
        Me.PicProfilHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicProfilHasil.Location = New System.Drawing.Point(30, 80)
        Me.PicProfilHasil.Name = "PicProfilHasil"
        Me.PicProfilHasil.Size = New System.Drawing.Size(100, 120)
        Me.PicProfilHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProfilHasil.TabIndex = 0
        Me.PicProfilHasil.TabStop = False
        '
        'LabelTitle
        '
        Me.LabelTitle.BackColor = System.Drawing.Color.Navy
        Me.LabelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(434, 50)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "KARTU IDENTITAS KOMUNITAS"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(150, 80)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(51, 20)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(150, 110)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(20, 17)
        Me.lblID.TabIndex = 3
        Me.lblID.Text = "ID"
        '
        'lblKomunitas
        '
        Me.lblKomunitas.AutoSize = True
        Me.lblKomunitas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKomunitas.Location = New System.Drawing.Point(150, 140)
        Me.lblKomunitas.Name = "lblKomunitas"
        Me.lblKomunitas.Size = New System.Drawing.Size(69, 17)
        Me.lblKomunitas.TabIndex = 4
        Me.lblKomunitas.Text = "Komunitas"
        '
        'lblKontak
        '
        Me.lblKontak.AutoSize = True
        Me.lblKontak.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontak.Location = New System.Drawing.Point(150, 170)
        Me.lblKontak.Name = "lblKontak"
        Me.lblKontak.Size = New System.Drawing.Size(48, 17)
        Me.lblKontak.TabIndex = 5
        Me.lblKontak.Text = "Kontak"
        '
        'lblHobi
        '
        Me.lblHobi.AutoSize = True
        Me.lblHobi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHobi.Location = New System.Drawing.Point(150, 200)
        Me.lblHobi.Name = "lblHobi"
        Me.lblHobi.Size = New System.Drawing.Size(36, 17)
        Me.lblHobi.TabIndex = 6
        Me.lblHobi.Text = "Hobi"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 261)
        Me.Controls.Add(Me.lblHobi)
        Me.Controls.Add(Me.lblKontak)
        Me.Controls.Add(Me.lblKomunitas)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PicProfilHasil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kartu Komunitas"
        CType(Me.PicProfilHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicProfilHasil As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
End Class