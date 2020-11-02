using System.Collections.Generic;
using System.Threading.Tasks;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Services
{
    public interface IService
    {
        //private readonly List<IRepository<>> repositories;
    }

    // public interface IGenericService<T, TIdType> : IService//: IRepository<T, TIdType>
    //     where T : class, IEntity<TIdType>
    // {
    //     Task<List<T>> GetAll();
    //     Task<T> Get(T entity);
    //     Task<T> Add(T entity);
    //     Task<bool> Update(T entity);
    //     Task<T> Delete(T entity);
    // }
}