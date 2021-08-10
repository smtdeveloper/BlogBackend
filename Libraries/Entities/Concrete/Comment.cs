using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Comment :IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public Guid ArticleId { get; set; }
        public string  Content { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleted { get; set; }

    }
}
