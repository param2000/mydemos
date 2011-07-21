Imports NUnit.Framework
Imports WatiN.Core
Imports StorEvil

<Context()> _
Public Class SignInContext

    Private _username As String
    Private _password As String
    Private _ie As Browser

    Public Sub Given_username_USERNAME_and_password_PASSWORD(ByVal USERNAME As String, ByVal PASSWORD As String)
        _ie = New IE("http://localhost:49699/Account/LogOn")
        _username = USERNAME
        _password = PASSWORD
    End Sub

    Public Sub When_I_login()
        _ie.TextField(Find.ById("UserName")).TypeText(_username)
        _ie.TextField(Find.ById("Password")).TypeText(_password)

        _ie.Button(Find.ByValue("Log On")).Click()
    End Sub

    Public Sub Then_I_should_be_logged_in_as_me()
        Assert.IsTrue(_ie.ContainsText("Welcome " + _username))
        _ie.Dispose()
    End Sub

    Public Sub Then_I_should_not_be_logged_in_as_me()
        Assert.IsFalse(_ie.ContainsText("Welcome " + _username))
        _ie.Dispose()
    End Sub



End Class