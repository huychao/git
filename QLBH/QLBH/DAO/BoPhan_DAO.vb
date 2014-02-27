Imports System.Data.SqlClient

Public Class BoPhan_DAO
    'Public Function LayDanhSachBoPhan() As DataTable
    '    Dim dt As New DataTable()
    '    Dim cn As SqlConnection = DataProvider.ConnectionData()

    '    Dim cmd As New SqlCommand()
    '    cmd.CommandText = "LayDanhSachBoPhan"
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Connection = cn

    '    Dim adapt As New SqlDataAdapter(cmd)
    '    adapt.Fill(dt)
    '    cn.Close()

    '    Return dt
    'End Function
    Public Shared Function getlist() As List(Of BoPhan_DTO)
        Dim ls As New List(Of BoPhan_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "BoPhan_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New BoPhan_DTO
            da.Id_BP = cusor("Id_BP")
            da.MaBP = cusor("MaBP")
            da.TenBP = cusor("TenBP")
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
End Class
