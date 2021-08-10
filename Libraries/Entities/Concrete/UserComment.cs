using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class UserComment :IEntity
    {
        public Guid UserId { get; set; }
        public Guid CommentId { get; set; }

    }
}
