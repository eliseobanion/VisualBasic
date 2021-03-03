Public Class Form1
    Public CostPerDay As Integer = 0
    Public Days As Integer = 0
    Public GasPrepaid As Integer = 0
    Private Sub btnCalculatePrice_Click(sender As Object, e As EventArgs) Handles btnCalculatePrice.Click
        Dim totalCost = (CostPerDay * Days) + GasPrepaid

        If txtRentalDays.Text.Equals("") Then
            MsgBox("Please enter the amount of days the vehicle will be rented.")
        Else
            lblTotalOutput.Text = "$" & totalCost
        End If


    End Sub

    Private Sub txtRentalDays_TextChanged(sender As Object, e As EventArgs) Handles txtRentalDays.TextChanged
        If Not (txtRentalDays.Text.Equals("1") Or txtRentalDays.Text.Equals("2") Or txtRentalDays.Text.Equals("3") Or txtRentalDays.Text.Equals("")) Then
            txtRentalDays.Text = ""
            MsgBox("Please enter a valid number. (1-3)")
        Else
            lblNumberOfDaysOutput.Text = txtRentalDays.Text
            If Not txtRentalDays.Text.Equals("") Then
                Days = txtRentalDays.Text
            End If
        End If

    End Sub

    Private Sub radMysteryMachine_CheckedChanged(sender As Object, e As EventArgs) Handles radMysteryMachine.CheckedChanged
        lblCostPerDayOutput.Text = "$55"
        PictureBox1.Image = Image.FromFile("C:\Users\s734435\source\repos\Car Rental\Resources\mysterymachine.jpg")
        CostPerDay = 55
    End Sub

    Private Sub radHerbie_CheckedChanged(sender As Object, e As EventArgs) Handles radHerbie.CheckedChanged
        lblCostPerDayOutput.Text = "$75"
        PictureBox1.Image = Image.FromFile("C:\Users\s734435\source\repos\Car Rental\Resources\herbie.jpg")
        CostPerDay = 75
    End Sub

    Private Sub radBatmobile_CheckedChanged(sender As Object, e As EventArgs) Handles radBatmobile.CheckedChanged
        lblCostPerDayOutput.Text = "$125"
        PictureBox1.Image = Image.FromFile("C:\Users\s734435\source\repos\Car Rental\Resources\batmobile.jpg")
        CostPerDay = 125
    End Sub

    Private Sub chkPrepayGas_CheckedChanged(sender As Object, e As EventArgs) Handles chkPrepayGas.CheckedChanged
        If chkPrepayGas.Checked = True Then
            lblGasIfPrepaidOutput.Text = "$40"
            GasPrepaid = 40
        Else
            lblGasIfPrepaidOutput.Text = ""
            GasPrepaid = 0
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        chkPrepayGas.Checked = False
        txtRentalDays.Text = ""
        radMysteryMachine.Checked = True
        lblCostPerDayOutput.Text = ""
        lblGasIfPrepaidOutput.Text = ""
        lblNumberOfDaysOutput.Text = ""
        lblTotalOutput.Text = ""

    End Sub
End Class
