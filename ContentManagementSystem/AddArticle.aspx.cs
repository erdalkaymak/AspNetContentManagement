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
    public partial class AddArticle : System.Web.UI.Page
    {
        ArticlesRepository rep;
        CategoriesRepository repCat;
        public Articles entity;
        public Authors author;
        public List<Categories> catList;
        public List<Articles> articleList;
        public List<Authors> authorsList;
        AuthorsRepository repAuthor;
        public int id;
        public static int myid;
        ContentManagementEntities db;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                db = new ContentManagementEntities();
                if (Request.Form["action"] == "save")
                {
                    SaveToDb();
                }

                id = Convert.ToInt32(Request.QueryString["id"]);
                if (id != 0)
                {
                    myid = id;
                }

                author = author = db.Authors.Where(c => c.Id == myid).FirstOrDefault();
                rep = new ArticlesRepository();
                repCat = new CategoriesRepository();
                repAuthor = new AuthorsRepository();
                articleList = rep.List();
                catList = repCat.List();
                authorsList = repAuthor.List();
            }
            else
            {
                Response.Redirect("/AuthorLogin");
            }
             
            
        }

        public void SaveToDb()
        {
            db = new ContentManagementEntities();
            rep = new ArticlesRepository();
            entity = new Articles();
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (id != 0)
            {
                myid = id;
            }
            entity.Authors = db.Authors.Where(c => c.Id == myid).FirstOrDefault();
            entity.AuthorId = entity.Authors.Id;
            entity.ArticleBody = Request.Form["ArticleBody"];
            entity.Title = Request.Form["Title"];
            int catId = Convert.ToInt32(Request.Form["CatType"]);
            entity.Categories = db.Categories.Where(c => c.Id ==catId ).FirstOrDefault();
            entity.CreateDate = DateTime.Now;
            entity.CategoryId = entity.Categories.Id;
            entity.IsVisible = true;

            rep.Add(entity,db);
            Response.Redirect("/ReadArticlesPage");
        }
    }
}