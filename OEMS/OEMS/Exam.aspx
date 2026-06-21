<%@ Page Language="C#"  MasterPageFile ="~/Instruct.Master" AutoEventWireup="true" CodeBehind="Exam.aspx.cs" Inherits="VPLab7.Exam" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
    
   <div class ="container">
        
       <h4>Examination</h4>

        <div class="form-group button-row">
     <asp:Button ID="btnInsert" runat="server"  Text="Insert" CssClass =" btn-crud" OnClick="btnInsert_Click"/>
     <asp:Button ID="btnSrch" runat="server" Text="Search" CssClass =" btn-crud" OnClick="btnSrch_Click"/>
    <asp:Button ID="btnUpdate" runat="server"  Text="Update" CssClass =" btn-crud" OnClick="btnUpdate_Click"/>
    <asp:Button ID="btnDlt" runat="server"  Text="Delete" CssClass =" btn-crud"  OnClick="btnDlt_Click"/>

    <asp:Button ID="btnClear" runat="server" Text="Clear"  CssClass =" btn-crud" OnClick="btnClear_Click"/>
    <asp:Button ID="btnView" runat="server" Text="ViewAll" CssClass =" btn-crud" OnClick="btnView_Click"/>

     
    </div>     

         <div class="form-group">

             <asp:Label ID="labelID" runat="server" Text="Exam ID"></asp:Label>
               <asp:TextBox ID="txtID" runat="server" class="form-control"></asp:TextBox>
             
         </div>
 
         <div class="form-group">

              <asp:Label ID="labelname" runat="server" Text="Exam Name"></asp:Label>

            <asp:TextBox ID="txtname" runat="server" class="form-control"></asp:TextBox>
     
         </div>
       <div class="form-group">

              <asp:Label ID="labeldate" runat="server" Text="Date"></asp:Label>

            <asp:TextBox ID="txtdate" runat="server" class="form-control"></asp:TextBox>
     
         </div>
      
       <div class="form-group">

              <asp:Label ID="labeltime" runat="server" Text="Time Allowed"></asp:Label>
            <asp:TextBox ID="txttime" runat="server" class="form-control" ></asp:TextBox>
           
     
         </div>
       
       <div class="form-group">
            <asp:Label ID="labeltm" runat="server" Text="Total Marks "></asp:Label>
            
            <asp:TextBox ID="txttm" runat="server" class="form-control"></asp:TextBox>
           
  
     
         </div>
       
             
           <div class="lbl">

  <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
</div>

        
            <asp:GridView ID="datagv" runat="server" Height="95px" Width="463px">
            </asp:GridView>
            

   </div>
    

</asp:Content>
