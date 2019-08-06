using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositorys
{
    public class AdminsRepository
    {
        ContentManagementEntities db;
        Admin admin;
        public AdminsRepository()
        {
            db = new ContentManagementEntities();

        }

        public List<Admin> List()
        {
            var adminList = db.Admin.ToList();
            return adminList;
        }

        public void Add(Admin entity)
        {
            admin = db.Admin.Add(entity);
            db.SaveChanges();
        }

        public void Update(Admin entity)
        {
            admin = db.Admin.Where(c => c.Id == entity.Id).FirstOrDefault();
            admin.Password = entity.Password;
            admin.Username = entity.Username;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            admin = db.Admin.Where(c => c.Id == id).FirstOrDefault();
            db.Admin.Remove(admin);
            db.SaveChanges();
        }

        public bool isAdmin(string u , string p)
        {
            bool isfound = false;
            var adminList = db.Admin.Where(c => c.Username == u && c.Password == p).ToList();

            if (adminList.Count >0)
            {
                isfound = true;
            }
            return isfound;
        }

        public Admin search(string u, string p)
        {
            admin = db.Admin.Where(c => c.Username == u && c.Password == p).FirstOrDefault();
            return admin;
        }
    }
}
