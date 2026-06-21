<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="VPLab7.UserLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  
    <title>User Login</title>
    
   <link rel="stylesheet" href="Users.css" />
    <link href="SignLogstyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form2" runat="server">
      
        <div class="container">
           
            <h2>User Login</h2>
            
            <div class="form-group">
            
                <label for="txtUsername">Username:</label>
                
                <asp:TextBox ID="txtuname" runat="server" class="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
               
                <label for="txtPassword">Password:</label>
              
                <asp:TextBox ID="txtpass" runat="server" TextMode="Password" class="form-control"></asp:TextBox>
            </div>
             
            <div class="lbl">

              <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
            </div>

            <div class="form-group">
            
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click"  />
            </div>
            
          
       
        </div>
    
    </form>
</body>
</html>