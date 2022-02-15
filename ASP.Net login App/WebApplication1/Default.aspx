<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <link rel="stylesheet" href="Content\Style.css">

     <div class="bg-color-defaultPage" style="text-align:center;color:antiquewhite;font-size:60px;margin-top:50px;" >
         <asp:Label ID="LabelDefaultPageText1" runat="server" Text="Label"></asp:Label>  
         </div>
    <div class="default2" style="color:antiquewhite;text-align:center;font-size:60px;">
    <asp:Label ID="LabelDefaultPageText2" runat="server" Text="Label"></asp:Label>
</div>
    <br><br><br><br><br><br><br>
</asp:Content>

