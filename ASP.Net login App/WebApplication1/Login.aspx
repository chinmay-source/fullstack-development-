<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
      <link rel="stylesheet" href="Content\Style.css">
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"/>
   
      <div class="login-form" style="align-content:center;">
         <div class="text">
            LOGIN
         </div>
         
            <div class="field" style="margin-left:110px;">
               <div class="fas fa-envelope"></div>
               <asp:TextBox ID="TextBoxUserName" class="form-control" runat="server"  placeholder="Enter email"></asp:TextBox>
            </div>
            <div class="field" style="margin-left:110px;">
               <div class="fas fa-lock"></div>
               <asp:TextBox ID="TextBoxPassword" class="form-control" runat="server"   placeholder="Password" TextMode="Password"></asp:TextBox>
            </div><br>
              <asp:Label ID="LabelMessage" runat="server" Text="Message" ForeColor="#CC0000" Font-Size="Large"></asp:Label><br>
            <asp:Button ID="ButtonSubmit" class="btn btn-primary" runat="server" Text="Login" OnClick="ButtonSubmit_Click" BackColor="#66FF33" ForeColor="Black" EnableTheming="True" OnClientClick="ButtonSubmit_Click" />
          
      </div><br><br><br><br><br><br>
 
</asp:Content>
