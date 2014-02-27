Public Class KhachHang_BUS
    Public check As Integer
    Public Function SearchCustomer(ByVal keyWord As String) As DataTable
        Return KhachHang_DAO.SearchCustomer(keyWord, check)
    End Function
    Public Function SearchAllCustomer(ByVal keyWord As String) As DataTable
        Return KhachHang_DAO.SearchAllCustomer(keyWord)
    End Function
End Class
