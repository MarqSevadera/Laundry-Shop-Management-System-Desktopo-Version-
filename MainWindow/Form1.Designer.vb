<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New ns1.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.BunifuSeparator2)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 379)
        Me.Panel1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox2.Location = New System.Drawing.Point(64, 201)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(271, 42)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtUsername.Location = New System.Drawing.Point(64, 132)
        Me.txtUsername.Multiline = True
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(271, 42)
        Me.txtUsername.TabIndex = 5
        Me.txtUsername.Text = "Username"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.ForeColor = System.Drawing.SystemColors.Control
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(52, 320)
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
        Me.BunifuSeparator1.Location = New System.Drawing.Point(52, 91)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(293, 35)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(96, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login Form"
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
        Me.btnLogin.ButtonText = "CLAIM"
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.IdleBorderThickness = 1
        Me.btnLogin.IdleCornerRadius = 20
        Me.btnLogin.IdleFillColor = System.Drawing.Color.White
        Me.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogin.Location = New System.Drawing.Point(103, 268)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(199, 44)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 377)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents btnLogin As ns1.BunifuThinButton2
End Class
