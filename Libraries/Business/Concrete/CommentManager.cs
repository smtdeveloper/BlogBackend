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
        private readonly ICommentDal _commentDal;
        private readonly IMapper _mapper;


        public CommentManager(ICommentDal commentDal, IMapper mapper)
        {
            _commentDal = commentDal;
            _mapper = mapper;
        }
        public async Task<IResult> AddAsync(CommentAddDto addDto)
        {
            Comment commentToAdd = _mapper.Map<Comment>(addDto);
            bool addResult = await _commentDal.AddAsync(commentToAdd);
            if (!addResult)
                return new ErrorResult(Messages.CommentNotAdded);
            return new SuccessResult(Messages.CommentAdded);
        }

        public async Task<IDataResult<List<CommentDto>>> GetAllAsync()
        {
            var comment = await _commentDal.GetAllAsync();
           
            if (comment == null)
            {
                return new ErrorDataResult<List<CommentDto>>(null, Messages.CommentsNotFound);

            }

            var commentDto = _mapper.Map<List<CommentDto>>(comment);

            return new SuccessDataResult<List<CommentDto>>(commentDto, Messages.CommentsListed);
        }

        public async Task<IResult> UpdateAsync(CommentUpdateDto updateDto)
        {
            var comment = await _commentDal.GetAsync(a => a.SecondaryId == updateDto.SecondaryId);
            if (comment == null)
            {
                return new ErrorResult(Messages.CommentNotFound);
            }
           
            _mapper.Map<CommentUpdateDto, Comment>(updateDto, comment);
            
            bool updateresult = await _commentDal.UpdateAsync(comment);

            if (!updateresult)
               
                return new ErrorResult(Messages.CommentNotUpdated);
           
            return new SuccessResult(Messages.CommentUpdated);
        }
    }
}