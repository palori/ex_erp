using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Services
{
    public interface IService<T, TIdType> : IRepository<T, TIdType>
        where T : class, IEntity<TIdType>
    { }
}