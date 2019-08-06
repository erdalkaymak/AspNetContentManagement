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
    public partial class ArticleUpdate : System.Web.UI.Page
    {
        ArticlesRepository rep;
        public List<Categories> catList;
        CategoriesRepository repCat;
        public Authors author;
        ContentManagementEntities db;
        public Articles article;
        int Authorid;
        int ArticleId;
        public bool AdminVarmi;
        public bool isFirst = true;
        protected void Page_Load(object sender, EventArgs e)
        {

            db = new ContentManagementEntities();
            rep = new ArticlesRepository();
            repCat = new CategoriesRepository();
            Authorid = AddArticle.myid;
            AdminVarmi = AdminLogin.isAdmin;
            catList = repCat.List();
            author = db.Authors.Where(c => c.Id == Authorid).FirstOrDefault();
            ArticleId = Convert.ToInt32(Request.QueryString["id"].ToString());
            article = db.Articles.Where(c => c.Id == ArticleId).FirstOrDefault();
            if (AdminVarmi)
            {
                author= article.Authors;
            }
            

            if (IsPostBack)
            {
                article.ArticleBody = Request.Form["ArticleBody"].ToString();
                article.Title = Request.Form["Title"].ToString();
                article.IsVisible = true;
                article.CreateDate = DateTime.Now;
                article.CategoryId =Convert.ToInt32(Request.Form["CatType"]);
                article.Authors.Id = Authorid;

                rep.Update(article);
                Response.Redirect("/ReadArticleDetail?id=" + article.Id);
            }
        }
    }
}