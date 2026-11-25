
Public Class Hond
    'Inherits 表示 Hond 继承 Dier 类的属性和方法
    ' Inherits betekent dat Hond de
    ' eigenschappen en methodes van Dier overneemt.
    Inherits Dier

    'Constructor:
    Public Sub New(intLeeftijd As Integer, strHabitat As String, strSoortEten As String, strGedragType As String, strNaam As String)
        ' MyBase.New 调用父类 Dier 的构造方法。
        ' MyBase.New roept de constructor van de basisklasse Dier op.
        MyBase.New(intLeeftijd, strHabitat, strSoortEten, strGedragType, strNaam)
    End Sub

    Public Sub Blaffen()
        Console.WriteLine("Woef!")
    End Sub

    Public Overrides Sub ToonGedrag()
        Console.WriteLine(strNaam & " is sociaal en speels.")
    End Sub

End Class