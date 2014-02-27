Public Class NhaPhanPhoi_DTO
    Private id_NhaPhanPhoi As Integer
    Public Property Id_NPP() As Integer
        Get
            Return id_NhaPhanPhoi
        End Get
        Set(ByVal value As Integer)
            id_NhaPhanPhoi = value
        End Set
    End Property
    Private maNhaPhanPhoi As String
    Public Property MaNPP() As String
        Get
            Return maNhaPhanPhoi
        End Get
        Set(ByVal value As String)
            maNhaPhanPhoi = value
        End Set
    End Property
    Private tenNhaPhanPhoi As String
    Public Property TenNPP() As String
        Get
            Return tenNhaPhanPhoi
        End Get
        Set(ByVal value As String)
            tenNhaPhanPhoi = value
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
    Private id_NhaSanXuat As Integer
    Public Property Id_NSX() As Integer
        Get
            Return id_NhaSanXuat
        End Get
        Set(ByVal value As Integer)
            id_NhaSanXuat = value
        End Set
    End Property
    Private _id_KV As Integer
    Public Property Id_KV() As Integer
        Get
            Return _id_KV
        End Get
        Set(ByVal value As Integer)
            _id_KV = value
        End Set
    End Property

End Class
