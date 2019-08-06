using DataAccesLayer;
using DataAccesLayer.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContentManagementSystem
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        Admin admin;
        AdminsRepository rep;
        public static bool isAdmin;
        public static int adminId;
        protected void Page_Load(object sender, EventArgs e)
        {
            rep = new AdminsRepository();
            if (Request.Form["action"] == "login")
            {
                isAdmin = rep.isAdmin(Username.Value, Password.Value);

                if (isAdmin)
                {
                    admin = rep.search(Username.Value, Password.Value);
                    adminId = admin.Id;
                    Session["username"] = admin.Username;
                    Response.Redirect("/ReadArticlesPage?id=" + adminId);
                }
                else
                {
                    Response.Redirect("/AdminLogin");
                }
            }
        
           
        }
    }
}