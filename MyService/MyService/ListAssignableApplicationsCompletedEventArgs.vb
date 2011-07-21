'''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.1"),  _
        System.Diagnostics.DebuggerStepThroughAttribute(),  _
        System.ComponentModel.DesignerCategoryAttribute("code")>  _
Partial Public Class ListAssignableApplicationsCompletedEventArgs
    Inherits System.ComponentModel.AsyncCompletedEventArgs
        
    Private results() As Object
        
    Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
        MyBase.New(exception, cancelled, userState)
        Me.results = results
    End Sub
        
    '''<remarks/>
    Public ReadOnly Property Result() As EntityReference()
        Get
            Me.RaiseExceptionIfNecessary
            Return CType(Me.results(0),EntityReference())
        End Get
    End Property
End Class