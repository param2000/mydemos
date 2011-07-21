Imports System.DirectoryServices

Namespace LdapStuff

    Public Class UserFunctions

        Public Shared Function CurrentUser() As String
            Return HttpContext.Current.Request.ServerVariables("LOGON_USER").ToUpper
        End Function

        Public Shared Function GetUserName(ByVal loginName As String) As String
            Dim dsDirectoryEntry As New DirectoryEntry
            Dim strPath As String
            Dim strLogin As String
            Dim strFullName As String

            If loginName = "" Then
                strLogin = GetLoginName()
            Else
                strLogin = Replace(loginName, "\", "/")
            End If


            strPath = "WinNT://" & strLogin
            dsDirectoryEntry.Close()
            dsDirectoryEntry.Dispose()
            Try
                dsDirectoryEntry = New DirectoryEntry(strPath)
                strFullName = dsDirectoryEntry.Properties("Fullname").Value.ToString
                strFullName = CType(dsDirectoryEntry.Invoke("Get", "FullName"), String)
            Catch ex As Exception
                strFullName = ""
            Finally
                dsDirectoryEntry.Close()
                dsDirectoryEntry.Dispose()
            End Try

            Return strFullName

        End Function

        Public Shared Function GetLoginName() As String
            Return System.Environment.UserName
        End Function
    End Class
End Namespace