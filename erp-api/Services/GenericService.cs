using Microsoft.EntityFrameworkCore;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Services
{
    public abstract class GenericService<TEntity, TContext, TIdType> :
        GenericRepository<TEntity, TContext, TIdType>,
        IService<TEntity, TIdType>
        where TEntity : class, IEntity<TIdType>
        where TContext : DbContext
        // where TIdType : string or int
    {
        public GenericService(TContext context): base(context)
        {
            
        }
    }
}