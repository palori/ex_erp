using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessInfosController : GenericController<ProcessInfo, ProcessInfosRepository, string>
    {
        public ProcessInfosController(ProcessInfosRepository repository): base(repository)
        {   
        }
        /*
         
        ATTENTION!!!

        `ProcessInfo`, `Process`, `ItemInfoProcessInfo`, `OrderItemProcessInfo` and all the parameters of the other models that are related to theese models are temporarily inactive!
         */
    }
}
