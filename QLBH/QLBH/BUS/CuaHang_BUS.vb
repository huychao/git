Public Class CuaHang_BUS
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        dt = CuaHang_DAO.gettable()
        Return dt
    End Function
    Public Shared Function gettable2() As DataTable
        Dim dt As New DataTable()
        dt = CuaHang_DAO.gettable2()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of CuaHang_DTO)
        Dim dt As New List(Of CuaHang_DTO)
        dt = CuaHang_DAO.getlist()
        Return dt
    End Function
    Public Shared Sub themcuahang(ByVal cc As CuaHang_DTO)
        CuaHang_DAO.themcuahang(cc)
    End Sub
    Public Shared Sub capnhatcuahang(ByVal cc As CuaHang_DTO)
        CuaHang_DAO.capnhatcuahang(cc)
    End Sub
    Public Shared Sub xoacuahang(ByVal cc As Integer)
        CuaHang_DAO.xoacuahang(cc)
    End Sub
End Class
