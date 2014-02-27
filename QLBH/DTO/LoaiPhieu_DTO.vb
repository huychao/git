Public Class LoaiPhieu_DTO
    Private id_LoaiPhieu As Integer
    Public Property Id_LP() As Integer
        Get
            Return id_LoaiPhieu
        End Get
        Set(ByVal value As Integer)
            id_LoaiPhieu = value
        End Set
    End Property
    Private maLoaiPhieu As String
    Public Property MaLP() As String
        Get
            Return maLoaiPhieu
        End Get
        Set(ByVal value As String)
            maLoaiPhieu = value
        End Set
    End Property
    Private tenLoaiPhieu As String
    Public Property TenLP() As String
        Get
            Return tenLoaiPhieu
        End Get
        Set(ByVal value As String)
            tenLoaiPhieu = value
        End Set
    End Property

End Class
