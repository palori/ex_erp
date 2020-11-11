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
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetAll()
        {
            return await _clientProfileContactService.GetAll();
        }
    }
}
