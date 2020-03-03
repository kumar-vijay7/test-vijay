<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="MyWeb.Calculator" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <!--<link href="Content/Site.css" rel="stylesheet" />-->

    <div class="container h-100 w-25 pt-2 pb-4 border border-primary rounded">
        <asp:Label ID="Label1" runat="server" Text="Calculator" Font-Bold="True"></asp:Label>
        <br />
        <asp:TextBox ID="DisplayText" Class="h-100 sp-2 text-right" runat="server" TextMode="Number" Width="250px"></asp:TextBox>
      <br />
        <!----------------------------Operator Button Starts here-------------------------------------------->

    <div class="container mt-2 w-100  p-0">
      <asp:Button class="btn btn-primary w-20" ID="Add" runat="server" Text="+" OnClick="CallOperator"/>
      <asp:Button class="btn btn-success w-20" ID="Sub" runat="server" Text="-" OnClick="CallOperator"/>
      <asp:Button class="btn btn-warning w-20" ID="Mul" runat="server" Text="x" OnClick="CallOperator"/>
      <asp:Button class="btn btn-info  w-20" ID="Divide" runat="server" Text="/" OnClick="CallOperator" />
      
    </div>
<!----------------------------Operator Button Ends here-------------------------------------------->

<!----------------------------Number Button Button Starts here-------------------------------------------->
      
        <div class="container mt-2  p-0">
           
        <asp:Button class="btn btn-secondary  w-20"  ID="Button1" runat="server" Text="1" OnClick="Button_click" />
        <asp:Button class="btn btn-secondary  w-20"  ID="Button2" runat="server" Text="2" OnClick="Button_click" />
        <asp:Button class="btn btn-secondary  w-20"  ID="Button3" runat="server" Text="3" OnClick="Button_click"/>
        <asp:Button class="btn btn-secondary  w-20"  ID="Button4" runat="server" Text="4" OnClick="Button_click"/>
        </div> 
         <div class="container mt-2   p-0">
       
        <asp:Button class="btn btn-secondary  w-20"  ID="Button5" runat="server" Text="5" OnClick="Button_click"/>
        <asp:Button class="btn btn-secondary  w-20"  ID="Button6" runat="server" Text="6" OnClick="Button_click"/>
        <asp:Button class="btn btn-secondary  w-20"  ID="Button7" runat="server" Text="7" OnClick="Button_click" />
        <asp:Button class="btn btn-secondary  w-20"  ID="Button8" runat="server" Text="8" OnClick="Button_click"/>
        </div>
         <div class="container mt-2  p-0">
        <asp:Button class="btn btn-secondary  w-20"  ID="Button9" runat="server" Text="9" OnClick="Button_click"/>
        <asp:Button class="btn btn-secondary  w-20"  ID="zero" runat="server" Text="0" OnClick="Button_click" />
        <asp:Button class="btn btn-danger  w-20"  ID="clear" runat="server" Text="clear" OnClick="ClearDisplay"/>
        <asp:Button class="btn btn-secondary  w-20" ID="Button10" runat="server" Text="=" OnClick="Calculate" />
        </div>
       </div>


    
 </asp:Content>