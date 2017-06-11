using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Domain
{
    public class ArticleRecipe
    {
        public int ArticleId { get; set; }
        public Article Article { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
