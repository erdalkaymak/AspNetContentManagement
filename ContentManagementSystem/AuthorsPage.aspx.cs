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
    public partial class AuthorsPage : System.Web.UI.Page
    {
        public List<Authors> authorList;
        AuthorsRepository rep;
        protected void Page_Load(object sender, EventArgs e)
        {
            rep = new AuthorsRepository();

            authorList = rep.List();
        }
    }
}