Friend Class SqlParameters
    Private v As String
    Private varChar As SqlDbType

    Public Sub New(v As String, varChar As SqlDbType)
        Me.v = v
        Me.varChar = varChar
    End Sub
End Class
