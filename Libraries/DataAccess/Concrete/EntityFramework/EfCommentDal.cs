using Core.DataAccess.RepositoryPattern;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : EntityRepositoryBase<Comment, ProjectDbContext>, ICommentDal
    {
        public EfCommentDal(ProjectDbContext context) : base(context)
        {

        }
    
    }
    
    
}
