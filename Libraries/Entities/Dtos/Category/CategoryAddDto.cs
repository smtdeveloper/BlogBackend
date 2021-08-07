using Core.Entities.Abstract;

namespace Entities.Dtos.Category
{
    public class CategoryAddDto : IDto
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
