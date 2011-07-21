'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class PostalAddress
    Inherits Entity
        
    Private parentField As EntityReference
        
    Private postalAddressTypeField As PostalAddressType
        
    Private isDefaultField As Boolean
        
    Private refInstitutionIDField As System.Guid
        
    Private refPostalAddressTypeField As PostalAddressType
        
    Private streetAddress1Field As String
        
    Private streetAddress2Field As String
        
    Private cityField As String
        
    Private stateField As String
        
    Private countyIDField As Integer
        
    Private zipcodeField As String
        
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
    Public Property PostalAddressType() As PostalAddressType
        Get
            Return Me.postalAddressTypeField
        End Get
        Set
            Me.postalAddressTypeField = value
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
    Public Property RefInstitutionID() As System.Guid
        Get
            Return Me.refInstitutionIDField
        End Get
        Set
            Me.refInstitutionIDField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property RefPostalAddressType() As PostalAddressType
        Get
            Return Me.refPostalAddressTypeField
        End Get
        Set
            Me.refPostalAddressTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property StreetAddress1() As String
        Get
            Return Me.streetAddress1Field
        End Get
        Set
            Me.streetAddress1Field = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property StreetAddress2() As String
        Get
            Return Me.streetAddress2Field
        End Get
        Set
            Me.streetAddress2Field = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property City() As String
        Get
            Return Me.cityField
        End Get
        Set
            Me.cityField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property State() As String
        Get
            Return Me.stateField
        End Get
        Set
            Me.stateField = value
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
    Public Property Zipcode() As String
        Get
            Return Me.zipcodeField
        End Get
        Set
            Me.zipcodeField = value
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