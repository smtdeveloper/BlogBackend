using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Category;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper;
        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(CategoryAddDto addDto)
        {
            var rulesResult = BusinessRules.Run(await this.CheckCategoryNameExistAsync(addDto.Name));
            if (!rulesResult.Success)
                return rulesResult;

            Category categoryToAdd = _mapper.Map<Category>(addDto);

            bool addResult = await _categoryDal.AddAsync(categoryToAdd);
            if (!addResult)
                return new ErrorResult(Messages.CategoryNotAdded);

            return new SuccessResult(Messages.CategoryAdded);
        }
         
        public async Task<IResult> UpdateAsync(CategoryUpdateDto updateDto)
        {
            var entity = await _categoryDal.GetAsync(e => e.SecondaryId == updateDto.SecondaryId);
            if (entity==null)
            {
                return new ErrorResult(Messages.CategoryNotFound);
            }
            
            _mapper.Map<CategoryUpdateDto, Category>(updateDto, entity);

            bool updateResult = await _categoryDal.UpdateAsync(entity);
            if (!updateResult)
                return new ErrorResult(Messages.CategoryNotUpdated);

            return new SuccessResult(Messages.CategoryUpdated);


        }

        public async Task<IDataResult<List<CategoryDto>>> GetAllAsync()
        {
            var categories = await _categoryDal.GetAllAsync();
            if (categories.Count == 0)
                return new ErrorDataResult<List<CategoryDto>>(null, Messages.CategoryNotList);

            var categoryDtos = _mapper.Map<List<CategoryDto>>(categories);

            return new SuccessDataResult<List<CategoryDto>>(categoryDtos,Messages.CategoryList);
        }

        private async Task<IResult> CheckCategoryNameExistAsync(string categoryName)
        {
            bool isExist = await _categoryDal.IsExistsAsync(
                predicate: p => p.Name.Equals(categoryName),
                include: null,
                ignoreQueryFilters: false);
            if (isExist)
                return new ErrorResult(Messages.CategoryNameAlreadyExist);

            return new SuccessResult(Messages.CategoryNameAvailable);
        }

        public async Task<IResult> DeleteAsync(CategoryDeleteDto deleteDto)
        {
           var entity = await _categoryDal.GetAsync(p => p.SecondaryId == deleteDto.SecondaryId);
            if (entity == null)
                return new ErrorResult(Messages.CategoryNotFound);

            _mapper.Map<CategoryDeleteDto, Category>(deleteDto, entity);

            bool deleteResult = await _categoryDal.UpdateAsync(entity);
            if (!deleteResult)
                return new ErrorResult(Messages.CategoryNotDelete);

            return new SuccessResult(Messages.CategoryDelete);
        }

        public async Task<IDataResult<CategoryDto>> GetCategorySecondaryIdAsync(Guid SecondaryId)
        {
            var category = await _categoryDal.GetAsync(c => c.SecondaryId == SecondaryId);
            if (category == null)
                return new ErrorDataResult<CategoryDto>(null, Messages.ArticleNotfound);

            var categoryIdDtos = _mapper.Map<CategoryDto>(category);
            
            return new SuccessDataResult<CategoryDto>(categoryIdDtos, Messages.CategoryIdList);

        }
    }
}
