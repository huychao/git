Public Class BoPhan_DTO
    Private id_BoPhan As Integer
    Public Property Id_BP() As Integer
        Get
            Return id_BoPhan
        End Get
        Set(ByVal value As Integer)
            id_BoPhan = value
        End Set
    End Property
    Private maBoPhan As String
    Public Property MaBP() As String
        Get
            Return maBoPhan
        End Get
        Set(ByVal value As String)
            maBoPhan = value
        End Set
    End Property
    Private tenBoPhan As String
    Public Property TenBP() As String
        Get
            Return tenBoPhan
        End Get
        Set(ByVal value As String)
            tenBoPhan = value
        End Set
    End Property

End Class
