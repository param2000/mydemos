'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class EntityMembership
    Inherits Entity
        
    Private fromField As EntityReference
        
    Private toField As EntityMap
        
    '''<remarks/>
    Public Property From() As EntityReference
        Get
            Return Me.fromField
        End Get
        Set
            Me.fromField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property [To]() As EntityMap
        Get
            Return Me.toField
        End Get
        Set
            Me.toField = value
        End Set
    End Property
End Class