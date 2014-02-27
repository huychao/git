<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.txtPas = New System.Windows.Forms.TextBox()
        Me.lbUname = New System.Windows.Forms.Label()
        Me.lbPas = New System.Windows.Forms.Label()
        Me.chbRemember = New System.Windows.Forms.CheckBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.QLBH.My.Resources.Resources.user_login_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 149)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tên đăng nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mật khẩu"
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(253, 11)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(190, 21)
        Me.txtUname.TabIndex = 3
        '
        'txtPas
        '
        Me.txtPas.Location = New System.Drawing.Point(253, 52)
        Me.txtPas.Name = "txtPas"
        Me.txtPas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPas.Size = New System.Drawing.Size(190, 21)
        Me.txtPas.TabIndex = 4
        '
        'lbUname
        '
        Me.lbUname.AutoSize = True
        Me.lbUname.ForeColor = System.Drawing.Color.Red
        Me.lbUname.Location = New System.Drawing.Point(256, 34)
        Me.lbUname.Name = "lbUname"
        Me.lbUname.Size = New System.Drawing.Size(0, 15)
        Me.lbUname.TabIndex = 5
        '
        'lbPas
        '
        Me.lbPas.AutoSize = True
        Me.lbPas.ForeColor = System.Drawing.Color.Red
        Me.lbPas.Location = New System.Drawing.Point(257, 76)
        Me.lbPas.Name = "lbPas"
        Me.lbPas.Size = New System.Drawing.Size(0, 15)
        Me.lbPas.TabIndex = 6
        '
        'chbRemember
        '
        Me.chbRemember.AutoSize = True
        Me.chbRemember.Location = New System.Drawing.Point(253, 92)
        Me.chbRemember.Name = "chbRemember"
        Me.chbRemember.Size = New System.Drawing.Size(103, 19)
        Me.chbRemember.TabIndex = 7
        Me.chbRemember.Text = "Nhớ mật khẩu"
        Me.chbRemember.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(253, 117)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(87, 24)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Đăng nhập"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 149)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.chbRemember)
        Me.Controls.Add(Me.lbPas)
        Me.Controls.Add(Me.lbUname)
        Me.Controls.Add(Me.txtPas)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents txtPas As System.Windows.Forms.TextBox
    Friend WithEvents lbUname As System.Windows.Forms.Label
    Friend WithEvents lbPas As System.Windows.Forms.Label
    Friend WithEvents chbRemember As System.Windows.Forms.CheckBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
End Class
