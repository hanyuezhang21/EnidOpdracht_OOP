Public Class Kat
    Inherits Dier
    ' Constructor: 
    Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String, strGedragType As String, strNaam As String)
        MyBase.New(intLeeftijd, strHabitat, strSoortEten, strGedragType, strNaam)
    End Sub

    Public Sub Miauwen()
        Console.WriteLine("Miauw!")
    End Sub

    Public Sub Spinnen()
        Console.WriteLine(strNaam & " spint.")
    End Sub
    'Overrides 表示重写父类 Dier 中的 ToonGedrag 方法。
    ' Overrides betekent dat deze methode de
    ' methode ToonGedrag van Dier overschrijft.
    Public Overrides Sub ToonGedrag()
        Console.WriteLine(strNaam & " is rustig en onafhankelijk.")
    End Sub

End Class