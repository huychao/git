Imports System.Data.SqlClient

Public Class SanPhamDaBan_DAO
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SanPhamDaBan_select"
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
        cmd.CommandText = "SanPhamDaBan_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of SanPhamDaBan_DTO)
        Dim ls As New List(Of SanPhamDaBan_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SanPhamDaBan_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New SanPhamDaBan_DTO
            da.id_SPBan = cusor("Id_SPBan")
            da.SoLuong = cusor("SoLuong")
            da.DonGia = cusor("DonGia")
            da.ThanhTien = cusor("ThanhTien")
            da.Id_SP = cusor("Id_SP")
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
    Public Shared Sub themsanphamdaban(ByVal sanphamdaban As SanPhamDaBan_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SanPhamDaBan_insert"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@SoLuong", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = sanphamdaban.SoLuong
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@DonGia", SqlDbType.Int)
        para2.Direction = ParameterDirection.Input
        para2.Value = sanphamdaban.DonGia
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ThanhTien", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = sanphamdaban.ThanhTien
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@ID_SP", SqlDbType.Int)
        para4.Direction = ParameterDirection.Input
        para4.Value = sanphamdaban.Id_SP
        cmd.Parameters.Add(para4)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub capnhatsanphamdaban(ByVal sanphamdaban As SanPhamDaBan_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SanPhamDaBan_update"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@SoLuong", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = sanphamdaban.SoLuong
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@DonGia", SqlDbType.Int)
        para2.Direction = ParameterDirection.Input
        para2.Value = sanphamdaban.DonGia
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ThanhTien", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = sanphamdaban.ThanhTien
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@ID_SP", SqlDbType.Int)
        para4.Direction = ParameterDirection.Input
        para4.Value = sanphamdaban.Id_SP
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@ID_SPBan", SqlDbType.Int)
        para5.Direction = ParameterDirection.Input
        para5.Value = sanphamdaban.Id_SP
        cmd.Parameters.Add(para5)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub xoasanphamdaban(ByVal ID As Integer)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "SanPhamDaBan_delete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@ID_SPBan", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = ID
        cmd.Parameters.Add(para)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class
