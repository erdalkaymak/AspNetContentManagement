<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CategoryPage.aspx.cs" Inherits="ContentManagementSystem.AddCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="MyContent/MyCss.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script>
        function alertMessage() {
            var name = $('#CatName').val();
            alert(name + " category added succesfully!");
        }
    </script>
</head>
<body class="Author">
    <div>
    <h1 class="header">New Category</h1>
    <div class="AllForms">
    <form class="MyformInAllForms" id="form2" runat="server">
        <input type="hidden" name="action" value="save" />
            <div class="form-group">
                 <i class="glyphicon glyphicon-globe"></i>
                 Category Name
                <div>
                    <input class="form-control inputForm" name="CatName" id="CatName" type="text"/>
                </div>
                
                </div>
               <div class="form-group">                
                <div><input style="float:right;" id="btnSave" type="submit" value="Save" class="btn btn-primary" onclick="alertMessage()" /></div>
            </div>        
    </form>
       
        </div>
        </div>


    <h1 class="header" style="margin-top:40px;">List Categories</h1>
    <div   style="width:20%;margin:auto; padding:20px; margin-top:30px; background-color:white;"> 
        
        <i class="glyphicon glyphicon-globe"></i>
                Category List
                <div><select class="form-control" id="CatType" name="CatType">
                <%foreach (var item in catList)
                    {%>      
                <option value="<%:item.Type %>"><%:item.Type%></option>                
                   <%} %>
                    </select></div>
                </div>
        
</body>
</html>
