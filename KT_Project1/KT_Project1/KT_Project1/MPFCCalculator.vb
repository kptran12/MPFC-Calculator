Imports System.IO

Public Class MPFCCalculator

    Dim IndividualEndMile1 As Integer
    Dim DriverPercent As Decimal
    Dim IndividualEndMile2 As Integer
    Dim IndividualEndMile3 As Integer
    Dim IndividualEndMile4 As Integer
    Dim NumberOfTests As Integer
    Dim VehiclesTested As Integer

    Private Sub ddID_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddID.SelectedValueChanged

        If ddID.SelectedItem = 100 Then
            tbDriverFN.Text = "Bart"
            tbDriverLN.Text = "Simpson"
            tbDriverPhone.Text = "909-888-7777"
            DriverPercent = 1.0
            pbDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/Bart.png")
        ElseIf ddID.SelectedItem = 200 Then
            tbDriverFN.Text = "Homer"
            tbDriverLN.Text = "Simpson"
            tbDriverPhone.Text = "909-666-5555"
            DriverPercent = 1.1
            pbDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/Homer.png")
        ElseIf ddID.SelectedItem = 300 Then
            tbDriverFN.Text = "Marge"
            tbDriverLN.Text = "Simpson"
            tbDriverPhone.Text = "909-111-3333"
            DriverPercent = 1.2
            pbDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/Marge.png")
        Else
            tbDriverFN.Text = "Lisa"
            tbDriverLN.Text = "Simpson"
            tbDriverPhone.Text = "909-333-6666"
            DriverPercent = 1.3
            pbDriver.Image = Image.FromFile(Directory.GetCurrentDirectory() & "/images/Lisa.png")
        End If
    End Sub


    Private Sub ddDataVehicle1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddDataVehicle1.SelectedValueChanged
        Dim finalMile1 As Integer = IndividualEndMile1 * DriverPercent

        If ddDataVehicle1.SelectedItem = "Banshee" Then
            tbDataStartMile1.Text = "12537"
            tbDataStartFuel1.Text = "5000"
            tbDataEndFuel1.Text = "1000"
            IndividualEndMile1 = 302512

        ElseIf ddDataVehicle1.SelectedItem = "Ghost" Then
            tbDataStartMile1.Text = "12537"
            tbDataStartFuel1.Text = "4000"
            tbDataEndFuel1.Text = "2200"
            IndividualEndMile1 = 502500
        ElseIf ddDataVehicle1.SelectedItem = "Chopper" Then
            tbDataStartMile1.Text = "12537"
            tbDataStartFuel1.Text = "4000"
            tbDataEndFuel1.Text = "2000"
            IndividualEndMile1 = 499937
        Else
            tbDataStartMile1.Text = "12537"
            tbDataStartFuel1.Text = "6000"
            tbDataEndFuel1.Text = "1000"
            IndividualEndMile1 = 2092537

        End If

        tbDataEndMile1.Text = finalMile1
    End Sub

    Private Sub ddDataVehicle2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddDataVehicle2.SelectedIndexChanged
        Dim finalMile2 As Integer = IndividualEndMile2 * DriverPercent

        If ddDataVehicle2.SelectedItem = "Banshee" Then
            tbDataStartMile2.Text = "12537"
            tbDataStartFuel2.Text = "5000"
            tbDataEndFuel2.Text = "1000"
            IndividualEndMile2 = 302512

        ElseIf ddDataVehicle2.SelectedItem = "Ghost" Then
            tbDataStartMile2.Text = "12537"
            tbDataStartFuel2.Text = "4000"
            tbDataEndFuel2.Text = "2200"
            IndividualEndMile2 = 502500
        ElseIf ddDataVehicle2.SelectedItem = "Chopper" Then
            tbDataStartMile2.Text = "12537"
            tbDataStartFuel2.Text = "4000"
            tbDataEndFuel2.Text = "2000"
            IndividualEndMile2 = 499937
        Else
            tbDataStartMile2.Text = "12537"
            tbDataStartFuel2.Text = "6000"
            tbDataEndFuel2.Text = "1000"
            IndividualEndMile2 = 2092537

        End If

        tbDataEndMile2.Text = finalMile2
    End Sub

    Private Sub ddDataVehicle3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddDataVehicle3.SelectedIndexChanged
        Dim finalMile3 As Integer = IndividualEndMile3 * DriverPercent

        If ddDataVehicle3.SelectedItem = "Banshee" Then
            tbDataStartMile3.Text = "12537"
            tbDataStartFuel3.Text = "5000"
            tbDataEndFuel3.Text = "1000"
            IndividualEndMile3 = 302512

        ElseIf ddDataVehicle3.SelectedItem = "Ghost" Then
            tbDataStartMile3.Text = "12537"
            tbDataStartFuel3.Text = "4000"
            tbDataEndFuel3.Text = "2200"
            IndividualEndMile3 = 502500
        ElseIf ddDataVehicle3.SelectedItem = "Chopper" Then
            tbDataStartMile3.Text = "12537"
            tbDataStartFuel3.Text = "4000"
            tbDataEndFuel3.Text = "2000"
            IndividualEndMile3 = 499937
        Else
            tbDataStartMile3.Text = "12537"
            tbDataStartFuel3.Text = "6000"
            tbDataEndFuel3.Text = "1000"
            IndividualEndMile3 = 2092537

        End If

        tbDataEndMile3.Text = finalMile3
    End Sub

    Private Sub ddDataVehicle4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddDataVehicle4.SelectedIndexChanged
        Dim finalMile4 As Integer = IndividualEndMile4 * DriverPercent

        If ddDataVehicle4.SelectedItem = "Banshee" Then
            tbDataStartMile4.Text = "12537"
            tbDataStartFuel4.Text = "5000"
            tbDataEndFuel4.Text = "1000"
            IndividualEndMile4 = 302512

        ElseIf ddDataVehicle4.SelectedItem = "Ghost" Then
            tbDataStartMile4.Text = "12537"
            tbDataStartFuel4.Text = "4000"
            tbDataEndFuel4.Text = "2200"
            IndividualEndMile4 = 502500
        ElseIf ddDataVehicle4.SelectedItem = "Chopper" Then
            tbDataStartMile4.Text = "12537"
            tbDataStartFuel4.Text = "4000"
            tbDataEndFuel4.Text = "2000"
            IndividualEndMile4 = 499937
        Else
            tbDataStartMile4.Text = "12537"
            tbDataStartFuel4.Text = "6000"
            tbDataEndFuel4.Text = "1000"
            IndividualEndMile4 = 2092537

        End If

        tbDataEndMile4.Text = finalMile4

        'Additions for summary

    End Sub


    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnProcess_Click_1(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim ID As String = chkSelection(ddID)

        Dim TestNum As Integer = chkInt(tbTestNum)
        Dim TestDate As Date = chkDate(tbDate)

        'Calculate results for the first vehicle and check if the input is valid

        Dim Vehicle1 As String = chkSelection(ddDataVehicle1)

        Dim StartMile1 As Integer = chkInt(tbDataStartMile1)
        Dim EndMile1 As Integer = chkInt(tbDataEndMile1)
        Dim TotalMile1 As Integer = (EndMile1 - StartMile1)
        tbResultsMile1.Text = TotalMile1

        Dim StartFuel1 As Integer = chkInt(tbDataStartFuel1)
        Dim EndFuel1 As Integer = chkInt(tbDataEndFuel1)
        Dim FuelUse1 As Integer = StartFuel1 - EndFuel1
        Dim CostofFuel1 As Integer = FormatCurrency(FuelUse1 * 22.0)
        tbResultsFuelUse1.Text = FuelUse1
        tbResultsFuelCost1.Text = FormatCurrency(CostofFuel1)

        If ddDataVehicle1.SelectedItem = "Banshee" Then
            tbResultsVehicle1.Text = "Banshee"
            tbResultsFamily1.Text = "Covenant"
        ElseIf ddDataVehicle1.SelectedItem = "Ghost" Then
            tbResultsVehicle1.Text = "Ghost"
            tbResultsFamily1.Text = "Covenant"
        ElseIf ddDataVehicle1.SelectedItem = "Chopper" Then
            tbResultsVehicle1.Text = "Chopper"
            tbResultsFamily1.Text = "Covenant"
        Else
            tbResultsVehicle1.Text = "Hornet"
            tbResultsFamily1.Text = "UN Space Command"
        End If

        Dim MPFC1 As Integer = (TotalMile1 / FuelUse1)
        Dim MPFCRating1 As String

        If (MPFC1 < 200) Then
            MPFCRating1 = "Guzzler"
        ElseIf ((MPFC1 > 200) And (MPFC1 < 300)) Then
            MPFCRating1 = "Economical"
        Else
            MPFCRating1 = "Amazing!!"
        End If

        tbMPFCRate1.Text = MPFCRating1


        'Calculate results for the 2nd vehicle

        Dim Vehicle2 As String = chkSelection(ddDataVehicle2)

        Dim StartMile2 As Integer = chkInt(tbDataStartMile2)
        Dim EndMile2 As Integer = chkInt(tbDataEndMile2)
        Dim TotalMile2 As Integer = (EndMile2 - StartMile2)
        tbResultsMile2.Text = TotalMile2

        Dim StartFuel2 As Integer = chkInt(tbDataStartFuel2)
        Dim EndFuel2 As Integer = chkInt(tbDataEndFuel2)
        Dim FuelUse2 As Integer = (StartFuel2 - EndFuel2)
        Dim CostofFuel2 As Integer = FormatCurrency(FuelUse2 * 22.0)
        tbResultsFuelUse2.Text = FuelUse2
        tbResultsFuelCost2.Text = FormatCurrency(CostofFuel2)


        If ddDataVehicle2.SelectedItem = "Banshee" Then
            tbResultsVehicle2.Text = "Banshee"
            tbResultsFamily2.Text = "Covenant"
        ElseIf ddDataVehicle2.SelectedItem = "Ghost" Then
            tbResultsVehicle2.Text = "Ghost"
            tbResultsFamily2.Text = "Covenant"
        ElseIf ddDataVehicle2.SelectedItem = "Chopper" Then
            tbResultsVehicle2.Text = "Chopper"
            tbResultsFamily2.Text = "Covenant"
        Else
            tbResultsVehicle2.Text = "Hornet"
            tbResultsFamily2.Text = "UN Space Command"
        End If

        Dim MPFC2 As Integer = TotalMile2 / FuelUse2
        Dim MPFCRating2 As String

        If (MPFC2 < 200) Then
            MPFCRating2 = "Guzzler"
        ElseIf ((MPFC2 > 200) And (MPFC2 < 300)) Then
            MPFCRating2 = "Economical"
        Else
            MPFCRating2 = "Amazing!!"
        End If

        tbMPFCRate2.Text = MPFCRating2



        'Calculate Results for the 3rd vehicle

        Dim Vehicle3 As String = chkSelection(ddDataVehicle3)

        Dim StartMile3 As Integer = chkInt(tbDataStartMile3)
        Dim EndMile3 As Integer = chkInt(tbDataEndMile3)
        Dim TotalMile3 As Integer = (EndMile3 - StartMile3)
        tbResultsMile3.Text = TotalMile3

        Dim StartFuel3 As Integer = chkInt(tbDataStartFuel3)
        Dim EndFuel3 As Integer = chkInt(tbDataEndFuel3)
        Dim FuelUse3 As Integer = (StartFuel3 - EndFuel3)
        Dim CostofFuel3 As Integer = FormatCurrency(FuelUse1 * 22.0)
        tbResultsFuelUse3.Text = FuelUse3
        tbResultsFuelCost3.Text = FormatCurrency(CostofFuel3)

        If ddDataVehicle3.SelectedItem = "Banshee" Then
            tbResultsVehicle3.Text = "Banshee"
            tbResultsFamily3.Text = "Covenant"
        ElseIf ddDataVehicle3.SelectedItem = "Ghost" Then
            tbResultsVehicle3.Text = "Ghost"
            tbResultsFamily3.Text = "Covenant"
        ElseIf ddDataVehicle3.SelectedItem = "Chopper" Then
            tbResultsVehicle3.Text = "Chopper"
            tbResultsFamily3.Text = "Covenant"
        Else
            tbResultsVehicle3.Text = "Hornet"
            tbResultsFamily3.Text = "UN Space Command"
        End If

        Dim MPFC3 As Integer = TotalMile3 / FuelUse3
        Dim MPFCRating3 As String

        If (MPFC3 < 200) Then
            MPFCRating3 = "Guzzler"
        ElseIf ((MPFC3 > 200) And (MPFC3 < 300)) Then
            MPFCRating3 = "Economical"
        Else
            MPFCRating3 = "Amazing!!"
        End If

        tbMPFCRate3.Text = MPFCRating3


        'Calculate Results for 4th Vehicle
        Dim Vehicle4 As String = chkSelection(ddDataVehicle4)

        Dim StartMile4 As Integer = chkInt(tbDataStartMile4)
        Dim EndMile4 As Integer = chkInt(tbDataEndMile4)
        Dim TotalMile4 As Integer = (EndMile4 - StartMile4)
        tbResultsMile4.Text = TotalMile4

        Dim StartFuel4 As Integer = chkInt(tbDataStartFuel4)
        Dim EndFuel4 As Integer = chkInt(tbDataEndFuel4)
        Dim FuelUse4 As Integer = (StartFuel4 - EndFuel4)
        Dim CostofFuel4 As Integer = FormatCurrency(FuelUse4 * 22.0)
        tbResultsFuelUse4.Text = FuelUse4
        tbResultsFuelCost4.Text = FormatCurrency(CostofFuel4)

        If ddDataVehicle4.SelectedItem = "Banshee" Then
            tbResultsVehicle4.Text = "Banshee"
            tbResultsFamily4.Text = "Covenant"
        ElseIf ddDataVehicle4.SelectedItem = "Ghost" Then
            tbResultsVehicle4.Text = "Ghost"
            tbResultsFamily4.Text = "Covenant"
        ElseIf ddDataVehicle4.SelectedItem = "Chopper" Then
            tbResultsVehicle4.Text = "Chopper"
            tbResultsFamily4.Text = "Covenant"
        Else
            tbResultsVehicle4.Text = "Hornet"
            tbResultsFamily4.Text = "UN Space Command"
        End If

        Dim MPFC4 As Integer = TotalMile4 / FuelUse4
        Dim MPFCRating4 As String

        If (MPFC4 < 200) Then
            MPFCRating4 = "Guzzler"
        ElseIf ((MPFC4 > 200) And (MPFC4 < 300)) Then
            MPFCRating4 = "Economical"
        Else
            MPFCRating4 = "Amazing!!"
        End If

        tbMPFCRate4.Text = MPFCRating4


        NumberOfTests += 1

        VehiclesTested += 4
    End Sub

    'Integer Validation
    Private Function validInt(aValue As String) As Integer
        Dim i As Integer
        Return Integer.TryParse(aValue, i)
    End Function

    Private Function chkInt(ctrl As TextBox) As Integer
        While (validInt(ctrl.Text) = False)
            ctrl.Text = InputBox("The values you have entered are invalid. Please enter a positive integer.")
            ctrl.Focus()
        End While

        Return CInt(ctrl.Text)
    End Function


    'Date Validation
    Private Function ValidDate(aValue As String) As Boolean

        Dim aDate As Date

        Return Date.TryParse(aValue, aDate)

    End Function

    Private Function chkDate(ctrl As TextBox) As Date
        While (ValidDate(ctrl.Text) = False)
            ctrl.Text = InputBox("Invalid date. Please try again")
        End While

        Return CDate(ctrl.Text)
    End Function

    'Check combobox
    Private Function chkSelection(ctrl As ComboBox) As String
        Dim MsgBtns As MessageBoxButtons = MessageBoxButtons.OK
        Dim Msg As String = "Invalid vehicle and/or id. Please re-enter."
        Dim MsgCaption As String = "An error has been detected."
        Dim MsgBox As DialogResult

        If (ctrl.SelectedIndex = -1) Then
            MsgBox = MessageBox.Show(Msg, MsgCaption, MsgBtns)
            ctrl.Focus()
            If MsgBox = System.Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If

        End If



        Return ctrl.SelectedText
    End Function


    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        For Each ctrl In Me.gbData.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""

            ElseIf TypeOf (ctrl) Is ComboBox Then
                ctrl.SelectedIndex = -1
            End If
        Next

        For Each ctrl In Me.gbDriver.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""

            ElseIf TypeOf (ctrl) Is ComboBox Then
                ctrl.SelectedIndex = -1
            End If
        Next

        For Each ctrl In Me.gbInventor.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
            End If
        Next

        For Each ctrl In Me.gbResults.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
            End If
        Next

        For Each ctrl In Me.gbTest.Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = ""
            End If
        Next

    End Sub

    Private Function getFinalTotalMiles() As Integer
        Dim finalMile1 As Integer = chkInt(tbResultsMile1)
        Dim finalMile2 As Integer = chkInt(tbResultsMile2)
        Dim finalMile3 As Integer = chkInt(tbResultsMile3)
        Dim finalMile4 As Integer = chkInt(tbResultsMile4)

        Dim CurrTotalMiles As Integer = finalMile1 + finalMile2 + finalMile3 + finalMile4
        Dim FinalTotalMiles As Integer = CurrTotalMiles

        Return FinalTotalMiles
    End Function

    Private Function getTotalfuelUse() As Integer
        Dim fuelUse1 As Integer = chkInt(tbResultsFuelUse1)
        Dim fuelUse2 As Integer = chkInt(tbResultsFuelUse2)
        Dim fuelUse3 As Integer = chkInt(tbResultsFuelUse3)
        Dim fuelUse4 As Integer = chkInt(tbResultsFuelUse4)

        Dim CurrTotalFuelUse As Integer = fuelUse1 + fuelUse2 + fuelUse3 + fuelUse4
        Dim FinalTotalFuelUse As Integer = CurrTotalFuelUse

        Return FinalTotalFuelUse
    End Function

    Private Function getTotalFuelCost() As Decimal
        Dim FuelCost1 As Decimal = tbResultsFuelCost1.Text
        Dim FuelCost2 As Decimal = tbResultsFuelCost2.Text
        Dim FuelCost3 As Decimal = tbResultsFuelCost3.Text
        Dim FuelCost4 As Decimal = tbResultsFuelCost4.Text

        Dim CurrTotalFuelCost As Decimal = FuelCost1 + FuelCost2 + FuelCost3 + FuelCost4
        Dim FinalTotalFuelCost As Decimal = (CurrTotalFuelCost)

        Return FormatCurrency(FinalTotalFuelCost)
    End Function

    Private Sub btnTests_Click(sender As Object, e As EventArgs) Handles btnTests.Click

        Summary.rtbSummary.Text = "Number of tests: " & NumberOfTests & vbCrLf & "Vehicles Tested: " & VehiclesTested & vbCrLf & "Total Mileage: " & getFinalTotalMiles() & vbCrLf & "Total Fuel Used: " & getTotalfuelUse() & vbCrLf & "Total Fuel Cost: " & FormatCurrency(getTotalFuelCost())

        Summary.Show()

    End Sub



End Class
