    
    '''<remarks/>
    <System.Xml.Serialization.XmlIncludeAttribute(GetType(User)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ApplicationRole)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(UserApplicationRole)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(EntityMap)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(EntityMembership)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(UserAccount)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(PostalAddress)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(ContactInfo)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(Institution)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(County)),  _
     System.Xml.Serialization.XmlIncludeAttribute(GetType(State)),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
    Partial Public MustInherit Class Entity
        
        Private idField As System.Guid
        
        Private entityActionField As EntityAction
        
        Private createdByField As String
        
        Private createdOnField As Date
        
        Private lastModifiedByField As String
        
        Private lastModifiedOnField As Date
        
        '''<remarks/>
        Public Property ID() As System.Guid
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property EntityAction() As EntityAction
            Get
                Return Me.entityActionField
            End Get
            Set
                Me.entityActionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CreatedBy() As String
            Get
                Return Me.createdByField
            End Get
            Set
                Me.createdByField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property CreatedOn() As Date
            Get
                Return Me.createdOnField
            End Get
            Set
                Me.createdOnField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LastModifiedBy() As String
            Get
                Return Me.lastModifiedByField
            End Get
            Set
                Me.lastModifiedByField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property LastModifiedOn() As Date
            Get
                Return Me.lastModifiedOnField
            End Get
            Set
                Me.lastModifiedOnField = value
            End Set
        End Property
    End Class
    