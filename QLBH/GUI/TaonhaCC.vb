Public Class TaonhaCC

    Private Sub TaonhaCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub thoat_Click(sender As Object, e As EventArgs) Handles thoat.Click
        Me.Close()
    End Sub

    Private Sub buttonsuachuanhacungcap_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonthemnhacungcap_Click(sender As Object, e As EventArgs) Handles buttonthemnhacungcap.Click
        Dim nhacc As New NhaPhanPhoi_DTO
        nhacc.MaNPP = "CC" + textmanhacc.Text
        nhacc.TenNPP = texttennhaphanphoi.Text
        nhacc.Sdt = textsdt.Text
        nhacc.DiaChi = textdiachi.Text
        nhacc.Id_KV = "KV2"
        nhacc.Id_CH = 1
        nhacc.Id_NSX = 1
        NhaPhanPhoi_DAO.themnhaphanphoi(nhacc)
    End Sub
End Class