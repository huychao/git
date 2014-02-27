Imports System.Data.SqlClient

Public Class Khuvuc_DAO
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuVuc_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of KhuVuc_DTO)
        Dim ls As New List(Of KhuVuc_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuVuc_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New KhuVuc_DTO
            da.ID_KV = cusor("Id_KV")
            da.Ten = cusor("Ten")
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
    Public Shared Sub themkhuvuc(ByVal khuvuc As KhuVuc_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuVuc_insert"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn

        Dim para As New SqlParameter("@Ma", SqlDbType.Char, 3)
        para.Direction = ParameterDirection.Input
        para.Value = khuvuc.Ma
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@Ten", SqlDbType.NVarChar, 20)
        para2.Direction = ParameterDirection.Input
        para2.Value = khuvuc.Ten
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@TrucThuoc", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = khuvuc.TrucThuoc
        cmd.Parameters.Add(para3)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub updatekhuvuc(ByVal khuvuc As KhuVuc_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuVuc_update"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn

        Dim para As New SqlParameter("@Ma", SqlDbType.Char, 3)
        para.Direction = ParameterDirection.Input
        para.Value = khuvuc.Ma
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@Ten", SqlDbType.NVarChar, 20)
        para2.Direction = ParameterDirection.Input
        para2.Value = khuvuc.Ten
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@TrucThuoc", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = khuvuc.TrucThuoc
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@ID_KV", SqlDbType.Int)
        para4.Direction = ParameterDirection.Input
        para4.Value = khuvuc.ID_KV
        cmd.Parameters.Add(para4)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub xoackhuvuc(ByVal id As Integer)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuVuc_delete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@ID_KV", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = ID
        cmd.Parameters.Add(para)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class
