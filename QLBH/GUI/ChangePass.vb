Public Class ChangePass
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bus As New NhanVien_BUS()
        bus.ChangePas(Form1.nv, txtNew.Text, txtAgain.Text)
        lbAgain.Text = bus.wrongAgainPass
        lbNew.Text = bus.wrongNewPass
        lbOld.Text = bus.wrongOldPass
        Me.Close()
    End Sub

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class