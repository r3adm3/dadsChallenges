Module Module1

    Sub Main()
        Dim number As String
        Dim decision As String
        Dim answer As Integer
        Do
            Console.WriteLine("Pick any Number")
            number = Console.ReadLine()

            If IsNumeric(Number) = False Then
                Console.WriteLine("Try Again...")
                Console.WriteLine()
            End If

        Loop While IsNumeric(number) = False

        Convert.ToInt32(number)

        Console.WriteLine("Would you like to find the sum or product of that number?")
        decision = Console.ReadLine()

        If decision.ToLower = "sum" Then
            answer = number * number
        ElseIf decision.ToLower = "product" Then
            answer = number * 2
        End If

        Console.WriteLine("The " & decision & " of " & number & " is " & answer)
        Console.ReadLine()

    End Sub

End Module
