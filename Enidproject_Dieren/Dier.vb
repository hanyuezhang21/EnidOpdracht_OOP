Partial Public Module EindProject
    Public Class Dier
        ' Protected 表示这些变量可以在当前类和子类中使用。
        ' Protected betekent dat deze variabelen gebruikt kunnen
        ' worden in deze klasse en de subklassen.
        Protected intLeeftijd As Integer
        Protected strHabitat As String
        Protected strSoortEten As String
        Protected strGedragType As String
        Protected strNaam As String

        ' Constructor
        Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String, strGedragType As String, strNaam As String)
            Me.intLeeftijd = intLeeftijd
            Me.strHabitat = strHabitat
            Me.strSoortEten = strSoortEten
            Me.strGedragType = strGedragType
            Me.strNaam = strNaam

        End Sub
        ' Voeden 方法：给动物喂食，并将它的行为状态设置为 Actief。
        ' Methode Voeden: geeft het dier eten
        ' en verandert het gedragstype naar Actief.
        Public Sub Voeden()
            strGedragType = "Actief"
            Console.WriteLine(strNaam & " krijgt " & strSoortEten)
        End Sub
        'Methode
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
        ' KanSpelen 方法：检查动物是否可以玩耍。
        ' Methode KanSpelen: controleert of het dier mag spelen.
        ' 如果状态不是 Moe，就返回 True；否则返回 False。
        ' Als het gedragstype niet Moe is, geeft de methode True terug. Anders False.
        Public Function KanSpelen() As Boolean
            Return strGedragType <> "Moe"
        End Function
        ' Overridable 表示这个方法可以在子类中被重写。
        ' Overridable betekent dat deze methode in
        ' een subklasse overschreven kan worden.
        Public Overridable Sub ToonDetails()
            Console.WriteLine(strNaam & " " & intLeeftijd & " jaar oud \n" &
                              "Habitat: " & strHabitat & "\n" &
                              "Soort eten: " & strSoortEten & "\n" &
                              "Gedrag: " & strGedragType)
        End Sub

    End Class
End Module
