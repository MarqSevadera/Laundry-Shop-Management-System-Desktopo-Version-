<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxAdmin = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New ns1.BunifuThinButton2()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtStaffCode = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.cbxAdmin)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtStaffCode)
        Me.Panel1.Controls.Add(Me.BunifuSeparator2)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.lblLogin)
        Me.Panel1.Location = New System.Drawing.Point(1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 434)
        Me.Panel1.TabIndex = 0
        '
        'cbxAdmin
        '
        Me.cbxAdmin.AutoSize = True
        Me.cbxAdmin.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAdmin.Location = New System.Drawing.Point(118, 393)
        Me.cbxAdmin.Name = "cbxAdmin"
        Me.cbxAdmin.Size = New System.Drawing.Size(163, 23)
        Me.cbxAdmin.TabIndex = 20
        Me.cbxAdmin.Text = "Login as Admin?"
        Me.cbxAdmin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Password  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 22)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Staff Code "
        '
        'btnLogin
        '
        Me.btnLogin.ActiveBorderThickness = 1
        Me.btnLogin.ActiveCornerRadius = 20
        Me.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogin.ActiveForecolor = System.Drawing.Color.Black
        Me.btnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.ButtonText = "LOGIN"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.White
        Me.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.Location = New System.Drawing.Point(104, 311)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(199, 44)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtPassword.Location = New System.Drawing.Point(77, 259)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(247, 32)
        Me.txtPassword.TabIndex = 6
        '
        'txtStaffCode
        '
        Me.txtStaffCode.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffCode.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtStaffCode.Location = New System.Drawing.Point(77, 166)
        Me.txtStaffCode.Name = "txtStaffCode"
        Me.txtStaffCode.Size = New System.Drawing.Size(247, 32)
        Me.txtStaffCode.TabIndex = 5
        Me.txtStaffCode.Tag = ""
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(52, 363)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(293, 35)
        Me.BunifuSeparator2.TabIndex = 4
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(52, 84)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(293, 35)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLogin.Location = New System.Drawing.Point(97, 40)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(227, 41)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Staff Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 432)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLogin As Label
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtStaffCode As TextBox
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents btnLogin As ns1.BunifuThinButton2
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxAdmin As CheckBox
End Class
