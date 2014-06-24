Namespace Service.WebService
    Public Class Factory
        Public Shared Function Create(entity As Model.Entity) As Entity
            If TypeOf (entity) Is Model.Centre Then
                Return New Centre
            ElseIf TypeOf (entity) Is Model.Person Then
                Return New Person()
            Else
                Throw New Exception("No TypeOf")
            End If
        End Function
    End Class
End Namespace
