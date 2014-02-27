Public Class NhaSanXuatt_DTO
    Private id_NhaSanXuat As Integer
    Public Property Id_NSX() As Integer
        Get
            Return id_NhaSanXuat
        End Get
        Set(ByVal value As Integer)
            id_NhaSanXuat = value
        End Set
    End Property
    Private maNhaSanXuat As String
    Public Property MaNSX() As String
        Get
            Return maNhaSanXuat
        End Get
        Set(ByVal value As String)
            maNhaSanXuat = value
        End Set
    End Property
    Private tenNhaSanXuat As String
    Public Property TenNSX() As String
        Get
            Return tenNhaSanXuat
        End Get
        Set(ByVal value As String)
            tenNhaSanXuat = value
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
    Private id_CuaHang As Integer
    Public Property Id_CH() As Integer
        Get
            Return id_CuaHang
        End Get
        Set(ByVal value As Integer)
            id_CuaHang = value
        End Set
    End Property
    Private id_NhaPhanPhoi As Integer
    Public Property Id_NPP() As Integer
        Get
            Return id_NhaPhanPhoi
        End Get
        Set(ByVal value As Integer)
            id_NhaPhanPhoi = value
        End Set
    End Property

End Class
