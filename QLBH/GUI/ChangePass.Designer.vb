<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtAgain = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbOld = New System.Windows.Forms.Label()
        Me.lbNew = New System.Windows.Forms.Label()
        Me.lbAgain = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mật khẩu cũ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mật khẩu mới"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Xác nhận mật khẩu"
        '
        'txtOld
        '
        Me.txtOld.Location = New System.Drawing.Point(135, 7)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOld.Size = New System.Drawing.Size(186, 21)
        Me.txtOld.TabIndex = 3
        '
        'txtNew
        '
        Me.txtNew.Location = New System.Drawing.Point(135, 49)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew.Size = New System.Drawing.Size(186, 21)
        Me.txtNew.TabIndex = 4
        '
        'txtAgain
        '
        Me.txtAgain.Location = New System.Drawing.Point(135, 91)
        Me.txtAgain.Name = "txtAgain"
        Me.txtAgain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtAgain.Size = New System.Drawing.Size(186, 21)
        Me.txtAgain.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Image = Global.QLBH.My.Resources.Resources.Lưu
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(135, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(52, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Lưu"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbOld
        '
        Me.lbOld.AutoSize = True
        Me.lbOld.ForeColor = System.Drawing.Color.Red
        Me.lbOld.Location = New System.Drawing.Point(132, 31)
        Me.lbOld.Name = "lbOld"
        Me.lbOld.Size = New System.Drawing.Size(0, 15)
        Me.lbOld.TabIndex = 7
        '
        'lbNew
        '
        Me.lbNew.AutoSize = True
        Me.lbNew.ForeColor = System.Drawing.Color.Red
        Me.lbNew.Location = New System.Drawing.Point(132, 73)
        Me.lbNew.Name = "lbNew"
        Me.lbNew.Size = New System.Drawing.Size(0, 15)
        Me.lbNew.TabIndex = 8
        '
        'lbAgain
        '
        Me.lbAgain.AutoSize = True
        Me.lbAgain.ForeColor = System.Drawing.Color.Red
        Me.lbAgain.Location = New System.Drawing.Point(132, 115)
        Me.lbAgain.Name = "lbAgain"
        Me.lbAgain.Size = New System.Drawing.Size(0, 15)
        Me.lbAgain.TabIndex = 9
        '
        'ChangePass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 165)
        Me.Controls.Add(Me.lbAgain)
        Me.Controls.Add(Me.lbNew)
        Me.Controls.Add(Me.lbOld)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAgain)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "ChangePass"
        Me.Text = "ChangePass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtAgain As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lbOld As System.Windows.Forms.Label
    Friend WithEvents lbNew As System.Windows.Forms.Label
    Friend WithEvents lbAgain As System.Windows.Forms.Label
End Class
