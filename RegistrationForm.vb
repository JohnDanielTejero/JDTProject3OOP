Imports System.Text.RegularExpressions

Public Class RegistrationForm
    Private Sub RegisterSubmit_Click(sender As Object, e As EventArgs) Handles RegisterSubmit.Click
        Dim phoneNumberPattern As String = "^\((02)\)\s\d{4}\d{4}$|^(09\d{2})\d{3}\d{4}$"

        Try
            If RegisterName.Text = String.Empty Then
                Throw New Exception("Name field is required!")
            End If

            If RegisterAddress.Text = String.Empty Then
                Throw New Exception("Address field is required!")
            End If

            If RegisterPhone.Text = String.Empty Then
                Throw New Exception("Phone number field is required!")
            End If

            If RegisterPass.Text = String.Empty Then
                Throw New Exception("Password field is required!")
            End If

            Dim isPhoneNumberValid As Boolean = Regex.IsMatch(RegisterPhone.Text, phoneNumberPattern)

            If Not isPhoneNumberValid Then
                Throw New Exception("Invalid phone format!!")
            End If
            Dim dbCon = New ConnectionDb

            Dim colList = New List(Of String)

            colList.Add("Username")

            Dim res = dbCon.getDataFrom("Users", colList, "Username", RegisterName.Text)

            If res.Count > 0 Then
                Throw New Exception("User already exists!")
            End If

            Dim insertCols = New List(Of String)

            insertCols.Add("Username")
            insertCols.Add("Password")
            insertCols.Add("Role")
            insertCols.Add("CustomerName")
            insertCols.Add("CustomerAdd")
            insertCols.Add("CustomerPhone")

            Dim insertVal = New List(Of Object)
            insertVal.Add(RegisterName.Text)
            insertVal.Add(RegisterPass.Text)
            insertVal.Add("USER")
            insertVal.Add(RegisterName.Text)
            insertVal.Add(RegisterAddress.Text)
            insertVal.Add(RegisterPhone.Text)

            dbCon = New ConnectionDb

            If dbCon.insert("Users", insertCols, insertVal) Then
                Dim dialog = MessageBox.Show("User successfully registered!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If dialog = DialogResult.OK Then
                    Dispose()
                    LoginForm.Show()

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class