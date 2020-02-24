<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.btnLogout = New ns1.BunifuThinButton2()
        Me.btnEditAcc = New ns1.BunifuThinButton2()
        Me.btnStaff = New ns1.BunifuThinButton2()
        Me.btnCreateAcc = New ns1.BunifuThinButton2()
        Me.btnOrder = New ns1.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adminNameHolder = New ns1.BunifuCustomLabel()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.parentPanel = New System.Windows.Forms.Panel()
        Me.orderPanel = New System.Windows.Forms.Panel()
        Me.deleteBtn = New ns1.BunifuTileButton()
        Me.detailsBtn = New ns1.BunifuTileButton()
        Me.orderGrid = New System.Windows.Forms.DataGridView()
        Me.btnClaimed = New ns1.BunifuThinButton2()
        Me.btnUnclaimed = New ns1.BunifuThinButton2()
        Me.btnAll = New ns1.BunifuThinButton2()
        Me.BunifuSeparator3 = New ns1.BunifuSeparator()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.editAccPanel = New System.Windows.Forms.Panel()
        Me.btnSave = New ns1.BunifuTileButton()
        Me.txtSearch = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnSearch = New ns1.BunifuThinButton2()
        Me.txtPass = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtLastName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtMiddleName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtFirstName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.btnDelete = New ns1.BunifuThinButton2()
        Me.btnEdit = New ns1.BunifuThinButton2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuSeparator4 = New ns1.BunifuSeparator()
        Me.staffPanel = New System.Windows.Forms.Panel()
        Me.drpdwnSort = New ns1.BunifuDropdown()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gridStaff = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.createAccPanel = New System.Windows.Forms.Panel()
        Me.txtStaffCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnSubmit = New ns1.BunifuThinButton2()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtMN = New System.Windows.Forms.TextBox()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblMN = New System.Windows.Forms.Label()
        Me.lblLN = New System.Windows.Forms.Label()
        Me.lblFN = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sidePanel.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.parentPanel.SuspendLayout()
        Me.orderPanel.SuspendLayout()
        CType(Me.orderGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.editAccPanel.SuspendLayout()
        Me.staffPanel.SuspendLayout()
        CType(Me.gridStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.createAccPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.sidePanel.Controls.Add(Me.btnLogout)
        Me.sidePanel.Controls.Add(Me.btnEditAcc)
        Me.sidePanel.Controls.Add(Me.btnStaff)
        Me.sidePanel.Controls.Add(Me.btnCreateAcc)
        Me.sidePanel.Controls.Add(Me.btnOrder)
        Me.sidePanel.Controls.Add(Me.Label2)
        Me.sidePanel.Controls.Add(Me.adminNameHolder)
        Me.sidePanel.Controls.Add(Me.pictureBox)
        Me.sidePanel.Location = New System.Drawing.Point(-2, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(220, 503)
        Me.sidePanel.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.ActiveBorderThickness = 1
        Me.btnLogout.ActiveCornerRadius = 20
        Me.btnLogout.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogout.ActiveForecolor = System.Drawing.Color.Black
        Me.btnLogout.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.ButtonText = "LOGOUT"
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.IdleBorderThickness = 1
        Me.btnLogout.IdleCornerRadius = 20
        Me.btnLogout.IdleFillColor = System.Drawing.Color.White
        Me.btnLogout.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnLogout.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnLogout.Location = New System.Drawing.Point(-15, 425)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(243, 43)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEditAcc
        '
        Me.btnEditAcc.ActiveBorderThickness = 1
        Me.btnEditAcc.ActiveCornerRadius = 20
        Me.btnEditAcc.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnEditAcc.ActiveForecolor = System.Drawing.Color.Black
        Me.btnEditAcc.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnEditAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnEditAcc.BackgroundImage = CType(resources.GetObject("btnEditAcc.BackgroundImage"), System.Drawing.Image)
        Me.btnEditAcc.ButtonText = "EDIT ACCOUNT"
        Me.btnEditAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditAcc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEditAcc.IdleBorderThickness = 1
        Me.btnEditAcc.IdleCornerRadius = 20
        Me.btnEditAcc.IdleFillColor = System.Drawing.Color.White
        Me.btnEditAcc.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnEditAcc.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnEditAcc.Location = New System.Drawing.Point(-15, 385)
        Me.btnEditAcc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEditAcc.Name = "btnEditAcc"
        Me.btnEditAcc.Size = New System.Drawing.Size(243, 43)
        Me.btnEditAcc.TabIndex = 15
        Me.btnEditAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnStaff
        '
        Me.btnStaff.ActiveBorderThickness = 1
        Me.btnStaff.ActiveCornerRadius = 20
        Me.btnStaff.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnStaff.ActiveForecolor = System.Drawing.Color.Black
        Me.btnStaff.ActiveLineColor = System.Drawing.Color.Black
        Me.btnStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnStaff.BackgroundImage = CType(resources.GetObject("btnStaff.BackgroundImage"), System.Drawing.Image)
        Me.btnStaff.ButtonText = "STAFFS"
        Me.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStaff.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStaff.IdleBorderThickness = 1
        Me.btnStaff.IdleCornerRadius = 20
        Me.btnStaff.IdleFillColor = System.Drawing.Color.White
        Me.btnStaff.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnStaff.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnStaff.Location = New System.Drawing.Point(-15, 303)
        Me.btnStaff.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(243, 43)
        Me.btnStaff.TabIndex = 14
        Me.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreateAcc
        '
        Me.btnCreateAcc.ActiveBorderThickness = 1
        Me.btnCreateAcc.ActiveCornerRadius = 20
        Me.btnCreateAcc.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCreateAcc.ActiveForecolor = System.Drawing.Color.Black
        Me.btnCreateAcc.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnCreateAcc.BackgroundImage = CType(resources.GetObject("btnCreateAcc.BackgroundImage"), System.Drawing.Image)
        Me.btnCreateAcc.ButtonText = "CREATE ACCOUNT"
        Me.btnCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateAcc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCreateAcc.IdleBorderThickness = 1
        Me.btnCreateAcc.IdleCornerRadius = 20
        Me.btnCreateAcc.IdleFillColor = System.Drawing.Color.White
        Me.btnCreateAcc.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnCreateAcc.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnCreateAcc.Location = New System.Drawing.Point(-15, 344)
        Me.btnCreateAcc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCreateAcc.Name = "btnCreateAcc"
        Me.btnCreateAcc.Size = New System.Drawing.Size(243, 43)
        Me.btnCreateAcc.TabIndex = 13
        Me.btnCreateAcc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOrder
        '
        Me.btnOrder.ActiveBorderThickness = 1
        Me.btnOrder.ActiveCornerRadius = 20
        Me.btnOrder.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnOrder.ActiveForecolor = System.Drawing.Color.Black
        Me.btnOrder.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnOrder.BackgroundImage = CType(resources.GetObject("btnOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnOrder.ButtonText = "ORDERS"
        Me.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOrder.IdleBorderThickness = 1
        Me.btnOrder.IdleCornerRadius = 20
        Me.btnOrder.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnOrder.IdleForecolor = System.Drawing.Color.Black
        Me.btnOrder.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnOrder.Location = New System.Drawing.Point(-15, 262)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(243, 43)
        Me.btnOrder.TabIndex = 12
        Me.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(82, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ADMIN"
        '
        'adminNameHolder
        '
        Me.adminNameHolder.AutoSize = True
        Me.adminNameHolder.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNameHolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.adminNameHolder.Location = New System.Drawing.Point(66, 152)
        Me.adminNameHolder.Name = "adminNameHolder"
        Me.adminNameHolder.Size = New System.Drawing.Size(90, 28)
        Me.adminNameHolder.TabIndex = 9
        Me.adminNameHolder.Text = "Marque"
        Me.adminNameHolder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox
        '
        Me.pictureBox.Image = Global.MainWindow.My.Resources.Resources.user_male_circle_filled1600
        Me.pictureBox.Location = New System.Drawing.Point(59, 32)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(106, 96)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox.TabIndex = 1
        Me.pictureBox.TabStop = False
        '
        'parentPanel
        '
        Me.parentPanel.Controls.Add(Me.orderPanel)
        Me.parentPanel.Controls.Add(Me.editAccPanel)
        Me.parentPanel.Controls.Add(Me.staffPanel)
        Me.parentPanel.Controls.Add(Me.createAccPanel)
        Me.parentPanel.Location = New System.Drawing.Point(224, 0)
        Me.parentPanel.Name = "parentPanel"
        Me.parentPanel.Size = New System.Drawing.Size(622, 503)
        Me.parentPanel.TabIndex = 1
        '
        'orderPanel
        '
        Me.orderPanel.Controls.Add(Me.deleteBtn)
        Me.orderPanel.Controls.Add(Me.detailsBtn)
        Me.orderPanel.Controls.Add(Me.orderGrid)
        Me.orderPanel.Controls.Add(Me.btnClaimed)
        Me.orderPanel.Controls.Add(Me.btnUnclaimed)
        Me.orderPanel.Controls.Add(Me.btnAll)
        Me.orderPanel.Controls.Add(Me.BunifuSeparator3)
        Me.orderPanel.Controls.Add(Me.lblOrder)
        Me.orderPanel.Location = New System.Drawing.Point(0, 0)
        Me.orderPanel.Name = "orderPanel"
        Me.orderPanel.Size = New System.Drawing.Size(626, 497)
        Me.orderPanel.TabIndex = 0
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.Transparent
        Me.deleteBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.deleteBtn.color = System.Drawing.Color.Transparent
        Me.deleteBtn.colorActive = System.Drawing.Color.SeaGreen
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.Enabled = False
        Me.deleteBtn.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.deleteBtn.ForeColor = System.Drawing.Color.Black
        Me.deleteBtn.Image = CType(resources.GetObject("deleteBtn.Image"), System.Drawing.Image)
        Me.deleteBtn.ImagePosition = 20
        Me.deleteBtn.ImageZoom = 50
        Me.deleteBtn.LabelPosition = 41
        Me.deleteBtn.LabelText = "DELETE"
        Me.deleteBtn.Location = New System.Drawing.Point(341, 421)
        Me.deleteBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(187, 45)
        Me.deleteBtn.TabIndex = 12
        '
        'detailsBtn
        '
        Me.detailsBtn.BackColor = System.Drawing.Color.Transparent
        Me.detailsBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.detailsBtn.color = System.Drawing.Color.Transparent
        Me.detailsBtn.colorActive = System.Drawing.Color.SeaGreen
        Me.detailsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.detailsBtn.Enabled = False
        Me.detailsBtn.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.detailsBtn.ForeColor = System.Drawing.Color.Black
        Me.detailsBtn.Image = CType(resources.GetObject("detailsBtn.Image"), System.Drawing.Image)
        Me.detailsBtn.ImagePosition = 20
        Me.detailsBtn.ImageZoom = 50
        Me.detailsBtn.LabelPosition = 41
        Me.detailsBtn.LabelText = "DETAILS"
        Me.detailsBtn.Location = New System.Drawing.Point(91, 421)
        Me.detailsBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.detailsBtn.Name = "detailsBtn"
        Me.detailsBtn.Size = New System.Drawing.Size(187, 45)
        Me.detailsBtn.TabIndex = 11
        '
        'orderGrid
        '
        Me.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.orderGrid.Location = New System.Drawing.Point(36, 138)
        Me.orderGrid.Name = "orderGrid"
        Me.orderGrid.Size = New System.Drawing.Size(556, 265)
        Me.orderGrid.TabIndex = 8
        '
        'btnClaimed
        '
        Me.btnClaimed.ActiveBorderThickness = 1
        Me.btnClaimed.ActiveCornerRadius = 20
        Me.btnClaimed.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnClaimed.ActiveForecolor = System.Drawing.Color.White
        Me.btnClaimed.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnClaimed.BackColor = System.Drawing.SystemColors.Control
        Me.btnClaimed.BackgroundImage = CType(resources.GetObject("btnClaimed.BackgroundImage"), System.Drawing.Image)
        Me.btnClaimed.ButtonText = "CLAIMED"
        Me.btnClaimed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClaimed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClaimed.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnClaimed.IdleBorderThickness = 1
        Me.btnClaimed.IdleCornerRadius = 20
        Me.btnClaimed.IdleFillColor = System.Drawing.Color.White
        Me.btnClaimed.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnClaimed.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnClaimed.Location = New System.Drawing.Point(419, 91)
        Me.btnClaimed.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClaimed.Name = "btnClaimed"
        Me.btnClaimed.Size = New System.Drawing.Size(126, 37)
        Me.btnClaimed.TabIndex = 7
        Me.btnClaimed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUnclaimed
        '
        Me.btnUnclaimed.ActiveBorderThickness = 1
        Me.btnUnclaimed.ActiveCornerRadius = 20
        Me.btnUnclaimed.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnUnclaimed.ActiveForecolor = System.Drawing.Color.White
        Me.btnUnclaimed.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnUnclaimed.BackColor = System.Drawing.SystemColors.Control
        Me.btnUnclaimed.BackgroundImage = CType(resources.GetObject("btnUnclaimed.BackgroundImage"), System.Drawing.Image)
        Me.btnUnclaimed.ButtonText = "UNCLAIMED"
        Me.btnUnclaimed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnclaimed.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnclaimed.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnUnclaimed.IdleBorderThickness = 1
        Me.btnUnclaimed.IdleCornerRadius = 20
        Me.btnUnclaimed.IdleFillColor = System.Drawing.Color.White
        Me.btnUnclaimed.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnUnclaimed.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnUnclaimed.Location = New System.Drawing.Point(244, 90)
        Me.btnUnclaimed.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUnclaimed.Name = "btnUnclaimed"
        Me.btnUnclaimed.Size = New System.Drawing.Size(126, 37)
        Me.btnUnclaimed.TabIndex = 6
        Me.btnUnclaimed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAll
        '
        Me.btnAll.ActiveBorderThickness = 1
        Me.btnAll.ActiveCornerRadius = 20
        Me.btnAll.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnAll.ActiveForecolor = System.Drawing.Color.White
        Me.btnAll.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnAll.BackgroundImage = CType(resources.GetObject("btnAll.BackgroundImage"), System.Drawing.Image)
        Me.btnAll.ButtonText = "ALL"
        Me.btnAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAll.IdleBorderThickness = 1
        Me.btnAll.IdleCornerRadius = 20
        Me.btnAll.IdleFillColor = System.Drawing.Color.SeaGreen
        Me.btnAll.IdleForecolor = System.Drawing.Color.White
        Me.btnAll.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnAll.Location = New System.Drawing.Point(74, 91)
        Me.btnAll.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(126, 37)
        Me.btnAll.TabIndex = 5
        Me.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(36, 67)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(556, 35)
        Me.BunifuSeparator3.TabIndex = 2
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(26, 22)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(180, 56)
        Me.lblOrder.TabIndex = 1
        Me.lblOrder.Text = "ORDERS"
        '
        'editAccPanel
        '
        Me.editAccPanel.Controls.Add(Me.btnSave)
        Me.editAccPanel.Controls.Add(Me.txtSearch)
        Me.editAccPanel.Controls.Add(Me.btnSearch)
        Me.editAccPanel.Controls.Add(Me.txtPass)
        Me.editAccPanel.Controls.Add(Me.txtLastName)
        Me.editAccPanel.Controls.Add(Me.txtMiddleName)
        Me.editAccPanel.Controls.Add(Me.txtFirstName)
        Me.editAccPanel.Controls.Add(Me.btnDelete)
        Me.editAccPanel.Controls.Add(Me.btnEdit)
        Me.editAccPanel.Controls.Add(Me.Label6)
        Me.editAccPanel.Controls.Add(Me.Label11)
        Me.editAccPanel.Controls.Add(Me.Label10)
        Me.editAccPanel.Controls.Add(Me.Label9)
        Me.editAccPanel.Controls.Add(Me.Label8)
        Me.editAccPanel.Controls.Add(Me.Label7)
        Me.editAccPanel.Controls.Add(Me.BunifuSeparator4)
        Me.editAccPanel.Location = New System.Drawing.Point(0, 0)
        Me.editAccPanel.Name = "editAccPanel"
        Me.editAccPanel.Size = New System.Drawing.Size(622, 500)
        Me.editAccPanel.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnSave.color = System.Drawing.Color.Transparent
        Me.btnSave.colorActive = System.Drawing.Color.SeaGreen
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImagePosition = 18
        Me.btnSave.ImageZoom = 50
        Me.btnSave.LabelPosition = 36
        Me.btnSave.LabelText = "SAVE"
        Me.btnSave.Location = New System.Drawing.Point(265, 394)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(103, 47)
        Me.btnSave.TabIndex = 23
        '
        'txtSearch
        '
        Me.txtSearch.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSearch.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(251, 134)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(175, 30)
        Me.txtSearch.TabIndex = 22
        '
        'btnSearch
        '
        Me.btnSearch.ActiveBorderThickness = 1
        Me.btnSearch.ActiveCornerRadius = 20
        Me.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnSearch.ActiveForecolor = System.Drawing.Color.White
        Me.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.ButtonText = "SEARCH"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.IdleBorderThickness = 1
        Me.btnSearch.IdleCornerRadius = 20
        Me.btnSearch.IdleFillColor = System.Drawing.Color.White
        Me.btnSearch.IdleForecolor = System.Drawing.SystemColors.Highlight
        Me.btnSearch.IdleLineColor = System.Drawing.SystemColors.Highlight
        Me.btnSearch.Location = New System.Drawing.Point(438, 129)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 40)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPass
        '
        Me.txtPass.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtPass.Enabled = False
        Me.txtPass.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(290, 334)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(197, 30)
        Me.txtPass.TabIndex = 19
        '
        'txtLastName
        '
        Me.txtLastName.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(290, 289)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(197, 30)
        Me.txtLastName.TabIndex = 18
        '
        'txtMiddleName
        '
        Me.txtMiddleName.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtMiddleName.Enabled = False
        Me.txtMiddleName.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(289, 244)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(197, 30)
        Me.txtMiddleName.TabIndex = 17
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(289, 199)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(197, 30)
        Me.txtFirstName.TabIndex = 16
        '
        'btnDelete
        '
        Me.btnDelete.ActiveBorderThickness = 1
        Me.btnDelete.ActiveCornerRadius = 20
        Me.btnDelete.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.ActiveForecolor = System.Drawing.Color.White
        Me.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.ButtonText = "DELETE"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.IdleBorderThickness = 1
        Me.btnDelete.IdleCornerRadius = 20
        Me.btnDelete.IdleFillColor = System.Drawing.Color.White
        Me.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnDelete.Location = New System.Drawing.Point(442, 401)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(108, 40)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEdit
        '
        Me.btnEdit.ActiveBorderThickness = 1
        Me.btnEdit.ActiveCornerRadius = 20
        Me.btnEdit.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.ActiveForecolor = System.Drawing.Color.White
        Me.btnEdit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.ButtonText = "EDIT"
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.IdleBorderThickness = 1
        Me.btnEdit.IdleCornerRadius = 20
        Me.btnEdit.IdleFillColor = System.Drawing.Color.White
        Me.btnEdit.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnEdit.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnEdit.Location = New System.Drawing.Point(80, 401)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(108, 40)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 56)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "EDIT ACCOUNT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(140, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 24)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Password : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(133, 292)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Last Name : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(110, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 24)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Middle Name : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(132, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "First Name : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(70, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Search Staff Code : "
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(36, 93)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Size = New System.Drawing.Size(556, 35)
        Me.BunifuSeparator4.TabIndex = 2
        Me.BunifuSeparator4.Transparency = 255
        Me.BunifuSeparator4.Vertical = False
        '
        'staffPanel
        '
        Me.staffPanel.Controls.Add(Me.drpdwnSort)
        Me.staffPanel.Controls.Add(Me.BunifuSeparator1)
        Me.staffPanel.Controls.Add(Me.Label3)
        Me.staffPanel.Controls.Add(Me.gridStaff)
        Me.staffPanel.Controls.Add(Me.Label1)
        Me.staffPanel.Location = New System.Drawing.Point(0, 0)
        Me.staffPanel.Name = "staffPanel"
        Me.staffPanel.Size = New System.Drawing.Size(626, 497)
        Me.staffPanel.TabIndex = 10
        '
        'drpdwnSort
        '
        Me.drpdwnSort.BackColor = System.Drawing.Color.Transparent
        Me.drpdwnSort.BorderRadius = 3
        Me.drpdwnSort.ForeColor = System.Drawing.Color.White
        Me.drpdwnSort.Items = New String() {"Staff Code", "Last Name", "First Name", "Middle Intl"}
        Me.drpdwnSort.Location = New System.Drawing.Point(462, 116)
        Me.drpdwnSort.Name = "drpdwnSort"
        Me.drpdwnSort.NomalColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.drpdwnSort.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.drpdwnSort.selectedIndex = 0
        Me.drpdwnSort.Size = New System.Drawing.Size(130, 28)
        Me.drpdwnSort.TabIndex = 9
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(36, 72)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(556, 35)
        Me.BunifuSeparator1.TabIndex = 8
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(366, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sort By:"
        '
        'gridStaff
        '
        Me.gridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridStaff.Location = New System.Drawing.Point(36, 169)
        Me.gridStaff.Name = "gridStaff"
        Me.gridStaff.Size = New System.Drawing.Size(556, 297)
        Me.gridStaff.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STAFFS"
        '
        'createAccPanel
        '
        Me.createAccPanel.Controls.Add(Me.txtStaffCode)
        Me.createAccPanel.Controls.Add(Me.Label12)
        Me.createAccPanel.Controls.Add(Me.btnSubmit)
        Me.createAccPanel.Controls.Add(Me.txtPassword)
        Me.createAccPanel.Controls.Add(Me.txtMN)
        Me.createAccPanel.Controls.Add(Me.txtLN)
        Me.createAccPanel.Controls.Add(Me.txtFN)
        Me.createAccPanel.Controls.Add(Me.Label5)
        Me.createAccPanel.Controls.Add(Me.lblMN)
        Me.createAccPanel.Controls.Add(Me.lblLN)
        Me.createAccPanel.Controls.Add(Me.lblFN)
        Me.createAccPanel.Controls.Add(Me.BunifuSeparator2)
        Me.createAccPanel.Controls.Add(Me.Label4)
        Me.createAccPanel.Location = New System.Drawing.Point(0, 0)
        Me.createAccPanel.Name = "createAccPanel"
        Me.createAccPanel.Size = New System.Drawing.Size(622, 497)
        Me.createAccPanel.TabIndex = 10
        '
        'txtStaffCode
        '
        Me.txtStaffCode.Enabled = False
        Me.txtStaffCode.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffCode.Location = New System.Drawing.Point(271, 108)
        Me.txtStaffCode.Multiline = True
        Me.txtStaffCode.Name = "txtStaffCode"
        Me.txtStaffCode.Size = New System.Drawing.Size(242, 36)
        Me.txtStaffCode.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(105, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(130, 22)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Staff Code :"
        '
        'btnSubmit
        '
        Me.btnSubmit.ActiveBorderThickness = 1
        Me.btnSubmit.ActiveCornerRadius = 20
        Me.btnSubmit.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnSubmit.ActiveForecolor = System.Drawing.Color.White
        Me.btnSubmit.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.Control
        Me.btnSubmit.BackgroundImage = CType(resources.GetObject("btnSubmit.BackgroundImage"), System.Drawing.Image)
        Me.btnSubmit.ButtonText = "SUBMIT"
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.IdleBorderThickness = 1
        Me.btnSubmit.IdleCornerRadius = 20
        Me.btnSubmit.IdleFillColor = System.Drawing.Color.White
        Me.btnSubmit.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnSubmit.Location = New System.Drawing.Point(168, 394)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(297, 47)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.txtPassword.Location = New System.Drawing.Point(271, 317)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(242, 36)
        Me.txtPassword.TabIndex = 19
        '
        'txtMN
        '
        Me.txtMN.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.txtMN.Location = New System.Drawing.Point(271, 263)
        Me.txtMN.MaxLength = 1
        Me.txtMN.Multiline = True
        Me.txtMN.Name = "txtMN"
        Me.txtMN.Size = New System.Drawing.Size(242, 36)
        Me.txtMN.TabIndex = 16
        '
        'txtLN
        '
        Me.txtLN.Font = New System.Drawing.Font("Consolas", 15.75!)
        Me.txtLN.Location = New System.Drawing.Point(272, 210)
        Me.txtLN.Multiline = True
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(242, 36)
        Me.txtLN.TabIndex = 15
        '
        'txtFN
        '
        Me.txtFN.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.Location = New System.Drawing.Point(272, 158)
        Me.txtFN.Multiline = True
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(242, 36)
        Me.txtFN.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Password : "
        '
        'lblMN
        '
        Me.lblMN.AutoSize = True
        Me.lblMN.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMN.Location = New System.Drawing.Point(55, 267)
        Me.lblMN.Name = "lblMN"
        Me.lblMN.Size = New System.Drawing.Size(190, 22)
        Me.lblMN.TabIndex = 10
        Me.lblMN.Text = "Middle Initial  : "
        '
        'lblLN
        '
        Me.lblLN.AutoSize = True
        Me.lblLN.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLN.Location = New System.Drawing.Point(115, 215)
        Me.lblLN.Name = "lblLN"
        Me.lblLN.Size = New System.Drawing.Size(130, 22)
        Me.lblLN.TabIndex = 9
        Me.lblLN.Text = "Last Name : "
        '
        'lblFN
        '
        Me.lblFN.AutoSize = True
        Me.lblFN.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFN.Location = New System.Drawing.Point(105, 163)
        Me.lblFN.Name = "lblFN"
        Me.lblFN.Size = New System.Drawing.Size(130, 22)
        Me.lblFN.TabIndex = 8
        Me.lblFN.Text = "First Name :"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(36, 75)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(556, 35)
        Me.BunifuSeparator2.TabIndex = 2
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(388, 56)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CREATE ACCOUNT"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 500)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.parentPanel)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.sidePanel.ResumeLayout(False)
        Me.sidePanel.PerformLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.parentPanel.ResumeLayout(False)
        Me.orderPanel.ResumeLayout(False)
        Me.orderPanel.PerformLayout()
        CType(Me.orderGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.editAccPanel.ResumeLayout(False)
        Me.editAccPanel.PerformLayout()
        Me.staffPanel.ResumeLayout(False)
        Me.staffPanel.PerformLayout()
        CType(Me.gridStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.createAccPanel.ResumeLayout(False)
        Me.createAccPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidePanel As Panel
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents adminNameHolder As ns1.BunifuCustomLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCreateAcc As ns1.BunifuThinButton2
    Friend WithEvents btnOrder As ns1.BunifuThinButton2
    Friend WithEvents btnLogout As ns1.BunifuThinButton2
    Friend WithEvents btnEditAcc As ns1.BunifuThinButton2
    Friend WithEvents btnStaff As ns1.BunifuThinButton2
    Friend WithEvents parentPanel As Panel
    Friend WithEvents orderPanel As Panel
    Friend WithEvents lblOrder As Label
    Friend WithEvents BunifuSeparator3 As ns1.BunifuSeparator
    Friend WithEvents btnClaimed As ns1.BunifuThinButton2
    Friend WithEvents btnUnclaimed As ns1.BunifuThinButton2
    Friend WithEvents btnAll As ns1.BunifuThinButton2
    Friend WithEvents staffPanel As Panel
    Friend WithEvents orderGrid As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents drpdwnSort As ns1.BunifuDropdown
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents createAccPanel As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtMN As TextBox
    Friend WithEvents txtLN As TextBox
    Friend WithEvents txtFN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMN As Label
    Friend WithEvents lblLN As Label
    Friend WithEvents lblFN As Label
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents gridStaff As DataGridView
    Friend WithEvents btnSubmit As ns1.BunifuThinButton2
    Friend WithEvents txtStaffCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents editAccPanel As Panel
    Friend WithEvents txtPass As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtLastName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtMiddleName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtFirstName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnDelete As ns1.BunifuThinButton2
    Friend WithEvents btnEdit As ns1.BunifuThinButton2
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BunifuSeparator4 As ns1.BunifuSeparator
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSearch As ns1.BunifuThinButton2
    Friend WithEvents txtSearch As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents btnSave As ns1.BunifuTileButton
    Friend WithEvents deleteBtn As ns1.BunifuTileButton
    Friend WithEvents detailsBtn As ns1.BunifuTileButton
End Class
