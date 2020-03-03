<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="MyWeb.HelloWorld" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="CountryList" runat="server" OnSelectedIndexChanged="Country" AutoPostBack="True">
                <asp:ListItem Value="1">Male</asp:ListItem>
                <asp:ListItem Value="2">Female</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Hello" runat="server" OnDataBinding="Country"></asp:Label>
            <asp:Label ID="QueryName" runat="server" OnDataBinding="Country"></asp:Label>
            
        </div>
    </form>
</body>
</html>
