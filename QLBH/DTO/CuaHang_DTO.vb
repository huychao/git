Public Class CuaHang_DTO
    Private id_CuaHang As Integer
    Public Property Id_CH() As Integer
        Get
            Return id_CuaHang
        End Get
        Set(ByVal value As Integer)
            id_CuaHang = value
        End Set
    End Property
    Private maCuaHang As String
    Public Property MaCH() As String
        Get
            Return maCuaHang
        End Get
        Set(ByVal value As String)
            maCuaHang = value
        End Set
    End Property
    Private tenCuaHang As String
    Public Property TenCH() As String
        Get
            Return tenCuaHang
        End Get
        Set(ByVal value As String)
            tenCuaHang = value
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
    Private id_NhaCungCap As Integer
    Public Property Id_NCC() As Integer
        Get
            Return id_NhaCungCap
        End Get
        Set(ByVal value As Integer)
            id_NhaCungCap = value
        End Set
    End Property

End Class
