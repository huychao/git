Public Class SanPham_DTO
    Private id_SanPham As Integer
    Public Property Id_SP() As Integer
        Get
            Return id_SanPham
        End Get
        Set(ByVal value As Integer)
            id_SanPham = value
        End Set
    End Property
    Private maSanPham As String
    Public Property MaSP() As String
        Get
            Return maSanPham
        End Get
        Set(ByVal value As String)
            maSanPham = value
        End Set
    End Property
    Private tenSanPham As String
    Public Property TenSP() As String
        Get
            Return tenSanPham
        End Get
        Set(ByVal value As String)
            tenSanPham = value
        End Set
    End Property
    Private d_ngayNhap As Date
    Public Property NgayNhap() As Date
        Get
            Return d_ngayNhap
        End Get
        Set(ByVal value As Date)
            d_ngayNhap = value
        End Set
    End Property
    Private i_soLuongTon As Integer
    Public Property SLTon() As Integer
        Get
            Return i_soLuongTon
        End Get
        Set(ByVal value As Integer)
            i_soLuongTon = value
        End Set
    End Property
    Private i_giaSi As Integer
    Public Property GiaTri() As Integer
        Get
            Return i_giaSi
        End Get
        Set(ByVal value As Integer)
            i_giaSi = value
        End Set
    End Property
    Private i_giaLe As Integer
    Public Property GiaLe() As Integer
        Get
            Return i_giaLe
        End Get
        Set(ByVal value As Integer)
            i_giaLe = value
        End Set
    End Property
    Private id_NhaSanXuat As Integer
    Public Property Id_NSX() As Integer
        Get
            Return id_NhaSanXuat
        End Get
        Set(ByVal value As Integer)
            id_NhaSanXuat = value
        End Set
    End Property

End Class
