Module Validation
    Public Function getStartFuel(StartFuel1 As Integer, StartFuel2 As Integer, StartFuel3 As Integer, StartFuel4 As Integer) As Decimal
        Dim DataStartFuel1 As Integer = CInt(StartFuel1)
        Dim DataStartFuel2 As Integer = CInt(StartFuel2)
        Dim DataStartFuel3 As Integer = CInt(StartFuel3)
        Dim DataStartFuel4 As Integer = CInt(StartFuel4)

        Return DataStartFuel1 , DataStartFuel2, DataStartFuel3, DataStartFuel4
    End Function
End Module
