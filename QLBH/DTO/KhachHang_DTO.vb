Public Class KhachHang_DTO
    Private id_KhachHang As Integer
    Public Property Id_KH() As Integer
        Get
            Return id_KhachHang
        End Get
        Set(ByVal value As Integer)
            id_KhachHang = value
        End Set
    End Property
    Private id_KhuyenMai As Integer
    Public Property Id_KM() As Integer
        Get
            Return id_KhuyenMai
        End Get
        Set(ByVal value As Integer)
            id_KhuyenMai = value
        End Set
    End Property
    Private hoTenKhachHang As String
    Public Property HoTen() As String
        Get
            Return hoTenKhachHang
        End Get
        Set(ByVal value As String)
            hoTenKhachHang = value
        End Set
    End Property
    Private diaChiLienHe As String
    Public Property DiaChi() As String
        Get
            Return diaChiLienHe
        End Get
        Set(ByVal value As String)
            diaChiLienHe = value
        End Set
    End Property
    Private sdtLienHe As String
    Public Property Sdt() As String
        Get
            Return sdtLienHe
        End Get
        Set(ByVal value As String)
            sdtLienHe = value
        End Set
    End Property
    Private diemTichLuy As Integer
    Public Property DiemTL() As Integer
        Get
            Return diemTichLuy
        End Get
        Set(ByVal value As Integer)
            diemTichLuy = value
        End Set
    End Property

End Class
