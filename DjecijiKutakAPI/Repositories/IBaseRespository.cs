using DjecijiKutakAPI.Entities;

namespace DjecijiKutakAPI.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);
        TEntity Get(TEntity entity);
        TEntity Remove(TEntity entity);
        TEntity Update(TEntity entity);
    }
}
