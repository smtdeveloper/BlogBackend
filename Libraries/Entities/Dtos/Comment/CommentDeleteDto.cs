using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Comment
{
    public class CommentDeleteDto : IDto
    {
        public Guid SecondaryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }


    }

}

