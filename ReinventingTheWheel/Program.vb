Module Program

    Sub Main()
        Dim currentPrice As Double = 1.23456
        Dim roundedPrice As Double = Math.Round(currentPrice, 4)
        Console.WriteLine(roundedPrice)
    End Sub

    Public intFractions = 0
    Public round_to_digits = -1

    Public Function Round_price(curr_price As Double) As Double
        Dim pr8 As Double
        Dim dec As Integer
        Dim intPos As Integer
        Dim strFraction As String
        Dim dblTempVal As Double
        Dim dblNewPrice As Double

        If (intFractions = 0) Then
            If round_to_digits = -1 Then
                Round_price = CDbl(curr_price)
            Else
                pr8 = curr_price * (10 ^ round_to_digits)
                dec = Int((pr8 - Int(pr8)) * 10)
                If dec >= 5 Then
                    pr8 = Int(pr8) + 1
                Else
                    pr8 = Int(pr8)
                End If
                Round_price = CDbl(pr8 / CDbl(10 ^ round_to_digits))
            End If
        Else
            '
            '   Find decimal point in string
            '
            intPos = InStr(1, CStr(curr_price), ".")
            If (intPos <> 0) Then
                strFraction = Mid(CStr(curr_price), intPos + 1)
                If (intFractions = 32) Then
                    strFraction = Left(strFraction & "00", 3)
                    dblTempVal = CDbl(strFraction) / 320
                Else
                    dblTempVal = CDbl(strFraction) / CDbl(intFractions)
                End If
                dblNewPrice = CDbl(Left(CStr(curr_price), intPos - 1)) + dblTempVal
            Else
                dblNewPrice = curr_price
            End If
            If round_to_digits = -1 Then
                Round_price = CDbl(dblNewPrice)
            Else
                pr8 = dblNewPrice * (10 ^ round_to_digits)
                dec = Int((pr8 - Int(pr8)) * 10)
                If dec >= 5 Then
                    pr8 = Int(pr8) + 1
                Else
                    pr8 = Int(pr8)
                End If
                Round_price = CDbl(pr8 / CDbl(10 ^ round_to_digits))
            End If
        End If
    End Function

End Module
