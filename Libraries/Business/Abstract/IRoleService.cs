using Core.Utilities.Results.Abstract;
using Entities.Dtos.Role;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRoleService
    {
        public Task<IResult> AddAsync(RoleAddDto addDto);
        public Task<IDataResult<List<RoleDto>>> GetAllAsync();
        public Task<IResult> UpdateAsync(RoleUpdateDto updateDto);
    }
}
