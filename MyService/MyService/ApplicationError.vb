    
    #Region "ApplicationError PartialClassDefinition"
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://namespace.fhlbsea.com/webservices/")>  _
    Partial Public Class ApplicationError
        
        Private idField As System.Guid
        
        Private userNameField As String
        
        Private pageNameField As String
        
        Private errorDateTimeField As Date
        
        Private errorDescriptionField As String
        
        Private innerExceptionField As String
        
        Private stackTraceField As String
        
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
        Public Property UserName() As String
            Get
                Return Me.userNameField
            End Get
            Set
                Me.userNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property PageName() As String
            Get
                Return Me.pageNameField
            End Get
            Set
                Me.pageNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ErrorDateTime() As Date
            Get
                Return Me.errorDateTimeField
            End Get
            Set
                Me.errorDateTimeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property ErrorDescription() As String
            Get
                Return Me.errorDescriptionField
            End Get
            Set
                Me.errorDescriptionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property InnerException() As String
            Get
                Return Me.innerExceptionField
            End Get
            Set
                Me.innerExceptionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property StackTrace() As String
            Get
                Return Me.stackTraceField
            End Get
            Set
                Me.stackTraceField = value
            End Set
        End Property
    End Class
    #End Region