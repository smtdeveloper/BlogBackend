using Core.Entities.Abstract;
using System;

namespace Entities.Dtos.Category
{
    public class CategoryUpdateDto : IDto
    {
        public Guid SecondaryId { get; set; }
        public string Name { get; set; }
    }
}
