<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <div id="carouselExampleIndicators" class="carousel slide h-100" data-ride="carousel">
  <ol class="carousel-indicators">
    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
  </ol>
  <div class="carousel-inner">
    <div class="carousel-item active">
        <asp:Image ID="Image1" class="d-block w-100" ImageUrl="~/Content/Images/Banner_Zinnov_1.jpg" runat="server" />
        <div class="carousel-caption d-none d-md-block">
    <h5>TO THE NEW achieves AWS Premier Consulting Partner status</h5>
    <p>This prestigious partnership aims to highlight some of the top consulting partners across the globe</p>
  </div>
    </div>
    <div class="carousel-item">
   
        <asp:Image ID="Image2" class="d-block w-100" ImageUrl="~/Content/Images/AWS_HPB_2.png" runat="server" />
        <div class="carousel-caption d-none d-md-block">
    <h5>TO THE NEW recognized by Gartner in top 80 service providers across the globe in Agile and DevOps Services</h5>
    <p>Proud to be featured as preferred service provider for software development & test services by Gartner in “Toolkit to Identify the Right Agile/DevOps Service Provider” report</p>
  </div>
    </div>
    <div class="carousel-item">
      <asp:Image ID="Image3" class="d-block w-100" ImageUrl="~/Content/Images/Banner_Gartner.png" runat="server" />
        <div class="carousel-caption d-none d-md-block">
    <h5>Proud to be named among India’s Best Companies To Work For</h5>
    <p>TO THE NEW is proud to be named in the prestigious “India’s Best Companies to Work For - 2019” list by Great Place to Work Institute® India</p>
  </div>
   
    </div>
  </div>
  <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
    
</asp:Content>
