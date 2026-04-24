using FinalWebAPI.Data;
using FinalWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamMemberController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TeamMemberController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamMember>>> GetAll() {
            return Ok(await _context.TeamMembers.Take(5).ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TeamMember>>> Get(int id)
        {
            if (id == 0)
            {
                return Ok(await _context.TeamMembers.Take(5).ToListAsync());
            }

            var teamMember = await _context.TeamMembers.FindAsync(id);

            if (teamMember == null)
            {
                return NotFound();
            }

            return Ok(teamMember);
        }

        [HttpPost]
        public async Task<ActionResult<TeamMember>> Post(TeamMember teamMember)
        {
            _context.TeamMembers.Add(teamMember);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = teamMember.TeamMemberId }, teamMember);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, TeamMember teamMember)
        {
            if (id != teamMember.TeamMemberId)
            {
                return BadRequest();
            }

            _context.Entry(teamMember).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var teamMember = await _context.TeamMembers.FindAsync(id);

            if (teamMember == null) {
                return NotFound();
            }

            _context.TeamMembers.Remove(teamMember);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}