Public Class NhaPhanPhoi_BUS
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        dt = NhaPhanPhoi_DAO.gettable()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of NhaPhanPhoi_DTO)
        Dim dt As New List(Of NhaPhanPhoi_DTO)
        dt = NhaPhanPhoi_DAO.getlist()
        Return dt
    End Function
    Public Shared Sub themnhaphanphoi(ByVal nhacc As NhaPhanPhoi_DTO)
        NhaPhanPhoi_DAO.themnhaphanphoi(nhacc)
    End Sub
    Public Shared Sub capnhatnhaphanphoi(ByVal nhacc As NhaPhanPhoi_DTO)
        NhaPhanPhoi_DAO.capnhatnhaphanphoi(nhacc)
    End Sub
    Public Shared Sub xoanhaphanphoi(ByVal nhacc As Integer)
        NhaPhanPhoi_DAO.xoanhaphanphoi(nhacc)
    End Sub

End Class
