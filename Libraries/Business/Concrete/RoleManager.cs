using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Entities.Dtos.Role;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        public Task<IResult> AddAsync(RoleAddDto addDto)
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
