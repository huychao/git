Imports System.Data.SqlClient

Public Class LoginForm
    Dim nv As New NhanVien_DTO
    Dim bus As New NhanVien_BUS
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        nv.MaNV = txtUname.Text
        nv.Password = txtPas.Text
        If chbRemember.Checked Then
            NhanVien_BUS.check = 1
        End If
        bus.Login(nv)
        lbPas.Text = bus.wrongPass
        lbUname.Text = bus.wrongName
    End Sub
    Private Sub txtUname_TextChanged(sender As Object, e As EventArgs) Handles txtUname.TextChanged
        Dim pas As String = bus.Login_CallPass(txtUname.Text)
        txtPas.Text = pas
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        bus.isLogin = False
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class