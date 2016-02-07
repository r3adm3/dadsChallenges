Module Module1

    Sub Main()
        Dim List(9) As String
        Dim counter As Integer

        Console.WriteLine("Write a list of 10 things.")
        Console.WriteLine("I will reverse the list")
        For counter = 0 To 9
            List(counter) = Console.ReadLine()
        Next
        Console.WriteLine()
        Array.Reverse(List)
        For i = 0 To 9
            Console.WriteLine(List(i))
        Next
        Console.ReadLine()
    End Sub

End Module
