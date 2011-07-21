Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.IO

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://localhost/FileServices/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class FileService
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function Getfile(ByVal strfileName As String, ByVal user As String) As Byte()
        'strfileName = "\UserDocs\Common\Participation_Security.pdf"
        strfileName = "\UserDocs\Common\" + strfileName



        Dim fileBytes As Byte()
        Dim binReader As New BinaryReader(File.Open(Server.MapPath(strfileName), FileMode.Open, FileAccess.Read))
        binReader.BaseStream.Position = 0
        fileBytes = binReader.ReadBytes(Convert.ToInt32(binReader.BaseStream.Length))

        Return fileBytes
    End Function


End Class