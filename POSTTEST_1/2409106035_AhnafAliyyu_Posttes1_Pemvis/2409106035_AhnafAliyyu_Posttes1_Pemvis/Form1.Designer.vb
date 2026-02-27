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
        lblStatus = New Label()
        lblIpkum = New Label()
        lblIpsem = New Label()
        txtIp = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        txtTotal = New TextBox()
        SuspendLayout()
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(347, 292)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(108, 25)
        lblStatus.TabIndex = 0
        lblStatus.Text = "memuaskan"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIpkum
        ' 
        lblIpkum.AutoSize = True
        lblIpkum.Location = New Point(202, 232)
        lblIpkum.Name = "lblIpkum"
        lblIpkum.Size = New Size(107, 25)
        lblIpkum.TabIndex = 1
        lblIpkum.Text = "IP Kumulatif"
        lblIpkum.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblIpsem
        ' 
        lblIpsem.AutoSize = True
        lblIpsem.Location = New Point(204, 148)
        lblIpsem.Name = "lblIpsem"
        lblIpsem.Size = New Size(105, 25)
        lblIpsem.TabIndex = 2
        lblIpsem.Text = "IP Semester"
        lblIpsem.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtIp
        ' 
        txtIp.Location = New Point(366, 156)
        txtIp.Name = "txtIp"
        txtIp.Size = New Size(255, 31)
        txtIp.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(366, 193)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(509, 193)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(366, 233)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(255, 31)
        txtTotal.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtTotal)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIp)
        Controls.Add(lblIpsem)
        Controls.Add(lblIpkum)
        Controls.Add(lblStatus)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStatus As Label
    Friend WithEvents lblIpkum As Label
    Friend WithEvents lblIpsem As Label
    Friend WithEvents txtIp As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtTotal As TextBox

End Class
