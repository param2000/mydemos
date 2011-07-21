'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.SerializableAttribute(),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code"),  _
        System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
Partial Public Class UserAccount
    Inherits Entity
        
    Private applicationField As EntityReference
        
    Private userAccountNameField As String
        
    Private institutionNameField As String
        
    Private institutionIDField As System.Guid
        
    Private secretQuestionField As String
        
    Private secretAnswerField As String
        
    Private forceChangePasswordField As Boolean
        
    Private fullNameField As String
        
    Private firstNameField As String
        
    Private lastNameField As String
        
    Private middleNameField As String
        
    Private salutationField As String
        
    Private suffixField As String
        
    Private titleField As String
        
    Private organizationField As String
        
    Private departmentField As String
        
    Private directoryRankingField As Integer
        
    Private effectiveFromDateField As Date
        
    Private effectiveThroughDateField As Date
        
    Private lastLoginField As Date
        
    Private institutionsField() As EntityMembership
        
    Private applicationRolesField() As UserApplicationRole
        
    Private uniqueApplicationRolesField() As UserApplicationRole
        
    Private contactInfoField() As ContactInfo
        
    Private departmentsField() As EntityMembership
        
    Private postalAddressesField() As PostalAddress
        
    Private primaryEmailField As ContactInfo
        
    Private primaryPhoneField As ContactInfo
        
    Private primaryFaxField As ContactInfo
        
    Private primaryAddressField As PostalAddress
        
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
    Public Property UserAccountName() As String
        Get
            Return Me.userAccountNameField
        End Get
        Set
            Me.userAccountNameField = value
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
    Public Property InstitutionID() As System.Guid
        Get
            Return Me.institutionIDField
        End Get
        Set
            Me.institutionIDField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property SecretQuestion() As String
        Get
            Return Me.secretQuestionField
        End Get
        Set
            Me.secretQuestionField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property SecretAnswer() As String
        Get
            Return Me.secretAnswerField
        End Get
        Set
            Me.secretAnswerField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property ForceChangePassword() As Boolean
        Get
            Return Me.forceChangePasswordField
        End Get
        Set
            Me.forceChangePasswordField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property FullName() As String
        Get
            Return Me.fullNameField
        End Get
        Set
            Me.fullNameField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property FirstName() As String
        Get
            Return Me.firstNameField
        End Get
        Set
            Me.firstNameField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property LastName() As String
        Get
            Return Me.lastNameField
        End Get
        Set
            Me.lastNameField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property MiddleName() As String
        Get
            Return Me.middleNameField
        End Get
        Set
            Me.middleNameField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Salutation() As String
        Get
            Return Me.salutationField
        End Get
        Set
            Me.salutationField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Suffix() As String
        Get
            Return Me.suffixField
        End Get
        Set
            Me.suffixField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Title() As String
        Get
            Return Me.titleField
        End Get
        Set
            Me.titleField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Organization() As String
        Get
            Return Me.organizationField
        End Get
        Set
            Me.organizationField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Department() As String
        Get
            Return Me.departmentField
        End Get
        Set
            Me.departmentField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property DirectoryRanking() As Integer
        Get
            Return Me.directoryRankingField
        End Get
        Set
            Me.directoryRankingField = value
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
    Public Property LastLogin() As Date
        Get
            Return Me.lastLoginField
        End Get
        Set
            Me.lastLoginField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property Institutions() As EntityMembership()
        Get
            Return Me.institutionsField
        End Get
        Set
            Me.institutionsField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property ApplicationRoles() As UserApplicationRole()
        Get
            Return Me.applicationRolesField
        End Get
        Set
            Me.applicationRolesField = value
        End Set
    End Property
        
    '''<remarks/>
    Public Property UniqueApplicationRoles() As UserApplicationRole()
        Get
            Return Me.uniqueApplicationRolesField
        End Get
        Set
            Me.uniqueApplicationRolesField = value
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
    Public Property Departments() As EntityMembership()
        Get
            Return Me.departmentsField
        End Get
        Set
            Me.departmentsField = value
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
    Public Property PrimaryEmail() As ContactInfo
        Get
            Return Me.primaryEmailField
        End Get
        Set
            Me.primaryEmailField = value
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
    Public Property PrimaryAddress() As PostalAddress
        Get
            Return Me.primaryAddressField
        End Get
        Set
            Me.primaryAddressField = value
        End Set
    End Property
End Class