
Public Class Hond
    Inherits Dier

    Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String, strGedragType As String, strNaam As String)
        MyBase.New(intLeeftijd, strHabitat, strSoortEten, strGedragType, strNaam)
    End Sub

    Public Sub Blaffen()
        Console.WriteLine("Woef!")
    End Sub

    Public Overrides Sub ToonGedrag()
        Console.WriteLine(strNaam & " is speels.")
    End Sub

End Class