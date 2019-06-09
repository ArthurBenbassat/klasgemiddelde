Module Module1

    Sub Main()
        Dim namen(3) As String
        Dim punten(2, 3) As Integer
        Dim gemiddelde As Integer
        Dim totaalStudent(3) As Integer
        Dim aantalln, aantaltesten As Integer


        Console.Write("Hoeveel leerlingen zitten er in de klas? ")
        aantalln = Console.ReadLine()
        Console.Write("Hoeveel testen zijn er? ")
        aantaltesten = Console.ReadLine()

        ReDim namen(aantalln)
        ReDim punten(aantaltesten, aantalln)
        ReDim totaalStudent(aantalln)

        For index As Integer = 0 To aantalln - 1
            Console.Write(vbCrLf & "Wat is de naam? ")
            namen(index) = Console.ReadLine()
            For teller As Integer = 0 To aantaltesten - 1
                Console.Write("Hoeveel had " & namen(index) & " op test " & teller + 1 & "? ")
                punten(teller, index) = Console.ReadLine
            Next
            For teller As Integer = 0 To aantaltesten - 1
                totaalStudent(index) += punten(teller, index)
            Next
            gemiddelde += totaalStudent(index)
        Next
        Console.WriteLine()
        For teller As Integer = 0 To aantalln - 1
            Console.WriteLine("Het gemiddelde van de leerling: " & namen(teller) & " is " & (totaalStudent(teller) / aantaltesten - 1) * 5 & "%")
        Next
        Console.Write(vbCrLf & "Het totaal gemiddelde is " & ((gemiddelde / aantaltesten - 1) / aantalln - 1) * 5 & "%")

        FileOpen(1, "C:\Users\Arthur\Documents\School\informatica\klasResulaten.txt", OpenMode.Append)
        For index As Integer = 0 To aantalln - 1
            PrintLine(1, namen(index))
            For teller As Integer = 0 To aantaltesten - 1
                PrintLine(1, "Test " & teller + 1 & ": " & punten(teller, index))
            Next
            PrintLine(1, vbCrLf & "Het gemiddelde: " & namen(index) & " is " & (totaalStudent(index) / aantaltesten - 1) * 5 & "%" & vbCrLf)
        Next
        PrintLine(1, vbCrLf & "Het totaal gemiddelde is " & ((gemiddelde / aantaltesten - 1) / aantalln - 1) * 5 & "%")
        Console.ReadLine()
    End Sub
End Module
