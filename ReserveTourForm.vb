Public Class ReserveTourForm
    Dim tours As List(Of Tour)
    Dim selectedTour As Tour
    Dim selectedDay As Integer

    Private _user As User
    Property User() As User
        Get
            Return _user
        End Get
        Set(value As User)
            _user = value
        End Set
    End Property

    Private Sub ReserveTourForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadTours = New ConnectionDb
        tours = loadTours.getAllTours

        For Each tour In tours
            ReserveTours.Items.Add(tour.Destination)
        Next
    End Sub

    Private Sub ReserveSubmit_Click(sender As Object, e As EventArgs) Handles ReserveSubmit.Click
        Try
            Dim hasSelectedDays = False
            If ReserveTours.SelectedIndex < 0 Then
                Throw New Exception("Please select a destination")
            End If

            For Each ctrl As Control In ReserveDays.Controls

                If TypeOf ctrl Is RadioButton Then
                    Dim radio = DirectCast(ctrl, RadioButton)
                    If radio.Checked = True Then
                        hasSelectedDays = True
                        Exit For
                    End If
                End If

            Next

            If Not hasSelectedDays Then
                Throw New Exception("Please select days of stay!")
            End If

            If ReservePax.Text.Equals(String.Empty) Then
                Throw New Exception("Number of pax is required!")
            End If

            If ReservePayment.SelectedIndex < 0 Then
                Throw New Exception("Please select a payment method!")
            End If

            Dim dateOfDep As Date = ReserveDate.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Dim totality As Double = Double.Parse(ReserveCostTotal.Text)
            Dim paxQuantity As Integer = Integer.Parse(ReservePax.Text)

            Dim cols = New List(Of String)

            cols.Add("NoOfPax")
            cols.Add("ModeOfPayment")
            cols.Add("DepDate")
            cols.Add("NoOfDays")
            cols.Add("Total")
            cols.Add("CustId")
            cols.Add("TourId")

            Dim colVals = New List(Of Object)
            colVals.Add(paxQuantity)
            colVals.Add(ReservePayment.SelectedItem.ToString)
            colVals.Add(dateOfDep)
            colVals.Add(selectedDay)
            colVals.Add(totality)
            colVals.Add(User.CustomerId)
            colVals.Add(selectedTour.TourId)

            Dim dbcon = New ConnectionDb

            Dim res = dbcon.insert("Reservations", cols, colVals)
            If res Then
                MessageBox.Show("Reservation saved!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PricePerPax.Text = "N/A"
                ReserveCostTotal.Text = "N/A"
                For Each ctrl As Control In ReserveDays.Controls

                    If TypeOf ctrl Is RadioButton Then
                        Dim radio = DirectCast(ctrl, RadioButton)
                        radio.Checked = False
                    End If

                Next

                ReservePayment.SelectedIndex = -1
                ReserveTours.SelectedIndex = -1
                ReservePax.Text = ""
                selectedTour = Nothing

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ReserveTours_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReserveTours.SelectedIndexChanged
        For Each tour In tours
            If ReserveTours.SelectedItem.Equals(tour.Destination) Then
                selectedTour = tour
                Exit For
            End If
        Next

    End Sub

    Private Sub Register7_CheckedChanged(sender As Object, e As EventArgs) Handles Register7.CheckedChanged
        setCostPerPax("7 days")
    End Sub

    Private Sub setCostPerPax(arg As String)
        Try
            If selectedTour Is Nothing Then
                For Each ctrl As Control In ReserveDays.Controls

                    If TypeOf ctrl Is RadioButton Then
                        Dim radio = DirectCast(ctrl, RadioButton)
                        radio.Checked = False
                    End If

                Next

                Throw New Exception("Please select a tour")
            End If

            If arg.Equals("7 days") Then
                PricePerPax.Text = selectedTour.Day7Price
                selectedDay = 7
            End If

            If arg.Equals("14 days") Then
                PricePerPax.Text = selectedTour.Day14Price
                selectedDay = 14
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Register14_CheckedChanged(sender As Object, e As EventArgs) Handles Register14.CheckedChanged
        setCostPerPax("14 days")
    End Sub

    Private Sub ReservePax_TextChanged(sender As Object, e As EventArgs) Handles ReservePax.TextChanged
        Dim pax As Integer

        Try
            If Not selectedTour Is Nothing Then
                pax = Integer.Parse(ReservePax.Text)
                If Register7.Checked = True Then
                    ReserveCostTotal.Text = String.Format((pax * selectedTour.Day7Price), "C")
                End If
                If Register14.Checked = True Then
                    ReserveCostTotal.Text = String.Format((pax * selectedTour.Day14Price), "C")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        Dim accountform = New AccountForm
        accountform.User = _user
        accountform.Show()
        Me.Close()

    End Sub
End Class