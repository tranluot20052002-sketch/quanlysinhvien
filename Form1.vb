Public Class Form1
    Private Sub mnu_Thoat_Click(sender As Object, e As EventArgs) Handles Mnu_Thoat.Click
        If MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub mnu_TKe_Click(sender As Object, e As EventArgs) Handles Mnu_Tke.Click
        Dim f As New formTKe
        f.ShowDialog()
    End Sub
    Private Sub mnu_SV_Click(sender As Object, e As EventArgs) Handles Mnu_SV.Click
        Dim f As New formSV
        f.ShowDialog()
    End Sub

    Private Sub mnu_MH_Click(sender As Object, e As EventArgs) Handles Mnu_MH.Click
        Dim f As New formMH
        f.ShowDialog()
    End Sub

    Private Sub mnu_Diem_Click(sender As Object, e As EventArgs) Handles Mnu_Diem.Click
        Dim f As New formDiem
        f.ShowDialog()
    End Sub

End Class
