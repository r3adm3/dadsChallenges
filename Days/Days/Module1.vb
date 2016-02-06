Module Module1

    Sub Main()
        Dim BDate As Date
        Dim Days As Integer

        Console.WriteLine("For all your answers please use the format DD/MM/YYYY")
        Console.WriteLine()
        Console.WriteLine("What is the date you were born?")
        BDate = Console.ReadLine()

        Days = DateAndTime.DateDiff(DateInterval.Day, BDate, Date.Now,)
        Console.WriteLine("You Have Been Alive for " & Days & " Days")
        Console.ReadLine()

    End Sub

End Module
