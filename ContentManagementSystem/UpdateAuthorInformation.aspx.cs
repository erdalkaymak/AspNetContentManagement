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
    public partial class AddAuthor : System.Web.UI.Page
    {
        ContentManagementEntities db;
        int id;
        public static int x;
        public bool aynimi = false;
        AuthorsRepository rep;
        Authors author;
        public bool isAdminFounded;
        public List<Authors> authorList;
        public List<Authors> myauthorList;
        protected void Page_Load(object sender, EventArgs e)
        {
            isAdminFounded = AdminLogin.isAdmin;
            db = new ContentManagementEntities();
            rep = new AuthorsRepository();
            authorList = rep.List();
            myauthorList = authorList;
            if (isAdminFounded)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);

            }
            else
            {
                id = AddArticle.myid;
            }


            if (x != 0)
                {
                    author = db.Authors.Where(c => c.Id == x).FirstOrDefault();
                    myauthorList.RemoveAll(c => c.Id == x);
                    foreach (var item in myauthorList)
                    {
                        if (item.UserName == Username.Value)
                        {
                            aynimi = true;
                        }
                    }


                    if (!aynimi)
                    {
                    if (IsPostBack)
                    {
                        updateDatabase(id);
                    }
                        
                        x = 0;
                        if (isAdminFounded)
                        {
                        Response.Redirect("/AuthorsPage");
                        }
                        else
                        {
                        Response.Redirect("/ReadArticlesPage");
                        }
                       
                    }
                    else
                    {
                        Username.Value = "this username is available";
                    }

                }

                if (Request.QueryString["act"] == "update")
                {
                    if (!IsPostBack)
                    {
                        if (isAdminFounded)
                        {
                            id = Convert.ToInt32(Request.QueryString["id"]);
                        }
                        else
                        {
                            id = AddArticle.myid;
                        }
                        
                        Authors entity = db.Authors.Where(c => c.Id == id).FirstOrDefault();
                        Name.Value = entity.Name;
                        Password.Value = entity.Password;
                        Surname.Value = entity.Surname;
                        Email.Value = entity.Mail;
                        Username.Value = entity.UserName;

                    }
                    x = id;
                }                                         
           
        }

        private void updateDatabase(int id)
        {          
        
            Authors entity = db.Authors.Where(c => c.Id == id).FirstOrDefault();
            entity.Name = Name.Value;
            entity.Password = Password.Value;
            entity.UserName = Username.Value;
            entity.Surname = Surname.Value;
            entity.Mail = Email.Value;
            rep.Update(entity);
            //Response.Redirect("/AuthorsPage");
        }

        //public void SavetoDb()
        //{
        //    AuthorsRepository rep = new AuthorsRepository();
        //    Authors entity = new Authors();
        //    entity.Name = Request.Form["Name"].ToString();
        //    entity.Surname = Request.Form["Surname"].ToString();
        //    entity.Mail = Request.Form["Email"];

        //    rep.Add(entity);
            
        //}
    }
}