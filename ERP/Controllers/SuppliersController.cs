using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : GenericController<Supplier, SuppliersRepository, string>
    {
        public SuppliersController(SuppliersRepository repository): base(repository)
        {   
        }
    }
}
