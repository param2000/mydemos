Imports System
Imports Castle.Windsor
Imports MbUnit.Framework



<TestFixture()> _
Public Class WindsorTest
    <Test()> _
    Public Sub Test()
        Dim container As WindsorContainer
        container = New WindsorContainer()

        container.AddComponent(Of Bob)()
        container.AddComponent(Of IWeapon, Revolver)()

        Dim b = container.Resolve(Of Bob)()
        Assert.IsNotNull(b)

    End Sub

End Class
Public Interface IPerson

End Interface

Public Class Bob
    Implements IPerson

    Private _weapon As IWeapon

    Public ReadOnly Property Weapon() As IWeapon
        Get
            Return _weapon

        End Get
    End Property

    Public Sub New(ByVal weapon As IWeapon)
        _weapon = weapon
    End Sub
End Class
Public Interface IWeapon
    ReadOnly Property Name() As String

End Interface
Public Class Sword
    Implements IWeapon

    Public ReadOnly Property Name() As String Implements IWeapon.Name
        Get
            Return "Sword"
        End Get
    End Property
End Class
Public Class Revolver
    Implements IWeapon

    Public ReadOnly Property Name() As String Implements IWeapon.Name
        Get
            Return "Revolver"
        End Get
    End Property
End Class
