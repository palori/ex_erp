using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
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
