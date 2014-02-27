Public Class SanPhamDaBan_DTO
    Private id_SanPhamBan As Integer
    Public Property id_SPBan() As Integer
        Get
            Return id_SanPhamBan
        End Get
        Set(ByVal value As Integer)
            id_SanPhamBan = value
        End Set
    End Property
    Private id_SanPham As Integer
    Public Property Id_SP() As Integer
        Get
            Return id_SanPham
        End Get
        Set(ByVal value As Integer)
            id_SanPham = value
        End Set
    End Property
    Private i_soLuong As Integer
    Public Property SoLuong() As Integer
        Get
            Return i_soLuong
        End Get
        Set(ByVal value As Integer)
            i_soLuong = value
        End Set
    End Property
    Private i_donGia As Integer
    Public Property DonGia() As Integer
        Get
            Return i_donGia
        End Get
        Set(ByVal value As Integer)
            i_donGia = value
        End Set
    End Property
    Private i_thanhTien As Integer
    Public Property ThanhTien() As Integer
        Get
            Return i_thanhTien
        End Get
        Set(ByVal value As Integer)
            i_thanhTien = value
        End Set
    End Property
End Class
