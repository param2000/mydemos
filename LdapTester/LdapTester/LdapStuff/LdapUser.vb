Namespace LdapStuff
    Public Class LdapUser
        Private _DisplayName As String = ""
        Private _FirstName As String = ""
        Private _LastName As String = ""
        Private _NetworkID As String = ""
        Private _Description As String = ""
        Private _Department As String = ""
        Private _Email As String = ""
        Private _Company As String = ""

        Public Sub New()
        End Sub

        Public Property DisplayName() As String
            Get
                Return _DisplayName
            End Get
            Set(ByVal Value As String)
                _DisplayName = Value
            End Set
        End Property

        Public Property FirstName() As String
            Get
                Return _FirstName
            End Get
            Set(ByVal Value As String)
                _FirstName = Value
            End Set
        End Property

        Public Property LastName() As String
            Get
                Return _LastName
            End Get
            Set(ByVal Value As String)
                _LastName = Value
            End Set
        End Property

        Public Property NetworkID() As String
            Get
                Return _NetworkID
            End Get
            Set(ByVal Value As String)
                If (Value.IndexOf(".") > 0) Then
                    _NetworkID = _LastName & _FirstName.Substring(0, 1)
                Else
                    _NetworkID = Value
                End If

            End Set
        End Property

        Public Property Description() As String
            Get
                Return _Description
            End Get
            Set(ByVal Value As String)
                _Description = Value
            End Set
        End Property

        Public Property Department() As String
            Get
                Return _Department
            End Get
            Set(ByVal Value As String)
                If Value.Substring(0, 1).ToLower() = Value.Substring(0, 1) Then
                    Value = Value.Substring(0, 1).ToUpper() & Value.Substring(1)
                End If
                _Department = Value
            End Set
        End Property

        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal Value As String)
                _Email = Value
            End Set
        End Property

        Public Property Company() As String
            Get
                Return _Company
            End Get
            Set(ByVal Value As String)
                _Company = Value
            End Set
        End Property

        Private Function GetDeptID(ByVal DepartmentName As String) As Integer

        End Function
    End Class
End Namespace