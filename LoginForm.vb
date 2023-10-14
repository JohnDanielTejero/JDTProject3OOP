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
            colList.Add("Username")
            colList.Add("Password")
            colList.Add("Role")
            Dim res = dbCon.getDataFrom("Users", colList, "Username", uname)
            If res.Count = 0 Then
                Throw New Exception("No user found!")
            Else
                If res.Item("Password").Equals(password) Then
                    Console.WriteLine("TITE")
                Else
                    Throw New Exception("Incorrect password!")
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
