Public Class Kat
    Inherits Dier

    Public Sub New(intLeeftijd As Integer,
                   strHabitat As String,
                   strSoortEten As String,
                   strGedragType As String,
                   strNaam As String)

        MyBase.New(intLeeftijd, strHabitat, strSoortEten,
                   strGedragType, strNaam)

    End Sub

    Public Sub Miauwen()
        Console.WriteLine("Miauw!")
    End Sub

    Public Sub Spinnen()
        Console.WriteLine(strNaam & " spint.")
    End Sub

    Public Overrides Sub ToonGedrag()
        Console.WriteLine(strNaam & " is rustig en onafhankelijk.")
    End Sub

End Class