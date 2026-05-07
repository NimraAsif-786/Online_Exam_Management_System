<%@ Page Language="C#"  MasterPageFile ="~/Instruct.Master" AutoEventWireup="true" CodeBehind="TrueFalse.aspx.cs" Inherits="VPLab7.TrueFalse" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
    
   <div class ="container">
        
       <h4>True False</h4>

              <div class="form-group button-row">
     <asp:Button ID="btnInsert" runat="server"  Text="Insert" CssClass =" btn-crud" OnClick="btnInsert_Click"/>
     <asp:Button ID="btnSrch" runat="server" Text="Search" CssClass =" btn-crud" OnClick="btnSrch_Click"/>
    <asp:Button ID="btnUpdate" runat="server"  Text="Update" CssClass =" btn-crud" OnClick="btnUpdate_Click"/>
    <asp:Button ID="btnDlt" runat="server"  Text="Delete" CssClass =" btn-crud"  OnClick="btnDlt_Click"/>

    <asp:Button ID="btnView" runat="server" Text="ViewAll" CssClass =" btn-crud" OnClick="btnView_Click"/>

     
    </div>     

         <div class="form-group">

             <asp:Label ID="labelqID" runat="server" Text="Question ID:" ></asp:Label>
               <asp:TextBox ID="txtqID" runat="server" class="form-control"></asp:TextBox>
             
         </div> 
       <div class="form-group">

             <asp:Label ID="labelID" runat="server" Text="Exam ID:"></asp:Label>
               <asp:TextBox ID="txtexID" runat="server" class="form-control"></asp:TextBox>
             
         </div>
 
         <div class="form-group">

              <asp:Label ID="labelqno" runat="server" Text="Question No:"></asp:Label>

            <asp:TextBox ID="txtqno" runat="server" class="form-control"></asp:TextBox>
     
         </div>
       <div class="form-group">

              <asp:Label ID="labelq" runat="server" Text="Question:"></asp:Label>

            <asp:TextBox ID="txtq" runat="server" class="form-control"></asp:TextBox>
     
         </div>
      
       <div class="form-group">

              <asp:Label ID="labelopt1" runat="server" Text="Option A:"></asp:Label>

            <asp:TextBox ID="txtopt1" runat="server" class="form-control"></asp:TextBox>
     
         </div>
      
       <div class="form-group">

              <asp:Label ID="labelopt2" runat="server" Text="Option B:"></asp:Label>

            <asp:TextBox ID="txtopt2" runat="server" class="form-control"></asp:TextBox>
     
         </div>
        
               
       <div class="form-group">

         <asp:Label ID="labelans" runat="server" Text="Ans:"></asp:Label>

       <asp:TextBox ID="txtans" runat="server" class="form-control"></asp:TextBox>

    </div>

  <div class="lbl">

  <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
</div>     

       <div class="form-group button-row">
    
             <asp:Button ID="btnNext" runat="server"  Text="Next" CssClass =" btn-crud" OnClick="btnNext_Click"/>
               <asp:Button ID="btnClear" runat="server" Text="Clear"  CssClass =" btn-crud" OnClick="btnClear_Click"/>
 
           <asp:Button ID="btnFinish" runat="server"  Text="Finish" CssClass =" btn-crud" OnClick="btnFinish_Click"/>

        </div>   
             
         <asp:GridView ID="datagv" runat="server" Height="95px" Width="463px">
         </asp:GridView>
 
   </div>
    

</asp:Content>
