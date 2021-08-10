using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Comment
{
    public class CommentDto : IDto

    {
        public Guid SecondaryId { get; set; }
        public Guid ArticleSecondaryId { get; set; }
        public string  Content { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
