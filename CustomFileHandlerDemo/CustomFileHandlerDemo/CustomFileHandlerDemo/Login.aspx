<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CustomFileHandlerDemo.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Login ID="ctrlLogin" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
                BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                Font-Size="0.8em" ForeColor="#333333" Height="129px" Width="241px" 
                DestinationPageUrl="~/User/Default.aspx" onloggedin="ctrlLogin_LoggedIn">
                <TextBoxStyle Font-Size="0.8em" />
                <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                    BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
                    ForeColor="White" />
            </asp:Login>
<br />
<table style="border:1px solid #000000;" width="241px" bgcolor="#F7F6F3" cellspacing="4px"><tr><td><font face="verdana" size="2">
Allowed access to PDF<br />
Username: john<br />
Password: doe<br />
<br />
Denied access to PDF<br />
Username: jane<br />
Password: doe<br />
</font></td></tr></table>
        </ContentTemplate>
        </asp:UpdatePanel>    
    </div>
    </form>
</body>
</html>
