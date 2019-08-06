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
    public partial class ReadArticlesPage : System.Web.UI.Page
    {
        public List<Articles> articleListFilter;
        public List<Articles> articleList;
        ArticlesRepository rep ;
        public List<Authors> authorList;
        CategoriesRepository repCat;
        AuthorsRepository repAutors;
        public List<Categories> catList;
        public static bool isonclick  ;
        public int authorid;
        public Authors author;
        ContentManagementEntities db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new ContentManagementEntities();
            authorid = AddArticle.myid;
            author = db.Authors.Where(c => c.Id == authorid).FirstOrDefault();
            rep = new ArticlesRepository();
            repAutors = new AuthorsRepository();
            repCat = new CategoriesRepository();
            articleList = rep.List();
            isonclick = false;
            if (IsPostBack)
            {
                isonclick = true;
            }
            if (isonclick)
            {
                articleListFilter = rep.FilterList(Title.Value, Request.Form["CatType"], Request.Form["Autors"], ArticleBody.Value);
            }
            else
            {
                articleListFilter = rep.List();
            }
            
            catList = repCat.List();
            authorList = repAutors.List();
                       
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            articleListFilter = rep.List();
            Title.Value = "";
            ArticleBody.Value = "";
        }
    }
}