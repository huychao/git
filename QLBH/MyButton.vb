Public Class MyButton
    Private icon As Image
    Public Property ButtonIcon() As Image
        Get
            Return icon
        End Get
        Set(ByVal value As Image)
            icon = value
            PictureBox1.Image = icon
        End Set
    End Property
    Private btnName As String
    Public Property ButtonName() As String
        Get
            Return btnName
        End Get
        Set(ByVal value As String)
            btnName = value
            Label1.Text = btnName
        End Set
    End Property

    Private Sub MyButton_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter
        Me.BackColor = Color.LightBlue
    End Sub
    Private Sub MyButton_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub
End Class
