<%@ Page Language="C#" MasterPageFile ="~/Stud.Master" AutoEventWireup="true" CodeBehind="StudExam.aspx.cs" Inherits="VPLab7.StudExam" %>


<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
    
   <div class ="container">
        
       <h4>Available Exams</h4>

            <div class="form-group button-row">
     
    <asp:Button ID="btnView" runat="server" Text="Show All Exams" CssClass =" btn-crud"  OnClick="btnView_Click"/>

     
    </div>     

         <div class="form-group">

             <asp:Label ID="labelID" runat="server" Text="Exam ID"></asp:Label>
               <asp:TextBox ID="txtID" runat="server" class="form-control"></asp:TextBox>
             
         </div>
 
            <asp:Button ID="btnproceed" runat="server" Text="Proceed" CssClass =" btn-crud"  OnClick="btnproceed_Click"/>

             
           <div class="lbl">

  <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
</div>

        
 <asp:GridView ID="datagv" runat="server" AutoGenerateColumns="False" CssClass="table">
    <Columns>
        <asp:BoundField DataField="EID" HeaderText="Exam ID" />
        <asp:BoundField DataField="EName" HeaderText="Exam Name" />
        <asp:BoundField DataField="EDate" HeaderText="Date" />
        <asp:BoundField DataField="TotalTime" HeaderText="Time Allowed" />
        <asp:BoundField DataField="TotalMarks" HeaderText="Total Marks" />
    </Columns>
</asp:GridView>




   </div>
    

</asp:Content>
