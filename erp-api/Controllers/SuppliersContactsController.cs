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
        public SuppliersContactsController(SupplierContactService teamMemeberProfileContactService)
        {   
            _teamMemeberProfileContactService = teamMemeberProfileContactService;
        }

        private readonly SupplierContactService _teamMemeberProfileContactService; // Service

        [Authorize]
        [HttpPost("1")] //[HttpGet("1")]
        public async Task<ActionResult<SupplierDto>> Get(SupplierDto supplier)
        {
            var supplierDto =  await _teamMemeberProfileContactService.Get(supplier);
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
            return await _teamMemeberProfileContactService.GetAll();
        }
    }
}
