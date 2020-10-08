using System.Collections.Generic;
using System.Threading.Tasks;

using ERP.Models;

namespace ERP.Data.Repositories
{
    public interface IRepository<T, TIdType>
        where T : class, IEntity<TIdType>
        // where TIdType : string or int
    {
        Task<List<T>> GetAll();
        Task<T> Get(TIdType id);
        Task<T> Add(T entity);
        UpdateResult<T, TIdType> Update(TIdType id, T entity);
        Task<T> Delete(TIdType id);
    }

    public class UpdateResult<T, TIdType>
        where T : class, IEntity<TIdType> // val la pena tot aixo???
    {
        Task<T> Entity {get; set;}
        bool Check {get; set;}
    }
}