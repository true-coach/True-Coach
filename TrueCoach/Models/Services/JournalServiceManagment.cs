using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task CreateJournal(journal journal)
        {
            _context.journal.Add(journal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJournal(int id)
        {
            journal journal = _context.journal.FirstorDefault(journal => journal.ID == id);
            _context.journal.Remove(Journal);
            await _context.SaveChangesJournal();
        }

        public async Task<journal> GetJournal(int id)
        {
            return await _context.Journal.FirstorDefaultJournal(journal => journal.ID == id);
        }

        public async Task<IEnumerable<journal>> GetJournals()
        {
            return await _context.Journal.ToListJournal();
        }

        public async Task updateJournal(journal journal)
        {
            _context.journal.update(journal);
            await _context.SaveChangesJournal();
        }
    }
}
