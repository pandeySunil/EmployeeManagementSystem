<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="welcome.aspx.cs" Inherits="EmployeeManagementSystem.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Welcome Page</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" CssClass="mylabel" 
        Style="position:absolute;top:59px; left:13px;" Font-Bold="True" 
        ForeColor="Red"></asp:Label>
    
        </div>
    </form>
</body>
</html>
