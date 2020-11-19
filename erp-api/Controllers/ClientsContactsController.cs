using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using erp_api.Data.DTO;
using erp_api.Services;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsContactsController : ControllerBase
    {
        public ClientsContactsController(ClientProfileContactService clientProfileContactService)
        {   
            _clientProfileContactService = clientProfileContactService;
        }

        private readonly ClientProfileContactService _clientProfileContactService; // Service

        [Authorize]
        [HttpPost("1")] //[HttpGet("1")]
        public async Task<ActionResult<ClientDto>> Get(ClientDto client)
        {
            var clientDto =  await _clientProfileContactService.Get(client);
            if (clientDto == null || clientDto.Id == null)
            {
                return NotFound();
            }

            return Ok(clientDto);
        }
        
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetAll()
        {
            return await _clientProfileContactService.GetAll();
        }

        [Authorize]
        [HttpPut()]
        public async Task<IActionResult> Update(ClientDto client)
        {
            bool updated = await _clientProfileContactService.Update(client);
            if (!updated) return NotFound();
            return NoContent();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<ClientDto>> Add(ClientDto client)
        {
            var entity = await _clientProfileContactService.Add(client);
            if (entity == null) return BadRequest();
            return Ok(entity);
        }

        [Authorize]
        [HttpPost("d")] //[HttpDelete]
        public async Task<ActionResult<ClientDto>> Delete(ClientDto client)
        {
            var entity = await _clientProfileContactService.Delete(client);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
    }
}
