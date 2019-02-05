using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using TrueCoach.Data;
using TrueCoach.Models.Interfaces;

namespace TrueCoach.Models.Services
{
    public class JournalServiceManagment : IJournal
    {
        private TrueCoachJournalDbContext _context { get; }

        public JournalServiceManagment(TrueCoachJournalDbContext context)
        {
            _context = context;
        }

        public async Task CreateJournal(Journal Journal)
        {
            _context.Journal.Add(Journal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJournal(int id)
        {
            Journal journal = _context.Journal.FirstOrDefault(Journal => Journal.ID == id);
            _context.Journal.Remove(journal);
            await _context.SaveChangesAsync();
        }

        public async Task<Journal> GetJournal(int id)
        {
            return await _context.Journal.FirstOrDefaultAsync(journal => journal.ID==id);
        }

        public async Task<IEnumerable<Journal>> GetJournal()
        {
            return await _context.Journal.ToListAsync();
        }

        public async Task UpdateJournal(Journal journal)
        {
            _context.Journal.Update(journal);
            await _context.SaveChangesAsync();
        }




    }
}
