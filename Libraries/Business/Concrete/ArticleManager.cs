using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Article;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ArticleManager : IArticleService
    {

        private readonly IArticleDal _articleDal;
        private readonly IMapper _mapper;
        public ArticleManager(IArticleDal articleDal, IMapper mapper)
        {
            _articleDal = articleDal;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(ArticleAddDto addDto)
        {
            Article article = _mapper.Map<Article>(addDto);

            bool Addresult = await _articleDal.AddAsync(article);
            if (!Addresult)
                return new ErrorResult(Messages.ArticleNotAdded);

            return new SuccessResult(Messages.ArticleAdded);
        }

        public async Task<IResult> DeleteAsync(ArticleDeleteDto deleteDto)
        {
           var entity =  await _articleDal.GetAsync(a => a.SecondaryId == deleteDto.SecondaryId);
            if(entity == null)
                return new ErrorResult(Messages.ArticleNotfound);

            _mapper.Map<ArticleDeleteDto, Article>(deleteDto, entity);

            bool deleteResult = await _articleDal.UpdateAsync(entity);
            if (!deleteResult)
                return new ErrorResult(Messages.ArticleNotDelete);

            return new SuccessResult(Messages.ArticleDelete);
        }

        public async Task<IDataResult<List<ArticleDto>>> GetAllAsync()
        {
              var article = await _articleDal.GetAllAsync();

              var articleDto = _mapper.Map<List<ArticleDto>>(article);
            if (article == null)
                return new ErrorDataResult<List<ArticleDto>>(null, Messages.ArticleNotList);

            return new SuccessDataResult<List<ArticleDto>>(articleDto, Messages.ArticleList);
        }

        public async Task<IDataResult<ArticleDto>> GetArticleSecondaryIdAsync(Guid SecondaryId)
        {
           var entity = await _articleDal.GetAsync(a => a.SecondaryId == SecondaryId);
            if (entity == null)
                return new ErrorDataResult<ArticleDto>(null, Messages.ArticleIdNotList);

            var ArticleDto =  _mapper.Map<ArticleDto>(entity);
            return new SuccessDataResult<ArticleDto>(ArticleDto, Messages.ArticleIdList);
        }

        public async Task<IResult> UpdateAsync(ArticleUpdateDto updateDto)
        {
           
            var entity = await _articleDal.GetAsync(a => a.SecondaryId == updateDto.SecondaryId);
            if (entity == null)
            {
                new ErrorResult(Messages.ArticleNotfound);
            }
            _mapper.Map<ArticleUpdateDto, Article>(updateDto, entity);

            bool updateResult = await _articleDal.UpdateAsync(entity);
            if (!updateResult)
                return new ErrorResult(Messages.ArticleNotUpdate);

            return new SuccessResult(Messages.ArticleUpdate);

        }
    }
}
