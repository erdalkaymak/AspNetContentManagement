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
    public partial class ReadArticleDetail : System.Web.UI.Page
    {
        public Articles article;
        ContentManagementEntities db;
        public static int myArticleid;
        public int myAuthorId;
        public bool isAdminLogin;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new ContentManagementEntities();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            myArticleid = id;
            myAuthorId = AddArticle.myid;
            article = db.Articles.Where(c => c.Id == myArticleid).FirstOrDefault();
            isAdminLogin = AdminLogin.isAdmin;
        }
    }
}