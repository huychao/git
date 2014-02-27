Public Class KhuVuc_DTO
    Private _id_KV As Integer
    Public Property ID_KV() As Integer
        Get
            Return _id_KV
        End Get
        Set(ByVal value As Integer)
            _id_KV = value
        End Set
    End Property
    Private _ma As Integer
    Public Property Ma() As String
        Get
            Return _ma
        End Get
        Set(ByVal value As String)
            _ma = value
        End Set
    End Property
    Private _ten As Integer
    Public Property Ten() As String
        Get
            Return _ten
        End Get
        Set(ByVal value As String)
            _ten = value
        End Set
    End Property
    Private _trucThuoc As Integer
    Public Property TrucThuoc() As Integer
        Get
            Return _trucThuoc
        End Get
        Set(ByVal value As Integer)
            _trucThuoc = value
        End Set
    End Property
End Class
