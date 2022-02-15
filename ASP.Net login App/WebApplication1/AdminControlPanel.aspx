<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminControlPanel.aspx.cs" Inherits="WebApplication1.AdminControlPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br ><br >
     <link rel="stylesheet" href="Content\Style.css">
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"/>
   
      <div class="login-form" style="align-content:center;">
         <div class="text">
            Admin Panel
         </div>
         
            <div class="field"style="margin-left:110px;">
               
                     
                      <asp:TextBox ID="TextBoxdefaultText1" class="form-control" runat="server"  placeholder="Default Text 1" ></asp:TextBox><br />
                 </div><br >
                <div class="field2" style="margin-left:110px;">
                    
                    <asp:TextBox ID="TextBoxdefaultText2" class="form-control" runat="server"  placeholder="Default Text 2"></asp:TextBox>
                  </div><br>
                <div class="field3"  style="margin-left:110px;">
                     
                  <asp:TextBox ID="TextBoxHeader" class="form-control" runat="server"   placeholder="Header Text"  ></asp:TextBox>
               </div><br>
               <div class="field4" style="margin-left:110px;">
                  
                  <asp:TextBox ID="TextBoxFooter" class="form-control" runat="server"   placeholder="Footer Text" ></asp:TextBox>
               </div><br>
                <asp:Button ID="ButtonSave" runat="server" Text="Save Settings" BackColor="#66FF33" BorderColor="#66FF33" OnClick="ButtonSave_Click" />
            
            <br>
          
            
          
      </div><br><br><br>

</asp:Content>
