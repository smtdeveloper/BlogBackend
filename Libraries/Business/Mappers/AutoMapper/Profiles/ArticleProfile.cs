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
                 .ForMember(p => p.SecondaryId, mopt => mopt.MapFrom(o => Guid.NewGuid()));

            CreateMap<Article, ArticleDto>();

            CreateMap<ArticleUpdateDto, Article>()
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore());
        }

    }
}
