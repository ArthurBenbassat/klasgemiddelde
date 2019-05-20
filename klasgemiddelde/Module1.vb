Module Module1

    Sub Main()
        Dim namen() As String
        Dim punten(,) As Integer
        Dim gemiddelde() As Integer
        Dim totaalStudent() As Integer
        For index As Integer = 0 To 10
            Console.Write("Wat is de naam? ")
            namen(index) = Console.ReadLine()
            Console.Write("Wat is het eerste punt?")
            punten(0, index) = Console.ReadLine
            Console.Write("Wat is het tweede punt?")
            punten(1, index) = Console.ReadLine
            Console.Write("Wat is het derde punt?")
            punten(2, index) = Console.ReadLine

            For teller As Integer = 0 To 2
                totaalStudent(index) = punten(1, teller)
            Next
        Next
        For teller As Integer = 0 To 10
            Console.Write("Het totaal van de leerling: " & namen(teller) & " is " & totaalStudent(teller))
        Next
    End Sub

End Module
