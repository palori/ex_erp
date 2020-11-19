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

        [Authorize]
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
        
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamMemberDto>>> GetAll()
        {
            return await _teamMemeberProfileContactService.GetAll();
        }

        [Authorize]
        [HttpPut()]
        public async Task<IActionResult> Update(TeamMemberDto teamMember)
        {
            bool updated = await _teamMemeberProfileContactService.Update(teamMember);
            if (!updated) return NotFound();
            return NoContent();
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<TeamMemberDto>> Add(TeamMemberDto teamMember)
        {
            var entity = await _teamMemeberProfileContactService.Add(teamMember);
            if (entity == null) return BadRequest();
            return Ok(entity);
        }

        [Authorize]
        [HttpPost("d")] //[HttpDelete]
        public async Task<ActionResult<TeamMemberDto>> Delete(TeamMemberDto teamMember)
        {
            var entity = await _teamMemeberProfileContactService.Delete(teamMember);
            if (entity == null) return NotFound();
            return Ok(entity);
        }
    }
}
