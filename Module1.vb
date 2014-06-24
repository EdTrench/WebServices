Module Module1

    Sub Main()

        Dim c1 = New Model.Centre() With {.Id = 1,
                                          .Name = "Asdan"}
        Dim c2 = New Model.Centre() With {.Id = 2,
                                          .Name = "Mapfre Abraxas"}
        Dim c3 = New Model.Centre() With {.Id = 3,
                                          .Name = "F1 Computing Services Ltd"}
        Dim p1 = New Model.Person() With {.Id = 1,
                                          .Name = "Phil"}
        Dim p2 = New Model.Person() With {.Id = 2,
                                          .Name = "Paul"}
        Dim p3 = New Model.Person() With {.Id = 3,
                                          .Name = "Ed"}

        
        Dim webSx = New Service.WebSession.WebSession

        webSx.Add(c1)
        webSx.Add(c2)
        webSx.Add(c3)
        webSx.Add(p1)
        webSx.Add(p2)
        webSx.Add(p3)

        webSx.Commit()
        
        webSx.Add(c1)
        webSx.Add(c2)
        webSx.Add(c3)
        webSx.Add(p1)
        webSx.Add(p2)
        webSx.Add(p3)

        webSx.Commit()

        Console.ReadKey()

    End Sub

End Module
