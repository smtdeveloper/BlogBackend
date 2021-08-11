using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.Comment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappers.AutoMapper.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<CommentAddDto, Comment>()
                 .ForMember(p => p.CreatedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                 .ForMember(p => p.SecondaryId, mopt => mopt.MapFrom(o => Guid.NewGuid()));

            CreateMap<Comment, CommentDto>();

            CreateMap<CommentUpdateDto, Comment>()
                .ForMember(p => p.UpdatedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore());
            CreateMap<CommentDeleteDto, Category>()
                .ForMember(p => p.DeletedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore());
        }
    }
}
