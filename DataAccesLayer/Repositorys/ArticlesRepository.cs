using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositorys
{
    public class ArticlesRepository
    {
        ContentManagementEntities dbs;
        Articles article;
        public ArticlesRepository()
        {
            dbs = new ContentManagementEntities();

        }

        public List<Articles> List()
        {
            var articleList = dbs.Articles.ToList();
            return articleList;
        }

        public void Add(Articles entity ,ContentManagementEntities db)
        {
           
            db.Articles.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            article = dbs.Articles.Where(c => c.Id == id).FirstOrDefault();
            dbs.Articles.Remove(article);
            dbs.SaveChanges();
        }

        public void Update(Articles entity)
        {
            article = dbs.Articles.Where(c => c.Id == entity.Id).FirstOrDefault();
            article.Title = entity.Title;
            article.ArticleBody = entity.ArticleBody;
            article.CreateDate = entity.CreateDate;
            article.IsVisible = entity.IsVisible;
            article.CategoryId = entity.CategoryId;
            article.AuthorId = entity.AuthorId;
            

            dbs.SaveChanges();
        }
        public List<Articles> FilterList(string title, string category, string author,string body)
        {
            var FilterList = dbs.Articles.Where(c =>
              c.Title.Contains(title)
              && c.Categories.Type.Contains(category)
              && (c.Authors.UserName.Contains(author))
              && c.ArticleBody.Contains(body)).ToList();

            return FilterList;
        }
        

        
    }
}
