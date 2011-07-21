Public Class WebForm1
    Inherits System.Web.UI.Page

    Public Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim fs As New FileService()
        Dim f = file1.Text.Trim
        Dim b = fs.Getfile(f, "")

        Dim isPdfFile As Boolean = True
        Response.ContentType = "application/pdf"

        Response.TransmitFile(b)



    End Sub

End Class