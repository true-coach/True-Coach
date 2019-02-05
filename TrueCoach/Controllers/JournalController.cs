using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrueCoach.Data;
using TrueCoach.Models;
using TrueCoach.Models.Interfaces;

namespace TrueCoach.Controllers
{
    public class JournalController:Controller
    {
        private readonly IJournal _context;

            public JournalController(IJournal context)
        {
            _context = context;
        }

        //Get:Journal

        public async Task<IActionResult> Index(string Entry)
        {
            var journal = await _context.GetJournal();

            if (!string.IsNullOrEmpty(Entry))
            {
                journal = journal.Where(Journal => Journal.Entry.ToLower().Contains(Entry.ToLower()));
                journal = journal.OrderByDescending(j => j.Entry);
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
            return View(journal);
        }

        //Get: Create journal

            public IActionResult create()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        //Post:Journal
        public async Task<IActionResult> Create([Bind("ID,Entry")]Journal journal)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateJournal(journal);
                return RedirectToAction(nameof(Index));
            }
            return View(journal);
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

        //Get Update
        [HttpPost]

        [ValidateAntiForgeryToken]

        public async Task<IActionResult>Edit(int id,[Bind("ID,Entry")]Journal journal)
        {
             if(id != journal.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateJournal(journal);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JournalExists(journal.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
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
            await _context.DeleteJournal(id);
            return RedirectToAction(nameof(Index));
        }
        private bool JournalExists(int id)
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
