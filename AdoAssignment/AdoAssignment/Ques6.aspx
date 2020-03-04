<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ques6.aspx.cs" Inherits="AdoAssignment.Ques6" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
            <asp:Label ID="Label1" class="label label-default" runat="server" Text="Product Name"></asp:Label>
            <asp:TextBox ID="TextBox1" class="form-control my-2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" CssClass="btn btn-primary mb-2" runat="server" Text="Purchase" OnClick="Purchase_Click" />

            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
</asp:content>
