Module Module1

    Sub Main()
        Dim i As Integer
        Dim j As Integer
        Dim t As Boolean
        For counter = 1 To 1000
            i = counter
            t = True
            For j = 2 To (i - 1)
                If i Mod j = 0 Then
                    t = False
                    Exit For
                End If
            Next j
            If t = True Then
                Console.WriteLine(i)
            End If


        Next
        Console.ReadLine()
    End Sub

End Module
