Imports MySql.Data.MySqlClient

Public Class Login

    Dim SQL As New SQLManager
    Public StaffCode As String

    Dim AsAdmin As Boolean = False 'Type of Login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Function IsAuthenticated() As Boolean

        'Check if user is  Logging in as An Admin
        If cbxAdmin.Checked = True Then
            Dim adminCode As String = "admin"
            Dim adminPass As String = "admin"
            If txtStaffCode.Text = adminCode And txtPassword.Text = adminPass Then
                AsAdmin = True 'Change the type of Login to Admin Previlege
                Return True
            Else
                MsgBox("Invalid Credentials!", MsgBoxStyle.Critical, "Login Failed!")
                Return False
            End If
        End If


        'Clear Existing Records of DataTable
        If SQL.Table IsNot Nothing Then
            SQL.Table.Clear()
        End If

        SQL.AddParam("@staffCode", txtStaffCode.Text, DbType.String)
        SQL.AddParam("@password", txtPassword.Text, DbType.String)
        SQL.RunQuery("SELECT tblStaff_strStaffCode , strPassword FROM tbllogin WHERE tblStaff_strStaffCode = @staffCode  AND strPassword = @password")

        If SQL.Table.Rows.Count <= 0 Then
            MsgBox("Invalid Credentials!", MsgBoxStyle.Critical, "Login Failed!")
            Return False
        End If


        Return True

    End Function



    Private Sub SubmitInfo()

        If SQL.HasConnection() = True Then

            If IsAuthenticated() = True Then
                Me.Hide()
                If AsAdmin = True Then
                    Admin.Show()
                    AsAdmin = False
                    txtStaffCode.Clear()
                    txtPassword.Clear()
                    cbxAdmin.Checked = False

                Else
                    StaffCode = txtStaffCode.Text
                    txtStaffCode.Clear()
                    txtPassword.Clear()
                    Staff.Show()
                End If
            End If

        End If

    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        SubmitInfo()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SubmitInfo()
        End If

    End Sub

    Private Sub txtStaffCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStaffCode.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SubmitInfo()
        End If

    End Sub










End Class