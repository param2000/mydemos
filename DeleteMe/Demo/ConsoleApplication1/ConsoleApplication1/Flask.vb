Public Class Flask(Of T As IMaterial)
    Public material As IMaterial

    Public Sub New()
        Dim type As Type = GetType(T)
        material = CType(System.Activator.CreateInstance(type), T)
        Me.material = material
    End Sub
End Class

Public Interface IMaterial
    Property _material() As String
End Interface

Public Class Steel
    Implements IMaterial

    Private _materialField As String = "Steel"

    Public Property _material() As String Implements IMaterial._material
        Get
            Return _materialField
        End Get
        Set(ByVal value As String)
            _materialField = value
        End Set
    End Property
End Class

Public Class Clay
    Implements IMaterial

    Private _materialField As String = "Clay"

    Public Property _material() As String Implements IMaterial._material
        Get
            Return _materialField
        End Get
        Set(ByVal value As String)

            _materialField = value
        End Set
    End Property
End Class

'
'
'
'

Public Interface IShape
    Function Mould() As Object
End Interface

Public Class RoundShape(Of T As IMaterial)
    Implements IShape

    Public Function Mould() As Object Implements IShape.Mould
        Dim type As Type = GetType(T)
        Dim roundObject As T = CType(Activator.CreateInstance(type), T)

        roundObject._material = "Round " + roundObject._material
        Return roundObject
    End Function
End Class

