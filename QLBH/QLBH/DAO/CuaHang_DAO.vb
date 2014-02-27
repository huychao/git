Imports System.Data.SqlClient

Public Class CuaHang_DAO
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function gettable2() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of CuaHang_DTO)
        Dim ls As New List(Of CuaHang_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New CuaHang_DTO
            da.Id_CH = cusor("Id_CH")
            da.TenCH = cusor("TenCH")
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
    Public Shared Sub themcuahang(ByVal cuahang As CuaHang_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_insert"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@MaCH", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = cuahang.MaCH
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TenCH", SqlDbType.NVarChar, 30)
        para2.Direction = ParameterDirection.Input
        para2.Value = cuahang.TenCH
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ID_NCC", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = cuahang.Id_NCC
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@Diachi", SqlDbType.NVarChar, 50)
        para4.Direction = ParameterDirection.Input
        para4.Value = cuahang.DiaChi
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@Sdt", SqlDbType.NChar, 12)
        para5.Direction = ParameterDirection.Input
        para5.Value = cuahang.Sdt
        cmd.Parameters.Add(para5)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub capnhatcuahang(ByVal cuahang As CuaHang_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_update"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para8 As New SqlParameter("@ID_CH", SqlDbType.Int)
        para8.Direction = ParameterDirection.Input
        para8.Value = cuahang.Id_CH
        cmd.Parameters.Add(para8)
        Dim para As New SqlParameter("@MaCH", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = cuahang.MaCH
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TenCH", SqlDbType.NVarChar, 30)
        para2.Direction = ParameterDirection.Input
        para2.Value = cuahang.TenCH
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ID_NCC", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = cuahang.Id_NCC
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@Diachi", SqlDbType.NVarChar, 50)
        para4.Direction = ParameterDirection.Input
        para4.Value = cuahang.DiaChi
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@Sdt", SqlDbType.NChar, 12)
        para5.Direction = ParameterDirection.Input
        para5.Value = cuahang.Sdt
        cmd.Parameters.Add(para5)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub xoacuahang(ByVal ID As Integer)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_delete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@ID_CH", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = ID
        cmd.Parameters.Add(para)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

End Class
