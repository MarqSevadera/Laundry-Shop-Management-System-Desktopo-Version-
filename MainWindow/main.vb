
Imports MySql.Data.MySqlClient

Public Class Staff

    Public SQL As New SQLManager
    Public AsStaff As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        UpdateFineRetrievals()
        AsStaff = True
        If SQL.HasConnection() = True Then
            ShowData("SELECT strReferenceNumber , strDispatchDate,strName,strStatus,fltTotalPrice FROM tblOrder,tblPrices where tblorder.strReferenceNumber = tblPrices.tblOrder_strReferenceNumber")
        End If

        If SQL.HasConnection() = True Then
            SQL.AddParam("@staffcode", Login.StaffCode)
            SQL.RunQuery("Select strFirstName from tblStaff where strStaffCode = @staffCode")
            Dim tr As DataTableReader = SQL.Table.CreateDataReader()

            If tr.HasRows Then
                staffName.Text = SQL.Table.Rows(0)(0)
            End If
        End If


    End Sub


    Private Sub addOrderButton_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        GenerateRN()
        GenerateDates()
        addPanel.Visible = True
        claimPanel.Visible = False
        orderPanel.Visible = False

        btnAddOrder.IdleFillColor = Color.FromArgb(230, 215, 42)
        btnAddOrder.IdleForecolor = Color.Black
        btnOrder.IdleFillColor = Color.White
        btnOrder.IdleForecolor = Color.SeaGreen
        btnClaimOrder.IdleFillColor = Color.White
        btnClaimOrder.IdleForecolor = Color.SeaGreen

    End Sub

    Private Sub btnClaimOrder_Click(sender As Object, e As EventArgs) Handles btnClaimOrder.Click
        claimPanel.Visible = True
        addPanel.Visible = False
        orderPanel.Visible = False

        btnAddOrder.IdleFillColor = Color.White
        btnAddOrder.IdleForecolor = Color.SeaGreen
        btnOrder.IdleFillColor = Color.White
        btnOrder.IdleForecolor = Color.SeaGreen
        btnClaimOrder.IdleFillColor = Color.FromArgb(230, 215, 42)



        btnClaimOrder.IdleForecolor = Color.Black

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        If SQL.HasConnection() = True Then
            SQL.AddParam("@staffcode", Login.StaffCode)
            ShowData("SELECT strReferenceNumber , strDispatchDate,strName,strStatus,fltTotalPrice FROM tblOrder,tblPrices where tblorder.strReferenceNumber = tblPrices.tblOrder_strReferenceNumber")

        End If

        orderPanel.Visible = True
        claimPanel.Visible = False
        addPanel.Visible = False

        btnAddOrder.IdleFillColor = Color.White
        btnAddOrder.IdleForecolor = Color.SeaGreen
        btnOrder.IdleFillColor = Color.FromArgb(230, 215, 42)
        btnOrder.IdleForecolor = Color.Black
        btnClaimOrder.IdleFillColor = Color.White
        btnClaimOrder.IdleForecolor = Color.SeaGreen

    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs)

        btnAddOrder.IdleFillColor = Color.White
        btnAddOrder.IdleForecolor = Color.SeaGreen
        btnOrder.IdleFillColor = Color.White
        btnOrder.IdleForecolor = Color.SeaGreen
        btnClaimOrder.IdleFillColor = Color.White
        btnClaimOrder.IdleForecolor = Color.SeaGreen
    End Sub


    Private Sub ShowData(Query As String)

        'Clear Existing Records of DataTable
        If SQL.Table IsNot Nothing Then
            SQL.Table.Clear()
        End If

        Dim bSource As New BindingSource

        SQL.RunQuery(Query)

        bSource.DataSource = SQL.Table
        gridOrder.DataSource = bSource
        SQL.Adapter.Update(SQL.Table)

    End Sub

    Private Sub GenerateRN()

        SQL.RunQuery("SELECT * FROM mydb.tblorder ORDER BY strReferenceNumber desc limit 1")
        Dim Reader As DataTableReader
        Reader = SQL.Table.CreateDataReader

        If Reader.HasRows Then
            Dim strLastRefCode As String = " "
            Dim strNewRefCode As String

            While (Reader.Read)
                strLastRefCode = Reader(0)
            End While

            If (Not strLastRefCode = " ") Then

                strNewRefCode = Convert.ToInt32(New String(strLastRefCode) + 1).ToString("D6")
                lblRef.Text = strNewRefCode
            Else
                MsgBox("Something Went Wrong!")
            End If



        Else
            lblRef.Text = "000001"
        End If


    End Sub



    Private Sub GenerateDates()

        Dim receivedDate As DateTime = DateTime.Today
        Dim dispatchDate As DateTime = receivedDate.AddDays(2)

        recDateHolder.Text = receivedDate.ToString("dd/MM/yyyy")
        disDateHolder.Text = dispatchDate.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click

        If SQL.HasConnection() Then
            AddOrder()
        End If

    End Sub


    Private Sub AddOrder()

        Dim cloth As Single
        Dim bedding As Single
        Dim pieces As Integer
        Dim totPrice As Single
        Dim clothPrice As Single
        Dim bedPrice As Single
        Dim handwash As String
        Dim status As String = "Unclaimed"
        Dim totalWeight As Single

        SetDefaultValues()

        ' Parse the inputs to their corresponding type
        If Single.TryParse(txtClothes.Text, cloth) = True And Single.TryParse(txtBeds.Text, bedding) Then

        Else
            MsgBox("Invalid Input!", MsgBoxStyle.Exclamation, "Erroneous Input!")
            Return
        End If


        If Single.TryParse(txtBeds.Text, bedding) = True Then

        Else
            MsgBox("Invalid Input!", MsgBoxStyle.Exclamation, "Erroneous Input!")
            Return
        End If

        If Integer.TryParse(txtPieces.Text, pieces) = True Then

        Else
            MsgBox("Invalid Input!", MsgBoxStyle.Exclamation, "Erroneous Input!")
            Return
        End If


        If txtName.Text = "" Then
            MsgBox("Name Field Must be Filled Out!", MsgBoxStyle.Exclamation, "Missing Field!")
            Return
        End If

        If (cloth = 0 And bedding = 0) Or pieces = 0 Then
            MsgBox("Clothes or Beddings And Pieces Fields Must have a Value.", MsgBoxStyle.Exclamation, "Erroneous Input!")
            Return
        End If

        clothPrice = cloth * 25.0
        bedPrice = bedding * 40.0
        totPrice = clothPrice + bedPrice
        totalWeight = cloth + bedding


        If rbtnHandWash.Checked = True Then
            totPrice = (totPrice * 0.03) + totPrice
            handwash = "Hand Washed"
        Else
            handwash = "Machine Washed"
        End If



        SQL.AddParam("@staffcode", Login.StaffCode)
        SQL.AddParam("@cloth", cloth, DbType.Single)
        SQL.AddParam("@bedding", bedding, DbType.Single)
        SQL.AddParam("@pieces", pieces, DbType.Int32)
        SQL.AddParam("@refnum", lblRef.Text)
        SQL.AddParam("@name", txtName.Text)
        SQL.AddParam("@recDate", recDateHolder.Text)
        SQL.AddParam("@disDate", disDateHolder.Text)
        SQL.AddParam("@totPrice", totPrice, DbType.Single)
        SQL.AddParam("@clothPrice", clothPrice, DbType.Single)
        SQL.AddParam("@bedPrice", bedPrice, DbType.Single)
        SQL.AddParam("@handwash", handwash)
        SQL.AddParam("@status", status)
        SQL.AddParam("@weight", totalWeight, DbType.Single)

        SQL.RunQuery("INSERT INTO 
                      tblOrder(strReferenceNumber,strReceivedDate,strDispatchDate,strName,strStatus,
                              strIsHandWashed , intTotalPieces, tblStaff_strStaffCode)
                      VALUES(@refnum,@recDate,@disDate,@name,@status,@handwash,@pieces,@staffcode);

                     INSERT INTO 
                     tblWeight (fltTotalWeight,fltClothesWeight,fltBeddingsWeight,tblOrder_strReferenceNumber)
                     VALUES(@weight,@cloth,@bedding,@refnum);
    
                     INSERT INTO 
                     tblPrices(fltTotalPrice,fltClothesPrice,fltBeddingsPrice,tblOrder_strReferenceNumber)
                     VALUES(@totPrice,@clothPrice,@bedPrice,@refnum) ;
                    ")

        MsgBox("Order Successfully Added!", MsgBoxStyle.Information, "Successfully added!")
        GenerateRN()

        txtName.Clear()
        txtClothes.Clear()
        txtBeds.Clear()
        txtPieces.Clear()
        SetDefaultValues()
        rbtnMachine.Checked = True


    End Sub

    Private Sub SetDefaultValues()
        If txtBeds.Text = "" Then
            txtBeds.Text = "0.0"
        End If

        If txtClothes.Text = "" Then
            txtClothes.Text = "0.0"
        End If

        If txtPieces.Text = "" Then
            txtPieces.Text = "0.0"
        End If
    End Sub


    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        If SQL.HasConnection() = True Then
            SQL.AddParam("@staffcode", Login.StaffCode)
            ShowData("SELECT strReferenceNumber , strDispatchDate,strName,strStatus,fltTotalPrice FROM tblOrder,tblPrices where tblorder.strReferenceNumber = tblPrices.tblOrder_strReferenceNumber")

        End If
    End Sub

    Private Sub btnUnclaimed_Click(sender As Object, e As EventArgs) Handles btnUnclaimed.Click

        ShowData("SELECT strReferenceNumber , strDispatchDate,strName,strStatus,fltTotalPrice FROM tblorder,tblPrices WHERE tblorder.strReferenceNumber = tblPrices.tblOrder_strReferenceNumber AND strStatus = 'Unclaimed'")
    End Sub

    Private Sub btnClaimed_Click(sender As Object, e As EventArgs) Handles btnClaimed.Click

        ShowData("SELECT strReferenceNumber , strDispatchDate,strName,strStatus,fltTotalPrice FROM tblorder,tblPrices WHERE tblorder.strReferenceNumber = tblPrices.tblOrder_strReferenceNumber AND strStatus = 'Claimed'")

    End Sub




    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearchRef.Text = "" Then
            MsgBox("Nothing to Search!", MsgBoxStyle.Exclamation, "No Input!")
        Else
            If SQL.HasConnection() = True Then
                SQL.AddParam("@ref", txtSearchRef.Text)
                SQL.RunQuery("SELECT strReferenceNumber,strName,strDispatchDate,strStatus,fltTotalPrice FROM tblorder,tblPrices WHERE (strReferenceNumber = @ref) AND strReferenceNumber = tblOrder_strReferenceNumber")
                Dim dr As DataTableReader
                dr = SQL.Table.CreateDataReader
                If dr.HasRows Then
                    referenceHolder.Text = SQL.Table.Rows(0)(0)
                    nameHolder.Text = SQL.Table.Rows(0)(1)
                    dateHolder.Text = SQL.Table.Rows(0)(2)
                    statusHolder.Text = SQL.Table.Rows(0)(3)
                    priceHolder.Text = SQL.Table.Rows(0)(4)
                    btnClaim.Enabled = True
                Else
                    MsgBox("Reference Number Not Found!", MsgBoxStyle.Exclamation, "Not Found!")
                End If

                If statusHolder.Text = "Claimed" Then
                    btnClaim.Enabled = False
                    btnClaim.BorderStyle = BorderStyle.Fixed3D
                Else
                    btnClaim.Enabled = True
                    btnClaim.BorderStyle = BorderStyle.FixedSingle
                End If
            End If
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Logout?") = MsgBoxResult.Yes Then
            Me.Close()
            Login.Show()

        End If
    End Sub

    Private Sub btnClaim_Click_1(sender As Object, e As EventArgs) Handles btnClaim.Click
        If nameHolder.Text = "" Then
            MsgBox("Search Reference Number to Claim!", MsgBoxStyle.Information)
        Else
            If SQL.HasConnection() = True Then
                Dim claimed As String = "Claimed"
                SQL.AddParam("@status", claimed)
                SQL.AddParam("@ref", referenceHolder.Text)
                SQL.RunQuery("UPDATE tblorder SET strStatus = @status WHERE strReferenceNumber = @ref ")
                MsgBox("Order Successfully Claimed!", MsgBoxStyle.Information, "Claim Successful!")
                statusHolder.Text = "Claimed"
                btnClaim.Enabled = False
                btnClaim.BorderStyle = BorderStyle.Fixed3D
            End If
        End If
    End Sub



    Private Sub btnMoreDetails_Click(sender As Object, e As EventArgs) Handles btnMoreDetails.Click

        OrderDetails.Show()


    End Sub

    Private Sub gridOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridOrder.CellClick
        Dim constraint As String
        Try
            If gridOrder.Rows(e.RowIndex).Cells(0).Value.ToString = "" Then
                btnMoreDetails.Enabled = False
                btnMoreDetails.BorderStyle = BorderStyle.Fixed3D
            Else
                btnMoreDetails.Enabled = True
                btnMoreDetails.BorderStyle = BorderStyle.FixedSingle
            End If

            SQL.FlushParams() 'Flush the previous params first
            constraint = gridOrder.Rows(e.RowIndex).Cells(0).Value.ToString
            SQL.AddParam("@constraint", constraint)
        Catch

        End Try
    End Sub



    Private Sub UpdateFineRetrievals()

        If SQL.HasConnection() Then
            Dim query As String = ""
            SQL.RunQuery("SELECT tblOrder_strReferenceNumber,strDispatchDate, fltTotalPrice , fltClothesPrice , fltBeddingsPrice  FROM tblOrder,tblPrices")
            Dim diff As Long
            Dim disDate As DateTime
            Dim dateNow As DateTime = DateTime.Now
            Dim lateFine As Single
            Dim totalPrice As Single
            Dim refNum As String

            For Each row As DataRow In SQL.Table.Rows

                refNum = row(0)
                disDate = DateTime.ParseExact(row(1), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) 'Dispatch Date
                diff = DateAndTime.DateDiff(DateInterval.Day, disDate, dateNow)


                If (diff > 0) Then
                    totalPrice = row(2)
                    lateFine = diff * 5.0
                    totalPrice = totalPrice + lateFine
                    SQL.AddParam("@fine", lateFine)
                    SQL.AddParam("@totalPrice", totalPrice)
                    SQL.RunQuery("UPDATE tblprices SET fltFinePrice = @fine , fltTotalPrice = @totalPrice")
                Else

                    lateFine = 0
                    totalPrice = row(3) + row(4)
                    SQL.AddParam("@totPrice", totalPrice)
                    SQL.AddParam("@fine", lateFine)
                    SQL.AddParam("@refNum", refNum)
                    SQL.RunQuery("UPDATE tblprices SET fltTotalPrice = @totPrice , fltFinePrice = @fine WHERE tblOrder_strReferenceNumber = @refNum")
                End If

            Next

        End If

    End Sub

End Class
