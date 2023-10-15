Public Class CustomerData
    Private _selectedUserId As Integer

    Property SelectedUserId() As Integer
        Get
            Return _selectedUserId
        End Get
        Set(value As Integer)
            _selectedUserId = value
        End Set
    End Property
    Private Sub CustomerData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dbcon = New ConnectionDb

            Dim colList = New List(Of String)

            colList.Add("CustId")
            colList.Add("CustomerAdd")
            colList.Add("CustomerPhone")
            colList.Add("CustomerName")

            Dim res = dbcon.getDataFrom("Users", colList, "CustId", _selectedUserId)
            If res.Count = 0 Then
                Throw New Exception("No user found!")
            Else
                DetailsAdd.Text = res.Item("CustomerAdd")
                DetailsId.Text = res.Item("CustId")
                DetailsName.Text = res.Item("CustomerName")
                DetailsNum.Text = res.Item("CustomerPhone")
            End If

            dbcon = New ConnectionDb
            dbcon.ReservationsOfUser(Reservations, "CustId = " & _selectedUserId)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Dispose()
        Customers.Show()
    End Sub
End Class