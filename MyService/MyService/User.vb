Option Strict on
Option Explicit On
'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class User
    Inherits Entity
        
    Private nameField As String
        
    Private samAccountNameField As String
        
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
    Public Property SamAccountName() As String
        Get
            Return Me.samAccountNameField
        End Get
        Set
            Me.samAccountNameField = value
        End Set
    End Property
End Class