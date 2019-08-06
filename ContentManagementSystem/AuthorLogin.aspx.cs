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
    public partial class AuthorLogin : System.Web.UI.Page
    {
        public List<Authors> authorList;
        AuthorsRepository rep;
        public bool isloginFailed = true;
        public  Authors author;
        ContentManagementEntities db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new ContentManagementEntities();
            if (Request.Form["action"] == "login")
            {
                rep = new AuthorsRepository();
                authorList = rep.List();
                for (int i = 0; i < authorList.Count; i++)
                {
                    if (authorList[i].UserName == Username.Value && authorList[i].Password == Password.Value)
                    {
                        isloginFailed = false;
                        break;
                    }
                    
                }

                if (isloginFailed)
                {
                    Session["username"] = null;
                    Response.Redirect("/AuthorLogin");

                }
                else
                {
                    author = db.Authors.Where(c => c.UserName == Username.Value).FirstOrDefault();
                    Session["username"] = author.UserName;
                    Response.Redirect("/AddArticle?id="+author.Id);
                }
                                   
            }
            
        }
    }
}