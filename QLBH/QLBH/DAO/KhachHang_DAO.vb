Imports System.Data.SqlClient

Public Class KhachHang_DAO
    Public Shared Function SearchCustomer(ByVal keyWord As String, ByVal check As Integer) As DataTable
        Dim dt As New DataTable()

        Dim conn As New SqlConnection(DataProvider.GetConnString())
        Dim sqlCmd As New SqlCommand("usp_SearchCustomer", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure

        Dim para1 As New SqlParameter("keyWord", SqlDbType.NVarChar, 50)
        para1.Direction = ParameterDirection.Input
        para1.Value = keyWord
        sqlCmd.Parameters.Add(para1)

        Dim para2 As New SqlParameter("check", SqlDbType.Int)
        para2.Direction = ParameterDirection.Input
        sqlCmd.Parameters.Add(para2)
        para2.Value = check

        Dim da As New SqlDataAdapter(sqlCmd)
        da.Fill(dt)
        conn.Open()
        sqlCmd.ExecuteNonQuery()
        conn.Close()
        Return dt
    End Function

    Public Shared Function SearchAllCustomer(ByVal keyWord As String) As DataTable
        Dim dt As New DataTable()

        Dim conn As New SqlConnection(DataProvider.GetConnString())
        Dim sqlCmd As New SqlCommand("usp_GetAllCustomer", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure

        Dim da As New SqlDataAdapter(sqlCmd)
        da.Fill(dt)

        conn.Open()
        sqlCmd.ExecuteNonQuery()
        conn.Close()
        Return dt
    End Function
End Class
