using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Image : IEntity
    {
        public Guid Id { get; set; }
        public Guid SecondaryId { get; set; }
        public string FilePath { get; set; }
        public bool IsDeleted { get; set; }
    }
}
