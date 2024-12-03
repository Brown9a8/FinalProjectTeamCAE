using FinalProject.Interfaces;
using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
 
        public class TeamMembersContextDAO : ITeamMembersContextDAO
        {
            private readonly ProjectDbContext _context;

            public TeamMembersContextDAO(ProjectDbContext context)
            {
                _context = context;
            }

            // Get all team members
            public async Task<List<TeamMember>> GetAllTeamMembersAsync()
            {
                return await _context.Members.ToListAsync();
            }

            // Get team member by Id
            public async Task<TeamMember> GetTeamMemberByIdAsync(int id)
            {
                return await _context.Members.FindAsync(id);
            }

            // Add a new team member
            public async Task AddTeamMemberAsync(TeamMember member)
            {
                _context.Members.Add(member);
                await _context.SaveChangesAsync();
            }

            // Update an existing team member
            public async Task UpdateTeamMemberAsync(TeamMember member)
            {
                _context.Members.Update(member);
                await _context.SaveChangesAsync();
            }

            // Delete a team member
            public async Task DeleteTeamMemberAsync(int id)
            {
                var member = await _context.Members.FindAsync(id);
                if (member != null)
                {
                    _context.Members.Remove(member);
                    await _context.SaveChangesAsync();
                }
            }
        }
    }
