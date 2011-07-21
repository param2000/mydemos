
Public Class Person

    Private _name As String = "some Name"
    Private _nick As String = "Some Nick"
    Public Phone As Integer = 123

    Public ReadOnly Property Nick() As String
        Get
            Return _nick
        End Get
    End Property


    Public ReadOnly Property Name() As String
        Get
            Return _name
        End Get
    End Property

    Public Sub NameChanged()
        _name = "DefaultName"
    End Sub

    Public Function NameInCapitalLetters() As String
        Return _name.ToUpper()
    End Function



End Class



