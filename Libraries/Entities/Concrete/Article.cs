using Core.Entities.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Article : IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }


        // Navigation Property
        //public virtual User User { get; set; }


        public virtual List<ArticleCategory> ArticleCategories { get; set; }
    }
}
