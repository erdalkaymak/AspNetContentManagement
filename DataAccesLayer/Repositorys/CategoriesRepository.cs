using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositorys
{
    public class CategoriesRepository
    {
        ContentManagementEntities db;
        Categories cat;
        public CategoriesRepository()
        {
            db = new ContentManagementEntities();
            
        }

        public List<Categories> List()
        {
            var catList = db.Categories.ToList();

            return catList;
        }

        public void Add(Categories entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            cat = db.Categories.Where(c => c.Id == id).FirstOrDefault();
            db.Categories.Remove(cat);
            db.SaveChanges();
        }

        public void Update(Categories entity)
        {
            cat = db.Categories.Where(c => c.Id == entity.Id).FirstOrDefault();
            cat.Type = entity.Type;
            db.SaveChanges();
        }
    }
}
