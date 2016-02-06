Module Module1

    Sub Main()
        Dim Unit As String
        Dim Speed As Integer
        Dim Time As Integer

        Console.WriteLine("What Unit would you like to use? MPH or Km/H")
        Unit = Console.ReadLine()

        Select Case Unit.ToLower
            Case "mph"
                Unit = "mile"
            Case "km/h"
                Unit = "km"
            Case "kmh"
                Unit = "km"
            Case Else
                Console.WriteLine("Sorry, that is not a valid input")
                Console.ReadLine()
                End

        End Select
        Console.WriteLine("What Speed Were you going at?")
        Speed = Console.ReadLine()
        Console.WriteLine("How much time did it take you?")
        Console.WriteLine("Please state your answer in minutes")
        Time = Console.ReadLine()
        Time = Time / 60

        Console.WriteLine("You Travelled " & (Speed * Time) & " " & Unit)
        Console.ReadLine()

    End Sub

End Module
