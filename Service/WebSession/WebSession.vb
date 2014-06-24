Namespace Service.WebSession
    Public Class WebSession

        Protected Property Entities As IList(Of Model.Entity)

        Sub New()
            Entities = New List(Of Model.Entity)
        End Sub

        Public Sub Commit()
            For Each e In Entities
                WebService.Factory.Create(e).Commit()
            Next
            Entities.Clear()
            Console.WriteLine("Commit Finished")
        End Sub

        Public Sub Add(entity As Model.Entity)
            Entities.Add(entity)
        End Sub
        
    End Class
End Namespace
