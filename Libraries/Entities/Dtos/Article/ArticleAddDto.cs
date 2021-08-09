using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Article
{
   public class ArticleAddDto :IDto
    {
        public Guid UserSecondaryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}
