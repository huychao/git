Public Class PhieuHang_DTO
    Private _id_P As Integer
    Public Property Id_P() As Integer
        Get
            Return _id_P
        End Get
        Set(ByVal value As Integer)
            _id_P = value
        End Set
    End Property
    Private _maPhieu As String
    Public Property MaPhieu() As String
        Get
            Return _maPhieu
        End Get
        Set(ByVal value As String)
            _maPhieu = value
        End Set
    End Property
    Private _id_SP As String
    Public Property ID_SP() As Integer
        Get
            Return _id_SP
        End Get
        Set(ByVal value As Integer)
            _id_SP = value
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
