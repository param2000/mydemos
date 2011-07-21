Imports System.DirectoryServices
Imports LdapTester.LdapStuff

Partial Public Class LdapUser
    Inherits System.Web.UI.Page

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loginID.Text = UserFunctions.GetUserName(UserFunctions.CurrentUser())
        currentUserID.Text = UserFunctions.CurrentUser()
        If Not Page.IsPostBack Then
            LoadUsers()
        End If
    End Sub

    Private Sub LoadUsers()
        Try
            Dim sb As New System.Text.StringBuilder()
            Dim arrDept As New ArrayList()
            ' Bind to the users container.
            Dim entry As New DirectoryEntry("LDAP://OU=AD Users,DC=FHLB10,DC=com")
            ' Create a DirectorySearcher object.
            Dim mySearcher As New DirectorySearcher(entry)
            ' Create a SearchResultCollection object to hold a collection of SearchResults
            ' returned by the FindAll method.
            Dim result As SearchResultCollection = mySearcher.FindAll()
            ' Create an object to hold a single result from the result collection.
            Dim resEnt1 As SearchResult
            ' Get search results. For more information, see Getting Search Results.
            sb.Append("<table border=1><tr><td><b>Department</b></td><td><b>Name</b></td><td><b>Description</b></td><td><b>Network ID</b></td><td><b>Updated</b></td></tr>")
            For Each resEnt1 In result
                Dim myLDAP As New LdapStuff.LdapUser()
                ' Iterate through each property name in each SearchResult.
                Dim propKey As String
                For Each propKey In resEnt1.Properties.PropertyNames
                    ' Retrieve the value assigned to that property name 
                    ' in the ResultPropertyValueCollection.
                    Dim valcol As ResultPropertyValueCollection = resEnt1.Properties(propKey)
                    ' Iterate through values for each property name in each SearchResult.
                    Dim prop As [Object]
                    For Each prop In valcol
                        ' Handle results. Be aware that the following WriteLine
                        ' only returns readable results on properties that are strings.
                        Select Case Convert.ToString(propKey)
                            Case "name"
                                myLDAP.DisplayName = prop.ToString().Trim()
                            Case "givenname"
                                myLDAP.FirstName = prop.ToString().Trim()
                            Case "sn"
                                myLDAP.LastName = prop.ToString().Trim()
                            Case "description"
                                myLDAP.Description = prop.ToString().Trim()
                            Case "department"
                                myLDAP.Department = prop.ToString().Trim()
                            Case "mail"
                                myLDAP.Email = prop.ToString().Trim()
                            Case "mailnickname"
                                myLDAP.NetworkID = prop.ToString().Trim()
                            Case "company"
                                myLDAP.Company = prop.ToString().Trim()
                        End Select
                    Next prop
                Next propKey
                If (myLDAP.NetworkID <> "" And myLDAP.DisplayName.IndexOf(" ") > 0 And myLDAP.Department <> "") Then
                    Dim bAdded As Boolean = False
                    If arrDept.IndexOf(myLDAP.Department) < 0 Then
                        arrDept.Add(myLDAP.Department)
                        'UpdateDepartment(myLDAP.Department)
                    End If

                    'bAdded = myLDAP.Save(FhlbSession.SecConnString, CStr(Session("CurrentUserID")), GetDeptID(myLDAP.Department))
                    sb.Append("<tr><td>" & myLDAP.Department)
                    sb.Append("</td><td>" & myLDAP.DisplayName)
                    sb.Append("</td><td>" & myLDAP.Description)
                    sb.Append("</td><td>" & myLDAP.NetworkID)
                    sb.Append("</td><td>" & bAdded.ToString())
                    sb.Append("</td></tr>")

                End If
            Next resEnt1

            sb.Append("</table><hr>List of FHLBank Departments:<ol>")
            Dim i As Integer
            For i = 0 To arrDept.Count - 1
                sb.Append("<li>" & CStr(arrDept(i)))
            Next
            sb.Append("</ol>")
            litUsers.Text = sb.ToString()
        Catch exception As System.Runtime.InteropServices.COMException
            'ExceptionManager.Publish(exception)
            litUsers.Text = exception.Message
        Catch InvOpEx As InvalidOperationException
            litUsers.Text = InvOpEx.Message
        Catch NotSuppEx As NotSupportedException
            litUsers.Text = NotSuppEx.Message
        End Try
    End Sub



    Private Function GetDeptID(ByVal DepartmentName As String) As Integer
        Return 1
    End Function

End Class