using AutoMapper;
using Entities.Concrete;
using Entities.Dtos.Role;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappers.AutoMapper.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleAddDto, Role>()
                .ForMember(p => p.SecondaryId, mopt => mopt.MapFrom(o => Guid.NewGuid()))
                .ForMember(p => p.CreatedAt, mopt => mopt.MapFrom(o => DateTime.Now));

            CreateMap<Role, RoleDto>();

            CreateMap<RoleDeleteDto, Role>()
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore())
                .ForMember(p => p.DeleteAt, mopt => mopt.MapFrom(o => DateTime.Now));

            CreateMap<RoleUpdateDto, Role>()
                .ForMember(p => p.UpdatedAt, mopt => mopt.MapFrom(o => DateTime.Now))
                .ForMember(p => p.SecondaryId, mopt => mopt.Ignore());




        }
    }
}
