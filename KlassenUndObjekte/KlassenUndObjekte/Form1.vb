Option Strict On
Option Explicit On

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreatePerson.Click

        Dim pg_A As New PG_Typ_A("XYZ1000")
        'Dim prüfgerät = New With {Key .Hersteller = "KeySight", .Modelbezeichnung = "ABC100"}
        'Dim exception1 As New DataException()
        pg_A.Hersteller = "Keysight"
        pg_A.Anschalten()
    End Sub
End Class
