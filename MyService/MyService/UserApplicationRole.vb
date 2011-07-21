Option Strict on
Option Explicit On
'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class UserApplicationRole
    Inherits Entity
        
    Private applicationRoleField As ApplicationRole
        
    Private roleTargetField As EntityReference
        
    '''<remarks/>
    Public Property ApplicationRole() As ApplicationRole
        Get
            Return Me.applicationRoleField
        End Get
        Set
            Me.applicationRoleField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property RoleTarget() As EntityReference
        Get
            Return Me.roleTargetField
        End Get
        Set
            Me.roleTargetField = value
        End Set
    End Property
End Class