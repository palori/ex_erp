// using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;
// using System.Threading.Tasks;

// using erp_api.Models;
// using erp_api.Repositories;

// namespace erp_api.Services
// {
//     public abstract class GenericService<TEntity,TIdType>> 
//     : IGenericService<TEntity, TIdType>
//         where TEntity : class, IEntity<TIdType>
//         // where TIdType : string or int
//     {
//         private readonly IRepository<TEntity, TIdType> repository;
//         public GenericService(IRepository<TEntity, TIdType> repository)
//         {
//             this.repository = repository;
//         }

//         public IRepository<TEntity, TIdType> GetRepository()
//         {
//             return this.repository;
//         }

//         public async Task<TEntity> Add(TEntity entity)
//         {
//             return await repository.Add(entity);
//         }
//         public async Task<TEntity> Delete(TEntity entity)
//         {
//             return await repository.Delete(entity);
//         }
//         public async Task<TEntity> Get(TEntity entity)
//         {
//             return await repository.Get(entity);
//         }
//         public async Task<List<TEntity>> GetAll()
//         {
//             return await repository.GetAll();
//         }
//         public async Task<bool> Update(TEntity entity)
//         {
//             return await repository.Update(entity);
//         }
//     }

//     /* public abstract class GenericService<TEntity, TIdType> : IGenericService<TEntity, TIdType>
//         where TEntity : class, IEntity<TIdType>
//         // where TIdType : string or int
//     {
//         private readonly IRepository<TEntity, TIdType> repository;
//         public GenericService(IRepository<TEntity, TIdType> repository)
//         {
//             this.repository = repository;
//         }

//         public IRepository<TEntity, TIdType> GetRepository()
//         {
//             return this.repository;
//         }

//         public async Task<TEntity> Add(TEntity entity)
//         {
//             return await repository.Add(entity);
//         }
//         public async Task<TEntity> Delete(TEntity entity)
//         {
//             return await repository.Delete(entity);
//         }
//         public async Task<TEntity> Get(TEntity entity)
//         {
//             return await repository.Get(entity);
//         }
//         public async Task<List<TEntity>> GetAll()
//         {
//             return await repository.GetAll();
//         }
//         public async Task<bool> Update(TEntity entity)
//         {
//             return await repository.Update(entity);
//         }
//     } */
// }