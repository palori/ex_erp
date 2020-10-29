using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;

namespace erp_api.Repositories
{
    public interface IRepository<T, TIdType>
        where T : class, IEntity<TIdType>
        // where TIdType : string or int
    {
        Task<List<T>> GetAll();
        Task<T> Get(TIdType id);
        Task<T> Add(T entity);
        Task<bool> Update(T entity);
        Task<T> Delete(T entity);
    }
}