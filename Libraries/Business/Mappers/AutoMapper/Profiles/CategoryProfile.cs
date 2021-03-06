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

            CreateMap<CategoryUpdateDto, Category>()
                .ForMember(p => p.UpdatedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore());

            CreateMap<CategoryDeleteDto, Category>()
                .ForMember(p => p.DeletedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore())
                .ForMember(p => p.IsDeleted, mopt => mopt.MapFrom(o => true));

        }
    }
}
