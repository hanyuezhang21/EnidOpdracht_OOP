Partial Public Module EindProject
    Public Class Kat
        Inherits Dier
        ' Constructor: 
        Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String, strGedragType As String, strNaam As String)
            MyBase.New(intLeeftijd, strHabitat, strSoortEten, strGedragType, strNaam)
        End Sub

        Public Sub Miauwen()
            Dim miauwGedrag As New List(Of String) From {"Protest", "Hongerig", "Aandacht eisend", "Dankbaar"}
            Console.WriteLine("Miauw!")

            If strGedragType <> "Blij" Then
                strGedragType = miauwGedrag(Random.Shared.Next(miauwGedrag.Count()))
            End If
        End Sub

        Public Sub Spinnen()
            Console.WriteLine(strNaam & " spint.")
            strGedragType = "Blij"
        End Sub

        'Overrides 表示重写父类 Dier 中的 ToonGedrag 方法。
        ' Overrides betekent dat deze methode de
        ' methode ToonGedrag van Dier overschrijft.
        Public Overrides Sub ToonDetails()
     
            Console.WriteLine(strNaam & " " & intLeeftijd & " jaar oud \n" &
                              "Habitat: " & strHabitat & "\n" &
                              "Soort eten: " & strSoortEten & "\n" &
                              "Gedrag: " & strGedragType)
        End Sub

    End Class
End Module
