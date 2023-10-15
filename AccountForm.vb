Imports System.Text.RegularExpressions

Public Class AccountForm
    Private _user As User
    Property User() As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dispose()
        LoginForm.Show()
    End Sub

    Private Sub ReserveATourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReserveATourToolStripMenuItem.Click
        Dim reserveform = New ReserveTourForm
        reserveform.User = _user
        reserveform.Show()
        Dispose()

    End Sub

    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountCustName.Text = _user.CustomerName
        AccountAddress.Text = _user.CustomerAddress
        AccountUsername.Text = _user.Username
        AccountPhoneNo.Text = _user.PhoneAddress
    End Sub

    Private Sub EditAccount_Click(sender As Object, e As EventArgs) Handles EditAccount.Click
        Try
            If AccountCustName.Text.Equals(String.Empty) Then
                Throw New Exception("Name is required!")
            End If

            If AccountAddress.Text.Equals(String.Empty) Then
                Throw New Exception("Address is required!")
            End If

            If AccountPhoneNo.Text.Equals(String.Empty) Then
                Throw New Exception("Phone is required!")
            End If

            If AccountUsername.Text.Equals(String.Empty) Then
                Throw New Exception("Username is required!")
            End If

            Dim phoneNumberPattern As String = "^\((02)\)\s\d{4}\d{4}$|^(09\d{2})\d{3}\d{4}$"
            Dim isPhoneNumberValid As Boolean = Regex.IsMatch(AccountPhoneNo.Text, phoneNumberPattern)


            If Not isPhoneNumberValid Then
                Throw New Exception("Invalid phone format!!")
            End If

            Dim dbCon = New ConnectionDb

            Dim colList = New List(Of String)

            colList.Add("Username")

            Dim res = dbCon.getDataFrom("Users", colList, "Username", AccountUsername.Text)

            If res.Count > 0 Then
                Throw New Exception("User already exists!")
            End If

            Dim updateCols = New List(Of String)

            updateCols.Add("Username")
            updateCols.Add("CustomerName")
            updateCols.Add("CustomerAdd")
            updateCols.Add("CustomerPhone")

            Dim updateVal = New List(Of Object)
            updateVal.Add(AccountUsername.Text)
            updateVal.Add(AccountCustName.Text)
            updateVal.Add(AccountAddress.Text)
            updateVal.Add(AccountPhoneNo.Text)

            If Not AccountPass.Text.Equals(String.Empty) Then
                updateCols.Add("Password")
                updateVal.Add(AccountPass.Text)
            End If
            dbCon = New ConnectionDb
            Dim updateres = dbCon.updateData("Users", updateCols, updateVal, "CustId", User.CustomerId)
            If updateres Then
                MessageBox.Show("Account successfully updated!", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class