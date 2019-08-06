<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AllPagesSiteMaster.Master"  CodeBehind="AddArticle.aspx.cs" Inherits="ContentManagementSystem.AddArticle" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
    <h1 class="header">Add Article</h1>
    <div class="AllForms">
    <form class="MyformInAllForms" id="form1" runat="server">
        <input type="hidden" name="action" value="save" />
        <div>
            <div class="form-group">
                 <i class="glyphicon glyphicon-book"></i>
                 Title
                <div><input class="form-control inputForm" name="Title" id="Title" type="text" /></div>
            </div>

              <div class="form-group">
              <i class="glyphicon glyphicon-book"></i>
                  ArticleBody                
                <div><input  id="ArticleBody" class="form-control inputForm" name="ArticleBody" type="text" /></div>
            </div>

              <div class="form-group">
                  <i class="glyphicon glyphicon-user"></i>
                 Author Name
                <div><input class="form-control inputForm" name="Author" id="Author" type="text" readonly="true" value="<%:author.UserName %>"  /></div>
            </div>
             
        <div> 
        <i class="glyphicon glyphicon-globe"></i>
                Category Type
                <div><select class="form-control" name="CatType">
                <%foreach (var item in catList)
                    {%>      
                <option value="<%:item.Id %>"><%:item.Type%></option>                
                   <%} %>
                    </select></div>
                </div>
            
               <div class="form-group" style="margin-top:10px;">                
                <div><input style="float:right;" id="btnSave" type="submit" value="Save" class="btn btn-primary" onclick="alertMessage()" /></div>
            </div>
                
        </div>
        
    </form>
        </div>
        </div>  


    </asp:Content>
