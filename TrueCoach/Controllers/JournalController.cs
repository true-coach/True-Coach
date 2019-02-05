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
                Journal = Journal.where(Journal => Journal.Entry.ToLower().contains(journal.ToLower()));

            }
            return View(journal);
        }
        //Get Journal Details
        public async Task <IActionResult> Details(int? id)
        {
            if(id== null)
            {
                return NotFound();
            }
            var journal =await _context.GetJournal((int)id);
            if(journal == null)
            {
                return NotFound();
            }

        }
    }
}
