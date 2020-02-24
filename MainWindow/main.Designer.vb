<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.sidePanel = New System.Windows.Forms.Panel()
        Me.btnLogout = New ns1.BunifuThinButton2()
        Me.staffName = New ns1.BunifuCustomLabel()
        Me.btnClaimOrder = New ns1.BunifuThinButton2()
        Me.btnAddOrder = New ns1.BunifuThinButton2()
        Me.btnOrder = New ns1.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pictureBox = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New ns1.BunifuSeparator()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addPanel = New System.Windows.Forms.Panel()
        Me.btnSaveOrder = New ns1.BunifuThinButton2()
        Me.btnSave = New ns1.BunifuThinButton2()
        Me.disDateHolder = New ns1.BunifuCustomLabel()
        Me.lblDisDate = New ns1.BunifuCustomLabel()
        Me.recDateHolder = New ns1.BunifuCustomLabel()
        Me.lblRecDate = New ns1.BunifuCustomLabel()
        Me.rbtnHandWash = New System.Windows.Forms.RadioButton()
        Me.rbtnMachine = New System.Windows.Forms.RadioButton()
        Me.txtPieces = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblPieces = New ns1.BunifuCustomLabel()
        Me.txtBeds = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblBeddings = New ns1.BunifuCustomLabel()
        Me.txtClothes = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblClothes = New ns1.BunifuCustomLabel()
        Me.lblRef = New ns1.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.txtName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.lblName = New ns1.BunifuCustomLabel()
        Me.claimPanel = New System.Windows.Forms.Panel()
        Me.btnClaim = New ns1.BunifuTileButton()
        Me.priceHolder = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.statusHolder = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.referenceHolder = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.dateHolder = New System.Windows.Forms.Label()
        Me.lblDispatchDate = New System.Windows.Forms.Label()
        Me.nameHolder = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSearch = New ns1.BunifuThinButton2()
        Me.txtSearchRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New ns1.BunifuSeparator()
        Me.claimLabel = New System.Windows.Forms.Label()
        Me.parentPanel = New System.Windows.Forms.Panel()
        Me.orderPanel = New System.Windows.Forms.Panel()
        Me.btnMoreDetails = New ns1.BunifuTileButton()
        Me.gridOrder = New System.Windows.Forms.DataGridView()
        Me.btnClaimed = New ns1.BunifuThinButton2()
        Me.btnUnclaimed = New ns1.BunifuThinButton2()
        Me.btnAll = New ns1.BunifuThinButton2()
        Me.BunifuSeparator3 = New ns1.BunifuSeparator()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.sidePanel.SuspendLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addPanel.SuspendLayout()
        Me.claimPanel.SuspendLayout()
        Me.parentPanel.SuspendLayout()
        Me.orderPanel.SuspendLayout()
        CType(Me.gridOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidePanel
        '
        Me.sidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.sidePanel.Controls.Add(Me.btnLogout)
        Me.sidePanel.Controls.Add(Me.staffName)
        Me.sidePanel.Controls.Add(Me.btnClaimOrder)
        Me.sidePanel.Controls.Add(Me.btnAddOrder)
        Me.sidePanel.Controls.Add(Me.btnOrder)
        Me.sidePanel.Controls.Add(Me.Label2)
        Me.sidePanel.Controls.Add(Me.pictureBox)
        Me.sidePanel.Location = New System.Drawing.Point(0, 0)
        Me.sidePanel.Name = "sidePanel"
        Me.sidePanel.Size = New System.Drawing.Size(220, 503)
        Me.sidePanel.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.ActiveBorderThickness = 1
        Me.btnLogout.ActiveCornerRadius = 20
        Me.btnLogout.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogout.ActiveForecolor = System.Drawing.Color.Black
        Me.btnLogout.ActiveLineColor = System.Drawing.Color.Black
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
        Me.btnLogout.Location = New System.Drawing.Point(-17, 397)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(243, 43)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'staffName
        '
        Me.staffName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.staffName.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.staffName.Location = New System.Drawing.Point(62, 146)
        Me.staffName.Name = "staffName"
        Me.staffName.Size = New System.Drawing.Size(90, 28)
        Me.staffName.TabIndex = 8
        Me.staffName.Text = "Marque"
        Me.staffName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClaimOrder
        '
        Me.btnClaimOrder.ActiveBorderThickness = 1
        Me.btnClaimOrder.ActiveCornerRadius = 20
        Me.btnClaimOrder.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnClaimOrder.ActiveForecolor = System.Drawing.Color.Black
        Me.btnClaimOrder.ActiveLineColor = System.Drawing.Color.Black
        Me.btnClaimOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnClaimOrder.BackgroundImage = CType(resources.GetObject("btnClaimOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnClaimOrder.ButtonText = "CLAIM ORDER"
        Me.btnClaimOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClaimOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClaimOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClaimOrder.IdleBorderThickness = 1
        Me.btnClaimOrder.IdleCornerRadius = 20
        Me.btnClaimOrder.IdleFillColor = System.Drawing.Color.White
        Me.btnClaimOrder.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnClaimOrder.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnClaimOrder.Location = New System.Drawing.Point(-17, 355)
        Me.btnClaimOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClaimOrder.Name = "btnClaimOrder"
        Me.btnClaimOrder.Size = New System.Drawing.Size(243, 43)
        Me.btnClaimOrder.TabIndex = 6
        Me.btnClaimOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddOrder
        '
        Me.btnAddOrder.ActiveBorderThickness = 1
        Me.btnAddOrder.ActiveCornerRadius = 20
        Me.btnAddOrder.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAddOrder.ActiveForecolor = System.Drawing.Color.Black
        Me.btnAddOrder.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnAddOrder.BackgroundImage = CType(resources.GetObject("btnAddOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnAddOrder.ButtonText = "ADD ORDER"
        Me.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddOrder.IdleBorderThickness = 1
        Me.btnAddOrder.IdleCornerRadius = 20
        Me.btnAddOrder.IdleFillColor = System.Drawing.Color.White
        Me.btnAddOrder.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnAddOrder.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnAddOrder.Location = New System.Drawing.Point(-17, 314)
        Me.btnAddOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(243, 43)
        Me.btnAddOrder.TabIndex = 7
        Me.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnOrder.Location = New System.Drawing.Point(-17, 272)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(243, 43)
        Me.btnOrder.TabIndex = 6
        Me.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(75, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "STAFF"
        '
        'pictureBox
        '
        Me.pictureBox.Image = Global.MainWindow.My.Resources.Resources.user_male_circle_filled1600
        Me.pictureBox.Location = New System.Drawing.Point(59, 36)
        Me.pictureBox.Name = "pictureBox"
        Me.pictureBox.Size = New System.Drawing.Size(96, 96)
        Me.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox.TabIndex = 0
        Me.pictureBox.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.Color.Aqua
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(46, 94)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(528, 28)
        Me.BunifuSeparator1.TabIndex = 4
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(36, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(258, 56)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ADD ORDER"
        '
        'addPanel
        '
        Me.addPanel.Controls.Add(Me.btnSaveOrder)
        Me.addPanel.Controls.Add(Me.btnSave)
        Me.addPanel.Controls.Add(Me.disDateHolder)
        Me.addPanel.Controls.Add(Me.lblDisDate)
        Me.addPanel.Controls.Add(Me.recDateHolder)
        Me.addPanel.Controls.Add(Me.lblRecDate)
        Me.addPanel.Controls.Add(Me.rbtnHandWash)
        Me.addPanel.Controls.Add(Me.rbtnMachine)
        Me.addPanel.Controls.Add(Me.txtPieces)
        Me.addPanel.Controls.Add(Me.lblPieces)
        Me.addPanel.Controls.Add(Me.txtBeds)
        Me.addPanel.Controls.Add(Me.lblBeddings)
        Me.addPanel.Controls.Add(Me.txtClothes)
        Me.addPanel.Controls.Add(Me.lblClothes)
        Me.addPanel.Controls.Add(Me.lblRef)
        Me.addPanel.Controls.Add(Me.BunifuCustomLabel1)
        Me.addPanel.Controls.Add(Me.txtName)
        Me.addPanel.Controls.Add(Me.lblName)
        Me.addPanel.Controls.Add(Me.Label3)
        Me.addPanel.Controls.Add(Me.BunifuSeparator1)
        Me.addPanel.Location = New System.Drawing.Point(0, 0)
        Me.addPanel.Name = "addPanel"
        Me.addPanel.Size = New System.Drawing.Size(635, 500)
        Me.addPanel.TabIndex = 2
        Me.addPanel.Visible = False
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.ActiveBorderThickness = 1
        Me.btnSaveOrder.ActiveCornerRadius = 20
        Me.btnSaveOrder.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnSaveOrder.ActiveForecolor = System.Drawing.Color.White
        Me.btnSaveOrder.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnSaveOrder.BackColor = System.Drawing.Color.White
        Me.btnSaveOrder.BackgroundImage = CType(resources.GetObject("btnSaveOrder.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveOrder.ButtonText = "SAVE ORDER"
        Me.btnSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveOrder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOrder.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSaveOrder.IdleBorderThickness = 1
        Me.btnSaveOrder.IdleCornerRadius = 20
        Me.btnSaveOrder.IdleFillColor = System.Drawing.Color.White
        Me.btnSaveOrder.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnSaveOrder.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnSaveOrder.Location = New System.Drawing.Point(223, 428)
        Me.btnSaveOrder.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(181, 41)
        Me.btnSaveOrder.TabIndex = 23
        Me.btnSaveOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.ActiveBorderThickness = 1
        Me.btnSave.ActiveCornerRadius = 20
        Me.btnSave.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnSave.ActiveForecolor = System.Drawing.Color.White
        Me.btnSave.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.ButtonText = "SAVE ORDER"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSave.IdleBorderThickness = 1
        Me.btnSave.IdleCornerRadius = 20
        Me.btnSave.IdleFillColor = System.Drawing.Color.White
        Me.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnSave.Location = New System.Drawing.Point(347, 579)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(253, 55)
        Me.btnSave.TabIndex = 22
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'disDateHolder
        '
        Me.disDateHolder.AutoSize = True
        Me.disDateHolder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disDateHolder.Location = New System.Drawing.Point(493, 379)
        Me.disDateHolder.Name = "disDateHolder"
        Me.disDateHolder.Size = New System.Drawing.Size(77, 19)
        Me.disDateHolder.TabIndex = 21
        Me.disDateHolder.Text = "09/30/17"
        '
        'lblDisDate
        '
        Me.lblDisDate.AutoSize = True
        Me.lblDisDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisDate.Location = New System.Drawing.Point(353, 379)
        Me.lblDisDate.Name = "lblDisDate"
        Me.lblDisDate.Size = New System.Drawing.Size(137, 19)
        Me.lblDisDate.TabIndex = 20
        Me.lblDisDate.Text = "DISPATCH DATE : "
        '
        'recDateHolder
        '
        Me.recDateHolder.AutoSize = True
        Me.recDateHolder.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recDateHolder.Location = New System.Drawing.Point(220, 379)
        Me.recDateHolder.Name = "recDateHolder"
        Me.recDateHolder.Size = New System.Drawing.Size(77, 19)
        Me.recDateHolder.TabIndex = 19
        Me.recDateHolder.Text = "09/28/17"
        '
        'lblRecDate
        '
        Me.lblRecDate.AutoSize = True
        Me.lblRecDate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecDate.Location = New System.Drawing.Point(80, 379)
        Me.lblRecDate.Name = "lblRecDate"
        Me.lblRecDate.Size = New System.Drawing.Size(134, 19)
        Me.lblRecDate.TabIndex = 18
        Me.lblRecDate.Text = "RECEIVED DATE : "
        '
        'rbtnHandWash
        '
        Me.rbtnHandWash.AutoSize = True
        Me.rbtnHandWash.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnHandWash.Location = New System.Drawing.Point(353, 314)
        Me.rbtnHandWash.Name = "rbtnHandWash"
        Me.rbtnHandWash.Size = New System.Drawing.Size(136, 28)
        Me.rbtnHandWash.TabIndex = 17
        Me.rbtnHandWash.Text = "HAND WASH"
        Me.rbtnHandWash.UseVisualStyleBackColor = True
        '
        'rbtnMachine
        '
        Me.rbtnMachine.AutoSize = True
        Me.rbtnMachine.Checked = True
        Me.rbtnMachine.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnMachine.Location = New System.Drawing.Point(155, 314)
        Me.rbtnMachine.Name = "rbtnMachine"
        Me.rbtnMachine.Size = New System.Drawing.Size(172, 28)
        Me.rbtnMachine.TabIndex = 16
        Me.rbtnMachine.TabStop = True
        Me.rbtnMachine.Text = "MACHINE WASH"
        Me.rbtnMachine.UseVisualStyleBackColor = True
        '
        'txtPieces
        '
        Me.txtPieces.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtPieces.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPieces.Location = New System.Drawing.Point(410, 217)
        Me.txtPieces.MaxLength = 7
        Me.txtPieces.Name = "txtPieces"
        Me.txtPieces.Size = New System.Drawing.Size(70, 30)
        Me.txtPieces.TabIndex = 15
        Me.txtPieces.Text = "0"
        '
        'lblPieces
        '
        Me.lblPieces.AutoSize = True
        Me.lblPieces.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPieces.Location = New System.Drawing.Point(334, 222)
        Me.lblPieces.Name = "lblPieces"
        Me.lblPieces.Size = New System.Drawing.Size(70, 19)
        Me.lblPieces.TabIndex = 14
        Me.lblPieces.Text = "PIECES : "
        '
        'txtBeds
        '
        Me.txtBeds.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtBeds.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeds.Location = New System.Drawing.Point(223, 265)
        Me.txtBeds.MaxLength = 7
        Me.txtBeds.Name = "txtBeds"
        Me.txtBeds.Size = New System.Drawing.Size(71, 30)
        Me.txtBeds.TabIndex = 13
        Me.txtBeds.Text = "0.0"
        '
        'lblBeddings
        '
        Me.lblBeddings.AutoSize = True
        Me.lblBeddings.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeddings.Location = New System.Drawing.Point(124, 269)
        Me.lblBeddings.Name = "lblBeddings"
        Me.lblBeddings.Size = New System.Drawing.Size(93, 19)
        Me.lblBeddings.TabIndex = 12
        Me.lblBeddings.Text = "BEDDINGS: "
        '
        'txtClothes
        '
        Me.txtClothes.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtClothes.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClothes.Location = New System.Drawing.Point(223, 219)
        Me.txtClothes.MaxLength = 7
        Me.txtClothes.Name = "txtClothes"
        Me.txtClothes.Size = New System.Drawing.Size(71, 30)
        Me.txtClothes.TabIndex = 11
        Me.txtClothes.Text = "0.0"
        '
        'lblClothes
        '
        Me.lblClothes.AutoSize = True
        Me.lblClothes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClothes.Location = New System.Drawing.Point(130, 224)
        Me.lblClothes.Name = "lblClothes"
        Me.lblClothes.Size = New System.Drawing.Size(87, 19)
        Me.lblClothes.TabIndex = 10
        Me.lblClothes.Text = "CLOTHES : "
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRef.Location = New System.Drawing.Point(345, 125)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(63, 19)
        Me.lblRef.TabIndex = 9
        Me.lblRef.Text = "000000"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(203, 125)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(136, 19)
        Me.BunifuCustomLabel1.TabIndex = 8
        Me.BunifuCustomLabel1.Text = "REFERENCE NO. : "
        '
        'txtName
        '
        Me.txtName.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtName.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(232, 166)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(198, 30)
        Me.txtName.TabIndex = 7
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(154, 171)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 19)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "NAME: "
        '
        'claimPanel
        '
        Me.claimPanel.BackColor = System.Drawing.Color.White
        Me.claimPanel.Controls.Add(Me.btnClaim)
        Me.claimPanel.Controls.Add(Me.priceHolder)
        Me.claimPanel.Controls.Add(Me.lblPrice)
        Me.claimPanel.Controls.Add(Me.statusHolder)
        Me.claimPanel.Controls.Add(Me.lblStatus)
        Me.claimPanel.Controls.Add(Me.referenceHolder)
        Me.claimPanel.Controls.Add(Me.lblReference)
        Me.claimPanel.Controls.Add(Me.dateHolder)
        Me.claimPanel.Controls.Add(Me.lblDispatchDate)
        Me.claimPanel.Controls.Add(Me.nameHolder)
        Me.claimPanel.Controls.Add(Me.Label4)
        Me.claimPanel.Controls.Add(Me.btnSearch)
        Me.claimPanel.Controls.Add(Me.txtSearchRef)
        Me.claimPanel.Controls.Add(Me.Label1)
        Me.claimPanel.Controls.Add(Me.BunifuSeparator2)
        Me.claimPanel.Controls.Add(Me.claimLabel)
        Me.claimPanel.Location = New System.Drawing.Point(0, 0)
        Me.claimPanel.Name = "claimPanel"
        Me.claimPanel.Size = New System.Drawing.Size(635, 503)
        Me.claimPanel.TabIndex = 24
        Me.claimPanel.Visible = False
        '
        'btnClaim
        '
        Me.btnClaim.BackColor = System.Drawing.Color.Transparent
        Me.btnClaim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnClaim.color = System.Drawing.Color.Transparent
        Me.btnClaim.colorActive = System.Drawing.Color.SeaGreen
        Me.btnClaim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClaim.Enabled = False
        Me.btnClaim.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnClaim.ForeColor = System.Drawing.Color.Black
        Me.btnClaim.Image = CType(resources.GetObject("btnClaim.Image"), System.Drawing.Image)
        Me.btnClaim.ImagePosition = 20
        Me.btnClaim.ImageZoom = 50
        Me.btnClaim.LabelPosition = 41
        Me.btnClaim.LabelText = "CLAIM"
        Me.btnClaim.Location = New System.Drawing.Point(200, 404)
        Me.btnClaim.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClaim.Name = "btnClaim"
        Me.btnClaim.Size = New System.Drawing.Size(198, 48)
        Me.btnClaim.TabIndex = 15
        '
        'priceHolder
        '
        Me.priceHolder.AutoSize = True
        Me.priceHolder.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceHolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.priceHolder.Location = New System.Drawing.Point(291, 345)
        Me.priceHolder.Name = "priceHolder"
        Me.priceHolder.Size = New System.Drawing.Size(0, 28)
        Me.priceHolder.TabIndex = 14
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblPrice.Location = New System.Drawing.Point(195, 345)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(90, 28)
        Me.lblPrice.TabIndex = 13
        Me.lblPrice.Text = "PRICE:"
        '
        'statusHolder
        '
        Me.statusHolder.AutoSize = True
        Me.statusHolder.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusHolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.statusHolder.Location = New System.Drawing.Point(291, 314)
        Me.statusHolder.Name = "statusHolder"
        Me.statusHolder.Size = New System.Drawing.Size(0, 28)
        Me.statusHolder.TabIndex = 12
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStatus.Location = New System.Drawing.Point(182, 313)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(103, 28)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "STATUS:"
        '
        'referenceHolder
        '
        Me.referenceHolder.AutoSize = True
        Me.referenceHolder.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.referenceHolder.Location = New System.Drawing.Point(291, 206)
        Me.referenceHolder.Name = "referenceHolder"
        Me.referenceHolder.Size = New System.Drawing.Size(0, 28)
        Me.referenceHolder.TabIndex = 10
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReference.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblReference.Location = New System.Drawing.Point(143, 206)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(142, 28)
        Me.lblReference.TabIndex = 9
        Me.lblReference.Text = "REFERENCE:"
        '
        'dateHolder
        '
        Me.dateHolder.AutoSize = True
        Me.dateHolder.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateHolder.Location = New System.Drawing.Point(291, 283)
        Me.dateHolder.Name = "dateHolder"
        Me.dateHolder.Size = New System.Drawing.Size(0, 28)
        Me.dateHolder.TabIndex = 8
        '
        'lblDispatchDate
        '
        Me.lblDispatchDate.AutoSize = True
        Me.lblDispatchDate.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispatchDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDispatchDate.Location = New System.Drawing.Point(91, 280)
        Me.lblDispatchDate.Name = "lblDispatchDate"
        Me.lblDispatchDate.Size = New System.Drawing.Size(194, 28)
        Me.lblDispatchDate.TabIndex = 7
        Me.lblDispatchDate.Text = "DISPATCH DATE:"
        '
        'nameHolder
        '
        Me.nameHolder.AutoSize = True
        Me.nameHolder.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameHolder.Location = New System.Drawing.Point(291, 243)
        Me.nameHolder.Name = "nameHolder"
        Me.nameHolder.Size = New System.Drawing.Size(0, 28)
        Me.nameHolder.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(208, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NAME:"
        '
        'btnSearch
        '
        Me.btnSearch.ActiveBorderThickness = 1
        Me.btnSearch.ActiveCornerRadius = 20
        Me.btnSearch.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnSearch.ActiveForecolor = System.Drawing.Color.White
        Me.btnSearch.ActiveLineColor = System.Drawing.Color.Sienna
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.ButtonText = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.IdleBorderThickness = 1
        Me.btnSearch.IdleCornerRadius = 20
        Me.btnSearch.IdleFillColor = System.Drawing.Color.White
        Me.btnSearch.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnSearch.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnSearch.Location = New System.Drawing.Point(423, 149)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(74, 38)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearchRef
        '
        Me.txtSearchRef.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchRef.Location = New System.Drawing.Point(264, 153)
        Me.txtSearchRef.Multiline = True
        Me.txtSearchRef.Name = "txtSearchRef"
        Me.txtSearchRef.Size = New System.Drawing.Size(151, 28)
        Me.txtSearchRef.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Reference: "
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(46, 94)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(528, 35)
        Me.BunifuSeparator2.TabIndex = 1
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'claimLabel
        '
        Me.claimLabel.AutoSize = True
        Me.claimLabel.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.claimLabel.Location = New System.Drawing.Point(36, 47)
        Me.claimLabel.Name = "claimLabel"
        Me.claimLabel.Size = New System.Drawing.Size(310, 56)
        Me.claimLabel.TabIndex = 0
        Me.claimLabel.Text = "CLAIM ORDER"
        '
        'parentPanel
        '
        Me.parentPanel.Controls.Add(Me.orderPanel)
        Me.parentPanel.Controls.Add(Me.claimPanel)
        Me.parentPanel.Controls.Add(Me.addPanel)
        Me.parentPanel.Location = New System.Drawing.Point(219, 0)
        Me.parentPanel.Name = "parentPanel"
        Me.parentPanel.Size = New System.Drawing.Size(629, 503)
        Me.parentPanel.TabIndex = 5
        '
        'orderPanel
        '
        Me.orderPanel.Controls.Add(Me.btnMoreDetails)
        Me.orderPanel.Controls.Add(Me.gridOrder)
        Me.orderPanel.Controls.Add(Me.btnClaimed)
        Me.orderPanel.Controls.Add(Me.btnUnclaimed)
        Me.orderPanel.Controls.Add(Me.btnAll)
        Me.orderPanel.Controls.Add(Me.BunifuSeparator3)
        Me.orderPanel.Controls.Add(Me.lblOrder)
        Me.orderPanel.Location = New System.Drawing.Point(0, 0)
        Me.orderPanel.Name = "orderPanel"
        Me.orderPanel.Size = New System.Drawing.Size(632, 500)
        Me.orderPanel.TabIndex = 24
        '
        'btnMoreDetails
        '
        Me.btnMoreDetails.BackColor = System.Drawing.Color.Transparent
        Me.btnMoreDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnMoreDetails.color = System.Drawing.Color.Transparent
        Me.btnMoreDetails.colorActive = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnMoreDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoreDetails.Enabled = False
        Me.btnMoreDetails.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.btnMoreDetails.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnMoreDetails.Image = CType(resources.GetObject("btnMoreDetails.Image"), System.Drawing.Image)
        Me.btnMoreDetails.ImagePosition = 20
        Me.btnMoreDetails.ImageZoom = 50
        Me.btnMoreDetails.LabelPosition = 41
        Me.btnMoreDetails.LabelText = "More Details"
        Me.btnMoreDetails.Location = New System.Drawing.Point(206, 435)
        Me.btnMoreDetails.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMoreDetails.Name = "btnMoreDetails"
        Me.btnMoreDetails.Size = New System.Drawing.Size(198, 50)
        Me.btnMoreDetails.TabIndex = 7
        '
        'gridOrder
        '
        Me.gridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOrder.Location = New System.Drawing.Point(36, 180)
        Me.gridOrder.Name = "gridOrder"
        Me.gridOrder.Size = New System.Drawing.Size(556, 246)
        Me.gridOrder.TabIndex = 5
        '
        'btnClaimed
        '
        Me.btnClaimed.ActiveBorderThickness = 1
        Me.btnClaimed.ActiveCornerRadius = 20
        Me.btnClaimed.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnClaimed.ActiveForecolor = System.Drawing.Color.White
        Me.btnClaimed.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnClaimed.BackColor = System.Drawing.Color.White
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
        Me.btnClaimed.Location = New System.Drawing.Point(408, 129)
        Me.btnClaimed.Margin = New System.Windows.Forms.Padding(5)
        Me.btnClaimed.Name = "btnClaimed"
        Me.btnClaimed.Size = New System.Drawing.Size(126, 37)
        Me.btnClaimed.TabIndex = 4
        Me.btnClaimed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUnclaimed
        '
        Me.btnUnclaimed.ActiveBorderThickness = 1
        Me.btnUnclaimed.ActiveCornerRadius = 20
        Me.btnUnclaimed.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnUnclaimed.ActiveForecolor = System.Drawing.Color.White
        Me.btnUnclaimed.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnUnclaimed.BackColor = System.Drawing.Color.White
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
        Me.btnUnclaimed.Location = New System.Drawing.Point(248, 129)
        Me.btnUnclaimed.Margin = New System.Windows.Forms.Padding(5)
        Me.btnUnclaimed.Name = "btnUnclaimed"
        Me.btnUnclaimed.Size = New System.Drawing.Size(126, 37)
        Me.btnUnclaimed.TabIndex = 3
        Me.btnUnclaimed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAll
        '
        Me.btnAll.ActiveBorderThickness = 1
        Me.btnAll.ActiveCornerRadius = 20
        Me.btnAll.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnAll.ActiveForecolor = System.Drawing.Color.White
        Me.btnAll.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnAll.BackColor = System.Drawing.Color.White
        Me.btnAll.BackgroundImage = CType(resources.GetObject("btnAll.BackgroundImage"), System.Drawing.Image)
        Me.btnAll.ButtonText = "ALL"
        Me.btnAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAll.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAll.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnAll.IdleBorderThickness = 1
        Me.btnAll.IdleCornerRadius = 20
        Me.btnAll.IdleFillColor = System.Drawing.Color.White
        Me.btnAll.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnAll.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnAll.Location = New System.Drawing.Point(86, 129)
        Me.btnAll.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(126, 37)
        Me.btnAll.TabIndex = 2
        Me.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 1
        Me.BunifuSeparator3.Location = New System.Drawing.Point(46, 94)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(556, 35)
        Me.BunifuSeparator3.TabIndex = 1
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrder.Location = New System.Drawing.Point(36, 47)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(180, 56)
        Me.lblOrder.TabIndex = 0
        Me.lblOrder.Text = "ORDERS"
        '
        'Staff
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(849, 500)
        Me.Controls.Add(Me.sidePanel)
        Me.Controls.Add(Me.parentPanel)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Staff"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Dashboard"
        Me.sidePanel.ResumeLayout(False)
        Me.sidePanel.PerformLayout()
        CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addPanel.ResumeLayout(False)
        Me.addPanel.PerformLayout()
        Me.claimPanel.ResumeLayout(False)
        Me.claimPanel.PerformLayout()
        Me.parentPanel.ResumeLayout(False)
        Me.orderPanel.ResumeLayout(False)
        Me.orderPanel.PerformLayout()
        CType(Me.gridOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sidePanel As System.Windows.Forms.Panel
    Friend WithEvents pictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClaimOrder As ns1.BunifuThinButton2
    Friend WithEvents btnAddOrder As ns1.BunifuThinButton2
    Friend WithEvents btnOrder As ns1.BunifuThinButton2
    Friend WithEvents BunifuSeparator1 As ns1.BunifuSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As ns1.BunifuThinButton2
    Private WithEvents addPanel As System.Windows.Forms.Panel
    Friend WithEvents staffName As ns1.BunifuCustomLabel
    Friend WithEvents btnSaveOrder As ns1.BunifuThinButton2
    Friend WithEvents disDateHolder As ns1.BunifuCustomLabel
    Friend WithEvents lblDisDate As ns1.BunifuCustomLabel
    Friend WithEvents recDateHolder As ns1.BunifuCustomLabel
    Friend WithEvents lblRecDate As ns1.BunifuCustomLabel
    Friend WithEvents rbtnHandWash As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMachine As System.Windows.Forms.RadioButton
    Friend WithEvents txtPieces As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblPieces As ns1.BunifuCustomLabel
    Friend WithEvents txtBeds As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblBeddings As ns1.BunifuCustomLabel
    Friend WithEvents txtClothes As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblClothes As ns1.BunifuCustomLabel
    Friend WithEvents lblRef As ns1.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents txtName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents lblName As ns1.BunifuCustomLabel
    Friend WithEvents claimPanel As System.Windows.Forms.Panel
    Friend WithEvents btnSearch As ns1.BunifuThinButton2
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator2 As ns1.BunifuSeparator
    Friend WithEvents claimLabel As System.Windows.Forms.Label
    Friend WithEvents parentPanel As System.Windows.Forms.Panel
    Friend WithEvents lblDispatchDate As System.Windows.Forms.Label
    Friend WithEvents nameHolder As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents statusHolder As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents referenceHolder As System.Windows.Forms.Label
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents dateHolder As System.Windows.Forms.Label
    Friend WithEvents priceHolder As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents orderPanel As System.Windows.Forms.Panel
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents BunifuSeparator3 As ns1.BunifuSeparator
    Friend WithEvents btnClaimed As ns1.BunifuThinButton2
    Friend WithEvents btnUnclaimed As ns1.BunifuThinButton2
    Friend WithEvents btnAll As ns1.BunifuThinButton2
    Friend WithEvents gridOrder As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchRef As TextBox
    Friend WithEvents btnLogout As ns1.BunifuThinButton2
    Friend WithEvents btnMoreDetails As ns1.BunifuTileButton
    Friend WithEvents btnClaim As ns1.BunifuTileButton
End Class
