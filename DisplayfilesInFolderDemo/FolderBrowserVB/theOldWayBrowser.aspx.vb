Imports System.Text
Imports System.IO
Imports System.Configuration

Namespace KeithRull.FolderBrowserVB
    Partial Class theOldWayBrowser
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub

        'NOTE: The following placeholder declaration is required by the Web Form Designer.
        'Do not delete or move it.
        Private designerPlaceholderDeclaration As System.Object

        Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
            'CODEGEN: This method call is required by the Web Form Designer
            'Do not modify it using the code editor.
            InitializeComponent()
        End Sub

#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim lcTableHead As LiteralControl = New LiteralControl("<TABLE id=FileSystem style='FONT-SIZE: xx-small; BORDER-TOP-STYLE: none; FONT-FAMILY: Arial; BORDER-RIGHT-STYLE: none; BORDER-LEFT-STYLE: none; BORDER-COLLAPSE: collapse; BORDER-BOTTOM-STYLE: none' cellSpacing=0 rules=all border=1>")
            plhFiles.Controls.Add(lcTableHead)
            Dim lcContents As LiteralControl

            Dim lcTableHeader As LiteralControl = New LiteralControl("<TR><TD style='WIDTH: 80px'>Type</TD><TD style='WIDTH: 350px'>Name</TD><TD style='WIDTH: 150px'>CreationTime</TD><TD style='WIDTH: 150px'>LastWriteTime</TD></TR>")
            plhFiles.Controls.Add(lcTableHeader)

            Try
                Dim browseProperty As New FileBrowserProperty
                Dim strDir As String = IIf(Request.QueryString("d") = Nothing, browseProperty.IntialPath, Request.QueryString("d"))
                Dim DirInfo As DirectoryInfo = New DirectoryInfo(strDir)
                Dim subDirs As DirectoryInfo() = DirInfo.GetDirectories()
                Dim Files As FileInfo() = DirInfo.GetFiles()

                If ((Files.Length <> 0) Or (subDirs.Length <> 0)) Then

                    For Each di As DirectoryInfo In subDirs
                        Dim lcFolders As LiteralControl = New LiteralControl("<TR><TD style='WIDTH: 80px'>Directory</TD><TD style='WIDTH: 350px'><a href='theOldWayBrowser.aspx?d=" + di.FullName + "'>" + di.Name + "</a></TD><TD style='WIDTH: 150px'>" + di.CreationTime + "</TD><TD style='WIDTH: 150px'>" + di.LastWriteTime + "</TD></TR>")
                        plhFiles.Controls.Add(lcFolders)
                    Next

                    For Each fi As FileInfo In Files
                        Dim lcContentsHead As LiteralControl = New LiteralControl("<tr><td>File</td><td>")
                        plhFiles.Controls.Add(lcContentsHead)
                        Dim lb As LinkButton = New LinkButton
                        lb.Text = fi.Name
                        lb.CommandArgument = fi.FullName
                        AddHandler lb.Click, AddressOf Download
                        plhFiles.Controls.Add(lb)
                        Dim lcContentsTail As LiteralControl = New LiteralControl("</td><td>" + fi.CreationTime + "</td><td valign='bottom'>" + fi.LastWriteTime + "</td></tr>")
                        plhFiles.Controls.Add(lcContentsTail)
                    Next

                Else
                    lcContents = New LiteralControl("<tr><td  colspan = 4>&nbsp;No file/folder found inside this directory.</td></tr>")
                    plhFiles.Controls.Add(lcContents)
                End If
            Catch ex As Exception
                lcContents = New LiteralControl("<tr><td colspan = 4>&nbsp;Error encountered while trying to parse directory. " + ex.Message + "</td></tr>")
                plhFiles.Controls.Add(lcContents)
            End Try

            Dim lcTableTail As LiteralControl = New LiteralControl("</table>")
            plhFiles.Controls.Add(lcTableTail)
        End Sub

        Private Sub Download(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim filepath As String = CType(sender, LinkButton).CommandArgument
            Dim filename As String = filepath.Substring(filepath.LastIndexOf("\") + 1, filepath.Length - filepath.LastIndexOf("\") - 1)

            Dim s As Stream = File.OpenRead(filepath)
            Dim buffer(s.Length) As Byte
            Try
                s.Read(buffer, 0, CType(s.Length, Int32))
            Finally

                s.Close()
            End Try
            Response.ClearHeaders()
            Response.ClearContent()
            Response.ContentType = "application/octet-stream"
            Response.AddHeader("Content-Disposition", "attachment; filename=" + filename)
            Response.BinaryWrite(buffer)
            Response.End()
        End Sub

    End Class
End Namespace