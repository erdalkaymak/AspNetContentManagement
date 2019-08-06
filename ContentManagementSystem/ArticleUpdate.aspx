<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AllPagesSiteMaster.Master" CodeBehind="ArticleUpdate.aspx.cs" Inherits="ContentManagementSystem.ArticleUpdate" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
            
     <div>
    <h1 class="header">Update Article</h1>
    <div class="AllForms">
    <form class="MyformInAllForms" id="form2" runat="server">
        <input type="hidden" name="action" value="save" />
        <div>
            <div class="form-group">
                 <i class="glyphicon glyphicon-book"></i>
                 Title
                <div><input  class="form-control inputForm" name="Title" id="Title" type="text" value="<%:article.Title %>" /></div>
            </div>

              <div class="form-group">
              <i class="glyphicon glyphicon-book"></i>
                  ArticleBody                
                <div><input  value="<%:article.ArticleBody%>"  id="ArticleBody" class="form-control inputForm" name="ArticleBody" type="text" /></div>
            </div>

              <div class="form-group">
                  <i class="glyphicon glyphicon-user"></i>
                 Author Name
                <div><input class="form-control inputForm" name="Author" id="Author" type="text" readonly="true" value="<%:author.UserName %>"  /></div>
            </div>
             
        <div> 
        <i class="glyphicon glyphicon-globe"></i>
                Category Type
                <div><select   class="form-control" name="CatType" id="CatType" >


                <%for(int i=0;i<catList.Count;i++)
                    {%>
                    <%if(isFirst){%>
                      <option  id="SelectedCat" value="<%:article.Categories.Id %>" ><%:article.Categories.Type %></option>
                        <%isFirst = false; %>
                    <%catList.RemoveAll(c => c.Id == article.CategoryId); %>
                        <% i=-1;%>
                    <% }%>
                   <%else{ %> 
                     <option value="<%:catList[i].Id %>"><%:catList[i].Type%></option>  
                    <% }%>                           
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

