
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ERP.Models;
using ERP.Contexts;
using ERP.Data.Repositories;

namespace ERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntity, TRepository, TIdType> : ControllerBase
        where TEntity : class, IEntity<TIdType>
        where TRepository : IRepository<TEntity, TIdType>
        // where TIdType : string or int
    {
        private readonly TRepository _repository;

        public GenericController(TRepository repository)
        {
            _repository = repository;
        }

        public TRepository GetRepository()
        {
            return _repository;
        }

        // GET: api/TEntity
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET: api/TEntity/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(TIdType id)
        {
            var entity = await _repository.Get(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        // PUT: api/TEntity/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut()]
        public async Task<IActionResult> Update(TIdType id, TEntity entity)
        {
            //if (id != entity.Id)
            /* if (!id.Equals(entity.Id))
            {
                return BadRequest();
            } */

            var updateResult = await _repository.Update(id, entity);

            if (!updateResult.Check)
            {
                return NotFound();
            }

            return Ok(updateResult.Entity);
        }

        // POST: api/TEntity
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TEntity>> Add(TEntity entity)
        {
            var entity2 = await _repository.Add(entity);
            if (entity2 == null) return BadRequest(); // may be a good idea
            return Ok(entity2);
            //return CreatedAtAction("GetTEntity", new { id = entity.Id }, entity); // don't know what it does
        }

        // DELETE: api/TEntity (not by passing Id in the URL, but in the body)
        //[EnableCors("_myAllowSpecificOrigins")]
        [HttpDelete]
        public async Task<ActionResult<TEntity>> Delete(TIdType id)
        {
            var entity = await _repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

    }
}
