using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : GenericController<Address, AddressesRepository, string>
    {
        public AddressesController(AddressesRepository repository): base(repository)
        {   
        }
    }
}
