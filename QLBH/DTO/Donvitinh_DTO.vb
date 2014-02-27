Public Class Donvitinh_DTO
    Private _id_DVT As String
    Public Property Id_DVT() As String
        Get
            Return _id_DVT
        End Get
        Set(ByVal value As String)
            _id_DVT = value
        End Set
    End Property
    Private _tenDVT As String
    Public Property TenDVT() As String
        Get
            Return _tenDVT
        End Get
        Set(ByVal value As String)
            _tenDVT = value
        End Set
    End Property
End Class
