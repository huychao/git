Public Class HoaDon_DTO
    Private id_HoaDon As Integer
    Public Property Id_HD() As Integer
        Get
            Return id_HoaDon
        End Get
        Set(ByVal value As Integer)
            id_HoaDon = value
        End Set
    End Property
    Private id_KhachHang As Integer
    Public Property Id_KH() As Integer
        Get
            Return id_KhachHang
        End Get
        Set(ByVal value As Integer)
            id_KhachHang = value
        End Set
    End Property
    Private id_NhanVien As Integer
    Public Property Id_NV() As Integer
        Get
            Return id_NhanVien
        End Get
        Set(ByVal value As Integer)
            id_NhanVien = value
        End Set
    End Property
    Private id_SanPhamBan As Integer
    Public Property Id_SPBan() As Integer
        Get
            Return id_SanPhamBan
        End Get
        Set(ByVal value As Integer)
            id_SanPhamBan = value
        End Set
    End Property
    Private maHoaDon As String
    Public Property MaHD() As String
        Get
            Return maHoaDon
        End Get
        Set(ByVal value As String)
            maHoaDon = value
        End Set
    End Property
    Private tongTienPhaiTra As Integer
    Public Property TongTien() As Integer
        Get
            Return tongTienPhaiTra
        End Get
        Set(ByVal value As Integer)
            tongTienPhaiTra = value
        End Set
    End Property
End Class
