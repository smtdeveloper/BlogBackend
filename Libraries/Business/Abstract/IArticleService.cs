using Core.Utilities.Results.Abstract;
using Entities.Dtos.Article;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IArticleService
    {
        public Task<IResult> AddAsync(ArticleAddDto addDto);
        public Task<IResult> UpdateAsync(ArticleUpdateDto updateDto);
        public Task<IDataResult<List<ArticleDto>>> GetAllAsync();

    }
}
