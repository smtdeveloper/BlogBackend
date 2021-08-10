using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos.Role;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;
        private readonly IMapper _mapper;

        public RoleManager(IRoleDal roleDal, IMapper mapper)
        {
            _mapper = mapper;
            _roleDal = roleDal;
        }
        public async Task<IResult> AddAsync(RoleAddDto addDto)
        {
            throw new NotImplementedException();

        }

        public Task<IDataResult<List<RoleDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(RoleUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
