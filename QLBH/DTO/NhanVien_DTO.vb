Public Class NhanVien_DTO
    Private id_NhanVien As Integer
    Public Property Id_NV() As Integer
        Get
            Return id_NhanVien
        End Get
        Set(ByVal value As Integer)
            id_NhanVien = value
        End Set
    End Property
    Private maNhanVien As String
    Public Property MaNV() As String
        Get
            Return maNhanVien
        End Get
        Set(ByVal value As String)
            maNhanVien = value
        End Set
    End Property
    Private tenNhanVien As String
    Public Property TenNV() As String
        Get
            Return tenNhanVien
        End Get
        Set(ByVal value As String)
            tenNhanVien = value
        End Set
    End Property
    Private s_cmnd As String
    Public Property CMND() As String
        Get
            Return s_cmnd
        End Get
        Set(ByVal value As String)
            s_cmnd = value
        End Set
    End Property
    Private d_ngaySinh As Date
    Public Property NgaySinh() As Date
        Get
            Return d_ngaySinh
        End Get
        Set(ByVal value As Date)
            d_ngaySinh = value
        End Set
    End Property
    Private s_gioiTinh As String
    Public Property GioiTinh() As String
        Get
            Return s_gioiTinh
        End Get
        Set(ByVal value As String)
            s_gioiTinh = value
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
    Private pw As String
    Public Property Password() As String
        Get
            Return pw
        End Get
        Set(ByVal value As String)
            pw = value
        End Set
    End Property
    Private id_BoPhan As Integer
    Public Property Id_BP() As Integer
        Get
            Return id_BoPhan
        End Get
        Set(ByVal value As Integer)
            id_BoPhan = value
        End Set
    End Property
    Private id_CuaHang As Integer
    Public Property Id_CH() As Integer
        Get
            Return id_CuaHang
        End Get
        Set(ByVal value As Integer)
            id_CuaHang = value
        End Set
    End Property
    Private manhanvienquanly As String
    Public Property MaNVQL() As String
        Get
            Return manhanvienquanly
        End Get
        Set(ByVal value As String)
            manhanvienquanly = value
        End Set
    End Property
End Class
