<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/AllPagesSiteMaster.Master" CodeBehind="AuthorsPage.aspx.cs" Inherits="ContentManagementSystem.AuthorsPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1 class="header">Authors Table</h1>
    <div>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th style="text-align:center">Id</th>
                    <th style="text-align:center">User Name</th>
                    <th style="text-align:center">Password</th>
                    <th style="text-align:center">Name</th>
                    <th style="text-align:center">Surname</th>
                    <th style="text-align:center">Mail</th>
                    <th style="text-align:center">Profile Photo</th>
                </tr>
                <%foreach (var item in authorList)
                    {%>
                 <tr>
                    <td style="width:150px;"><b><%:item.Id %></b><a href="/UpdateAuthorInformation?act=update&id=<%:item.Id%>"><i title="update" class="glyphicon glyphicon-pencil" style="float:left;padding-right:20px;color:black;"></i></a><a href="/OperationPage?act=delete&id=<%:item.Id%>"><i title="Delete" class="glyphicon glyphicon-trash" style="float:right;color:red" ></i></a></td>
                     <td><%:item.UserName %></td>
                     <td><%:item.Password %></td>
                     <td><%:item.Name %></td>
                     <td><%:item.Surname %></td>
                     <td><%:item.Mail %></td>
                     <td><%:item.Picture %></td>
                </tr>
                    <%} %>
                              
            </table>
        </div>
    </form>
        </div>
        </div>
 </asp:Content>
