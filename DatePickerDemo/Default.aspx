<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Date Picker Demo</title>
    <link href="css/jquery-ui-1.8.11.custom.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-1.5.1.min.js" type="text/javascript"></script>
    <script src="js/jquery-ui-1.8.11.custom.min.js" type="text/javascript"></script>
    <script src="js/jquery.ui.datepicker.js" type="text/javascript"></script>
    <script src="js/jquery.ui.core.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">
	$(function() {
	$("#datepicker").datepicker();
	$("#foo").datepicker();
	});
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat="server" ID="foo" ReadOnly="true"></asp:TextBox>
        <input type='text' id='datepicker' readonly="true">
    </div>
    </form>
</body>
</html>
