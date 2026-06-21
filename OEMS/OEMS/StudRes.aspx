<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile ="~/Stud.Master" CodeBehind="StudRes.aspx.cs" Inherits="VPLab7.StudRes" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
    
   <div class ="container">
        
       <h4>Final Result</h4>

               <div class="form-group">

       <asp:Label ID="labelID" runat="server" Text="Enter Exam ID:"></asp:Label>
         <asp:TextBox ID="txtexID" runat="server" class="form-control"  ></asp:TextBox>
   
      </div>

            <div class="form-group">

          <asp:Label ID="lblsid" runat="server" Text="Enter Student ID:"></asp:Label>
           <asp:TextBox ID="txtsid" runat="server" class="form-control" ></asp:TextBox> 
          </div>

          <div class="form-group button-row">
           <asp:Button ID="btnRes" runat="server"  Text="Show Result" CssClass =" btn-crud" OnClick="Showresult_Click"/>

        </div>
          
            
           <div class="lbl">

  <asp:Label ID="lblResult" runat="server"  ></asp:Label> 
</div>


          </div>
</asp:Content>