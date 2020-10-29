using Microsoft.AspNetCore.Mvc;

using erp_api.Models;
using erp_api.Repositories;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : GenericController<Profile, ProfilesRepository, string>
    {
        public ProfilesController(ProfilesRepository repository): base(repository)
        {   
        }
    }
}
