using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
    public class ArticleCategory : IEntity
    {
        public Guid Id { get; set; }
        public Guid ArticleId { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Article Article { get; set; }
        public virtual Category Category { get; set; }
    }
}
