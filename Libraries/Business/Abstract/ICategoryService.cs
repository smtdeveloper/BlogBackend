using Core.Utilities.Results.Abstract;
using Entities.Dtos.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public Task<IResult> AddAsync(CategoryAddDto addDto);
        public Task<IResult> UpdateAsync(CategoryUpdateDto updateDto);
        public Task<IDataResult<List<CategoryDto>>> GetAllAsync(); // deneme push
    }
}
