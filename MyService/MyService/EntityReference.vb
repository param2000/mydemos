#Region "EntityReference PartialClassDefinition"
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
    Partial Public Class EntityReference
        
        Private idField As System.Guid
        
        Private parentIDField As System.Guid
        
        Private nameField As String
        
        Private descriptionField As String
        
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
        Public Property ParentID() As System.Guid
            Get
                Return Me.parentIDField
            End Get
            Set
                Me.parentIDField = value
            End Set
        End Property
        
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
        Public Property Description() As String
            Get
                Return Me.descriptionField
            End Get
            Set
                Me.descriptionField = value
            End Set
        End Property
    End Class
    #End Region
