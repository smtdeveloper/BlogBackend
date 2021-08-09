using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Article
{
  public  class ArticleDto : IDto
    {
        public Guid SecondaryId { get; set; }
        public Guid UserSecondaryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
    }
}
