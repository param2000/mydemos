Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.IO

Namespace KeithRull.FileBrowserVB
    Partial Class theNewWayBrowser
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
            Dim browseProperty As New FileBrowserProperty
            Dim folderToBrowse As String = IIf(Request.QueryString("d") = Nothing, browseProperty.IntialPath, Request.QueryString("d"))

            Dim DirInfo As DirectoryInfo = New DirectoryInfo(folderToBrowse)

            Dim fileSystemFolderTable As DataTable = New DataTable
            Dim fileSystemFileTable As DataTable = New DataTable

            Dim fileSystemCombinedTable As DataTable = New DataTable

            Dim dcFileType As DataColumn = New DataColumn("Type")
            Dim dcFileFullName As DataColumn = New DataColumn("FullName")
            Dim dcFileName As DataColumn = New DataColumn("Name")
            Dim dcFileCreationTime As DataColumn = New DataColumn("CreationTime")
            Dim dcFileLastWriteTime As DataColumn = New DataColumn("LastWriteTime")

            Dim dcFolderType As DataColumn = New DataColumn("Type")
            Dim dcFolderFullName As DataColumn = New DataColumn("FullName")
            Dim dcFolderName As DataColumn = New DataColumn("Name")
            Dim dcFolderCreationTime As DataColumn = New DataColumn("CreationTime")
            Dim dcFolderLastWriteTime As DataColumn = New DataColumn("LastWriteTime")

            fileSystemFolderTable.Columns.Add(dcFileType)
            fileSystemFolderTable.Columns.Add(dcFileName)
            fileSystemFolderTable.Columns.Add(dcFileFullName)
            fileSystemFolderTable.Columns.Add(dcFileCreationTime)
            fileSystemFolderTable.Columns.Add(dcFileLastWriteTime)

            fileSystemFileTable.Columns.Add(dcFolderType)
            fileSystemFileTable.Columns.Add(dcFolderName)
            fileSystemFileTable.Columns.Add(dcFolderFullName)
            fileSystemFileTable.Columns.Add(dcFolderCreationTime)
            fileSystemFileTable.Columns.Add(dcFolderLastWriteTime)

            For Each di As DirectoryInfo In DirInfo.GetDirectories()
                Dim fileSystemRow As DataRow = fileSystemFolderTable.NewRow()
                fileSystemRow("Type") = "Directory"
                fileSystemRow("Name") = di.Name
                fileSystemRow("FullName") = di.FullName
                fileSystemRow("CreationTime") = di.CreationTime
                fileSystemRow("LastWriteTime") = di.LastWriteTime
                fileSystemFolderTable.Rows.Add(fileSystemRow)
            Next

            For Each fi As FileInfo In DirInfo.GetFiles()
                Dim fileSystemRow As DataRow = fileSystemFileTable.NewRow()
                fileSystemRow("Type") = "File"
                fileSystemRow("Name") = fi.Name
                fileSystemRow("FullName") = fi.FullName
                fileSystemRow("CreationTime") = fi.CreationTime
                fileSystemRow("LastWriteTime") = fi.LastWriteTime
                fileSystemFileTable.Rows.Add(fileSystemRow)
            Next

            fileSystemCombinedTable = fileSystemFolderTable.Copy()

            For Each drw As DataRow In fileSystemFileTable.Rows

                fileSystemCombinedTable.ImportRow(drw)
            Next
            FileSystemGrid.DataSource = fileSystemCombinedTable
            FileSystemGrid.DataBind()
        End Sub

        Private Sub FileSystemGrid_ItemCommand(ByVal sender As System.Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles FileSystemGrid.ItemCommand

            Dim filepath As String = e.CommandArgument.ToString()
            Dim fileSystemType As String = FileSystemGrid.Items(e.Item.ItemIndex).Cells(0).Text
            If (fileSystemType = "Directory") Then
                Response.Redirect("theNewWayBrowser.aspx?d=" + e.CommandArgument.ToString())
            Else

                Dim filename As String = e.CommandName


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
            End If
        End Sub
    End Class
End Namespace
