using MyHealthBlog.Data.IRepos;
using System;
using System.Collections.Generic;
using MyHealthBlog.Domain;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MyHealthBlog.Data.Repos
{
    public class ArticleRepo : IArticleRepo
    {
        private readonly MyHealthBlogContext _context;

        public ArticleRepo()
        {
            _context = new MyHealthBlogContext();
        }

        public IEnumerable<Article> GetAllArticles => throw new NotImplementedException();

        public void Create(Article article)
        {
            _context.Articles.Add(article);
        }

        public void Delete(Article article)
        {
            _context.Articles.Remove(article);
        }

        public Article GetArticleById(int articleId)
        {
            Article article = _context.Articles.FirstOrDefault(a => a.Id == articleId);
            return article;
        }

        public Article NameExists(string name)
        {
            Article article = _context.Articles.FirstOrDefault(a => a.HeadLine == name);
            return article;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Article article)
        {
            _context.Entry(article).State = EntityState.Modified;
        }
    }
}
