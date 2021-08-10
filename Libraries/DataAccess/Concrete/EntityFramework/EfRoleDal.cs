using Core.DataAccess.RepositoryPattern;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public  class EfRoleDal : EntityRepositoryBase<Role, ProjectDbContext>, IRoleDal
    {
        public EfRoleDal(ProjectDbContext context) : base(context)
        {
        }
 
    }
}
