using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Comment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        public Task<IResult> AddAsync(CommentAddDto addDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<CommentDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(CommentUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
