Imports System.Data.SqlClient

Public Class NhanVien_BUS
    Dim dao As New NhanVien_DAO

    'Thông báo lỗi
    Public wrongPass As String = My.Resources.lbPas
    Public wrongName As String = My.Resources.lbUname
    Public wrongOldPass As String = My.Resources.lbOld
    Public wrongNewPass As String = My.Resources.lbNew
    Public wrongAgainPass As String = My.Resources.lbAgain

    'Nhớ mật khẩu
    Public Shared check As Integer
    'Đăng nhập
    Public Shared isLogin As Boolean
    Public Sub Login(ByVal nv As NhanVien_DTO)
        Dim i As Integer = NhanVien_DAO.Login(nv, check)
        If i = 1 Then
            Form1.nv = nv
            LoginForm.Hide()
            nv.Id_BP = Login_Grant(nv)
            isLogin = True
        ElseIf i = 2 Then
            wrongName = My.Resources.lbUname.Insert(0, "Sai tên đăng nhập")
        ElseIf i = 3 Then
            wrongPass = My.Resources.lbPas.Insert(0, "Sai mật khẩu")
        End If
    End Sub

    'Gọi uname & pass đã được lưu
    Public Function Login_CallPass(ByVal uname As String) As String
        Return NhanVien_DAO.Login_CallPass(uname)
    End Function

    'Ủy quyền
    Public Function Login_Grant(ByVal nv As NhanVien_DTO) As Integer
        Return NhanVien_DAO.Login_Grant(nv)
    End Function

    'Đổi mật khẩu
    Public Shared test As String
    Public Sub ChangePas(ByVal nv As NhanVien_DTO, ByVal newPas As String, ByVal again As String)
        Dim i As Integer = NhanVien_DAO.ChangePas(nv, newPas, again)
        If i = 0 Then
            MessageBox.Show("Mật khẩu đã đổi")
        End If
        If i = 1 Then
            wrongNewPass = My.Resources.lbNew.Insert(0, "Mật khẩu không được quá 30 ký tự")
        ElseIf i = 2 Then
            wrongAgainPass = My.Resources.lbAgain.Insert(0, "Mật khẩu xác nhận sai")
        ElseIf i = 3 Then
            wrongOldPass = My.Resources.lbOld.Insert(0, "Mật khẩu sai")
        End If
    End Sub

    Public ds As New DataTable
    Function Info(ByVal maNV As String) As DataTable
        ds = dao.Info(maNV)
        With ds
            .Columns(0).ColumnName = "Họ tên"
            .Columns(1).ColumnName = "CMND"
            .Columns(2).ColumnName = "Ngày sinh"
            .Columns(3).ColumnName = "Giới tính"
            .Columns(4).ColumnName = "Địa chỉ"
            .Columns(5).ColumnName = "Số điện thoại"
        End With
        Return ds
    End Function



    Public Shared Function gettable() As DataTable
        Dim dt As New DataTable()
        dt = NhanVien_DAO.gettable()
        Return dt
    End Function
    Public Shared Function gettable2() As DataTable
        Dim dt As New DataTable()
        dt = NhanVien_DAO.gettable2()
        Return dt
    End Function
    Public Shared Function getlist() As List(Of NhanVien_DTO)
        Dim dt As New List(Of NhanVien_DTO)
        dt = NhanVien_DAO.getlist()
        Return dt
    End Function
    Public Shared Sub themnhaphanphoi(ByVal nv As NhanVien_DTO)
        NhanVien_DAO.themnhanvien(nv)
    End Sub
    Public Shared Sub capnhatnhaphanphoi(ByVal nv As NhanVien_DTO)
        NhanVien_DAO.capnhatnhanvien(nv)
    End Sub
    Public Shared Sub xoanhaphanphoi(ByVal nv As Integer)
        NhanVien_DAO.xoanhanvien(nv)
    End Sub
End Class
