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

        /// <summary>
        /// DbContext as the database connection and creating _context to access the tables.
        /// DbContext allows you to link your model properties using the Entity Framework to your database with a connection string
        /// </summary>
        private TrueCoachJournalDbContext _context { get; }

        /// <summary>
        /// Accessing context in MVC .NET core
        /// </summary>
        /// <param name="context"></param>
        public JournalServiceManagment(TrueCoachJournalDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// creating CreateJournal method to run parallel with other web requests
        /// </summary>
        /// <param name="Journal"></param>
        /// <returns></returns>
        public async Task CreateJournal(Journal Journal)
        {
            _context.Journal.Add(Journal);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// method to delete a journal 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task DeleteJournal(int id)
        {
            Journal journal = _context.Journal.FirstOrDefault(Journal => Journal.ID == id);
            _context.Journal.Remove(journal);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// method to get a single journal 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Journal> GetJournal(int id)
        {
            return await _context.Journal.FirstOrDefaultAsync(journal => journal.ID==id);
        }

        /// <summary>
        /// method to retrive a list of journals
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Journal>> GetJournal()
        {
            return await _context.Journal.ToListAsync();
        }

        /// <summary>
        /// method to to update a journal
        /// </summary>
        /// <param name="journal"></param>
        /// <returns></returns>
        public async Task UpdateJournal(Journal journal)
        {
            _context.Journal.Update(journal);
            await _context.SaveChangesAsync();
        }

    }
}
