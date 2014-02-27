Imports System.Data.SqlClient

Public Class NhanVien_DAO
    'Đăng nhập
    Public Shared Function Login(ByVal nv As NhanVien_DTO, ByVal check As Integer) As Integer
        check = NhanVien_BUS.check
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        Dim sqlCmd As New SqlCommand("usp_Login", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure

        Dim para1 As New SqlParameter("uname", SqlDbType.VarChar, 10)
        para1.Direction = ParameterDirection.Input
        para1.Value = nv.MaNV
        sqlCmd.Parameters.Add(para1)

        Dim para2 As New SqlParameter("pas", SqlDbType.VarChar, 30)
        para2.Direction = ParameterDirection.Input
        para2.Value = nv.Password
        sqlCmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("outRes", SqlDbType.Int)
        para3.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("check", SqlDbType.Int)
        para4.Direction = ParameterDirection.Input
        para4.Value = check
        sqlCmd.Parameters.Add(para4)

        conn.Open()
        sqlCmd.ExecuteNonQuery()
        conn.Close()

        Return Integer.Parse(para3.Value.ToString())
    End Function

    'Phân quyền sau khi đăng nhập
    Public Shared Function Login_Grant(ByVal nv As NhanVien_DTO) As Integer
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        Dim sqlCmd As New SqlCommand("usp_Login_Grant", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure

        Dim para1 As New SqlParameter("uname", SqlDbType.VarChar, 10)
        para1.Direction = ParameterDirection.Input
        para1.Value = nv.MaNV
        sqlCmd.Parameters.Add(para1)

        Dim para2 As New SqlParameter("pas", SqlDbType.VarChar, 30)
        para2.Direction = ParameterDirection.Input
        para2.Value = nv.Password
        sqlCmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("outRes", SqlDbType.Int)
        para3.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(para3)

        conn.Open()
        sqlCmd.ExecuteNonQuery()
        conn.Close()

        Return Integer.Parse(para3.Value.ToString())
    End Function

    'Đăng nhập với tài khoản đã nhớ trước đó
    Public Shared Function Login_CallPass(ByVal uname As String) As String
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        Dim sqlCmd As New SqlCommand("usp_CallPass", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure

        Dim para As New SqlParameter("uname", SqlDbType.VarChar, 10)
        para.Direction = ParameterDirection.Input
        para.Value = uname
        sqlCmd.Parameters.Add(para)

        Dim para1 As New SqlParameter("pas", SqlDbType.VarChar, 30)
        para1.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(para1)

        conn.Open()
        sqlCmd.ExecuteNonQuery()
        conn.Close()

        Return para1.Value.ToString()
    End Function

    'Đổi mật khẩu
    Public Shared Function ChangePas(ByVal nv As NhanVien_DTO, ByVal newPas As String, ByVal again As String) As Integer
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        Dim sqlCmd As New SqlCommand("usp_ChangePas", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure

        Dim para1 As New SqlParameter("maNV", SqlDbType.VarChar, 10)
        para1.Direction = ParameterDirection.Input
        para1.Value = nv.MaNV
        sqlCmd.Parameters.Add(para1)

        Dim para2 As New SqlParameter("old", SqlDbType.VarChar, 30)
        para2.Direction = ParameterDirection.Input
        para2.Value = nv.Password
        sqlCmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("newPas", SqlDbType.VarChar, 30)
        para3.Direction = ParameterDirection.Input
        para3.Value = newPas
        sqlCmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("again", SqlDbType.VarChar, 30)
        para4.Direction = ParameterDirection.Input
        para4.Value = again
        sqlCmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("test", SqlDbType.Int)
        para5.Direction = ParameterDirection.Output
        sqlCmd.Parameters.Add(para5)

        conn.Open()
        sqlCmd.ExecuteNonQuery()
        conn.Close()

        Return Integer.Parse(para5.Value.ToString())
    End Function
    'Thông tin nhân viên
    Public Function Info(ByVal maNV As String) As DataTable
        Dim dt As New DataTable

        Dim conn As New SqlConnection(DataProvider.GetConnString())
        Dim sqlCmd As New SqlCommand("usp_StaffInfo", conn)
        sqlCmd.CommandType = CommandType.StoredProcedure

        Dim para1 As New SqlParameter("maNV", SqlDbType.VarChar, 10)
        para1.Direction = ParameterDirection.Input
        para1.Value = maNV
        sqlCmd.Parameters.Add(para1)

        Dim da As New SqlDataAdapter(sqlCmd)
        da.Fill(dt)

        conn.Open()
        sqlCmd.ExecuteNonQuery()
        conn.Close()

        Return dt
    End Function

    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "Nhanvien_select"
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
        cmd.CommandText = "Nhanvien_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of NhanVien_DTO)
        Dim ls As New List(Of NhanVien_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "CuaHang_select"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim cusor As SqlDataReader
        cusor = cmd.ExecuteReader()
        While (cusor.Read)
            Dim da As New NhanVien_DTO
            da.Id_NV = cusor("Id_NV")
            da.MaNV = cusor("MaNV")
            da.TenNV = cusor("TenNV")
            ls.Add(da)
        End While
        cusor.Close()
        conn.Close()
        Return ls
    End Function
    Public Shared Sub themnhanvien(ByVal nhanvien As NhanVien_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "Nhanvien_insert"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@MaNV", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = nhanvien.MaNV
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TenNV", SqlDbType.NVarChar, 50)
        para2.Direction = ParameterDirection.Input
        para2.Value = nhanvien.TenNV
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@CMND", SqlDbType.Char, 10)
        para3.Direction = ParameterDirection.Input
        para3.Value = nhanvien.CMND
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@Ngaysinh", SqlDbType.Date)
        para4.Direction = ParameterDirection.Input
        para4.Value = nhanvien.NgaySinh
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@GioiTinh", SqlDbType.NVarChar, 3)
        para5.Direction = ParameterDirection.Input
        para5.Value = nhanvien.GioiTinh
        cmd.Parameters.Add(para5)

        Dim para6 As New SqlParameter("@Diachi", SqlDbType.NVarChar, 50)
        para6.Direction = ParameterDirection.Input
        para6.Value = nhanvien.DiaChi
        cmd.Parameters.Add(para6)

        Dim para7 As New SqlParameter("@Sdt", SqlDbType.NChar, 12)
        para7.Direction = ParameterDirection.Input
        para7.Value = nhanvien.Sdt
        cmd.Parameters.Add(para7)

        Dim para8 As New SqlParameter("@ID_BP", SqlDbType.Int)
        para8.Direction = ParameterDirection.Input
        para8.Value = nhanvien.Id_BP
        cmd.Parameters.Add(para8)

        Dim para9 As New SqlParameter("@ID_CH", SqlDbType.Int)
        para9.Direction = ParameterDirection.Input
        para9.Value = nhanvien.Id_CH
        cmd.Parameters.Add(para9)

        Dim para10 As New SqlParameter("@Pword", SqlDbType.VarChar, 30)
        para10.Direction = ParameterDirection.Input
        para10.Value = nhanvien.Password
        cmd.Parameters.Add(para10)

        Dim para11 As New SqlParameter("@MaNVQL", SqlDbType.VarChar, 50)
        para11.Direction = ParameterDirection.Input
        para11.Value = nhanvien.MaNVQL
        cmd.Parameters.Add(para11)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub capnhatnhanvien(ByVal nhanvien As NhanVien_DTO)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "Nhanvien_update"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@MaNV", SqlDbType.VarChar, 50)
        para.Direction = ParameterDirection.Input
        para.Value = nhanvien.MaNV
        cmd.Parameters.Add(para)

        Dim para2 As New SqlParameter("@TenNV", SqlDbType.NVarChar, 50)
        para2.Direction = ParameterDirection.Input
        para2.Value = nhanvien.TenNV
        cmd.Parameters.Add(para2)

        Dim para3 As New SqlParameter("@CMND", SqlDbType.Char, 10)
        para3.Direction = ParameterDirection.Input
        para3.Value = nhanvien.CMND
        cmd.Parameters.Add(para3)

        Dim para4 As New SqlParameter("@Ngaysinh", SqlDbType.Date)
        para4.Direction = ParameterDirection.Input
        para4.Value = nhanvien.NgaySinh
        cmd.Parameters.Add(para4)

        Dim para5 As New SqlParameter("@GioiTinh", SqlDbType.NVarChar, 3)
        para5.Direction = ParameterDirection.Input
        para5.Value = nhanvien.GioiTinh
        cmd.Parameters.Add(para5)

        Dim para6 As New SqlParameter("@Diachi", SqlDbType.NVarChar, 50)
        para6.Direction = ParameterDirection.Input
        para6.Value = nhanvien.DiaChi
        cmd.Parameters.Add(para6)

        Dim para7 As New SqlParameter("@Sdt", SqlDbType.NChar, 12)
        para7.Direction = ParameterDirection.Input
        para7.Value = nhanvien.Sdt
        cmd.Parameters.Add(para7)

        Dim para8 As New SqlParameter("@ID_BP", SqlDbType.Int)
        para8.Direction = ParameterDirection.Input
        para8.Value = nhanvien.Id_BP
        cmd.Parameters.Add(para8)

        Dim para9 As New SqlParameter("@ID_CH", SqlDbType.Int)
        para9.Direction = ParameterDirection.Input
        para9.Value = nhanvien.Id_CH
        cmd.Parameters.Add(para9)

        Dim para10 As New SqlParameter("@Pword", SqlDbType.VarChar, 30)
        para10.Direction = ParameterDirection.Input
        para10.Value = nhanvien.Password
        cmd.Parameters.Add(para10)

        Dim para11 As New SqlParameter("@MaNVQL", SqlDbType.VarChar, 50)
        para11.Direction = ParameterDirection.Input
        para11.Value = nhanvien.MaNVQL
        cmd.Parameters.Add(para11)

        Dim para12 As New SqlParameter("@ID_NV", SqlDbType.Int)
        para12.Direction = ParameterDirection.Input
        para12.Value = nhanvien.Id_NV
        cmd.Parameters.Add(para12)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Shared Sub xoanhanvien(ByVal ID As Integer)
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "Nhanvien_delete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        Dim para As New SqlParameter("@ID_NV", SqlDbType.Int)
        para.Direction = ParameterDirection.Input
        para.Value = ID
        cmd.Parameters.Add(para)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
End Class
