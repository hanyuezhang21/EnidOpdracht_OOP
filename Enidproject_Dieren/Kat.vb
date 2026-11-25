Partial Public Module EindProject
    Public Class Kat
        Inherits Dier
        ' Constructor: 
        Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String, enumGedrag As Gedrag, strNaam As String)
            MyBase.New(intLeeftijd, strHabitat, strSoortEten, enumGedrag, strNaam)
        End Sub

        Public Sub Miauwen()
            Dim miauwGedrag As New List(Of Gedrag) From {Gedrag.Protest, Gedrag.Hongerig, Gedrag.AandachtEisend, Gedrag.Dankbaar}
            Console.WriteLine("Miauw!")

            If enumGedrag <> Gedrag.Blij Then
                enumGedrag = miauwGedrag(Random.Shared.Next(miauwGedrag.Count()))
            End If
        End Sub

        Public Sub Spinnen()
            Console.WriteLine(strNaam & " spint.")
            enumGedrag = Gedrag.Blij
        End Sub

        'Overrides 表示重写父类 Dier 中的 ToonGedrag 方法。
        ' Overrides betekent dat deze methode de
        ' methode ToonGedrag van Dier overschrijft.
        Public Overrides Sub ToonDetails()
            Console.WriteLine("Kat: ")
            MyBase.ToonDetails()
        End Sub

    End Class
End Module
