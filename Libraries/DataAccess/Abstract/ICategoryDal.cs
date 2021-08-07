using Core.DataAccess.RepositoryPattern;
using Entities.Concrete;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
