Public Class HoaDon_BUS
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        dt = HoaDon_DAO.gettable()
        Return dt
    End Function
    Public Shared Function gettable2() As DataTable
        Dim dt As New DataTable()
        dt = HoaDon_DAO.gettable2()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of HoaDon_DTO)
        Dim dt As New List(Of HoaDon_DTO)
        dt = HoaDon_DAO.getlist()
        Return dt
    End Function
    Public Shared Sub themhoadon(ByVal cc As HoaDon_DTO)
        HoaDon_DAO.themhoadon(cc)
    End Sub
    Public Shared Sub capnhathoadon(ByVal cc As HoaDon_DTO)
        HoaDon_DAO.updatehoadon(cc)
    End Sub
    Public Shared Sub xoahoadon(ByVal cc As Integer)
        HoaDon_DAO.xoahoadon(cc)
    End Sub
End Class
