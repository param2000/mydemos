<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="LdapTester.LdapUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" method="post" runat="server">
        <table>
        <tr>
            <td>LoginName=<asp:Label runat="server" ID="loginID">Empty LoginName</asp:Label></td>
            <td>CurrentUser=<asp:Label runat="server" ID="currentUserID">Empty CurrentUser</asp:Label></td>
        </tr>
            <tr valign="middle">
                <td>
                    <h1>
                        FHLBank Active Directory Users
                        <asp:button id="btnDone" runat="server" text="Back" font-size="XX-Small" />
                    </h1>
                </td>
            </tr>
        </table>
        <asp:literal id="litUsers" runat="server" />
        <br />
        <asp:button id="Button1" runat="server" text="Back" font-size="XX-Small" />
    </form>
</body>
</html>
