Option Explicit On
Option Strict On
Module Module1

    Sub Main()
Line1:
        Dim generator As New Random ' Generator-Instanz der Klasse Random erzeugen
        Dim ZufallsZahlenArray(2) As Integer ' Zufallszahlen-Array mit definierter Länge 2 (3 Elemente) 
        Dim ZufallsZahl As Integer ' Integer-Variable für erweiterten Zugriff über Gültigkeitsbereiche hinaus
        Dim Zähler As Integer = 0 ' Zähler-Variable für richtig geratene Zahlen
        Dim Indexer As Integer ' Laufvariable zum Durchlaufen des Zufallszahlen-Arrays

        ' Benutzereingaben abfangen
        Console.WriteLine("Bitte eine Zahl zwischen 1 und 10 eingeben: ")
        Dim BenutzerZahl1 As Integer = CInt(Console.ReadLine())
        Console.WriteLine("Bitte eine weitere Zahl 1 und 10 eingeben: ")
        Dim BenutzerZahl2 As Integer = CInt(Console.ReadLine())
        Console.WriteLine("Bitte eine dritte Zahl 1 und 10 eingeben: ")
        Dim BenutzerZahl3 As Integer = CInt(Console.ReadLine())

        ' Neues Array mit Benutzereingaben initialisieren
        Dim BenutzerZahlenArray = New Integer() {BenutzerZahl1, BenutzerZahl2, BenutzerZahl3}

        ' 3 mal das Zufallszahlenarray durchlaufen, denn wir wollen 3 Zufallszahlen hinzufügen
        For Indexer = 0 To ZufallsZahlenArray.Length - 1
            Do ' Kopfgesteuert, denn die erste Zahl kann nicht im Array enthalten sein
                ZufallsZahl = generator.Next(1, 10) ' Zahl erzeugen
            Loop While ZufallsZahlenArray.Contains(ZufallsZahl) ' Solange die erzeugte Zahl im Array enthalten ist, eine neue Zufallszahl erzeugen

            ZufallsZahlenArray(Indexer) = ZufallsZahl ' ZufallsZahl dem Array am Index "Indexer" (0-2) hinzufügen
            Console.WriteLine($"{Indexer + 1}. Gewinnzahl: {ZufallsZahl}") ' Ausgabe

            For Each BenutzerZahl In BenutzerZahlenArray ' Prüfung, ob die drei eingegebenen Zahlen einer Zufallszahl entsprechen
                If BenutzerZahl = ZufallsZahl Then
                    Zähler += 1 ' Zähler eins raufzählen, falls man richtig tippt
                End If
            Next
        Next
        Console.WriteLine($"Du hast {Zähler} Zahlen richtig getippt :)") ' Finale Ausgabe

        Console.WriteLine("--- Ende ---")
        Console.ReadLine()
        GoTo Line1
    End Sub

End Module
