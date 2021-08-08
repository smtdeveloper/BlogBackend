using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.Category;
using System;

namespace Business.Mappers.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryAddDto, Category>()
                .ForMember(p => p.CreatedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                .ForMember(p => p.SecondaryId, mopt => mopt.MapFrom(o => Guid.NewGuid()));

            CreateMap<Category, CategoryDto>();
        }
    }
}
