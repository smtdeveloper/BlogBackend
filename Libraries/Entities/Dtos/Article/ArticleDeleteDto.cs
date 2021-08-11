using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Article
{
    public class ArticleDeleteDto :IDto
    {
        public Guid SecondaryId { get; set; }
    }
}
