<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadArticleDetail.aspx.cs" Inherits="ContentManagementSystem.ReadArticleDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="MyContent/MyCss.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
</head>
<body class="Author">
    <form id="form1" runat="server">
         <div class="ArticleMainBody">
            <span class="Title">
                <%if(isAdminLogin){%>
                        <a href="OperationPage?act=deleteArticle&Aid=<%:article.Id%>"><i title="Delete Article" class="glyphicon glyphicon-trash" style="color:#ff0000;margin-right:5px;"></i></a>
                        <a title="Update Article" href="ArticleUpdate?id=<%:article.Id%>"><%:article.Title%></a>
                <% }%>
                <%else{ %>

                 <%if (article.Authors.Id == myAuthorId)
                                    {%>
                                    <a href="OperationPage?act=deleteArticle&Aid=<%:article.Id%>"><i title="Delete Article" class="glyphicon glyphicon-trash" style="color:#ff0000;margin-right:5px;"></i></a>
                                    <a title="Update Article" href="ArticleUpdate?id=<%:article.Id%>"><%:article.Title%></a>
                                    <%}%> 
                                 <%else{ %>
                                    <%:article.Title%>
                                    <% }%>

                <% }%>
               
                </span>
            <span class="CatType"><%:article.Categories.Type %></span>
            
            <div><p class="ArticleBody">
                    <%:article.ArticleBody %>
                </p>
            </div>
            <span>
                <span class="ArticleDate"><%:article.CreateDate %></span>
                <span class="AuthorNameSurname"><%:article.Authors.UserName%></span>
                 
            </span>
            
           
        </div>
    </form>
</body>
</html>
