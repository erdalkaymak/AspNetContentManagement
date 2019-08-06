using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContentManagementSystem
{
    public partial class Logout : System.Web.UI.Page
    {
        public bool wasAdmin;
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            wasAdmin = AdminLogin.isAdmin;
            if (wasAdmin)
            {
                AdminLogin.isAdmin = false;
                Response.Redirect("/AdminLogin");
            }
            else
            {
                Response.Redirect("/AuthorLogin");
            }
            
            
        }
    }
}