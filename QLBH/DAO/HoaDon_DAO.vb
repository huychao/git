Imports System.Data.SqlClient

Public Class HoaDon_DAO
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "HoaDon_select"
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
        cmd.CommandText = "HoaDon_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of HoaDon_DTO)
        Dim ls As New List(Of HoaDon_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "HoaDon_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New HoaDon_DTO
            da.Id_HD = cusor("Id_HD")
            da.MaHD = cusor("MaHD")
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
    Public Shared Sub updatehoadon(ByVal hoadon As HoaDon_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "HoaDon_update"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        
        Dim para As New SqlParameter("@MaHD", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = hoadon.MaHD
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TongTien", SqlDbType.Int)
        para2.Direction = ParameterDirection.Input
        para2.Value = hoadon.TongTien
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ID_KH", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = hoadon.Id_KH
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@ID_NV", SqlDbType.Int)
        para4.Direction = ParameterDirection.Input
        para4.Value = hoadon.Id_NV
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@ID_SPBan", SqlDbType.NChar, 12)
        para5.Direction = ParameterDirection.Input
        para5.Value = hoadon.Id_SPBan
        cmd.Parameters.Add(para5)

        Dim para8 As New SqlParameter("@ID_HD", SqlDbType.Int)
        para8.Direction = ParameterDirection.Input
        para8.Value = hoadon.MaHD
        cmd.Parameters.Add(para8)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub themhoadon(ByVal hoadon As HoaDon_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "HoaDon_insert"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@MaHD", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = hoadon.MaHD
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TongTien", SqlDbType.Int)
        para2.Direction = ParameterDirection.Input
        para2.Value = hoadon.TongTien
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ID_KH", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = hoadon.Id_KH
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@ID_NV", SqlDbType.Int)
        para4.Direction = ParameterDirection.Input
        para4.Value = hoadon.Id_NV
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@ID_SPBan", SqlDbType.NChar, 12)
        para5.Direction = ParameterDirection.Input
        para5.Value = hoadon.Id_SPBan
        cmd.Parameters.Add(para5)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    
    Public Shared Sub xoahoadon(ByVal hoadon As Integer)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "HoaDon_delete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@ID_HD", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = hoadon
        cmd.Parameters.Add(para)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class

