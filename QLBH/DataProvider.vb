Imports System.Data.SqlClient

Public Class DataProvider
    'Shared cn As SqlConnection
    'Private adapt As SqlDataAdapter
    'Private dt As DataTable

    'Shared cnStr As String = "Data Source=(local);Initial Catalog=QLSP;Integrated Security=True"

    'Public Shared Function OpenConnectionData() As SqlConnection
    '    cn = New SqlConnection(cnStr)
    '    Try
    '        cn.Open()
    '    Catch ex As Exception
    '        MessageBox.Show("Lỗi kết nối: " + Chr(10) + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    Return cn
    'End Function
    'Public Shared Sub CloseConnectionData()
    '    If cn Is Nothing Then
    '        If cn.State = cnStr Then
    '            cn.Close()
    '        End If
    '        cn.Dispose()
    '    End If
    'End Sub
    'Public Function ExcecuteQuery_Bool(ByVal sql As String) As Boolean
    '    Dim cmd As New SqlCommand(sql, cn)

    '    Try
    '        cmd.ExecuteNonQuery()
    '        MessageBox.Show("Thao tác thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Return True
    '    Catch ex As Exception
    '        MessageBox.Show("Thao tác thất bại. Lỗi: " + Chr(10) + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question)
    '        Return False
    '    End Try
    'End Function
    'Public Function ExecuteReader_Bool(ByVal sql As String) As Boolean
    '    Dim cmd As New SqlCommand(sql, cn)
    '    Dim dr As SqlDataReader = cmd.ExecuteReader()
    '    If (dr.Read) Then
    '        dr.Close()
    '        Return True
    '    Else
    '        dr.Close()
    '        Return False
    '    End If
    'End Function
    'Public Function ExecuteScalar_String(ByVal sql As String) As String
    '    Dim cmd As New SqlCommand(sql, cn)
    '    Return cmd.ExecuteScalar().ToString()
    'End Function
    'public static SqlConnection ConnectionData()
    '    { 
    '        string cnStr = "Server=kvhgiang-PC\\SQLEXPRESS;Database=QuanLiDuongSat;Trusted_Connection=True";
    '        SqlConnection cn = new SqlConnection(cnStr);
    '        cn.Open();

    '        return cn;
    '    }
    '    public static string getConnectString()
    '    {
    '        string rs = "Server=kvhgiang-PC\\SQLEXPRESS;Database=QuanLiDuongSat;Trusted_Connection=True";

    '        return rs;
    '    }

    Public Shared Function ConnectionData() As SqlConnection
        Dim cnStr As String = "Data Source=Admin-PC0928zsi\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True"
        Dim cn As SqlConnection = New SqlConnection(cnStr)
        cn.Open()
        Return cn
    End Function
    Public Shared Function GetConnString() As String
        Dim rs As String = "Data Source=Admin-PC0928zsi\SQLEXPRESS;Initial Catalog=QLSP;Integrated Security=True"
        Return rs
    End Function
End Class
