using Core.Entities.Abstract;
using System;

namespace Entities.Dtos.Category
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
      //  public DateTime CreatedAt { get; set; }
    }
}
