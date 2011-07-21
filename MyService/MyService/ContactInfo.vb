'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class ContactInfo
    Inherits Entity
        
    Private parentField As EntityReference
        
    Private contactInfoTypeField As ContactInfoType
        
    Private isDefaultField As Boolean
        
    Private infoField As String
        
    Private infoExtensionField As String
        
    Private customLabelField As String
        
    '''<remarks/>
    Public Property Parent() As EntityReference
        Get
            Return Me.parentField
        End Get
        Set
            Me.parentField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property ContactInfoType() As ContactInfoType
        Get
            Return Me.contactInfoTypeField
        End Get
        Set
            Me.contactInfoTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property IsDefault() As Boolean
        Get
            Return Me.isDefaultField
        End Get
        Set
            Me.isDefaultField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Info() As String
        Get
            Return Me.infoField
        End Get
        Set
            Me.infoField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property InfoExtension() As String
        Get
            Return Me.infoExtensionField
        End Get
        Set
            Me.infoExtensionField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property CustomLabel() As String
        Get
            Return Me.customLabelField
        End Get
        Set
            Me.customLabelField = value
        End Set
    End Property
End Class