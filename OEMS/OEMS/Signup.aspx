<%@ Page Language="C#" MasterPageFile ="~/Admin.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="VPLab7.Signup" %>


<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="SignLogstyle.css" />
   
        
        <div class="container">
            <h2>User Signup</h2>

            <div class="form-group">               
                <label for="txtUserName">User Name:</label>

                <asp:TextBox ID="txtUserName" runat="server" class="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
               
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
            
            </div>
            
            

            <div class="form-group" >
                <label for="ddlStatus">Status:</label>
                
                <asp:DropDownList ID="ddlStatus" runat="server" class="form-control">
                   
                    <asp:ListItem >Select</asp:ListItem>

                    <asp:ListItem >Inactive</asp:ListItem>

                    <asp:ListItem >Active</asp:ListItem>
                </asp:DropDownList>
            </div>
            
            <div class="form-group">
                <asp:Button ID="btnSignup" runat="server" Text="Create Account" CssClass="btn btn-primary" OnClick="btnSignup_Click" />
            </div>

          
  <div class="lbl">

  <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
</div>

        </div>
   
    

</asp:Content>








