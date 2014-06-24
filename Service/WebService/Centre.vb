Namespace Service.WebService
    Public Class Centre
        Inherits Entity

        Public Overrides Sub Commit()
            Console.WriteLine("COMMIT using CENTRE Web Service")
        End Sub

    End Class
End Namespace
