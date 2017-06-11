using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealthBlog.Domain
{
    public class Article
    {
        public int Id { get; set; }
        public DateTime ReleaseTime { get; set; }
        public string Category { get; set; }
        public string HeadLine { get; set; }
        public string Content { get; set; }
        public string NotesAndLinks { get; set; }
        public int FoodCategoryId { get; set; }

    }
}
