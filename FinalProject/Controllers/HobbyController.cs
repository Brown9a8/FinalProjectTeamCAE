using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class HobbyController : ControllerBase {
        private readonly ILogger<HobbyController> _logger;
        private readonly IHobbyContextDAO _context;

        public HobbyController(ILogger<HobbyController> logger, IHobbyContextDAO context) {
            _logger = logger;
            _context = context;
        }

            // GET: Hobbies
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies() {
                var hobbies = await _context.GetAllHobbiesAsync();
                return Ok(hobbies);
            }

            // GET: Hobbies
            [HttpGet("{id}")]
            public async Task<ActionResult<Hobby>> GetHobby(int id) {
                var hobby = await _context.GetHobbyByIdAsync(id);
                if (hobby == null) {
                    return NotFound();
                }

                return Ok(hobby);
            }

            // POST: Hobbies
            [HttpPost]
            public async Task<ActionResult<Hobby>> PostHobby(Hobby hobby) {
                await _context.AddHobbyAsync(hobby);
                return CreatedAtAction(nameof(GetHobby), new { id = hobby.Id }, hobby);
            }

            // PUT: Hobbies
            [HttpPut("{id}")]
            public async Task<IActionResult> PutHobby(int id, Hobby hobby) {
                if (id != hobby.Id) {
                    return BadRequest();
                }

                await _context.UpdateHobbyAsync(hobby);
                return Ok(NoContent());
            }

            // DELETE: Hobbies
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteHobby(int id){
                await _context.DeleteHobbyAsync(id);
                return Ok(NoContent());
            }
        }
    }
