using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;

namespace erp_api.Repositories
{
    public abstract class GenericRepository<TEntity, TContext, TIdType> : IRepository<TEntity, TIdType>
        where TEntity : class, IEntity<TIdType>
        where TContext : DbContext
        // where TIdType : string or int
    {
        private readonly TContext context;
        public GenericRepository(TContext context)
        {
            this.context = context;
        }

        public TContext GetContext()
        {
            return this.context;
        }
        
        public async Task<TEntity> Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(TIdType id)
        {
            var entity = await context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(TIdType id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<bool> Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            bool updated = true;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TEntityExists(entity.Id).Result) // will it work???
                {
                    updated = false;
                }
                else
                {
                    throw;
                }
            }
            return updated;
        }

        private async Task<bool> TEntityExists(TIdType id)
        {
            return await context.Set<TEntity>().AnyAsync<TEntity>(e => e.Id.Equals(id));
        }

    }
}