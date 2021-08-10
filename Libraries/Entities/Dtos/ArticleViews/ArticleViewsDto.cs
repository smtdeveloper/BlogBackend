using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.ArticleViews
{
    public class ArticleViewsDto : IDto
    {
        public Guid SecondaryId { get; set; }
        public Guid ArticleId { get; set; }
        public int Count { get; set; }
    }
}
