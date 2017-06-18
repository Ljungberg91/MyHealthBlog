using MyHealthBlog.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Data.IRepos
{
   public interface IArticleRepo
    {
        IEnumerable<Article> GetAllArticles { get; }
        Article GetArticleById(int articleId);
        void Create(Article article);
        void Update(Article article);
        void Delete(Article article);
        Article NameExists(string name);
        void Save();
    }
}
