<%@ Page Language="C#" MasterPageFile ="~/Stud.Master" AutoEventWireup="true" CodeBehind="StudQuestMain.aspx.cs" Inherits="VPLab7.StudQuestMain" %>

<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
        <div class ="container">
          <div class="form-group" >

       <asp:HiddenField ID="hiddenExamID" runat="server" />

          </div>
          <div class="form-group" >

             <label for="ddlQtype">Select type of questions you want to solve first:</label>
    
             <asp:DropDownList ID="ddlSQtype" runat="server" class="form-control">

                 <asp:ListItem >Select</asp:ListItem>
                 <asp:ListItem >MCQ's</asp:ListItem>

                 <asp:ListItem >True/False</asp:ListItem>

                 <asp:ListItem >Short Questions</asp:ListItem>
             </asp:DropDownList>
         </div>
            <div class="form-group">
                <asp:Label ID="lblDebug" runat="server" ForeColor="Blue"> </asp:Label> 

                </div>

              <div class="lbl">

  <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
</div>
      

       <div class="form-group ">
    
             <asp:Button ID="btnProc" runat="server"  Text="Proceed" CssClass =" btn-crud" OnClick="btnProc_Click"/>
 
        </div>   
      </div>
   </asp:Content>
