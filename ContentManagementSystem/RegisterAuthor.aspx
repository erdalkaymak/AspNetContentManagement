<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterAuthor.aspx.cs" Inherits="ContentManagementSystem.LoginAuthor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="MyContent/MyCss.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    
</head>
<body class="Author">
    <div>
    <h1 class="header">Author Informations</h1>
    <div class="AllForms">
    <form class="MyformInAllForms" id="form1" runat="server" enctype="multipart/form-data">       
        <input type="hidden" name="action" value="save" />
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

              <div class="form-group">
                  <i class="glyphicon glyphicon-user"></i>
                 <span>Email</span> <span style="color:#808080">(if you want to write)</span>
                <div><input runat="server" class="form-control inputForm" name="Email" id="Email" type="email" /></div>
            </div>
            
               <div class="form-group">
                  <i class="glyphicon glyphicon-picture"></i>
                 <span>Image</span> <span style="color:#808080">(if you want to Add)</span>
                <div><input class="form-control inputForm" name="ImageFile" id="ImageFile" type="file" accept="image/x-png,image/gif,image/jpeg" /></div>
            </div>

            <div class="form-group">
                 <i class="glyphicon glyphicon-user"></i>
                 Name <span style="color:#808080">(Required)</span>
                <div><input runat="server" class="form-control inputForm" name="Name" id="Name" type="text" /></div>
            </div>
              <div class="form-group">
               <i class="glyphicon glyphicon-user"></i>
                  Surname  <span style="color:#808080">(Required)</span>                
                <div><input runat="server"  id="Surname" class="form-control inputForm" name="Surname" type="text" /></div>
            </div>
                                         
               <div class="form-group">                
                <div><input runat="server" style="float:right;" id="btnSave" type="submit" value="Save" class="btn btn-primary" /></div>
            </div>
                
        </div>
    </form>
        </div>
        </div>


</body>
</html>
