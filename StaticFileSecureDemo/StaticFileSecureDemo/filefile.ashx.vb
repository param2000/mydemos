Imports System.Web
Imports System.IO
Imports System.Web.Security
Imports System.Configuration

Public Class filefile
    Implements System.Web.IHttpHandler

    '~/filefile.ashx?file=somefile.pdf
    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        
        If Not context.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
            Return
        End If

        If Not context.User.IsInRole("admin") Then
            'not authorized
            context.Response.Redirect("~/NotInRole.aspx")
            Return
        End If

        Dim fName As String = context.Request.QueryString("file")
        Dim docsPath As String = ConfigurationManager.AppSettings("MembersOnlyStaticDocumentPath").ToString
        Dim p As String = Path.Combine(docsPath, fName)
        SendContentTypeAndFile(context, p)
    End Sub

    Private Function SendContentTypeAndFile(ByVal context As HttpContext, ByVal fileName As String) As HttpContext
        context.Response.ContentType = GetContentType(fileName)
        SendIt(context, fileName)
        context.Response.Flush()
        context.Response.End()
        Return context
    End Function

    Private Sub SendIt(ByVal context As HttpContext, ByVal fileName As String)
        context.Response.TransmitFile(fileName)
    End Sub

    Private Function GetContentType(ByVal filename As String) As String
        'MIME type
        Dim fileinfo As New FileInfo(filename)

        If fileinfo.Exists Then
            Select Case fileinfo.Extension.ToLower()
                Case ".doc"
                    Return "application/msword"
                Case ".pdf"
                    Return "application/pdf"
                Case ".xls"
                    Return "application/vnd.ms-excel"
                Case ".xlsx"
                    Return "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                Case ".docx"
                    Return "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
            End Select
        End If
        Return Nothing
    End Function

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class