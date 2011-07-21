<%@ Page Language="vb" AutoEventWireup="false" Codebehind="theNewWayBrowser.aspx.vb" Inherits="KeithRull.FolderBrowserVB.KeithRull.FileBrowserVB.theNewWayBrowser"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>theNewWayBrowser</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:datagrid id="FileSystemGrid" runat="server" BorderStyle="None" AutoGenerateColumns="False"
				Font-Size="XX-Small" Font-Names="Arial" AllowSorting="True">
				<Columns>
					<asp:BoundColumn DataField="Type" HeaderText="Type">
						<HeaderStyle Width="80px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:TemplateColumn HeaderText="Name">
						<HeaderStyle Width="350px"></HeaderStyle>
						<ItemTemplate>
							<asp:LinkButton id="systemLink" runat="server" CommandArgument='<%# DataBinder.Eval(Container, "DataItem.FullName") %>' CommandName='<%# DataBinder.Eval(Container, "DataItem.Name") %>'>
								<%# DataBinder.Eval(Container, "DataItem.Name") %> 
							</asp:LinkButton>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:BoundColumn DataField="CreationTime" HeaderText="CreationTime">
						<HeaderStyle Width="150px"></HeaderStyle>
					</asp:BoundColumn>
					<asp:BoundColumn DataField="LastWriteTime" HeaderText="LastWriteTime">
						<HeaderStyle Width="150px"></HeaderStyle>
					</asp:BoundColumn>
				</Columns>
			</asp:datagrid>
		</form>
	</body>
</HTML>
