using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Comment
{
    public class CommentUpdateDto :IDto
    {
        public Guid SecondaryId { get; set; }
        public Guid ArticleId { get; set; }
        public string  Content { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
