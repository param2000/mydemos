Option Strict on
Option Explicit On
'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class ApplicationRole
    Inherits Entity
        
    Private applicationField As EntityReference
        
    Private subApplicationField As String
        
    Private nameField As String
        
    Private institutionIDField As System.Guid
        
    Private descriptionField As String
        
    Private aDGroupField As String
        
    Private permissionScopeField As PermissionScope
        
    Private institutionTypeField As InstitutionType
        
    '''<remarks/>
    Public Property Application() As EntityReference
        Get
            Return Me.applicationField
        End Get
        Set
            Me.applicationField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property SubApplication() As String
        Get
            Return Me.subApplicationField
        End Get
        Set
            Me.subApplicationField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Name() As String
        Get
            Return Me.nameField
        End Get
        Set
            Me.nameField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property InstitutionID() As System.Guid
        Get
            Return Me.institutionIDField
        End Get
        Set
            Me.institutionIDField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Description() As String
        Get
            Return Me.descriptionField
        End Get
        Set
            Me.descriptionField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property ADGroup() As String
        Get
            Return Me.aDGroupField
        End Get
        Set
            Me.aDGroupField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property PermissionScope() As PermissionScope
        Get
            Return Me.permissionScopeField
        End Get
        Set
            Me.permissionScopeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property InstitutionType() As InstitutionType
        Get
            Return Me.institutionTypeField
        End Get
        Set
            Me.institutionTypeField = value
        End Set
    End Property
End Class