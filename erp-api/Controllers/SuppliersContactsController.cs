using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using erp_api.Data.DTO;
using erp_api.Services;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersContactsController : ControllerBase
    {
        public SuppliersContactsController(SupplierContactService supplierContactService)
        {   
            _supplierContactService = supplierContactService;
        }

        private readonly SupplierContactService _supplierContactService; // Service

        [Authorize]
        [HttpPost("1")] //[HttpGet("1")]
        public async Task<ActionResult<SupplierDto>> Get(SupplierDto supplier)
        {
            var supplierDto =  await _supplierContactService.Get(supplier);
            if (supplierDto == null || supplierDto.Id == null)
            {
                return NotFound();
            }

            return Ok(supplierDto);
        }
        
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupplierDto>>> GetAll()
        {
            return await _supplierContactService.GetAll();
        }

        [Authorize]
        [HttpPut()]
        public async Task<IActionResult> Update(SupplierDto supplier)
        {
            bool updated = await _supplierContactService.Update(supplier);
            if (!updated) return NotFound();
            return NoContent();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<SupplierDto>> Add(SupplierDto supplier)
        {
            var entity = await _supplierContactService.Add(supplier);
            if (entity == null) return BadRequest();
            return Ok(entity);
        }

        [Authorize]
        [HttpPost("d")] //[HttpDelete]
        public async Task<ActionResult<SupplierDto>> Delete(SupplierDto supplier)
        {
            var entity = await _supplierContactService.Delete(supplier);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
    }
}
