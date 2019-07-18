Module Module1

    Sub Main()

#Region "Variablen-Deklaration"
        Dim a As Integer = 5
        Dim b As Integer = 10
        Dim Name As String = "Paul"
        Dim Name1 As String = "Hans"
        Dim c As Integer = 10
#End Region

#Region "Kontrollstrukturen"
#Region "IfElse"
        'If a > 0 Then ' größer als
        '    'If a < 0 Then kleiner als
        '    ' If <= kleiner gleich
        '    ' If >= größer gleich
        '    Console.WriteLine("Variable a ist größer als 0")
        '    ' If = gleich
        '    ' Operation wenn true
        '    'ElseIf TypeOf Name Is String Then
        'ElseIf b < 15 Then ' Wenn erstes If True ergibt, wird ElseIf nichtmehr abgefragt
        '    ' Operation wenn zweite  Bedingung true
        '    Console.WriteLine($"Variable Name ist ein String")
        'Else
        '    '    ' Operationen wenn False
        '    Console.WriteLine("Else-Block")
        'End If

        ' Operationen
#End Region

#Region "Select Case"
        Select Case Name1
            Case "Hans"
                Console.WriteLine("Hallo, ich bin Hans.")
            Case "Paul"
                Console.WriteLine("Hallo, ich bin Paul")
            Case "Peter"
                Console.WriteLine("Hallo, ich bin Peter")
                ' u.s.w.
            Case Else
                Console.WriteLine("Keiner der geprüften Werte ist in der Variablen enthalten")
                Exit Select
        End Select
#End Region

#Region "Arrays & Schleifen"
        ' Standard Array-Deklaration mit Längen-Angabe
        Dim array(5) As Integer ' Länge 6
        Dim array2 = New Integer(,) {{1, 2, 3}, {2, 3, 4}}

        Console.WriteLine($"Länge 1. Dimension: {array2.GetLength(0)}")
        Console.WriteLine($"Länge 2. Dimension: {array2.GetLength(1)}")

        Console.WriteLine(array2(1, 2))

        'For i = 0 To array2.GetLength(0) - 1
        '    Console.WriteLine($"Aktuelle Zahl in Dimension 1: {array2(0, i)}")
        'Next

        'For Each zahl In array2
        '    Console.WriteLine($"Aktuelle Zahl: {zahl}")
        'Next

        Console.WriteLine($"UpperBound: {array2.GetUpperBound(1)}")
        'Console.WriteLine($"{array.Length}")

        ' Array-Größe erweitern
        ReDim Preserve array(7)
        'Console.WriteLine(array.Length)

        ' Array-Initialisierer (Initiale Zuweisung von Werten)
        Dim initArray = New Integer() {1, 2, 3, 4} ' Länge 4
        Dim liste = New List(Of String) From {"element1", "element2"}
        Dim zahlenliste = New List(Of Integer)

        For g As Integer = 0 To liste.Count - 1
            Console.WriteLine($"Listen-Element: {liste(g)}")
        Next

        For Each element In liste
            Console.WriteLine($"Listen-Element: {element}")
        Next

        Console.WriteLine($"Listen-Typ: {liste.GetType}")
        Console.WriteLine($"Listen-Typ: {zahlenliste.GetType}")

        Console.WriteLine($"Array-Länge: {initArray.Length}")

        ' Mehrdimensionales Array
        Dim multidim(5, 5) As Integer
        ' Benötigt eine Laufvariable zum durchiterieren der Schleife

#Region "For-Schleife"
        For index As Integer = 0 To initArray.Length - 1
            Console.WriteLine($"Aktueller Index: {index} / Dazugehöriger Wert: {initArray(index)}")
        Next

        ReDim Preserve initArray(2)
        Console.WriteLine("Neue ArrayLänge: {0}", initArray.Length)

        For index As Integer = 0 To initArray.Length - 1 Step 2
            Console.WriteLine($"Aktueller Index: {index} / Dazugehöriger Wert: {initArray(index)}")
        Next
#End Region

#Region "While"
        ' Kopfgeprüfte Schleife
        Dim k As Integer = 0
        While k < 10
            Console.WriteLine($"Durchlauf: {k}")
            k = k + 1
            ' k += 1
            If k = 5 Then
                Console.WriteLine("k ist 5")
                Continue While
            End If
            Console.WriteLine("Nach dem If")
            ' Operationen
        End While
#End Region

#Region "Do Loop"
        ' Fußgeprüfte Schleife
        Dim j As Integer = 0
        Do
            Console.WriteLine(j)
            j += 1
        Loop Until j = 5
#End Region

#Region "For Each"
        For Each wert In initArray
            Console.WriteLine(wert)
        Next
#End Region

#End Region

#End Region

        Console.WriteLine("--- Ende ---")
        Console.ReadLine()

    End Sub

#Region "Funktion überladen"
    Function Addieren(param1 As Integer, param2 As Integer) As Integer
        Return 0
    End Function

    Function Addieren(param1 As Double, param2 As Double) As Double
        Return 0.00
    End Function
#End Region

End Module
