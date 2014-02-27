Public Class SanPhamDaBan_BUS
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        dt = SanPhamDaBan_DAO.gettable()
        Return dt
    End Function
    Public Shared Function gettable2() As DataTable
        Dim dt As New DataTable()
        dt = SanPhamDaBan_DAO.gettable2()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of SanPhamDaBan_DTO)
        Dim dt As New List(Of SanPhamDaBan_DTO)
        dt = SanPhamDaBan_DAO.getlist()
        Return dt
    End Function
    Public Shared Sub themsaphamdaban(ByVal cc As SanPhamDaBan_DTO)
        SanPhamDaBan_DAO.themsanphamdaban(cc)
    End Sub
    Public Shared Sub capnhatsanphamdaban(ByVal cc As SanPhamDaBan_DTO)
        SanPhamDaBan_DAO.capnhatsanphamdaban(cc)
    End Sub
    Public Shared Sub xoasanphamdaban(ByVal cc As Integer)
        SanPhamDaBan_DAO.xoasanphamdaban(cc)
    End Sub
End Class
