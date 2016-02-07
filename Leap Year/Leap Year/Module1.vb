Module Module1

    Sub Main()

        'this is a comment, setting up my variables
        Dim current As Integer
        Dim place As Integer
        Dim i As Integer

        current = Date.Today.Year
        current = 2017


        'this is another commnet
        If current Mod 4 = 0 Then
            For counter = 0 To 19
                Console.WriteLine(current + (counter * 4))
            Next
        Else
            For i = 1 To 3
                place = current + i
                If place Mod 4 = 0 Then
                    For counter = 0 To 19
                        Console.WriteLine(place + (counter * 4))
                    Next
                    Exit For
                End If
            Next
        End If
        Console.ReadLine()
    End Sub

End Module
