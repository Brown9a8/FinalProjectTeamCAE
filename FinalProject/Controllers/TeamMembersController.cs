using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Interfaces;
using FinalProject.Data;
using Microsoft.Extensions.Logging;

namespace FinalProject.Controllers {
        [Route("[controller]")]
        [ApiController]
        public class TeamMembersController : ControllerBase {
        private readonly ILogger<TeamMembersController> _logger;
        private readonly ITeamMembersContextDAO _context;

            public TeamMembersController(ILogger<TeamMembersController> logger, ITeamMembersContextDAO context ) {
            _logger = logger;
            _context = context;
            }

            // GET: TeamMembers
            [HttpGet]
            public async Task<ActionResult<IEnumerable<TeamMember>>> GetTeamMembers() {
                var members = await _context.GetAllTeamMembersAsync();
                return Ok(members);
            }

            // GET: TeamMembers
            [HttpGet("{id}")]
            public async Task<ActionResult<TeamMember>> GetTeamMember(int id) {
                var member = await _context.GetTeamMemberByIdAsync(id);
                if (member == null) {
                    return NotFound();
                }

                return Ok(member);
            }

            // POST: TeamMembers
            [HttpPost]
            public async Task<ActionResult<TeamMember>> PostTeamMember(TeamMember member) {
                await _context.AddTeamMemberAsync(member);
                return CreatedAtAction(nameof(GetTeamMember), new { id = member.Id }, member);
            }

            // PUT: TeamMembers
            [HttpPut("{id}")]
            public async Task<IActionResult> PutTeamMember(int id, TeamMember member) {
                if (id != member.Id) {
                    return BadRequest();
                }

                await _context.UpdateTeamMemberAsync(member);
                return NoContent();
            }

            // DELETE: TeamMembers
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteTeamMember(int id) {
                await _context.DeleteTeamMemberAsync(id);
                return NoContent();
            }
        }
    }
