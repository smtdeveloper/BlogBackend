using Core.Utilities.Results.Abstract;
using Entities.Dtos.Category;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public Task<IResult> AddAsync(CategoryAddDto addDto);
        public Task<IResult> UpdateAsync(CategoryUpdateDto updateDto);
    
   
    }
}
