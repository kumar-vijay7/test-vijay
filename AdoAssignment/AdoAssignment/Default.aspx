<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AdoAssignment._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container my-3 border-secondary"> 
        <asp:Button ID="Button1" CssClass="btn btn-primary mb-2" runat="server" Text="Connected" OnClick="Show_Data" />
        <asp:Button ID="Button2" CssClass="btn btn-primary mb-2 ml-2" runat="server" Text="Disconnected" OnClick="Disconnected_Click" />
        <asp:Label ID="Label1" runat="server" Text="" Visible="False"></asp:Label>  
        <asp:Label ID="Label2" runat="server" Text="" Visible="False"></asp:Label>
        <asp:GridView ID="GridView1" class="table table-hover table-dark" runat="server">

        </asp:GridView>
        
        
    </div>
    
</asp:Content>
