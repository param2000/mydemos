<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebServicePdfFileDemo.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" enctype="multipart/form-data" runat="server">
        <p>
        <asp:TextBox ID="file1" runat="server"></asp:TextBox>
        </p>
        <p>
          <asp:Button id="Button1" onclick="Button1_Click" runat="server" Text="Button"></asp:Button>
        </p>
        <!-- Insert content here -->
    </form>
</body>

</body>
</html>
