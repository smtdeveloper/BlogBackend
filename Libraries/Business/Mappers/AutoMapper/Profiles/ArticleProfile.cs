using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappers.AutoMapper.Profiles
{
    class ArticleProfile :Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleAddDto, Article>()
                 .ForMember(p => p.CreatedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                 .ForMember(p => p.SecondaryId, mopt => mopt.MapFrom(o => Guid.NewGuid()));

            CreateMap<Article, ArticleDto>();

            CreateMap<ArticleUpdateDto, Article>()
                 .ForMember(p => p.UpdatedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore());

            CreateMap<ArticleDeleteDto, Article>()
                .ForMember(p => p.DeletedAt, mopt => mopt.MapFrom(o => DateTime.Now))
               .ForMember(p => p.SecondaryId, mopt => mopt.Ignore())
               .ForMember(p => p.IsDeleted, mopt => mopt.MapFrom(o => true));


        }

    }
}
