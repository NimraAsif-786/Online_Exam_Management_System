<%@ Page Language="C#" MasterPageFile ="~/Instruct.Master" AutoEventWireup="true" CodeBehind="InsProfile.aspx.cs" Inherits="VPLab7.WebForm1" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
    
   <div class ="container">
        
       <h4>Instructor Information</h4>

         <div class="form-group">

             <asp:Label ID="lblid" runat="server" Text="Enter your ID to access your profile: "></asp:Label>
               <asp:TextBox ID="txtID" runat="server" class="form-control"></asp:TextBox>
             
         </div>

       <div class="form-group">
             <asp:Button ID="btnSrch" runat="server" Text="Get" CssClass =" btn-crud" OnClick="btnSrch_Click"/>
        </div>
 
         <div class="form-group">

              <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>

            <asp:TextBox ID="txtname" runat="server" class="form-control"></asp:TextBox>
     
         </div>
      
       <div class="form-group">

              <asp:Label ID="lblcnic" runat="server" Text="CNIC"></asp:Label>
            <asp:TextBox ID="txtcnic" runat="server" class="form-control" ></asp:TextBox>
           
     
         </div>
       
       <div class="form-group">
            <asp:Label ID="lblcontact" runat="server" Text="Contact "></asp:Label>
            
            <asp:TextBox ID="txtcontact" runat="server" class="form-control"></asp:TextBox>
               
         </div>
       <div class="form-group">
            <asp:Label ID="lbladrs" runat="server" Text="Address "></asp:Label>
            
            <asp:TextBox ID="txtadrs" runat="server" class="form-control"></asp:TextBox>
               
         </div>
       <div class="form-group">
            <asp:Label ID="lbldept" runat="server" Text="Department "></asp:Label>
            
            <asp:TextBox ID="txtdept" runat="server" class="form-control"></asp:TextBox>
               
         </div>

         <div class="lbl">
               <asp:Label ID="lblMessage" runat="server"></asp:Label>
  
            </div> 
       
       <div class="form-group">
           <asp:Label ID="Labelp" runat="server" Text="No profile? "></asp:Label>
        </div>
         <div class="form-group button-row">
                        
            <asp:Button ID="btnCreate" runat="server"  Text="Create your profile" CssClass =" btn-crud" OnClick="btnCreate_Click"/>

             <asp:Button ID="btnInsert" runat="server"  Text="Save" CssClass =" btn-crud" OnClick="btnInsert_Click"/>

            <asp:Button ID="btnUpdate" runat="server"  Text="Update" CssClass =" btn-crud" OnClick="btnUpdate_Click"/>
            <asp:Button ID="btnDlt" runat="server"  Text="Delete" CssClass =" btn-crud"  OnClick="btnDlt_Click"/>

     
         </div>
       
      

        <asp:GridView ID="datagv" runat="server" Height="95px" Width="463px">
        </asp:GridView>
           
            

   </div>
    

</asp:Content>
