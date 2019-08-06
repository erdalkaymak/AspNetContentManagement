<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/AllPagesSiteMaster.Master" CodeBehind="UpdateAuthorInformation.aspx.cs" Inherits="ContentManagementSystem.AddAuthor" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1 class="header">Authors Informations</h1>
    <div class="AllForms">
    <form class="MyformInAllForms" id="form1" runat="server">       
        
        <div>
            <div class="form-group">
                 <i class="glyphicon glyphicon-user"></i>
                 Username <span class="Required">(Required)</span>
                <div><input runat="server" class="form-control inputForm" name="Username" id="Username" type="text" /></div>
            </div>
              <div class="form-group">
               <i class="glyphicon glyphicon-user"></i>
                  Password <span class="Required">(Required)</span>                
                <div><input runat="server"  id="Password" class="form-control inputForm" name="Password" type="text" /></div>
            </div>

              <div class="form-group">
                  <i class="glyphicon glyphicon-user"></i>
                 <span>Email</span> <span class="Required">(if you want to write)</span>
                <div><input runat="server" class="form-control inputForm" name="Email" id="Email" type="email" /></div>
            </div> 

            <div class="form-group">
                 <i class="glyphicon glyphicon-user"></i>
                 Name <span class="Required">(Required)</span>
                <div><input runat="server" class="form-control inputForm" name="Name" id="Name" type="text" /></div>
            </div>
              <div class="form-group">
               <i class="glyphicon glyphicon-user"></i>
                  Surname  <span class="Required">(Required)</span>                
                <div><input runat="server"  id="Surname" class="form-control inputForm" name="Surname" type="text" /></div>
            </div>
                                         
               <div class="form-group">                
                <div><input runat="server" style="float:right;" id="btnSave" type="submit" value="Save" class="btn btn-primary" /></div>
            </div>
                
        </div>
    </form>
        </div>
        </div>

 </asp:Content>