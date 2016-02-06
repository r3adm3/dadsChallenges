Module Module1

    Sub Main()
        Randomize()
        Dim num As Integer
        Dim usernum As String
        Dim tries As Integer

        tries = 0

        num = CInt(Int((100 * Rnd()) + 1))

        Console.WriteLine("I have picked a number between 1 and 100")
        Console.WriteLine("Can You Guess What it is?")

        Do
            usernum = Console.ReadLine()
            If IsNumeric(usernum) = True Then
                If usernum > num Then
                    Console.WriteLine("The Right Number is Lower")
                    Console.WriteLine()
                ElseIf usernum < num Then
                    Console.WriteLine("The Right Number is Higher")
                    Console.WriteLine()
                ElseIf usernum = num Then
                    Console.WriteLine("Well Done!")
                    Console.WriteLine()
                End If
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
            End If
            tries = tries + 1
        Loop Until num.ToString = usernum
        Console.WriteLine("It took you " & tries & " tries")
        Console.ReadLine()
    End Sub

End Module
