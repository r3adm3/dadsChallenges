Module Module1

    Sub Main()
        Dim number As String
        Dim answer As Integer
        Dim numcheck As String

        Console.WriteLine("What times table would you like to see displayed")
        number = Console.ReadLine()

        numcheck = IsNumeric(number)

        If numcheck = "False" Then
            Console.WriteLine("That input is invalid")
            Console.ReadLine()
            End
        End If

        For counter = 1 To 12
            answer = counter * number
            Console.WriteLine(number & " * " & counter & " = " & answer)
        Next
        Console.ReadLine()
    End Sub

End Module
