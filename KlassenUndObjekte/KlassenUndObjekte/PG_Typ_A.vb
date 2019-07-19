Option Strict On
Option Explicit On
Public Class PG_Typ_A
    Inherits Prüfgerät

#Region "Konstruktor"
    Public Sub New()

    End Sub
    Public Sub New(_modelbezeichnung As String)
        MyBase.New(_modelbezeichnung)
    End Sub
    Public Sub New(_hersteller As String, _modelbezeichnung As String)
        MyBase.New(_hersteller, _modelbezeichnung)
    End Sub

    Public Overrides Function Anschalten() As Boolean
        MessageBox.Show("Prüfgerät Typ-A wurde angeschalten.")
        Return True
    End Function
#End Region
    Public Overrides Function Ausschalten() As Boolean
        MessageBox.Show("Prüfgerät Typ-A wurde ausgeschaltet.")
        Return MyBase.Ausschalten()
    End Function
End Class
