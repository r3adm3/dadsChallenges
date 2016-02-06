Module Module1

    Sub Main()
        Dim number As String
        Dim counter As Integer
        'this is a comment

        Do

            Console.WriteLine("Welcome to FizzBuzz")
            Console.WriteLine("Pick any Number")
            number = Console.ReadLine()

            If IsNumeric(number) = False Then
                Console.WriteLine("Try Again...")
                Console.WriteLine()
            End If

        Loop While IsNumeric(number) = False

        For counter = 1 To number
            If number / counter = 3 Then
                Console.Write("Fizz")
            End If
        Next

        For counter = 1 To number
            If number / counter = 5 Then
                Console.WriteLine("Buzz")
            End If
        Next



        Console.ReadLine()

    End Sub

End Module
