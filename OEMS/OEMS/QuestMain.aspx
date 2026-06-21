<%@ Page Language="C#" MasterPageFile ="~/Instruct.Master" AutoEventWireup="true" CodeBehind="QuestMain.aspx.cs" Inherits="VPLab7.QuestMain" %>


<asp:Content ID ="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <link rel="stylesheet" href="Users.css" />
  
    
   <div class ="container">
        
       <h4>Questions</h4>

         

        <div class="form-group" >
            <label for="ddlQtype">Please select the question type:</label>
    
            <asp:DropDownList ID="ddlQtype" runat="server" class="form-control">
       
                <asp:ListItem >Select</asp:ListItem>
                <asp:ListItem >MCQ's</asp:ListItem>

                <asp:ListItem >True/False</asp:ListItem>

                <asp:ListItem >Short Questions</asp:ListItem>
            </asp:DropDownList>
        </div>

  <div class="lbl">

  <asp:Label ID="lblMessage" runat="server"  ></asp:Label> 
</div>
      

       <div class="form-group ">
    
             <asp:Button ID="btnProceed" runat="server"  Text="Proceed" CssClass =" btn-crud" OnClick="btnProceed_Click"/>
 
        </div>   
             
 
   </div>
    

</asp:Content>
