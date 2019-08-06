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
    public partial class OperationPage : System.Web.UI.Page
    {
        
        AuthorsRepository rep;
        ContentManagementEntities db;
        Articles article;
        public int ArticleId;
        ArticlesRepository repArticle;
        protected void Page_Load(object sender, EventArgs e)
        {
            repArticle = new ArticlesRepository();
            int id = Convert.ToInt32(Request.QueryString["id"]);
            db = new ContentManagementEntities();
             ArticleId = Convert.ToInt32(Request.QueryString["Aid"]);
            if (Request.QueryString["act"] == "delete")
            {
                deleteDatabase();
                Response.Redirect("/AuthorsPage");
            }

            if (Request.QueryString["act"] == "deleteArticle")
            {                
                deleteArticle();
                Response.Redirect("/ReadArticlesPage");
            }

            
        }

        private void deleteArticle()
        {
            article = db.Articles.Where(c => c.Id == ArticleId).FirstOrDefault();
            repArticle.Delete(article.Id);
        }

        public void deleteDatabase()
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            db = new ContentManagementEntities();
            Authors entity = new Authors();
            entity=db.Authors.Where(c => c.Id == id).FirstOrDefault();
            rep = new AuthorsRepository();
            rep.Delete(entity.Id);
            
        }
    }
}