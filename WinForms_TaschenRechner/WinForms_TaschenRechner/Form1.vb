Public Class Form1
    Private Sub BtnAddieren_Click(sender As Object, e As EventArgs) Handles btnAddieren.Click
        lblErgebnisWert.Text = Berechnen(CInt(tbZahl1.Text), CInt(tbZahl2.Text), sender)

    End Sub

    Private Sub BtnSubstrahieren_Click(sender As Object, e As EventArgs) Handles btnSubstrahieren.Click
        lblErgebnisWert.Text = Berechnen(CInt(tbZahl1.Text), CInt(tbZahl2.Text), sender)
    End Sub

    Function Berechnen(a As Integer, b As Integer, o As Object) As Integer
        If o.Equals(btnAddieren) Then
            Return a + b
        ElseIf o.Equals(btnSubstrahieren) Then
            Return a - b
        End If
        Return 0
    End Function
End Class
