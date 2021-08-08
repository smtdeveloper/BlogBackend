using Core.Entities.Abstract;
using System;

namespace Entities.Concrete
{
   public class Role :IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public string FilePath { get; set; }
        public  bool IsDeleted { get; set; }
    }
}
