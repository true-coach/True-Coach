using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TrueCoach.Data;
using System.Threading.Tasks;
using TrueCoach.Models.Interfaces;

namespace TrueCoach.Models.Services
{
    public class RegenerationManagementService : IRegeneration
    {
        private TrueCoachJournalDbContext _context { get; }

        public RegenerationManagementService(TrueCoachJournalDbContext context)
        {
            _context = context;
        }

        public async Task CreateRegeneration(Regeneration Regeneration)
        {
            //throw new NotImplementedException();
            _context.Regeneration.Add(Regeneration);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteRegeneration(int id)
        {
             Regeneration regeneration = _context.Regeneration.FirstOrDefault(Regeneration => Regeneration.ID == id);
            _context.Regeneration.Remove(regeneration);
            await _context.SaveChangesAsync();
        }

        public async Task<Regeneration> GetRegeneration(int id)
        {
            return await _context.Regeneration.FirstOrDefaultAsync(regeneration => regeneration.ID==id);
           
        }

        public async Task<IEnumerable<Regeneration>> GetRegenerations()
        {
            return await _context.Regeneration.ToListAsync();
        }

        public async Task UpdateRegeneration(Regeneration Regeneration)
        {
            _context.Regeneration.Update(Regeneration);
            await _context.SaveChangesAsync();
        }
    }
}
