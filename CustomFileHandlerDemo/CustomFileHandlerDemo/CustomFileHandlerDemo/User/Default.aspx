<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CustomFileHandlerDemo.User.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        Welcome
        <asp:Label ID="lblName" runat="server" Text="Label" />. You are in the role
        <asp:Label ID="lblRole" runat="server" Text="Label" />. Only those in the User role may access the link below.
    </p>
    <div>
        <asp:HyperLink ID="lnkPDF1" runat="server" NavigateUrl="~/User/Documents/PDF1.pdf" Target="_blank">View PDF 1</asp:HyperLink> | 
        <asp:HyperLink ID="lnkLogout" runat="server" NavigateUrl="~/User/Default.aspx?Logout=1">Logout</asp:HyperLink>
    </div>
    </form>
</body>
</html>
