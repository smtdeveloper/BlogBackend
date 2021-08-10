using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Image
{
   public  class ImageUpdateDto :IDto
    {
        public Guid SecondaryId { get; set; }
        public string FilePath { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
