using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class HobbyContextDAO : IHobbyContextDAO
    {
        private readonly ProjectDbContext _context;

        public HobbyContextDAO(ProjectDbContext context)
        {
            _context = context;
        }
            // Get all hobbies
            public async Task<List<Hobby>> GetAllHobbiesAsync()
            {
                return await _context.Hobbies.ToListAsync();
            }

            // Get hobby by Id
            public async Task<Hobby> GetHobbyByIdAsync(int id)
            {
                return await _context.Hobbies.FindAsync(id);
            }

            // Add a new hobby
            public async Task AddHobbyAsync(Hobby hobby)
            {
                _context.Hobbies.Add(hobby);
                await _context.SaveChangesAsync();
            }

            // Update an existing hobby
            public async Task UpdateHobbyAsync(Hobby hobby)
            {
                _context.Hobbies.Update(hobby);
                await _context.SaveChangesAsync();
            }

            // Delete a hobby
            public async Task DeleteHobbyAsync(int id)
            {
                var hobby = await _context.Hobbies.FindAsync(id);
                if (hobby != null)
                {
                    _context.Hobbies.Remove(hobby);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
