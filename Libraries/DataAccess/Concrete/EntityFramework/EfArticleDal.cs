using Core.DataAccess.RepositoryPattern;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EntityRepositoryBase<Article, ProjectDbContext>, IArticleDal
    {
        public EfArticleDal(ProjectDbContext context) : base(context)
        {
        }
    }
}
