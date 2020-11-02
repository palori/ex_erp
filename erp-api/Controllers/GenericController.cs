
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
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
        [HttpGet("1")] //[HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(TEntity _entity)
        {
            var entity = await _repository.Get(_entity.Id);

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
        public async Task<IActionResult> Update(TEntity entity)
        {
            //var updateResult = await _repository.Update(id, entity);
            bool updated = await _repository.Update(entity);

            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
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
        public async Task<ActionResult<TEntity>> Delete(TEntity _entity)
        {
            var entity = await _repository.Delete(_entity);
            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

    }
}
