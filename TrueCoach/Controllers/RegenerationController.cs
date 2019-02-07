using Microsoft.AspNetCore.Http;
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
    public class RegenerationController : Controller
    {
        private readonly IRegeneration _context;

        public RegenerationController(IRegeneration context)
        {
            _context = context;
        }
        

        //Get:Regeneration
        public IActionResult Regeneration(string UserName)
        {
            if (UserName == null)
            {
                return RedirectToAction("Index", "User");
            }

            else
            {
                ViewBag.Status = "Welcome ";
              

            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Index(string RegenerationSteps)
        {
            var regeneration = await _context.GetRegenerations();

            if (!string.IsNullOrEmpty(RegenerationSteps))
            {
                regeneration = regeneration.Where(Regeneration => Regeneration.RegenerationSteps.ToLower().Contains(RegenerationSteps.ToLower()));
                regeneration = regeneration.OrderByDescending(r => r.RegenerationSteps);
            }
            return View(regeneration);
        }

        //Get Regeneration Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var regeneration = await _context.GetRegeneration((int)id);
            if (regeneration == null)
            {
                return NotFound();
            }
            return View(regeneration);
        }

        //Get: Create regeneration
        public IActionResult Create()
        {
            return View();
        }

        //[ValidateAntiForgeryToken]
        //Post:Regeneration
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID,RegenerationSteps")]Regeneration regeneration)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateRegeneration(regeneration);
                return RedirectToAction(nameof(Index));
            }
            return View(regeneration);
        }

        //Get:Regeneration/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var regeneration = await _context.GetRegeneration((int)id);
            if (regeneration == null)
            {
                return NotFound();
            }
            return View(regeneration);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("ID,RegenerationSteps")]Regeneration regeneration)
        {
            if (id != regeneration.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateRegeneration(regeneration);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegenerationExists(regeneration.ID))
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
            return View(regeneration);

        }

        //Get:Regeneration Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var regeneration = await _context.GetRegeneration((int)id);
            if (regeneration == null)
            {
                return NotFound();
            }
            return View(regeneration);
        }

        //Post:Regeneration Delete
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.DeleteRegeneration(id);
            return RedirectToAction(nameof(Index));
        }
        
        private bool RegenerationExists(int id)
        {
            var regeneration = _context.GetRegeneration((int)id);
            if (regeneration == null)
            {
                return false;
            }
            return true;
        }
    }
}
