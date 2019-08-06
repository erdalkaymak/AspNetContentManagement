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
    public partial class AddCategory : System.Web.UI.Page
    {
        public List<Categories> catList;
        CategoriesRepository rep;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["action"] == "save")
            {
                SaveToDb();
            }
            rep = new CategoriesRepository();
            catList = rep.List();
        }

        private void SaveToDb()
        {
            rep = new CategoriesRepository();
            Categories entity = new Categories();
            entity.Type = Request.Form["CatName"].ToString();
            rep.Add(entity);
            catList = rep.List();
        }
    }
}