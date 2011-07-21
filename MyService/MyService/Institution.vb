'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class Institution
    Inherits Entity
        
    Private parentField As EntityReference
        
    Private institutionTypeField As InstitutionType
        
    Private institutionNameField As String
        
    Private descriptionField As String
        
    Private customerNumberField As String
        
    Private institutionTaxIDField As String
        
    Private isActiveField As Boolean
        
    Private effectiveFromDateField As Date
        
    Private effectiveThroughDateField As Date
        
    Private bankTypeField As BankType
        
    Private ownershipTypeField As OwnershipType
        
    Private regulatorTypeField As RegulatorType
        
    Private charterTypeField As CharterType
        
    Private insuranceTypeField As InsuranceType
        
    Private reportingAgencyTypeField As ReportingAgencyType
        
    Private mppPartTypeField As MppPartType
        
    Private countyField As String
        
    Private cityField As String
        
    Private stateField As String
        
    Private craDateField As Date
        
    Private craRatingField As CraRating
        
    Private foundedField As Date
        
    Private marketingRepField As String
        
    Private crdRepField As String
        
    Private webSiteField As String
        
    Private contactInfoField() As ContactInfo
        
    Private postalAddressesField() As PostalAddress
        
    Private primaryPhoneField As ContactInfo
        
    Private primaryFaxField As ContactInfo
        
    Private statementAddressField As PostalAddress
        
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
    Public Property InstitutionType() As InstitutionType
        Get
            Return Me.institutionTypeField
        End Get
        Set
            Me.institutionTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property InstitutionName() As String
        Get
            Return Me.institutionNameField
        End Get
        Set
            Me.institutionNameField = value
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
    Public Property CustomerNumber() As String
        Get
            Return Me.customerNumberField
        End Get
        Set
            Me.customerNumberField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property InstitutionTaxID() As String
        Get
            Return Me.institutionTaxIDField
        End Get
        Set
            Me.institutionTaxIDField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property IsActive() As Boolean
        Get
            Return Me.isActiveField
        End Get
        Set
            Me.isActiveField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property EffectiveFromDate() As Date
        Get
            Return Me.effectiveFromDateField
        End Get
        Set
            Me.effectiveFromDateField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property EffectiveThroughDate() As Date
        Get
            Return Me.effectiveThroughDateField
        End Get
        Set
            Me.effectiveThroughDateField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property BankType() As BankType
        Get
            Return Me.bankTypeField
        End Get
        Set
            Me.bankTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property OwnershipType() As OwnershipType
        Get
            Return Me.ownershipTypeField
        End Get
        Set
            Me.ownershipTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property RegulatorType() As RegulatorType
        Get
            Return Me.regulatorTypeField
        End Get
        Set
            Me.regulatorTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property CharterType() As CharterType
        Get
            Return Me.charterTypeField
        End Get
        Set
            Me.charterTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property InsuranceType() As InsuranceType
        Get
            Return Me.insuranceTypeField
        End Get
        Set
            Me.insuranceTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property ReportingAgencyType() As ReportingAgencyType
        Get
            Return Me.reportingAgencyTypeField
        End Get
        Set
            Me.reportingAgencyTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property MppPartType() As MppPartType
        Get
            Return Me.mppPartTypeField
        End Get
        Set
            Me.mppPartTypeField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property County() As String
        Get
            Return Me.countyField
        End Get
        Set
            Me.countyField = value
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
    Public Property CraDate() As Date
        Get
            Return Me.craDateField
        End Get
        Set
            Me.craDateField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property CraRating() As CraRating
        Get
            Return Me.craRatingField
        End Get
        Set
            Me.craRatingField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Founded() As Date
        Get
            Return Me.foundedField
        End Get
        Set
            Me.foundedField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property MarketingRep() As String
        Get
            Return Me.marketingRepField
        End Get
        Set
            Me.marketingRepField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property CrdRep() As String
        Get
            Return Me.crdRepField
        End Get
        Set
            Me.crdRepField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property WebSite() As String
        Get
            Return Me.webSiteField
        End Get
        Set
            Me.webSiteField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property ContactInfo() As ContactInfo()
        Get
            Return Me.contactInfoField
        End Get
        Set
            Me.contactInfoField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property PostalAddresses() As PostalAddress()
        Get
            Return Me.postalAddressesField
        End Get
        Set
            Me.postalAddressesField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property PrimaryPhone() As ContactInfo
        Get
            Return Me.primaryPhoneField
        End Get
        Set
            Me.primaryPhoneField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property PrimaryFax() As ContactInfo
        Get
            Return Me.primaryFaxField
        End Get
        Set
            Me.primaryFaxField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property StatementAddress() As PostalAddress
        Get
            Return Me.statementAddressField
        End Get
        Set
            Me.statementAddressField = value
        End Set
    End Property
End Class