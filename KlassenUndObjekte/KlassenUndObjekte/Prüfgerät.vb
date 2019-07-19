Option Strict On
Option Explicit On
Public MustInherit Class Prüfgerät
    ' Interne Variablen der Klasse, von außen nur über Get/Set lesbar (schreibbar)
#Region "Felder"

#End Region
    ' Welche Eigenschaften hat ein Prüfgerät
#Region "Eigenschaften"
    Public Hersteller As String
    Public ReadOnly Property Modelbezeichnung As String
#End Region

#Region "Konstruktor"
    ' Konstruktor
    Public Sub New()
        ' default Konstruktor
    End Sub
    Public Sub New(_modelbezeichnung As String)
        Me.Modelbezeichnung = _modelbezeichnung
    End Sub
    Public Sub New(_hersteller As String, _modelbezeichnung As String)
        Me.Hersteller = _hersteller
        Me.Modelbezeichnung = _modelbezeichnung
        MessageBox.Show($"Prüfgerät wurde erstellt. Hersteller: {Me.Hersteller}, Modelbezeichnung: {Me.Modelbezeichnung}")
    End Sub
#End Region

    Public Overridable Function Prüfen() As Boolean
        ' Operationen Prüfungsberechnungen, liefert zurück: Prüfung gut o. schlecht

        Return True
    End Function

    Public Overridable Function Anschalten() As Boolean
        ' Schaltet das Gerät an und liefert zurück ob es an ist
        MessageBox.Show("Ein Prüfgerät wurde angeschaltet.")
        Return True
    End Function

    Public Overridable Function Ausschalten() As Boolean
        ' Schaltet ..... ab ... ob es aus ist
        MessageBox.Show("Ein Prüfgerät wurde ausgeschaltet.")
        Return True
    End Function


End Class
