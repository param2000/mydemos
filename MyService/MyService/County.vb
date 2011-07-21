'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class County
    Inherits Entity
        
    Private stateCodeField As String
        
    Private countyIDField As Integer
        
    Private countyNameField As String
        
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
    Public Property CountyID() As Integer
        Get
            Return Me.countyIDField
        End Get
        Set
            Me.countyIDField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property CountyName() As String
        Get
            Return Me.countyNameField
        End Get
        Set
            Me.countyNameField = value
        End Set
    End Property
End Class