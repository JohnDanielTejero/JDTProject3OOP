Public Class Customers

    Dim selectedUserId As Integer
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim condb = New ConnectionDb
        condb.searchTable("Users", CustomersListing, "ROLE = 'USER'")
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dispose()
        LoginForm.Show()
    End Sub

    Private Sub CustomersListing_SelectionChanged(sender As Object, e As EventArgs) Handles CustomersListing.SelectionChanged
        If CustomersListing.SelectedRows.Count > 0 Then
            Dim selectedRow = CustomersListing.SelectedRows(0)

            ' Access the values of the selected row
            Dim customerID As String = selectedRow.Cells("CustId").Value.ToString()
            Dim customerName As String = selectedRow.Cells("CustomerName").Value.ToString()
            Dim username As String = selectedRow.Cells("Username").Value.ToString()

            selectedUserId = selectedRow.Cells("CustId").Value
            ' Populate the text boxes with the values
            CustId.Text = customerID
            CustName.Text = customerName
            CustUname.Text = username
        Else
            ' Handle the case when no rows are selected
            CustId.Text = ""
            CustName.Text = ""
            CustUname.Text = ""
        End If
    End Sub

    Private Sub LaunchData_Click(sender As Object, e As EventArgs) Handles LaunchData.Click
        Try
            If selectedUserId = Nothing Then
                Throw New Exception("Please select a user first!")
            End If

            Dim customerdata = New CustomerData
            customerdata.SelectedUserId = selectedUserId

            Dispose()
            customerdata.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class