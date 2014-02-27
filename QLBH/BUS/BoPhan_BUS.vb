Public Class BoPhan_BUS
    Public Shared Function getlist() As List(Of BoPhan_DTO)
        Dim dt As New List(Of BoPhan_DTO)
        dt = BoPhan_DAO.getlist()
        Return dt
    End Function
End Class
