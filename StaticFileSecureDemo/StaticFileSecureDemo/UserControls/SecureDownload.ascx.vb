Namespace UserControls
    Partial Public Class SecureDownload
        Inherits System.Web.UI.UserControl

        Private _fileName As String
        Private _displayText As String
        Private _isEnabled As Boolean
        Public Property DisplayText() As String
            Get
                Return _displayText
            End Get
            Set(ByVal value As String)
                _displayText = value
            End Set
        End Property

        Public Property FileName() As String
            Get
                Return _fileName
            End Get
            Set(ByVal value As String)
                _fileName = value
            End Set
        End Property

        Public Property IsEnabled() As Boolean
            Get
                Return _isEnabled
            End Get
            Set(ByVal value As Boolean)
                _isEnabled = value
            End Set
        End Property

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.HyperLink1.Enabled = IsEnabled
            Me.HyperLink1.NavigateUrl = "~/StaticFileProtectionHandler.ashx?file=" + FileName
        End Sub
    End Class
End Namespace