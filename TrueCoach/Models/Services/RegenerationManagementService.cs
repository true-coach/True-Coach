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

        /// <summary>
        /// Connect with DB context
        /// </summary>
        /// <param name="context"></param>
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

        /// <summary>
        /// delete a single regeneration from the table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Get all the regeneration in a string
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Regeneration>> GetRegenerations()
        {
            return await _context.Regeneration.ToListAsync();
        }

        /// <summary>
        /// Update the regeneration information
        /// </summary>
        /// <param name="Regeneration"></param>
        /// <returns></returns>
        public async Task UpdateRegeneration(Regeneration Regeneration)
        {
            _context.Regeneration.Update(Regeneration);
            await _context.SaveChangesAsync();
        }
    }
}
