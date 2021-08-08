using Core.Entities.Abstract;
using System;

namespace Entities.Dtos.Category
{
    public class CategoryDto : IDto
    {
        public Guid SecondaryId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
