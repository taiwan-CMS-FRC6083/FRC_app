<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.version = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.login_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Location = New System.Drawing.Point(12, 688)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(96, 25)
        Me.version.TabIndex = 0
        Me.version.Text = "Version :"
        '
        'logo
        '
        Me.logo.Image = Global.FRC_app.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(69, 32)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(762, 412)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'login_button
        '
        Me.login_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login_button.Location = New System.Drawing.Point(912, 32)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(133, 61)
        Me.login_button.TabIndex = 2
        Me.login_button.Text = "Login"
        Me.login_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(196, 497)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 63)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Login to Continue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(132, 688)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Beta 04m01a"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(868, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 87)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 715)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.logo)
        Me.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "home"
        Me.Text = "Home"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents version As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents login_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
