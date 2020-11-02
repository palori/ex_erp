using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;
using erp_api.Data.DTO;
using erp_api.Services;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : GenericController<Client, ClientsRepository, string>
    {
        // public ClientsController(ClientsRepository repository): base(repository)
        // {   
        // }
        public ClientsController(ClientsRepository repository, ClientProfileContactService clientProfileContactService): base(repository)
        {   
            _clientProfileContactService = clientProfileContactService;
        }


        // Service
        private readonly ClientProfileContactService _clientProfileContactService;

        [HttpGet("full/1")]
        public async Task<ActionResult<ClientDto>> Get1(ClientDto client)
        {
            var clientDto =  await _clientProfileContactService.Get(client);
            if (clientDto == null || clientDto.Id == null)
            {
                return NotFound();
            }

            return Ok(clientDto);
        }
        
        [HttpGet("full")]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetN()
        {
            return await _clientProfileContactService.GetAll();
        }
    }
}
