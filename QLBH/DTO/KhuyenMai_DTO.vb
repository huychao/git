Public Class KhuyenMai_DTO
    Private id_KhuyenMai As Integer
    Public Property Id_KM() As Integer
        Get
            Return id_KhuyenMai
        End Get
        Set(ByVal value As Integer)
            id_KhuyenMai = value
        End Set
    End Property
    Private soDiemTuongUng As Integer
    Public Property SoDiem() As Integer
        Get
            Return soDiemTuongUng
        End Get
        Set(ByVal value As Integer)
            soDiemTuongUng = value
        End Set
    End Property
    Private tiLe As Integer
    Public Property TiLeGiam() As Integer
        Get
            Return tiLe
        End Get
        Set(ByVal value As Integer)
            tiLe = value
        End Set
    End Property
End Class
