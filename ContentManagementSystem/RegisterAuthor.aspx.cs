using DataAccesLayer;
using DataAccesLayer.Repositorys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContentManagementSystem
{
    public partial class LoginAuthor : System.Web.UI.Page
    {
        AuthorsRepository rep;
        Authors entity;
        public bool aynimi = false;
        public int id;
        public List<Authors> authorList;
        protected void Page_Load(object sender, EventArgs e)
        {
            rep = new AuthorsRepository();
            authorList = rep.List();
            if (Request.Form["action"] == "save")
            {
                foreach (var item in authorList)
                {
                    if (item.UserName == Username.Value)
                    {
                        aynimi = true;
                    }
                }

                if (!aynimi)
                {
                    SaveToDb();
                }
                else
                {
                    Username.Value = "this username is available";
                    
                }
                
            }
            
        }

        private void SaveToDb()
        {
            entity = new Authors();
            rep = new AuthorsRepository();
            entity.UserName = Request.Form["Username"].ToString();
            entity.Password = Request.Form["Password"].ToString();
            entity.Mail = Request.Form["Email"].ToString();
            entity.Surname = Request.Form["Surname"].ToString();
            entity.Name = Request.Form["Name"].ToString();
            var picture = Request.Files["ImageFile"];

            rep.Add(entity);

            string filename = entity.UserName + "_" + entity.Id+".png";
            string filePath = Server.MapPath("~/Images/") + filename;
            picture.SaveAs(filePath);         
            entity.Picture = filename;

            rep.Update(entity);
            Response.Redirect("/AddArticle?id="+entity.Id);
        }
    }
}