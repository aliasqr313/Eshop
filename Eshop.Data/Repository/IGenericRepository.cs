using Eshop.Data.Entities.Common;

namespace Eshop.Data.Repository
{
    public interface IGenericRepository<TEntity > :IAsyncDisposable where TEntity:BaseEntity
    {
        IQueryable<TEntity> GetQuery();
        Task <TEntity> GetEntityById(long id);
        Task AddEntity(TEntity entity);
        Task AddRangeEntities(List<TEntity> entities);
        void DeleteEntity(TEntity entity);
        void EditEntity(TEntity entity);
        void DeleteEntities(List<TEntity> entities);

        Task DeleteParament(TEntity entity);  //حذف بصورت کامل 
        Task SaveAsync();
    }
}
