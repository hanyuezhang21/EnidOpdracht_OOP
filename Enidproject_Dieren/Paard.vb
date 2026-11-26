Imports System.Security.Cryptography

Partial Public Module EindProject
    Public Class Paard
        Inherits Dier
        Private strRas As String
        Private dblSnelheid As Double
        Private blnGetemd As Boolean

        ' Random integer generator voor snelheids variatie tussen paarden
        ' Deze staat niet in de constructor omdat het een willekeurige waarde is
        ' die bij elke instantie van Paard wordt gegenereerd
        Private intRngSnelheid As Integer

        ' Constructor
        Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String,
                       enumGedrag As Gedrag, strNaam As String, strRas As String, dblSnelheid As Double,
                       blnGetemd As Boolean)

            MyBase.New(intLeeftijd, strHabitat, strSoortEten, enumGedrag, strNaam)

            Me.strRas = strRas
            Me.dblSnelheid = dblSnelheid
            Me.blnGetemd = blnGetemd

            ' Random integer generator voor snelheids variatie tussen paarden.
            ' Wordt een keer uitgevoerd bij het aanmaken van een Paard object.
            Me.intRngSnelheid = RandomNumberGenerator.GetInt32(0, 40)
        End Sub

        ' Methodes
        Public Sub Lopen()
            dblSnelheid = 20 + (intRngSnelheid * 0.2)
            Console.WriteLine(strNaam & " loopt met een snelheid van " & dblSnelheid & " km/u.")
        End Sub

        Public Sub Galopperen()
            dblSnelheid = 40 + intRngSnelheid
            Console.WriteLine(strNaam & " galoppeert met een snelheid van " & dblSnelheid & " km/u.")
        End Sub

        Public Sub Tem()
            If blnGetemd Then
                Console.WriteLine(strNaam & " is al getemd.")
            Else
                blnGetemd = True
                Console.WriteLine(strNaam & " is nu getemd.")
            End If
        End Sub

        ' overrides zodat de methode ToonDetails van de Dier klasse wordt overschreven
        Public Overrides Sub ToonDetails()
            Console.WriteLine("Paard: ")
            MyBase.ToonDetails()

            Console.WriteLine("Ras: " & strRas)
            Console.WriteLine("Snelheid: " & dblSnelheid & " km/u")
            ' Korte if statement om te controleren of het paard getemd is
            Console.WriteLine("Getemd: " & If(blnGetemd, "Ja", "Nee"))
            Console.WriteLine()
        End Sub
    End Class
End Module

