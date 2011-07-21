Imports System.DirectoryServices

Namespace LdapStuff

    Public Class LdapLookup
        Private Shared Function GetDirectoryEntry(ByVal domainAddress As String, ByVal domainUsername As String, ByVal domainPassword As String) As DirectoryEntry
            Dim domainName As String = String.Format("LDAP://{0}", domainAddress)

            If domainUsername = Nothing Then
                Return New DirectoryEntry("LDAP://" & domainAddress)
            Else
                Return New DirectoryEntry("LDAP://" & domainAddress, domainUsername, domainPassword)
            End If
        End Function

        Public Shared Function GetGroupUsers(ByVal domainAddress As String, ByVal groupName As String) As String
            Return GetGroupUsers(domainAddress, groupName, Nothing, Nothing)
        End Function

        Public Shared Function GetGroupUsers(ByVal domainAddress As String, ByVal groupName As String, ByVal domainUsername As String, ByVal domainPassword As String) As String
            Dim dsDirectoryEntry As DirectoryEntry = GetDirectoryEntry(domainAddress, domainUsername, domainPassword)
            Dim dsDirectorySearcher As New DirectorySearcher(dsDirectoryEntry)
            Dim strUsers As String
            Dim intEqualsIndex As Integer
            Dim intCommaIndex As Integer
            Dim sbGroupUsers As New StringBuilder
            Dim searchString As String = String.Format("sAMAccountName={0}", groupName)

            With dsDirectorySearcher
                .Filter = (searchString)
                .PropertiesToLoad.Add("member")

                Try
                    Dim dsResult As SearchResult = .FindOne
                    Dim intCounter As Integer

                    If dsResult Is Nothing Then
                        Return Nothing
                    End If

                    For intCounter = 0 To dsResult.Properties("member").Count - 1
                        strUsers = dsResult.Properties("member")(intCounter).ToString

                        intEqualsIndex = strUsers.IndexOf("=", 1)
                        intCommaIndex = strUsers.IndexOf(",", 1)

                        If intEqualsIndex = -1 Then
                            Return Nothing
                        End If

                        sbGroupUsers.Append(strUsers.Substring((intEqualsIndex + 1), (intCommaIndex - intEqualsIndex) - 1))
                        sbGroupUsers.Append("<br>")

                    Next intCounter
                Catch ex As Exception
                    Throw
                Finally
                    dsDirectorySearcher.Dispose()
                    dsDirectoryEntry.Close()
                    dsDirectoryEntry.Dispose()
                End Try
            End With

            Return sbGroupUsers.ToString

        End Function
    End Class
End Namespace