Public Class Dier
    Protected intLeeftijd As Integer
    Protected strHabitat As String
    Protected strSoortEten As String
    Protected strGedragType As String
    Protected strNaam As String

    Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String, strGedragType As String, strNaam As String)
        Me.intLeeftijd = intLeeftijd
        Me.strHabitat = strHabitat
        Me.strSoortEten = strSoortEten
        Me.strGedragType = strGedragType
        Me.strNaam = strNaam

    End Sub
    Public Sub Voeden()
        strGedragType = "Actief"
        Console.WriteLine(strNaam & " krijgt " & strSoortEten)
    End Sub

    Public Sub Verzorgen()
        Console.WriteLine(strNaam & " wordt verzorgd.")
    End Sub

    Public Sub LatenSpelen()

        If KanSpelen() Then
            strGedragType = "Moe"
            Console.WriteLine(strNaam & " speelt!")
        Else
            Console.WriteLine(strNaam & " is te moe.")
        End If

    End Sub

    Public Function KanSpelen() As Boolean
        Return strGedragType <> "Moe"
    End Function

    Public Overridable Sub ToonGedrag()
        Console.WriteLine(strNaam & " toont zijn gedrag.")
    End Sub

End Class