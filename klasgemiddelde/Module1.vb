Module Module1

    Sub Main()
        Dim namen(3) As String
        Dim punten(2, 3) As Integer
        Dim gemiddelde As Integer
        Dim totaalStudent(3) As Integer
        For index As Integer = 0 To 3
            Console.Write("Wat is de naam? ")
            namen(index) = Console.ReadLine()
            Console.Write("Wat is het eerste punt?")
            punten(0, index) = Console.ReadLine
            Console.Write("Wat is het tweede punt?")
            punten(1, index) = Console.ReadLine
            Console.Write("Wat is het derde punt?")
            punten(2, index) = Console.ReadLine

            For teller As Integer = 0 To 2
                totaalStudent(index) += punten(teller, index)
            Next
            gemiddelde += totaalStudent(index)
        Next
        For teller As Integer = 0 To 3
            Console.WriteLine("Het gemiddelde van de leerling: " & namen(teller) & " is " & totaalStudent(teller) / 3)
        Next
        Console.Write(vbCrLf & "Het totaal gemiddelde is " & (gemiddelde / 3) / 4)
        Console.ReadLine()
    End Sub
End Module
