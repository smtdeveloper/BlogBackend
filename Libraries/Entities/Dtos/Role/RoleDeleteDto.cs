using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Role
{
   public class RoleDeleteDto :IDto
    {
        public Guid SecondaryId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeleteAt { get; set; }
    }
}
