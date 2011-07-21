'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class State
    Inherits Entity
        
    Private stateCodeField As String
        
    Private stateNameField As String
        
    '''<remarks/>
    Public Property StateCode() As String
        Get
            Return Me.stateCodeField
        End Get
        Set
            Me.stateCodeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property StateName() As String
        Get
            Return Me.stateNameField
        End Get
        Set
            Me.stateNameField = value
        End Set
    End Property
End Class