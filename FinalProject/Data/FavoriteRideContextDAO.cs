using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class FavoriteRideContextDAO : IFavoriteRideContextDAO
    {
        private readonly ProjectDbContext _context;

        public FavoriteRideContextDAO(ProjectDbContext context)
        {
            _context = context;
        }
            // Get all favorite rides
            public async Task<List<FavoriteRide>> GetAllFavoriteRidesAsync()
            {
                return await _context.FavoriteRides.ToListAsync();
            }

            // Get a favorite ride by Id
            public async Task<FavoriteRide> GetFavoriteRideByIdAsync(int id)
            {
                return await _context.FavoriteRides.FindAsync(id);
            }

            // Add a new favorite ride
            public async Task AddFavoriteRideAsync(FavoriteRide favoriteRide)
            {
                _context.FavoriteRides.Add(favoriteRide);
                await _context.SaveChangesAsync();
            }

            // Update an existing favorite ride
            public async Task UpdateFavoriteRideAsync(FavoriteRide favoriteRide)
            {
                _context.FavoriteRides.Update(favoriteRide);
                await _context.SaveChangesAsync();
            }

            // Delete a favorite ride by Id
            public async Task DeleteFavoriteRideAsync(int id)
            {
                var favoriteRide = await _context.FavoriteRides.FindAsync(id);
                if (favoriteRide != null)
                {
                    _context.FavoriteRides.Remove(favoriteRide);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
