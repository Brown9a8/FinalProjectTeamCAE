using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class FavoriteRideController : ControllerBase {
        private readonly ILogger<FavoriteRideController> _logger;
        private readonly IFavoriteRideContextDAO _context;

        public FavoriteRideController(ILogger<FavoriteRideController> logger, IFavoriteRideContextDAO context) {
            _logger = logger;
            _context = context;
        }
            // GET: FavoriteRides
            [HttpGet]
            public async Task<ActionResult<IEnumerable<FavoriteRide>>> GetFavoriteRides() {
                var favoriteRides = await _context.GetAllFavoriteRidesAsync();
                return Ok(favoriteRides);
            }

            // GET: FavoriteRides
            [HttpGet("{id}")]
            public async Task<ActionResult<FavoriteRide>> GetFavoriteRide(int id) {
                var favoriteRide = await _context.GetFavoriteRideByIdAsync(id);
                if (favoriteRide == null) {
                    return NotFound();
                }

                return Ok(favoriteRide);
            }

            // POST: FavoriteRides
            [HttpPost]
            public async Task<ActionResult<FavoriteRide>> PostFavoriteRide(FavoriteRide favoriteRide)
            {
                await _context.AddFavoriteRideAsync(favoriteRide);
                return CreatedAtAction(nameof(GetFavoriteRide), new { id = favoriteRide.Id }, favoriteRide);
            }

            // PUT: FavoriteRides
            [HttpPut("{id}")]
            public async Task<IActionResult> PutFavoriteRide(int id, FavoriteRide favoriteRide) {
                if (id != favoriteRide.Id) {
                    return BadRequest();
                }

                await _context.UpdateFavoriteRideAsync(favoriteRide);
                return Ok(NoContent());
            }

            // DELETE: FavoriteRides
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteFavoriteRide(int id) {
                await _context.DeleteFavoriteRideAsync(id);
                return Ok(NoContent());
            }
        }
    }
