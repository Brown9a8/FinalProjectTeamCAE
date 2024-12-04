using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class FavoriteFoodController : ControllerBase {
        private readonly ILogger<FavoriteFoodController> _logger;
        private readonly IFavoriteFoodContextDAO _context;

        public FavoriteFoodController(ILogger<FavoriteFoodController> logger, IFavoriteFoodContextDAO context) {
            _logger = logger;
            _context = context;
        }
            // GET: FavoriteFoods
            [HttpGet]
            public async Task<ActionResult<IEnumerable<FavoriteFood>>> GetFavoriteFoods() {
                var favoriteFoods = await _context.GetAllFavoriteFoodsAsync();
                return Ok(favoriteFoods);
            }

            // GET: FavoriteFoods by Id
            [HttpGet("{id}")]
            public async Task<ActionResult<FavoriteFood>> GetFavoriteFood(int id) {
                var favoriteFood = await _context.GetFavoriteFoodByIdAsync(id);
                if (favoriteFood == null) {
                    return NotFound();
                }

                return Ok(favoriteFood);
            }

            // POST: FavoriteFoods
            [HttpPost]
            public async Task<ActionResult<FavoriteFood>> PostFavoriteFood(FavoriteFood favoriteFood) {
                await _context.AddFavoriteFoodAsync(favoriteFood);
                return CreatedAtAction(nameof(GetFavoriteFood), new { id = favoriteFood.Id }, favoriteFood);
            }

            // PUT: FavoriteFoods
            [HttpPut("{id}")]
            public async Task<IActionResult> PutFavoriteFood(int id, FavoriteFood favoriteFood) {
                if (id != favoriteFood.Id) {
                    return BadRequest();
                }

                await _context.UpdateFavoriteFoodAsync(favoriteFood);
                return Ok(NoContent());
            }

            // DELETE: FavoriteFoods
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteFavoriteFood(int id) {
                await _context.DeleteFavoriteFoodAsync(id);
                return Ok(NoContent());
            }
        }
    }
