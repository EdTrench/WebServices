Namespace Service.WebService
    Public Class Person
        Inherits Entity

        Public Overrides Sub Commit()
            Console.WriteLine("COMMIT using PERSON Web Service")
        End Sub

    End Class
End Namespace
