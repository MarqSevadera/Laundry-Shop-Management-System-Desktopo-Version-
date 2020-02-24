
Imports MySql.Data.MySqlClient

Public Class OrderDetails
    Dim SQL As SQLManager
    Private Sub OrderDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        If Staff.AsStaff = True Then
            SQL = Staff.SQL
        Else
                SQL = Admin.SQL
        End If


        If (SQL.HasConnection) Then
            ShowData()
        End If

    End Sub

    Private Sub ShowData()


        SQL.RunQuery("SELECT  
                            strReferenceNumber ,strFirstName , strReceivedDate , strDispatchDate,strName, strStatus ,fltClothesWeight, intTotalPieces  ,fltBeddingsWeight ,strIsHandWashed , fltTotalWeight , fltClothesPrice ,
                            fltBeddingsPrice,fltFinePrice, fltTotalPrice FROM tblorder , tblweight , tblprices , tblstaff
                            WHERE 
                            tblOrder.strReferenceNumber = tblprices.tblOrder_strReferenceNumber 
                            AND 
                             tblprices.tblOrder_strReferenceNumber  =  tblweight.tblOrder_strReferenceNumber
                            AND
                            strStaffCode = tblStaff_strStaffCode
                            AND strReferenceNumber = @constraint")


        Dim Reader As DataTableReader
        Reader = Admin.SQL.Table.CreateDataReader()
        If Reader.HasRows Then

            lblRef.Text = SQL.Table.Rows(0)(0)
            lblStaff.Text = SQL.Table.Rows(0)(1)
            lblReceived.Text = SQL.Table.Rows(0)(2)
            lblDispatch.Text = SQL.Table.Rows(0)(3)
            lblName.Text = SQL.Table.Rows(0)(4)
            lblStat.Text = SQL.Table.Rows(0)(5)
            lblClothW.Text = SQL.Table.Rows(0)(6)
            lblPieces.Text = SQL.Table.Rows(0)(7)
            lblBedW.Text = SQL.Table.Rows(0)(8)
            lblType.Text = SQL.Table.Rows(0)(9)
            lblTotW.Text = SQL.Table.Rows(0)(10)
            lblClothP.Text = SQL.Table.Rows(0)(11)
            lblBedP.Text = SQL.Table.Rows(0)(12)
            lblFineP.Text = SQL.Table.Rows(0)(13)
            lblTotP.Text = SQL.Table.Rows(0)(14)

        End If

        lblToday.Text = Date.Now.ToString("dd/MM/yyyy")
        If Staff.AsStaff = True Then
            Label2.Visible = False
            lblStaff.Visible = False
        Else
            Label2.Visible = True
            lblStaff.Visible = True
        End If

    End Sub



End Class