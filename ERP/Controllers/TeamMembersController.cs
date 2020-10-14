using Microsoft.AspNetCore.Mvc;

using ERP.Models;
using ERP.Data.Repositories;

namespace ERP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersController : GenericController<TeamMember, TeamMembersRepository, string>
    {
        public TeamMembersController(TeamMembersRepository repository): base(repository)
        {   
        }
    }
}
