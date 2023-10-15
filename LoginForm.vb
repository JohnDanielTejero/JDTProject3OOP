Public Class LoginForm

    Private Sub LoginSubmit_Click(sender As Object, e As EventArgs) Handles LoginSubmit.Click
        Dim uname, password As String
        Dim dbCon = New ConnectionDb()
        Try
            If LoginUsername.Text = String.Empty Then
                Throw New Exception("Username field is required!")
            End If

            If LoginPassword.Text = String.Empty Then
                Throw New Exception("Password field is required!")
            End If

            uname = LoginUsername.Text
            password = LoginPassword.Text

            Dim colList = New List(Of String)

            colList.Add("CustId")
            colList.Add("Username")
            colList.Add("Password")
            colList.Add("CustomerAdd")
            colList.Add("CustomerPhone")
            colList.Add("CustomerName")
            colList.Add("Role")
            Dim res = dbCon.getDataFrom("Users", colList, "Username", uname)
            If res.Count = 0 Then
                Throw New Exception("No user found!")
            Else
                If res.Item("Password").Equals(password) Then
                    Dim user = New User
                    user.Username = res.Item("Username")
                    user.CustomerId = res.Item("CustId")
                    user.Role = res.Item("Role")
                    user.CustomerAddress = res.Item("CustomerAdd")
                    user.PhoneAddress = res.Item("CustomerPhone")
                    user.CustomerName = res.Item("CustomerName")

                    If res.Item("Role").Equals("ADMIN") Then
                        Customers.Show()
                        Me.Hide()
                    Else
                        Dim reserve = New ReserveTourForm
                        reserve.User = user
                        reserve.Show()
                        Me.Hide()
                    End If
                Else
                    Throw New Exception("Incorrect password!")
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoginToRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LoginToRegister.LinkClicked
        RegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub LoginCancel_Click(sender As Object, e As EventArgs) Handles LoginCancel.Click
        Me.Close()

    End Sub
End Class
