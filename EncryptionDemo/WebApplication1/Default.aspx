<%@ Page Title="Home Page" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeBehind="Default.aspx.vb" Inherits="WebApplication1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
      <h2>
        Welcome to Encode Decode Demo!
    </h2>
    <p>
        <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
    </p>
    <p> 
        <asp:Button ID="encrypt" runat="server" Text="Encrypt" />
        <asp:Button ID="decrypt" runat="server" Text="Decrypt" />
       
    </p>
        
    <p>
        <asp:Label ID="Label1" runat="server" Text="Encoded string >>"></asp:Label>
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </p>
    <p> 
        <asp:Label ID="Label2" runat="server" Text="Decoded string >>"></asp:Label>
    <asp:Label ID="lblInput" runat="server" Text=""></asp:Label>
    </p>
     <p> 
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
