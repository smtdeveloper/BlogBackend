using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Role
{
   public class RoleUpdateDto :IDto
    {
        public Guid SecondaryId { get; set; }
        public string Name { get; set; }
    }
}
