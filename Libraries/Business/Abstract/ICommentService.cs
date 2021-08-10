using Core.Utilities.Results.Abstract;
using Entities.Dtos.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICommentService
    {

        public Task<IResult> AddAsync(CommentAddDto addDto);
        public Task<IDataResult<List<CommentDto>>> GetAllAsync();
        public Task<IResult> UpdateAsync(CommentUpdateDto updateDto);
    }
}
