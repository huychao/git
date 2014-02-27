<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchInfoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchInfoForm))
        Me.txtKeyWord = New System.Windows.Forms.TextBox()
        Me.rbPhone = New System.Windows.Forms.RadioButton()
        Me.rbName = New System.Windows.Forms.RadioButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtKeyWord
        '
        Me.txtKeyWord.Location = New System.Drawing.Point(16, 15)
        Me.txtKeyWord.Name = "txtKeyWord"
        Me.txtKeyWord.Size = New System.Drawing.Size(253, 23)
        Me.txtKeyWord.TabIndex = 0
        '
        'rbPhone
        '
        Me.rbPhone.AutoSize = True
        Me.rbPhone.Checked = True
        Me.rbPhone.Location = New System.Drawing.Point(289, 16)
        Me.rbPhone.Name = "rbPhone"
        Me.rbPhone.Size = New System.Drawing.Size(109, 21)
        Me.rbPhone.TabIndex = 1
        Me.rbPhone.TabStop = True
        Me.rbPhone.Text = "Số điện thoại"
        Me.rbPhone.UseVisualStyleBackColor = True
        '
        'rbName
        '
        Me.rbName.AutoSize = True
        Me.rbName.Location = New System.Drawing.Point(420, 16)
        Me.rbName.Name = "rbName"
        Me.rbName.Size = New System.Drawing.Size(51, 21)
        Me.rbName.TabIndex = 2
        Me.rbName.Text = "Tên"
        Me.rbName.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(495, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(89, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'SearchInfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 52)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.rbName)
        Me.Controls.Add(Me.rbPhone)
        Me.Controls.Add(Me.txtKeyWord)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "SearchInfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchInfoForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtKeyWord As System.Windows.Forms.TextBox
    Friend WithEvents rbPhone As System.Windows.Forms.RadioButton
    Friend WithEvents rbName As System.Windows.Forms.RadioButton
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
