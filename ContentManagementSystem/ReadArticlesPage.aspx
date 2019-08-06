<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AllPagesSiteMaster.Master" CodeBehind="ReadArticlesPage.aspx.cs" Inherits="ContentManagementSystem.ReadArticlesPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
    <form class="MyformInAllForms" id="form1" runat="server">

        <span style="position:absolute;margin-left:275px;margin-top:-70px;">
            <span class="col-md-2">
                 <i class="glyphicon glyphicon-book"></i>
                 Title
                <span><input runat="server"  class="form-control inputFormFilter" name="Title" id="Title" type="text" /></span>
            </span>

              <span class="col-md-2">
              <i class="glyphicon glyphicon-book"></i>
                  ArticleBody                
                <span><input runat="server"  id="ArticleBody" class="form-control inputFormFilter" name="ArticleBody" type="text" /></span>
            </span>

              <span class="col-md-2"> 
        <i class="glyphicon glyphicon-user"></i>
                Autor
                <span><select   class="form-control" name="Autors" id="Autors">
                    <option value="">Choose...</option> 
                <%foreach (var item in authorList)
                    {%>      
                <option value="<%:item.UserName %>"><%:item.UserName%></option>        
                   <%} %>
                    </select></span>
                </span>
             
        <span class="col-md-2"> 
        <i class="glyphicon glyphicon-globe"></i>
                Category 
                <span><select id="CatType" class="form-control" name="CatType">
                    <option value="">Choose...</option>  
                <%foreach (var item in catList)
                    {%>      
                <option value="<%:item.Type %>"><%:item.Type%></option>                
                   <%} %>
                    </select></span>
                </span>
            
               <span class="col-md-2"style="margin-top:20px;">               
                <span><input style="float:right;background-color:#516d9c" id="btnSave" type="submit" value="Filter" class="btn btn-primary form-control" /></span>
            </span>

              <span class="col-md-2"style="margin-top:20px;">               
                <span>
                    <asp:Button CssClass= "btn btn-primary form-control"  ID="Button1" runat="server" OnClick="Button1_Click" Text="Refresh List" /></span>
            </span>
                
        </span>
        <%if (articleListFilter.Count == 0)
            {%>
            <h1 class="header" style="margin-top:85px;">No List Founded Please Refresh List </h1>
            <%}%>
        <%foreach (var item in articleListFilter)
            {%>
      
         <div class="ArticleMainBody"style="margin-top:90px;">
            <span class="Title"><a href="ReadArticleDetail?id=<%:item.Id%>"><%:item.Title%></a></span>
            <span class="CatType"><%:item.Categories.Type %></span>
            
            <div><p class="ArticleBody">
                <%if (item.ArticleBody.Length>80)
                    {%>
                         <%:item.ArticleBody.Substring(0,80)+"..."%>
                    <%} %>
                <%else
                    {%>
                        <%:item.ArticleBody%>
                    <%} %>               
                </p>
            </div>
            <span>
                <span class="ArticleDate"><%:item.CreateDate %></span>
                <span class="AuthorNameSurname"><%:item.Authors.UserName %></span>
                 
            </span>
            
           
        </div>
            <%} %>
       

    </form>
</div>

</asp:Content>