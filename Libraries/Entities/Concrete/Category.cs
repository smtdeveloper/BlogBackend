using Core.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }


        public List<ArticleCategory> ArticleCategories { get; set; }
    }
}
