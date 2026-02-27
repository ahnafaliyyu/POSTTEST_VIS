Public Class Form1
    Dim total As Double = 0
    Dim count As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ipSemester As Double

        If Not Double.TryParse(txtIp.Text, ipSemester) Then
            MessageBox.Show("Input harus berupa angka!")
            Return
        End If

        If ipSemester < 0 Or ipSemester > 4 Then
            MessageBox.Show("IP Semester harus diantara 0 - 4")
            Return
        End If

        total += ipSemester
        count += 1

        Dim ipk As Double = total / count

        txtTotal.Text = ipk
        txtIp.Text = ""
        If ipk >= 3.01 Then
            lblStatus.Text = "Sangat Memuaskan"
        ElseIf ipk >= 2.76 Then
            lblStatus.Text = "Memuaskan"
        ElseIf ipk >= 2.0 Then
            lblStatus.Text = "Cukup"
        Else
            lblStatus.Text = "Kurang"
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblStatus.Text = ""
        txtTotal.Text = ""
        total = 0
        count = 0
    End Sub

End Class