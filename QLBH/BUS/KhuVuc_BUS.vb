Public Class KhuVuc_BUS
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        dt = Khuvuc_DAO.gettable()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of KhuVuc_DTO)
        Dim dt As New List(Of KhuVuc_DTO)
        dt = Khuvuc_DAO.getlist()
        Return dt
    End Function
    Public Shared Sub themKhuVuc(ByVal khuvuc As KhuVuc_DTO)
        Khuvuc_DAO.themkhuvuc(khuvuc)
    End Sub
    Public Shared Sub capnhatnhaphanphoi(ByVal khuvuc As KhuVuc_DTO)
        Khuvuc_DAO.updatekhuvuc(khuvuc)
    End Sub
    Public Shared Sub xoanhaphanphoi(ByVal khuvuc As Integer)
        Khuvuc_DAO.xoackhuvuc(khuvuc)
    End Sub
End Class
