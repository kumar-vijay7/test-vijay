<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ques5.aspx.cs" Inherits="AdoAssignment.Ques5" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Product ID:"></asp:Label>
    <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox> 
    <asp:Label ID="Label2" runat="server" Text="Product Name:"></asp:Label>
    <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" CssClass="btn btn-primary my-2" runat="server" Text="Search" OnClick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server" Visible="False"></asp:GridView>
 </asp:content>
