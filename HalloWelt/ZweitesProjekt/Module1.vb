Option Explicit On
Option Strict On
Module Module1
    Sub Main()

        'Dim a As Integer = 5
        'Dim b As Integer = 10

        Dim c = Nothing
        Dim d = vbNull
        Dim x = Nothing



        If IsNothing(d) Then
            Console.WriteLine("Ich bin Nichts")
        Else
            Console.WriteLine("Ich bin Etwas")
        End If

        'Console.WriteLine(a)
        'MachWas(a)
        'Console.WriteLine(a)

#Region "Kauderwelsch"
        'MeineFunktion()
        'Console.WriteLine(Addieren(5, 5))
        'Dim EineVariable As Int16
        'EineVariable = "Hallo"

        'Dim StringObjekt As String = "Ein, kommagetrennter, Text"
        'Dim SplitObjekt = StringObjekt.Split(",")
        'Dim IntObjekt = 5
        'Console.WriteLine("Bitte gib eine Integer-Zahl ein")
        'Dim Eingabe1 As Integer = Console.ReadLine()
        'Console.WriteLine("Bitte gib eine Komma-Zahl ein")
        'Dim Eingabe2 As Decimal = Console.ReadLine()
        'Dim Dezimale As Decimal = 1.0294237549825724
        'Console.WriteLine("{0,10} {1,10:F3}", Eingabe1, Eingabe2)

        'Console.WriteLine("{0:F8}", Dezimale)

        'String.Format()

        'Dim result As Integer

        'Console.WriteLine("Bitte gib eine Zahl ein")
        'Dim Eingabe2 = Console.ReadLine()

        'If Integer.TryParse(Eingabe1, result) And Integer.TryParse(Eingabe2, result) Then
        '    Console.WriteLine($"Datentyp Eingabe: {Eingabe1.GetType}")
        '    Console.WriteLine($"Ergebnis: {Addieren(Eingabe1, Eingabe2)}")
        'Else
        '    Console.WriteLine("Ungültige Eingabe")
        'End If

        'Console.WriteLine(Addieren(Eingabe1, Eingabe2))

        'Console.WriteLine(Eingabe1.GetType)
        'For Each element In SplitObjekt
        '    Console.WriteLine(element)
        'Next
        'StringObjekt += " b"
        'Dim TrimmedObjekt As String = StringObjekt.Trim(" ")
        'Console.WriteLine(TrimmedObjekt)

        'TODO: Hier muss noch etwas erledigt werden
#End Region

        Console.WriteLine("--- Ende ---")
        Console.ReadLine()
    End Sub

#Region "Prozedur"
    Sub MeineFunktion()
        ' diese Funktion tut irgendwas
        Console.WriteLine("Hallo")
        Console.ReadLine()
    End Sub
#End Region

#Region "Funktion"
    ''' <summary>
    ''' Liefert die Summe zweier Zahlen zurück
    ''' </summary>
    ''' <param name="value">[int] value</param>
    ''' <param name="value2">[int] value</param>
    ''' <returns>[int] summe</returns>
    Function Addieren(value As Integer, value2 As Integer) As Integer
        Return value + value2
    End Function

    Sub MachWas(ByRef param As Integer)
        param = 10
    End Sub
#End Region


End Module
