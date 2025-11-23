using Eshop.Data.Entities.Common;
using Eshop.Data.Context;

using Microsoft.EntityFrameworkCore;
namespace Eshop.Data.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            this._dbSet = _dbContext.Set<TEntity>();
        }
        public async ValueTask DisposeAsync()
        {
            if (_dbContext != null)
            {
                await _dbContext.DisposeAsync();
            }

        }
        public IQueryable<TEntity> GetQuery()
        {
            return _dbSet.AsQueryable();
        }

        public  async Task<TEntity> GetEntityById(long id)
        {
            return await _dbSet.SingleOrDefaultAsync(d => d.id == id);
        }
        public async Task AddEntity(TEntity entity)
        {
            entity.CreatData = DateTime.Now;
            entity.LastUpdateData = DateTime.Now;
            await _dbSet.AddAsync(entity);
        }

        public  async Task AddRangeEntities(List<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                entity.CreatData = DateTime.Now;
                entity.LastUpdateData = DateTime.Now;
                await _dbSet.AddAsync(entity);
            }
        }
        public void DeleteEntity(TEntity entity)
        {
            entity.IsDeleted = true;
            EditEntity(entity);
        }

        public void DeleteEntities(List<TEntity> entities)
        {
         foreach(var item in entities)
            {
                item.IsDeleted = true;
                EditEntity(item);

            }
        }


        public async Task DeleteParament(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

       

        public async void EditEntity(TEntity entity)
        {
            entity.LastUpdateData = DateTime.Now;
            _dbSet.Update(entity);
           
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        
        
    }
}
