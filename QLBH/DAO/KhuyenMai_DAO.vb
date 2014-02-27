Imports System.Data.SqlClient

Public Class KhuyenMai_DAO
    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuyenMai_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of KhuyenMai_DTO)
        Dim ls As New List(Of KhuyenMai_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuyenMai_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New KhuyenMai_DTO
            da.Id_KM = cusor("Id_KM")
            da.SoDiem = cusor("SoDiem")
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
    Public Shared Sub themkhuyenmai(ByVal khuyenmai As KhuyenMai_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuyenMai_insert"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn

        Dim para As New SqlParameter("@SoDiem", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = khuyenmai.SoDiem
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TiLeGiam", SqlDbType.Int)
        para2.Direction = ParameterDirection.Input
        para2.Value = khuyenmai.TiLeGiam
        cmd.Parameters.Add(para2)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub capnhatkhuyenmai(ByVal khuyenmai As KhuyenMai_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuyenMai_update"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn

        Dim para As New SqlParameter("@SoDiem", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = khuyenmai.SoDiem
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TiLeGiam", SqlDbType.Int)
        para2.Direction = ParameterDirection.Input
        para2.Value = khuyenmai.TiLeGiam
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@ID_KM", SqlDbType.Int)
        para3.Direction = ParameterDirection.Input
        para3.Value = khuyenmai.Id_KM
        cmd.Parameters.Add(para3)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub xoackhuyenmai(ByVal id As Integer)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "KhuyenMai_delete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@ID_KM", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = id
        cmd.Parameters.Add(para)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class
