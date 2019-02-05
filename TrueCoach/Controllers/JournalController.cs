using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueCoach.Models.Interfaces;

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
                journal = journal.where(Journal => Journal.Entry.ToLower().contains(journal.ToLower()));

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
            return View(hotel);
        }

        //Get: Create journal

            public IActionResult create()
        {
            return View();
        }


        //Post:Journal
        public async Task<IActionResult> Create([Bind("ID,Entry")]Journal Journal)
        {
            if (journal.Isvalid)
            {
                await _context.CreateJOurnal(Journal);
                return RedirectToAction(nameof(Index));
            }
            return View(Journal);
        }
        //Get:Journal/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if(id== null)
            {
                return NotFound();
            }
            var journal = await _context.GetJournal((int)id);
            if(journal == null)
            {
                return NotFound();
            }
            return View(journal);
        }
        //Get:Journal Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var journal = await _context.GetJournal((int)id);
            if(journal == null)
            {
                return NotFound();
            }
            return View(journal);
        }
        //Post:Journal Delete
        public async Task<IActionResult> Delete(int id)
        {
            await _context.DeleteHotel(id);
            return RedirectToAction(nameof(Index));
        }
        private bool journalExists(int id)
        {
            var journal = _context.GetJournal((int)id);
            if(journal == null)
            {
                return false;
            }
            return true;
        }
    }
}
