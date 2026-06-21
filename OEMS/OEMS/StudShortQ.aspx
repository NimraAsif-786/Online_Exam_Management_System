<%@ Page Language="C#"  MasterPageFile ="~/Stud.Master" AutoEventWireup="true" CodeBehind="StudShortQ.aspx.cs" Inherits="VPLab7.StudShortQ" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
    
   <div class ="container">
        
       <h4>Short Questions</h4>
       
       <asp:HiddenField ID="hiddenExamID" runat="server" />
       <asp:Label ID="lblDebug" runat="server" ForeColor="Blue"> </asp:Label> 

       <div class="form-group">
              <asp:Button ID="btnStart" runat="server"  Text="Start" CssClass =" btn-crud" OnClick="btnStart_Click"/>
        </div>

        <div class="form-group">

          <asp:Label ID="lblsid" runat="server" Text="Enter your ID:"></asp:Label>
           <asp:TextBox ID="txtsid" runat="server" class="form-control" ></asp:TextBox>
 
         </div>

         <div class="form-group">

      <asp:Label ID="labelqID" runat="server" Text="Question ID:" ></asp:Label>
     <asp:TextBox ID="txtqID" runat="server" class="form-control" BackColor="#E6E6E6" ReadOnly="true"></asp:TextBox>
      
      </div> 
        <div class="form-group">

       <asp:Label ID="labelID" runat="server" Text="Exam ID:"></asp:Label>
         <asp:TextBox ID="txtexID" runat="server" class="form-control"  BackColor="#E6E6E6" ReadOnly="true"></asp:TextBox>
       
      </div>

       
      
 
         <div class="form-group">

              <asp:Label ID="labelqno" runat="server" Text="Question No:"></asp:Label>

            <asp:TextBox ID="txtqno" runat="server" class="form-control" BackColor="#E6E6E6" ReadOnly="true"></asp:TextBox>
     
         </div>
       <div class="form-group">

              <asp:Label ID="labelq" runat="server" Text="Question:"></asp:Label>

            <asp:TextBox ID="txtq" runat="server" class="form-control" BackColor="#E6E6E6" ReadOnly="true"></asp:TextBox>
     
         </div>
      
     
      
       
       <div class="form-group">

         <asp:Label ID="labelans" runat="server" Text="Ans:"></asp:Label>

       <asp:TextBox ID="txtans" runat="server" class="form-control"></asp:TextBox>

    </div>
       <div class="lbl">

       <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
     </div>

       <div class="form-group button-row">
    
                <asp:Button ID="btnInsert" runat="server"  Text="Save" CssClass =" btn-crud" OnClick="btnInsert_Click"/>

             <asp:Button ID="btnNext" runat="server"  Text="Next" CssClass =" btn-crud" OnClick="btnNext_Click"/>
 
           <asp:Button ID="btnFinish" runat="server"  Text="Finish" CssClass =" btn-crud" OnClick="btnFinish_Click"/>

         <asp:Button ID="btnRes" runat="server"  Text="Calculate Result" CssClass =" btn-crud" OnClick="btnCalculateResult_Click"/>

    </div>   
     
      <div class="lbl">

         <asp:Label ID="lblResult" runat="server"  ></asp:Label> 
    </div>   
        
   </div>
    

</asp:Content>