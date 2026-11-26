Partial Public Module EindProject
    Sub main(args As String())

        ' Vier dieren aanmaken
        ' 创建四只动物

        Dim objPaard1 = New Paard(12, "Weiland", "Hooi", Gedrag.Blij, "Gert", "Arabier", 40, False)
        Dim objPaard2 As New Paard(8, "Stal", "Gras", Gedrag.Actief, "Max", "Fries", 50, True)

        Dim objHond1 As New Hond(5, "Binnen", "Hondenvoer", Gedrag.Blij, "Bobby")
        Dim objHond2 As New Hond(3, "Buiten", "Brokken", Gedrag.Moe, "Luna")

        Dim keuze As String

        ' Menu tonen
        Console.WriteLine("=== DIERENOPVANG ===")
        Console.WriteLine("1. Toon gedrag")
        Console.WriteLine("2. Voeden")
        Console.WriteLine("3. Verzorgen")
        Console.WriteLine("4. Laten spelen")

        Console.Write("Maak een keuze: ")
        keuze = Console.ReadLine()

        ' Keuze uitvoeren
        Select Case keuze

            Case "1"

                objHond1.ToonDetails()
                objHond2.ToonDetails()

            Case "2"

                objHond1.Voeden()
                objHond2.Voeden()

            Case "3"
                objHond1.Verzorgen()
                objHond2.Verzorgen()

            Case "4"
                objHond1.LatenSpelen()
                objHond2.LatenSpelen()

            Case Else
                Console.WriteLine("Ongeldige keuze!")

        End Select

        Console.WriteLine("Druk op ENTER om af te sluiten.")

    End Sub
End Module



