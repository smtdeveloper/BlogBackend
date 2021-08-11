using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos.Category
{
  public  class CategoryDeleteDto : IDto
    {
        public Guid SecondaryId { get; set; } // kullanıcıdan alınan seyler burda olur sadece.
    }
}
