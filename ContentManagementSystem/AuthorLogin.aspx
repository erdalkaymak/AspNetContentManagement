<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthorLogin.aspx.cs" Inherits="ContentManagementSystem.AuthorLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="MyContent/MyCss.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script>
     <%-- function sendId() {
             <% if(!isloginFailed){%>
          window.location.href="/AddArticle?act=open&id="+<%:author.Id%>;
        <%}%>        
        }--%>
       
    </script>
</head>
<body class="Author">
    <div>
    <h1 style="margin-top:180px;" class="header">Author Login</h1>
    <div class="AllForms">
    <form class="MyformInAllForms" id="form1" runat="server">       
        <input type="hidden" name="action" value="login" />
        <div>
            <div class="form-group">
                 <i class="glyphicon glyphicon-user"></i>
                 Username <span style="color:#808080">(Required)</span>
                <div><input runat="server" class="form-control inputForm" name="Username" id="Username" type="text" /></div>
            </div>
              <div class="form-group">
               <i class="glyphicon glyphicon-user"></i>
                  Password <span style="color:#808080">(Required)</span>                
                <div><input runat="server"  id="Password" class="form-control inputForm" name="Password" type="password" /></div>
            </div>
                        
               <span class="form-group">                
                <span><input runat="server" style="float:right;padding-left:19px;padding-right:19px;" id="btnSave" type="submit"  value="Log in" class="btn btn-primary" /></span>
            </span>
               <span class="form-group">                
                <span><input runat="server" style="float:right;margin-right:10px;" id="Submit1" type="button" value="Register" class="btn btn-primary" onclick=" window.location.href = '/RegisterAuthor'" /></span>
            </span>
            </div>  
        </form>
        </div>
    
        </div>
        
</body>
</html>
