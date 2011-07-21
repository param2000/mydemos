Imports System.Web.Security

Partial Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub loginCntrl_LoginError(ByVal sender As Object, ByVal e As System.EventArgs) Handles loginCntrl.LoginError
        Dim memUser As MembershipUser = Membership.GetUser(loginCntrl.UserName)
        If (Not memUser Is Nothing) AndAlso memUser.IsLockedOut Then
            loginCntrl.FailureText = "Your account has been disabled. Please contact your Members Only administrator."
        End If
    End Sub

End Class