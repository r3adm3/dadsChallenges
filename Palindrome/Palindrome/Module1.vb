Module Module1

    Sub Main()
        Dim Input As String
        Dim revInput As String
        Do
            Console.WriteLine("Give me any sentence or word and I")
            Console.WriteLine("Will determine if it is a palindrome")
            Input = Console.ReadLine()
            Input = Input.Replace(" ", "")
            revInput = StrReverse(Input)
            If Input.ToLower = revInput.ToLower Then
                Console.WriteLine("That is a Palindrome")
            Else
                Console.WriteLine("That is not a palindrome")
            End If
            Console.WriteLine()
        Loop While 1 = 1

    End Sub

End Module
