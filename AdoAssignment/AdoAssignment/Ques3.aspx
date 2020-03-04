<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ques3.aspx.cs" Inherits="AdoAssignment.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="TextBox1"  class="form-control" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="TextBox2"  class="form-control" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Product Sold"></asp:Label>
        <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Product Left"></asp:Label>
        <asp:TextBox ID="TextBox4" class="form-control" runat="server"></asp:TextBox>
        <div class="container my-2">
        <asp:Button ID="Button1" CssClass="btn btn-primary mr-1" runat="server" Text="Insert" OnCommand="Button1_Command" CommandName="Insert"/>
        <asp:Button ID="Button2" CssClass="btn btn-danger mr-1" runat ="server" Text="Delete" OnCommand="Button1_Command" CommandName="edit" CommandArgument="Delete"/>
        <asp:Button ID="Button3" CssClass="btn btn-secondary" runat="server" Text="Update" OnCommand="Button1_Command" CommandName="edit" CommandArgument="Update"/>
            </div>
        
        <asp:GridView ID="GridView1" runat="server" Visible="False"></asp:GridView>
        <asp:Button ID="Button4" class="btn btn-success mt-2" runat="server" Text="Button" OnClick="Button4_Click" />
    </div>
</asp:Content>
