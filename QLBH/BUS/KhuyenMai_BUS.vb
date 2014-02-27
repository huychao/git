Public Class KhuyenMai_BUS
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        dt = KhuyenMai_DAO.gettable()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of KhuyenMai_DTO)
        Dim dt As New List(Of KhuyenMai_DTO)
        dt = KhuyenMai_DAO.getlist()
        Return dt
    End Function
    Public Shared Sub themKhuyenmai(ByVal khuyenmai As KhuyenMai_DTO)
        KhuyenMai_DAO.themkhuyenmai(khuyenmai)
    End Sub
    Public Shared Sub capnhatkhuyenmai(ByVal khuyenmai As KhuyenMai_DTO)
        KhuyenMai_DAO.themkhuyenmai(khuyenmai)
    End Sub
    Public Shared Sub xoakhuyenmai(ByVal khuyenmai As Integer)
        KhuyenMai_DAO.xoackhuyenmai(khuyenmai)
    End Sub
End Class
