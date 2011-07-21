<Serializable()> _
Public Class PongMessage
    Private _responseText As String

    Public Property ResponseText() As String
        Get
            Return _responseText
        End Get
        Set(ByVal value As String)
            _responseText = value
        End Set
    End Property
End Class