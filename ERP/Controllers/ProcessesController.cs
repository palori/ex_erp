using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessesController : GenericController<Process, ProcessesRepository, string>
    {
        public ProcessesController(ProcessesRepository repository): base(repository)
        {   
        }
    }
}
