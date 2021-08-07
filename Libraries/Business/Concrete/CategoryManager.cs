﻿using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Category;
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
            if (addResult)
                return new SuccessResult(Messages.CategoryAdded);

            return new ErrorResult(Messages.CategoryNotAdded);
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
    }
}