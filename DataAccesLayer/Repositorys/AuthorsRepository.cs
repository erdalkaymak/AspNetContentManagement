using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositorys
{
    public class AuthorsRepository
    {
        ContentManagementEntities db;
        Authors author;
        public AuthorsRepository()
        {
            db = new ContentManagementEntities();
        }

        public List<Authors> List()
        {
            var authorList = db.Authors.ToList();
            return authorList;
        }

        public void Add(Authors entity)
        {
            db.Authors.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            author = db.Authors.Where(c => c.Id == id).FirstOrDefault();
            db.Authors.Remove(author);
            db.SaveChanges();
        }

        public void Update(Authors entity)
        {
            author = db.Authors.Where(c => c.Id == entity.Id).FirstOrDefault();
            author.Name = entity.Name;
            author.Surname = entity.Surname;
            author.Mail = entity.Mail;
            author.Password = entity.Password;
            author.UserName = entity.UserName;
            db.SaveChanges();
        }
    }
}
