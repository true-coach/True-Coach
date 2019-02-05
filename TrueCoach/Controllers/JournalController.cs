using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueCoach.Controllers
{
    public class JournalController
    {
        private readonly IJournal _context;

            public JournalController(TrueCoachDbContext context)
        {
            _context = context;
        }

        //Get:Journal

        public async Task<IAsyncResult> Index()
        {
            var TrueCoachDbContext = await _context.GetJournals();

            if (!string.IsNullOrEmpty(Entry))
            {
                Journal=Journal.where(Journal =>)
            }
        }

    }
}
