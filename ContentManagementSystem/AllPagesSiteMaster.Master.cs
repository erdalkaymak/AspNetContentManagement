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
    public partial class Site2 : System.Web.UI.MasterPage
    {
        public int Authorid;
        AuthorsRepository rep;
        ContentManagementEntities db;
        public  Authors author;
        public Admin admin;
        public int myAdminId;
        public bool adminmi;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new ContentManagementEntities();
            rep = new AuthorsRepository();
            Authorid = AddArticle.myid;
            myAdminId = AdminLogin.adminId;
            adminmi = AdminLogin.isAdmin;
            author = db.Authors.Where(c => c.Id == Authorid).FirstOrDefault();
            admin = db.Admin.Where(c => c.Id ==myAdminId).FirstOrDefault();

        }
    }
}