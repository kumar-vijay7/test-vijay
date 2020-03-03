<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidationForm.aspx.cs" Inherits="MyWeb.ValidationForm" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <!-------------------------------------Question 9----------------------------------------->
        <div class="container">
                     <!------------------------------------Forms of validation starts from here------------------------------------------------->
            <div class="row">    
            <div class="col-md-6 border-right border-secondary py-2">
                <div class="container" id="register" runat="server">
                    <asp:Label class="my-2 font-weight-bold" ID="Label1" runat="server" Text="Register With Us"></asp:Label>
                    <br />
                    <asp:TextBox class="form-control my-2 w-50" ID="user" runat="server" placeholder="Username" Width="184px"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="UserRequiredField" runat="server" ErrorMessage="Please Fill the Username" ControlToValidate="user"></asp:RequiredFieldValidator>
                    
                    <asp:TextBox class="form-control w-50" ID="email" runat="server" placeholder="Email Address" Width="184px"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="EmailRequiredField" runat="server" ErrorMessage="Fill the Email Adress" ControlToValidate="email"></asp:RequiredFieldValidator>
                    
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email Address" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    
                    <asp:TextBox class="form-control w-50" ID="Age" runat="server" TextMode="Number" placeholder="Enter Age" Width="184px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Insert Age" ControlToValidate="Age"></asp:RequiredFieldValidator>
                    
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Age between 18 to 100 " Type="Integer" ControlToValidate="Age" MinimumValue="18" MaximumValue="100"></asp:RangeValidator>
                    
                    <asp:TextBox class="form-control w-50" ID="password" runat="server" TextMode="Password" placeholder="Password" Width="184px"></asp:TextBox>
                    
                    <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" runat="server" ErrorMessage="Fill the insert password" ControlToValidate="password"></asp:RequiredFieldValidator>
               
                    <asp:TextBox class="form-control w-50" ID="confirm_pass" runat="server" TextMode="Password" placeholder="Confirm Password" Width="184px"></asp:TextBox>
                    
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Not Match" ControlToValidate="confirm_pass" ControlToCompare="password"></asp:CompareValidator>
                    <br />
                    <asp:ValidationSummary class="text-danger" ID="ValidationSummary1" runat="server" HeaderText="Validation Errors" ShowMessageBox="True" ShowSummary="False" />
                    
                    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Register" OnClick="Register_Click" />
                    <asp:Label ID="updation" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <div class="col-md-6 login-form-1">
                    <div id="logindiv" class="container ml-3" runat="server">
                    <h3>Login</h3>
                    
                        <div class="form-group">
                            <asp:TextBox runat="server" id="lemail" type="text" class="form-control" placeholder="Your Email *" value="" />
                        </div>
                        <div class="form-group">
                            <asp:TextBox runat="server" id="lpassword" type="password" class="form-control" placeholder="Your Password *" value="" />
                        </div>
                        <div class="form-group">
                            <asp:Button ID="login" class="btn btn-primary" runat="server" Text="Login" OnClick="Login_Click" CausesValidation="False" />
                            </div>
                        <div class="form-group">
                            <a href="#" class="btnForgetPwd">Forget Password?</a>
                        </div>
                        </div>
                </div>
                </div>
            </div>

           

    
        <!------------------------------------Forms of validation ends here------------------------------------------------->
 </asp:Content>
  