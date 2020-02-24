
Imports MySql.Data.MySqlClient

Public Class Admin


    Public SQL As New SQLManager

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        orderPanel.Visible = True
        editAccPanel.Visible = False
        createAccPanel.Visible = False
        staffPanel.Visible = False

        btnOrder.IdleFillColor = Color.FromArgb(230, 215, 42)
        btnOrder.IdleForecolor = Color.Black

        btnEditAcc.IdleFillColor = Color.White
        btnEditAcc.IdleForecolor = Color.SeaGreen

        btnCreateAcc.IdleFillColor = Color.White
        btnCreateAcc.IdleForecolor = Color.SeaGreen

        btnStaff.IdleFillColor = Color.White
        btnStaff.IdleForecolor = Color.SeaGreen

        Staff.AsStaff = False

        If SQL.HasConnection() = True Then
            ShowData("SELECT strReferenceNumber,tblStaff_strStaffCode ,strName,strReceivedDate, strDispatchDate,strStatus FROM tblorder", orderGrid)
        End If

    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click

        staffPanel.Visible = True
        editAccPanel.Visible = False
        createAccPanel.Visible = False
        orderPanel.Visible = False

        btnStaff.IdleFillColor = Color.FromArgb(230, 215, 42)
        btnStaff.IdleForecolor = Color.Black

        btnOrder.IdleFillColor = Color.White
        btnOrder.IdleForecolor = Color.SeaGreen

        btnEditAcc.IdleFillColor = Color.White
        btnEditAcc.IdleForecolor = Color.SeaGreen

        btnCreateAcc.IdleFillColor = Color.White
        btnCreateAcc.IdleForecolor = Color.SeaGreen


        If SQL.HasConnection() = True Then
            SQL.AddParam("@index", drpdwnSort.selectedIndex + 1, DbType.Int32)
            ShowData("SELECT * FROM tblstaff ORDER BY @index ASC", gridStaff)

        End If


    End Sub

    Private Sub btnCreateAcc_Click(sender As Object, e As EventArgs) Handles btnCreateAcc.Click

        If SQL.HasConnection() = True Then
            GenerateStaffCode() 'Gets the last staffcode record in the db and increment
        End If


        createAccPanel.Visible = True
        editAccPanel.Visible = False
        orderPanel.Visible = False
        staffPanel.Visible = False

        btnCreateAcc.IdleFillColor = Color.FromArgb(230, 215, 42)
        btnCreateAcc.IdleForecolor = Color.Black

        btnOrder.IdleFillColor = Color.White
        btnOrder.IdleForecolor = Color.SeaGreen

        btnEditAcc.IdleFillColor = Color.White
        btnEditAcc.IdleForecolor = Color.SeaGreen

        btnStaff.IdleFillColor = Color.White
        btnStaff.IdleForecolor = Color.SeaGreen

    End Sub


    Private Sub btnEditAcc_Click(sender As Object, e As EventArgs) Handles btnEditAcc.Click

        editAccPanel.Visible = True
        createAccPanel.Visible = False
        orderPanel.Visible = False
        staffPanel.Visible = False


        btnEditAcc.IdleFillColor = Color.FromArgb(230, 215, 42)
        btnEditAcc.IdleForecolor = Color.Black

        btnOrder.IdleFillColor = Color.White
        btnOrder.IdleForecolor = Color.SeaGreen

        btnCreateAcc.IdleFillColor = Color.White
        btnCreateAcc.IdleForecolor = Color.SeaGreen

        btnStaff.IdleFillColor = Color.White
        btnStaff.IdleForecolor = Color.SeaGreen

    End Sub




    Private Sub GenerateStaffCode()

        SQL.RunQuery("SELECT * FROM mydb.tblstaff ORDER BY strStaffCode desc limit 1")
        Dim Reader As DataTableReader
        Reader = SQL.Table.CreateDataReader

        If Reader.HasRows Then
            Dim strLastStaffCode As String = " "
            Dim strNewStaffCode As String

            While (Reader.Read)
                strLastStaffCode = Reader(0)
            End While

            If (Not strLastStaffCode = " ") Then

                strNewStaffCode = Convert.ToInt32(New String(strLastStaffCode) + 1).ToString("D6")
                txtStaffCode.Text = strNewStaffCode
            Else
                MsgBox("Something Went Wrong!")
            End If



        Else
            txtStaffCode.Text = "000001"
        End If


    End Sub




    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If HasEmptyFields() = True Then
            MessageBox.Show("All Fields Must Be Filled Out!")
        Else
            If (SQL.HasConnection() = True) Then
                AddNewStaff()
            End If
        End If

    End Sub

    Private Function HasEmptyFields() As Boolean
        If txtFN.Text = " " Or txtLN.Text = " " Or txtMN.Text = " " Or txtPassword.Text = " " Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub AddNewStaff()

        SQL.AddParam("@staffCode", txtStaffCode.Text, DbType.String)
        SQL.AddParam("@LN", txtLN.Text, DbType.String)
        SQL.AddParam("@FN", txtFN.Text, DbType.String)
        SQL.AddParam("@MN", txtMN.Text, DbType.String)
        SQL.AddParam("@password", txtPassword.Text, DbType.String)
        SQL.RunQuery("INSERT INTO tblstaff (strStaffCode , strLastName , strFirstName , strMiddleInitial) VALUES (@staffCode,@LN,@FN,@MN) ;
                      INSERT INTO tbllogin (strPassword , tblStaff_strStaffCode )  VALUES (@password , @staffCode)")


        MessageBox.Show("Staff Added!")
        txtStaffCode.Clear()
        txtLN.Clear()
        txtFN.Clear()
        txtMN.Clear()
        txtPassword.Clear()

        GenerateStaffCode()
    End Sub





    Private Sub drpdwnSort_onItemSelected(sender As Object, e As EventArgs) Handles drpdwnSort.onItemSelected
        SQL.AddParam("@index", drpdwnSort.selectedIndex + 1, DbType.Int32)
        ShowData("SELECT * FROM tblstaff ORDER BY @index ASC", gridStaff)

    End Sub


    Private Sub ShowData(Query As String, ByRef dg As DataGridView)

        'Clear Existing Records of DataTable
        If SQL.Table IsNot Nothing Then
            SQL.Table.Clear()
        End If

        Dim bSource As New BindingSource

        SQL.RunQuery(Query)

        bSource.DataSource = SQL.Table
        dg.DataSource = bSource
        SQL.Adapter.Update(SQL.Table)

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        UpdateFineRetrievals()

        If SQL.HasConnection() = True Then
            ShowData("SELECT strReferenceNumber , tblStaff_strStaffCode  ,strName,strReceivedDate, strDispatchDate,strStatus FROM tblorder", orderGrid)
        End If



    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If (Not txtSearch.text = "") Then
            If SQL.HasConnection() Then
                btnSave.Enabled = True
                btnSave.BorderStyle = BorderStyle.FixedSingle
                txtFirstName.Enabled = True
                txtLastName.Enabled = True
                txtPass.Enabled = True
                txtMiddleName.Enabled = True
            End If
        Else
            MsgBox("Enter A Staff Code to Edit!", MsgBoxStyle.Information)
        End If





    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SQL.AddParam("@staffCode", txtSearch.Text)


        SQL.RunQuery("SELECT strStaffCode , strLastName , strFirstName , strMiddleInitial,strPassword
                      FROM tblStaff INNER JOIN tbllogin ON tblStaff.strStaffCode = tbllogin.tblStaff_strStaffCode
                      WHERE strStaffCode = @staffCode")

        Dim Reader As DataTableReader
        Reader = SQL.Table.CreateDataReader()
        If Reader.HasRows Then

            txtStaffCode.Text = SQL.Table.Rows(0)(0)
            txtLastName.Text = SQL.Table.Rows(0)(1)
            txtFirstName.Text = SQL.Table.Rows(0)(2)
            txtMiddleName.Text = SQL.Table.Rows(0)(3)
            txtPass.Text = SQL.Table.Rows(0)(4)
        Else
            MsgBox("Staff Code Not Found!", MsgBoxStyle.Exclamation, "Not Found!")
            txtSearch.Clear()
            txtStaffCode.Clear()
            txtLastName.Clear()
            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtPass.Clear()
        End If

    End Sub



    Private Sub DeleteRecord()

        If MsgBox("Are you sure you want to  delete this staff's record?", MsgBoxStyle.YesNo, "Delete Record?") = MsgBoxResult.Yes Then
            SQL.AddParam("@staffCode", txtSearch.Text)
            SQL.RunQuery("DELETE FROM tbllogin WHERE tblStaff_strStaffCode = @staffCode;
                          DELETE FROM tblStaff WHERE strStaffCode = @staffCode")
            MsgBox("Record Deleted!", MsgBoxStyle.Information)

            txtFirstName.Clear()
            txtSearch.Clear()
            txtLastName.Clear()
            txtMiddleName.Clear()
            txtPass.Clear()
            txtFirstName.Enabled = False
            txtLastName.Enabled = False
            txtMiddleName.Enabled = False
            txtPass.Enabled = False
        End If


    End Sub
    Private Sub SaveChanges()

        SQL.AddParam("@staffCode", txtSearch.Text)
        SQL.AddParam("@LN", txtLastName.Text)
        SQL.AddParam("@FN", txtFirstName.Text)
        SQL.AddParam("@MN", txtMiddleName.Text)
        SQL.AddParam("@password", txtPass.Text)

        SQL.RunQuery("UPDATE tblStaff SET strLastName = @LN , strFirstName = @FN , strMiddleInitial = @MN WHERE strStaffCode = @staffCode;
                      UPDATE tbllogin SET strPassword = @password WHERE tblStaff_strStaffCode = @staffCode")

        MsgBox("Record Updated!")

        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtMiddleName.Enabled = False
        txtPass.Enabled = False

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (Not txtSearch.Text = "") And Not txtStaffCode.Text = "" Then
            If SQL.HasConnection() Then

                DeleteRecord()
            End If
        Else
            MsgBox("Enter a Staff Code to Delete!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Logout?") = MsgBoxResult.Yes Then
            Me.Close()

            Login.Show()

        End If
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Do you want to save the changes made for staff " & txtStaffCode.Text & "?", MsgBoxStyle.YesNo, "Save Changes?") = MsgBoxResult.Yes Then
            If SQL.HasConnection() Then
                SaveChanges()
                btnSave.Enabled = False
                btnSave.BorderStyle = BorderStyle.Fixed3D
            End If
        End If
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        btnAll.IdleFillColor = Color.SeaGreen
        btnAll.IdleForecolor = Color.White
        btnAll.IdleLineColor = Color.SeaGreen

        btnUnclaimed.IdleFillColor = Color.White
        btnUnclaimed.IdleForecolor = Color.SeaGreen
        btnUnclaimed.IdleLineColor = Color.SeaGreen

        btnClaimed.IdleFillColor = Color.White
        btnClaimed.IdleForecolor = Color.SeaGreen
        btnClaimed.IdleLineColor = Color.SeaGreen

        If SQL.HasConnection() = True Then
            ShowData("SELECT  strReferenceNumber , tblStaff_strStaffCode ,strName,strReceivedDate, strDispatchDate,strStatus FROM tblorder", orderGrid)
        End If

    End Sub

    Private Sub btnUnclaimed_Click(sender As Object, e As EventArgs) Handles btnUnclaimed.Click
        btnAll.IdleFillColor = Color.White
        btnAll.IdleForecolor = Color.SeaGreen
        btnAll.IdleLineColor = Color.SeaGreen

        btnUnclaimed.IdleFillColor = Color.SeaGreen
        btnUnclaimed.IdleForecolor = Color.White
        btnUnclaimed.IdleLineColor = Color.SeaGreen

        btnClaimed.IdleFillColor = Color.White
        btnClaimed.IdleForecolor = Color.SeaGreen
        btnClaimed.IdleLineColor = Color.SeaGreen

        If SQL.HasConnection() = True Then
            ShowData("SELECT  strReferenceNumber,tblStaff_strStaffCode  ,strName,strReceivedDate, strDispatchDate,strStatus FROM tblorder WHERE strStatus = 'Unclaimed'", orderGrid)
        End If
    End Sub

    Private Sub btnClaimed_Click(sender As Object, e As EventArgs) Handles btnClaimed.Click
        btnAll.IdleFillColor = Color.White
        btnAll.IdleForecolor = Color.SeaGreen
        btnAll.IdleLineColor = Color.SeaGreen

        btnUnclaimed.IdleFillColor = Color.White
        btnUnclaimed.IdleForecolor = Color.SeaGreen
        btnUnclaimed.IdleLineColor = Color.SeaGreen

        btnClaimed.IdleFillColor = Color.SeaGreen
        btnClaimed.IdleForecolor = Color.White
        btnClaimed.IdleLineColor = Color.SeaGreen

        If SQL.HasConnection() = True Then
            ShowData("SELECT strReferenceNumber,tblStaff_strStaffCode,strName,strReceivedDate, strDispatchDate,strStatus FROM tblorder WHERE strStatus = 'Claimed'", orderGrid)
        End If
    End Sub

    Private Sub detailsBtn_Click(sender As Object, e As EventArgs) Handles detailsBtn.Click
        OrderDetails.Show()
    End Sub

    Private Sub orderGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderGrid.CellClick

        Dim constraint As String

        Try

            If orderGrid.Rows(e.RowIndex).Cells(0).Value.ToString = "" Then
                detailsBtn.Enabled = False
                detailsBtn.BorderStyle = BorderStyle.Fixed3D
                deleteBtn.Enabled = False
                deleteBtn.BorderStyle = BorderStyle.Fixed3D
            Else
                detailsBtn.Enabled = True
                detailsBtn.BorderStyle = BorderStyle.FixedSingle
                deleteBtn.Enabled = True
                deleteBtn.BorderStyle = BorderStyle.FixedSingle
            End If

            SQL.FlushParams() 'Flush the previous params first
            constraint = orderGrid.Rows(e.RowIndex).Cells(0).Value.ToString 'THE REFERENCE NUMBER IF THE ORDER
            SQL.AddParam("@constraint", constraint)

        Catch

        End Try
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        If SQL.HasConnection() Then
            Dim count As Integer = orderGrid.SelectedRows.Count
            Dim refNum As String

            If MsgBox(count & " records will be deleted. Continue?", MsgBoxStyle.YesNo, "Delete Records") = MsgBoxResult.Yes Then

                For Each row As DataGridViewRow In orderGrid.SelectedRows

                    refNum = orderGrid.Rows(row.Index).Cells(0).Value.ToString
                    SQL.AddParam("@refNum", refNum)
                    SQL.RunQuery("DELETE FROM tblPrices WHERE tblOrder_strReferenceNumber = @refNum;
                              DELETE FROM tblWeight WHERE tblOrder_strReferenceNumber = @refNum;
                              DELETE FROM tblOrder WHERE strReferenceNumber = @refNum;")

                Next

                MsgBox("Successfully deleted " & count & " records!", MsgBoxStyle.Information)
                ShowData("SELECT  strReferenceNumber , tblStaff_strStaffCode ,strName,strReceivedDate, strDispatchDate,strStatus FROM tblorder", orderGrid)
            End If
        End If

    End Sub


    Public Sub UpdateFineRetrievals()
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