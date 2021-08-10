using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class VisitorComment :IEntity
    {
        public Guid CommentId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
