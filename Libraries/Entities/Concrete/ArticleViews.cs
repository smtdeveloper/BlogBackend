using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class ArticleViews : IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public Guid ArticleId { get; set; }
        public int Count { get; set; }
    }
}
