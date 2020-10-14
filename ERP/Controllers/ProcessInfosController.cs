using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessInfosController : GenericController<ProcessInfo, ProcessInfosRepository, string>
    {
        public ProcessInfosController(ProcessInfosRepository repository): base(repository)
        {   
        }
    }
}
