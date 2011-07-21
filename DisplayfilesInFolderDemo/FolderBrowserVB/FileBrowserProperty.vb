Public Class FileBrowserProperty
    Public ReadOnly Property IntialPath() As String
        Get
            Return ConfigurationSettings.AppSettings.Item("InitialPath")
        End Get
    End Property
End Class
