Public Class SearchInfoForm
    Public ds As DataTable
    Dim kh As New KhachHang_BUS
    Dim nv As New NhanVien_BUS

    Public Delegate Sub Search()
    Public Event SearchResult As Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim kh As New KhachHang_BUS()
        If rbName.Checked Then
            kh.check = 1
        Else
            kh.check = 0
        End If
        If txtKeyWord.Text <> Nothing Then
            ds = kh.SearchCustomer(txtKeyWord.Text)
        Else
            ds = kh.SearchAllCustomer(txtKeyWord.Text)
        End If
        With ds
            .Columns(0).ColumnName = "STT"
            .Columns(1).ColumnName = "Họ tên"
            .Columns(2).ColumnName = "Số điện thoại"
            .Columns(3).ColumnName = "Điểm tích lũy"
            .Columns(4).ColumnName = "Địa chỉ liên lạc"
        End With
        If ds.Rows.Count <> 0 Then
            RaiseEvent SearchResult()
        Else : MessageBox.Show("Thông tin không tồn tại")
        End If
    End Sub

    Private Sub SearchInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class