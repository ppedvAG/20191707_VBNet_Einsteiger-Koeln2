<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAddieren = New System.Windows.Forms.Button()
        Me.btnSubstrahieren = New System.Windows.Forms.Button()
        Me.tbZahl1 = New System.Windows.Forms.TextBox()
        Me.tbZahl2 = New System.Windows.Forms.TextBox()
        Me.lblErgebnis = New System.Windows.Forms.Label()
        Me.lblErgebnisWert = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddieren
        '
        Me.btnAddieren.Location = New System.Drawing.Point(12, 81)
        Me.btnAddieren.Name = "btnAddieren"
        Me.btnAddieren.Size = New System.Drawing.Size(199, 23)
        Me.btnAddieren.TabIndex = 0
        Me.btnAddieren.Text = "Addieren"
        Me.btnAddieren.UseVisualStyleBackColor = True
        '
        'btnSubstrahieren
        '
        Me.btnSubstrahieren.Location = New System.Drawing.Point(12, 110)
        Me.btnSubstrahieren.Name = "btnSubstrahieren"
        Me.btnSubstrahieren.Size = New System.Drawing.Size(199, 23)
        Me.btnSubstrahieren.TabIndex = 1
        Me.btnSubstrahieren.Text = "Substrahieren"
        Me.btnSubstrahieren.UseVisualStyleBackColor = True
        '
        'tbZahl1
        '
        Me.tbZahl1.Location = New System.Drawing.Point(12, 12)
        Me.tbZahl1.Name = "tbZahl1"
        Me.tbZahl1.Size = New System.Drawing.Size(199, 22)
        Me.tbZahl1.TabIndex = 2
        '
        'tbZahl2
        '
        Me.tbZahl2.Location = New System.Drawing.Point(12, 40)
        Me.tbZahl2.Name = "tbZahl2"
        Me.tbZahl2.Size = New System.Drawing.Size(199, 22)
        Me.tbZahl2.TabIndex = 3
        '
        'lblErgebnis
        '
        Me.lblErgebnis.AutoSize = True
        Me.lblErgebnis.Location = New System.Drawing.Point(79, 157)
        Me.lblErgebnis.Name = "lblErgebnis"
        Me.lblErgebnis.Size = New System.Drawing.Size(64, 17)
        Me.lblErgebnis.TabIndex = 4
        Me.lblErgebnis.Text = "Ergebnis"
        '
        'lblErgebnisWert
        '
        Me.lblErgebnisWert.AutoSize = True
        Me.lblErgebnisWert.Location = New System.Drawing.Point(79, 174)
        Me.lblErgebnisWert.Name = "lblErgebnisWert"
        Me.lblErgebnisWert.Size = New System.Drawing.Size(0, 17)
        Me.lblErgebnisWert.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(221, 214)
        Me.Controls.Add(Me.lblErgebnisWert)
        Me.Controls.Add(Me.lblErgebnis)
        Me.Controls.Add(Me.tbZahl2)
        Me.Controls.Add(Me.tbZahl1)
        Me.Controls.Add(Me.btnSubstrahieren)
        Me.Controls.Add(Me.btnAddieren)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddieren As Button
    Friend WithEvents btnSubstrahieren As Button
    Friend WithEvents tbZahl1 As TextBox
    Friend WithEvents tbZahl2 As TextBox
    Friend WithEvents lblErgebnis As Label
    Friend WithEvents lblErgebnisWert As Label
End Class
