<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DashBoard.aspx.cs" Inherits="MyWeb.DashBoard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <div class="container-fluid border">
           <div class="container">
               <div class="row">
                   <div class="col-md-2">
                       <asp:Label ID="user" class="font-weight-bold" runat="server" Text="UserName :"></asp:Label>
                       <asp:Label ID="Username" runat="server" Text=""></asp:Label>
                   </div>
                   <div class="col-md-6"></div>
                   <div class="col-md-4">
                       
          <!--Card-->
          <div class="card mb-4 m-2">

            <!--Card content-->
            <div class="card-body">

              <!-- List group links -->
              <div class="list-group list-group-flush">
                <a class="list-group-item list-group-item-action waves-effect">Application Running
                  <span class="badge badge-success badge-pill pull-right">
                      <asp:Label ID="apprun" runat="server" Text=""></asp:Label>
                    <i class="fa fa-arrow-up ml-1"></i>
                  </span>
                </a>
                <a class="list-group-item list-group-item-action waves-effect">User Online
                  <span class="badge badge-danger badge-pill pull-right">
                      <asp:Label ID="useron" runat="server" Text=""></asp:Label>
                    <i class="fa fa-arrow-down ml-1"></i>
                  </span>
                </a>

              </div>
              <!-- List group links -->

            </div>

          </div>
                   </div>

               </div>
           </div>
       </div>
    

</asp:Content>