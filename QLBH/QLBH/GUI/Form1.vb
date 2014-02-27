Imports System.IO

Public Class Form1
    Dim bus As New NhanVien_BUS()
    Public nv As New NhanVien_DTO
    Dim logText As String, fileContents As String
    'Phân quyền theo màn hình
    Public Sub ShowForm(ByVal grant As Integer)
        With DataGridView1
            .BackgroundColor = Color.White
        End With
        If grant = 1 Then 'Quyền admin: xem được hết
            GroupBox1.Visible = True
            GroupBox2.Visible = True
            GroupBox3.Visible = True
            GroupBox4.Visible = True
            GroupBox5.Visible = True
            GroupBox6.Visible = True
            GroupBox7.Visible = True
            GroupBox8.Visible = True
            GroupBox9.Visible = True

            mybtnNhomHang.Enabled = True
            mybtnDV.Enabled = True
            mybtnKhoHang.Enabled = True
            If isUseLogFile Then
                mybtnHistory.Enabled = True
            Else
                mybtnHistory.Enabled = False
            End If
        ElseIf grant = 2 Then 'Quyền quản lý: không xem được grb hàng hóa, kho hàng, dữ liệu
            GroupBox1.Visible = True
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            GroupBox4.Visible = True
            GroupBox5.Visible = True
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = True
            GroupBox9.Visible = True

            mybtnNhomHang.Enabled = True
            mybtnDV.Enabled = True
            mybtnKhoHang.Enabled = True
        ElseIf grant = 3 Or grant = 4 Then 'Quyền nhân viên
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox9.Visible = False

            mybtnNhomHang.Enabled = False
            mybtnDV.Enabled = False
            mybtnKhoHang.Enabled = False

            If grant = 3 Then
                GroupBox6.Visible = False
                GroupBox8.Visible = False
            Else
                GroupBox7.Visible = False
            End If
        Else 'Quyền khách hàng
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = False

            mybtnNhomHang.Enabled = False
            mybtnDV.Enabled = False
            mybtnKhoHang.Enabled = False
            mybtnDoiPas.Enabled = False
            mybtnLogout.Enabled = False
        End If
    End Sub
    'Load form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(0) 'Quyền khách hàng
        LogFile()
        If isUseLogFile = True Then
            logText = DateTime.Now.ToString() + "-" + "-Khởi động chương trình" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub
    'Đăng nhập
    Private Sub KtraLogin()
        If NhanVien_BUS.isLogin Then
            mybtnLogin.Enabled = False
            mybtnLogout.Enabled = True
            mybtnDoiPas.Enabled = True
        Else
            mybtnLogin.Enabled = True
            mybtnLogout.Enabled = False
            mybtnDoiPas.Enabled = False
        End If
    End Sub
    Private Sub mybtnLogin_Click(sender As Object, e As EventArgs) Handles mybtnLogin.Click
        LoginForm.ShowDialog()
        ShowForm(nv.Id_BP)
        KtraLogin()
        If isUseLogFile = True Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Đăng nhập vào hệ thống" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub
    'Đăng xuất
    Private Sub mybtnLogout_Click(sender As Object, e As EventArgs) Handles mybtnLogout.Click
        ShowForm(0)
        LoginForm.txtPas.Text = ""
        LoginForm.txtUname.Text = ""
        NhanVien_BUS.isLogin = False
        KtraLogin()
        If isUseLogFile = True Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Đăng xuất khỏi hệ thống" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub
    'Đổi mật khẩu
    Private Sub mybtnDoiPas_Click(sender As Object, e As EventArgs) Handles mybtnDoiPas.Click
        ChangePass.Show()
        If isUseLogFile = True Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Đổi mật khẩu" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub
    'Thông tin người dùng
    Private Sub mybtnInfo_Click(sender As Object, e As EventArgs) Handles mybtnInfo.Click
        AddHandler SearchInfoForm.SearchResult, AddressOf SearchInfoForm_SearchResult
        If NhanVien_BUS.isLogin Then
            StaffInfo()
        Else
            SearchInfoForm.ShowDialog()
        End If
    End Sub
    Private Sub SearchInfoForm_SearchResult()
        Try
            With DataGridView1
                .Columns.Clear()
                .DataSource = SearchInfoForm.ds
                .Columns(0).Width = 50
                .Columns(1).Width = 220
                .Columns(2).Width = 130
                .Columns(3).Width = 130
                .Columns(4).Width = Me.Width - (.Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width)
            End With
            If isUseLogFile = True Then
                logText = DateTime.Now.ToString() + "-Khách hàng-Xem thông tin người dùng" + vbCrLf
                My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub StaffInfo()
        Try
            bus.Info(nv.MaNV)
            With DataGridView1
                .Columns.Clear()
                .DataSource = bus.ds
                .Columns(0).Width = 200
                .Columns(1).Width = 100
                .Columns(2).Width = 100
                .Columns(3).Width = 100
                .Columns(4).Width = 250
                .Columns(5).Width = .Width - (.Columns(0).Width + .Columns(1).Width + .Columns(2).Width + .Columns(3).Width + .Columns(4).Width)
            End With
            If isUseLogFile Then
                logText = DateTime.Now.ToString() + " - " + nv.MaNV + "-Xem thông tin cá nhân" + vbCrLf
                My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mybtnBackup_Click(sender As Object, e As EventArgs) Handles mybtnBackup.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-Admin-Thực hiện quá trình sao lưu dữ liệu" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub

    Private Sub mybtnRestore_Click(sender As Object, e As EventArgs) Handles mybtnRestore.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-Admin-Phục hồi dữ liệu" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub

    'Lịch sử hệ thống
    Dim isUseLogFile As Boolean = False
    Private Sub LogFile()
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\QLBH.log")
        If fileExists = False Then
            If MessageBox.Show("Tập tin chứa nhật ký hệ thống chưa tồn tại, tạo mới?", "Logfile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Dim dialog As New OpenFileDialog(), path As String
                'If DialogResult.Yes = dialog.ShowDialog Then
                '    path = dialog.FileName
                'End If
                isUseLogFile = True
                MessageBox.Show("Tập tin được lưu tại C:\QLBH.log")
                My.Computer.FileSystem.WriteAllText("C:\QLBH.log", String.Empty, False)
            End If
        End If
    End Sub
    Private Sub mybtnHistory_Click(sender As Object, e As EventArgs) Handles mybtnHistory.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-Admin-Kiểm tra nhật ký hệ thống" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
            Dim str As String = My.Computer.FileSystem.ReadAllText("C:\QLBH.log")
            Dim items() As String = str.Split(vbCrLf)
            Dim data As New DataTable
            With data
                .Columns.Add("Thời gian")
                .Columns.Add("Người dùng")
                .Columns.Add("Hành động")
            End With
            For j = 0 To items.Length() - 2
                Dim item() As String = items(j).Split("-")
                Dim a As String = item(0)
                Dim b As String = item(1)
                Dim c As String = item(2)
                data.Rows.Add(a, b, c)
            Next
            DataGridView1.DataSource = data
            With DataGridView1
                .Columns(0).Width = 200
                .Columns(1).Width = 150
                .Columns(2).Width = .Width - (.Columns(0).Width + .Columns(1).Width)
            End With
        End If
    End Sub

    Private Sub mybtnKhuVuc_Click(sender As Object, e As EventArgs) Handles mybtnKhuVuc.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Click button khu vực" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub

    Private Sub mybtnKhachHang_Click(sender As Object, e As EventArgs) Handles mybtnKhachHang.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Click button khách hàng" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub

    Private Sub mybtnNSX_Click(sender As Object, e As EventArgs) Handles mybtnNSX.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Click button nhà sản xuất" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub

    Private Sub mybtnNCC_Click(sender As Object, e As EventArgs) Handles mybtnNCC.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Click button nhà cung cấp" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If
    End Sub

    Private Sub mybtnNhanVien_Click(sender As Object, e As EventArgs) Handles mybtnNhanVien.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Click button nhân viên" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If


    End Sub

    Private Sub mybtnBoPhan_Click(sender As Object, e As EventArgs) Handles mybtnBoPhan.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Click button bộ phận" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If


    End Sub

    Private Sub mybtnSanPham_Click(sender As Object, e As EventArgs) Handles mybtnSanPham.Click
        If isUseLogFile Then
            logText = DateTime.Now.ToString() + "-" + nv.MaNV + "-Click button sản phẩm" + vbCrLf
            My.Computer.FileSystem.WriteAllText("C:\QLBH.log", logText, True)
        End If


    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub tpHeThong_Click(sender As Object, e As EventArgs) Handles tpHeThong.Click

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub pagenhaphang_Click(sender As Object, e As EventArgs) Handles pagenhaphang.Click

    End Sub

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter

    End Sub

    Private Sub mybtnNhap_Load(sender As Object, e As EventArgs) Handles mybtnNhap.Load
    End Sub

    Private Sub mybtnLogin_Load(sender As Object, e As EventArgs) Handles mybtnLogin.Load

    End Sub

    Private Sub mybtnSanPham_Load(sender As Object, e As EventArgs) Handles mybtnSanPham.Load
    End Sub

    Private Sub pagebanhang_Click(sender As Object, e As EventArgs) Handles pagebanhang.Click

    End Sub

    Private Sub mybtnTyGia_Click(sender As Object, e As EventArgs) Handles mybtnTyGia.Click
    End Sub

    Private Sub GroupBox11_Enter(sender As Object, e As EventArgs) Handles GroupBox11.Enter

    End Sub

    Private Sub pagenhacungcap_Enter(sender As Object, e As EventArgs) Handles pagenhacungcap.Enter
        hienthinhaCC()
    End Sub
    Sub hienthinhaCC()
        Dim dt As New DataTable()
        dt = NhaPhanPhoi_BUS.gettable()
        DataGridView2.DataSource = dt
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Dim form As New TaonhaCC()
        form.buttonthemnhacungcap.Visible = True
        form.textmanhacc.Visible = True
        form.Show()
        hienthinhaCC()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim update As New Suachuanhacc
        update.Show()
        hienthinhaCC()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    End Sub

    Private Sub suachua_Click(sender As Object, e As EventArgs) Handles suachua.Click
        
    End Sub
End Class
