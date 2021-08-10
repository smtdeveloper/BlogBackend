using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserImages :IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public Guid UserId { get; set; }
        public Guid ImageId { get; set; }
    }
}
