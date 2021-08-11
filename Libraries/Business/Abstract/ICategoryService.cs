using Core.Utilities.Results.Abstract;
using Entities.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public Task<IResult> AddAsync(CategoryAddDto addDto);
        public Task<IResult> UpdateAsync(CategoryUpdateDto updateDto);
        public Task<IResult> DeleteAsync(CategoryDeleteDto deleteDto);
        public Task<IDataResult<List<CategoryDto>>> GetAllAsync();
        public Task<IDataResult<CategoryDto>> GetCategorySecondaryIdAsync(Guid SecondaryId);



    }
}
