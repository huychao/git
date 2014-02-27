Imports System.Data.SqlClient
Imports System.Data
Public Class NhaPhanPhoi_DAO
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "nhaCC_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of NhaPhanPhoi_DTO)
        Dim ls As New List(Of NhaPhanPhoi_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "nhaCC_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New NhaPhanPhoi_DTO
            da.Id_NPP = cusor("Id_NCC").ToString()
            da.MaNPP = cusor("MaNCC")
            da.TenNPP = cusor("TenNCC")
            da.Id_CH = cusor("Id_CH").ToString()
            da.DiaChi = cusor("DIachi")
            da.Sdt = cusor("Sdt")
            da.Id_NSX = cusor("Id_NSX").ToString()
            da.Id_KV = cusor("Id_KV").ToString()
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
    Public Shared Sub themnhaphanphoi(ByVal nhacc As NhaPhanPhoi_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "nhaCC_insert"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@MaNCC", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = nhacc.MaNPP
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TenNCC", SqlDbType.NVarChar, 30)
        para2.Direction = ParameterDirection.Input
        para2.Value = nhacc.TenNPP
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ID_CH", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = nhacc.Id_CH
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@Diachi", SqlDbType.NVarChar, 50)
        para4.Direction = ParameterDirection.Input
        para4.Value = nhacc.DiaChi
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@Sdt", SqlDbType.NChar, 12)
        para5.Direction = ParameterDirection.Input
        para5.Value = nhacc.DiaChi
        cmd.Parameters.Add(para5)

        Dim para6 As New SqlParameter("@ID_NSX", SqlDbType.Int)
        para6.Direction = ParameterDirection.Input
        para6.Value = nhacc.Id_NSX
        cmd.Parameters.Add(para6)

        Dim para7 As New SqlParameter("@ID_Khuvuc", SqlDbType.NChar, 3)
        para7.Direction = ParameterDirection.Input
        para7.Value = nhacc.Id_KV
        cmd.Parameters.Add(para7)

        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub capnhatnhaphanphoi(ByVal nhacc As NhaPhanPhoi_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "nhaCC_update"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn

        Dim para8 As New SqlParameter("@ID_NCC", SqlDbType.VarChar, 50)
        para8.Direction = ParameterDirection.Input
        para8.Value = nhacc.MaNPP
        cmd.Parameters.Add(para8)
        Dim para As New SqlParameter("@MaNCC", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = nhacc.MaNPP
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TenNCC", SqlDbType.NVarChar, 30)
        para2.Direction = ParameterDirection.Input
        para2.Value = nhacc.TenNPP
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ID_CH", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = nhacc.Id_CH
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@Diachi", SqlDbType.NVarChar, 50)
        para4.Direction = ParameterDirection.Input
        para4.Value = nhacc.DiaChi
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@Sdt", SqlDbType.NChar, 12)
        para5.Direction = ParameterDirection.Input
        para5.Value = nhacc.DiaChi
        cmd.Parameters.Add(para5)

        Dim para6 As New SqlParameter("@ID_NSX", SqlDbType.Int)
        para6.Direction = ParameterDirection.Input
        para6.Value = nhacc.Id_NSX
        cmd.Parameters.Add(para6)

        Dim para7 As New SqlParameter("@ID_Khuvuc", SqlDbType.NChar, 3)
        para7.Direction = ParameterDirection.Input
        para7.Value = nhacc.Id_KV
        cmd.Parameters.Add(para7)

        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub xoanhaphanphoi(ByVal nhacc As Integer)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "nhaCC_delete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@ID_NCC", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = nhacc
        cmd.Parameters.Add(para)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class
