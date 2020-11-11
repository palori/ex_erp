using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using erp_api.Data.DTO;
using erp_api.Services;

namespace erp_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMembersContactsController : ControllerBase
    {
        public TeamMembersContactsController(TeamMemberProfileContactService teamMemeberProfileContactService)
        {   
            _teamMemeberProfileContactService = teamMemeberProfileContactService;
        }

        private readonly TeamMemberProfileContactService _teamMemeberProfileContactService; // Service

        [HttpPost("1")] //[HttpGet("1")]
        public async Task<ActionResult<TeamMemberDto>> Get(TeamMemberDto teamMember)
        {
            var teamMemberDto =  await _teamMemeberProfileContactService.Get(teamMember);
            if (teamMemberDto == null || teamMemberDto.Id == null)
            {
                return NotFound();
            }

            return Ok(teamMemberDto);
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamMemberDto>>> GetAll()
        {
            return await _teamMemeberProfileContactService.GetAll();
        }
    }
}
