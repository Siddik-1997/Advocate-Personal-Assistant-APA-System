using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdvocatePersonalAssistantSystem.Models;

namespace AdvocatePersonalAssistantSystem.Controllers
{
    public class CyberLawsController : Controller
    {
        private readonly AppDbContext _context;

        public CyberLawsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CyberLaws
        public async Task<IActionResult> Index(string searchBy, string search)
        {
            if (searchBy == "Law_no")
            {
                return View(await _context.CyberLaw.Where(X => X.Law_no == Int32.Parse(search) || search == null).ToListAsync());
            }
            else
            {
                return View(await _context.CyberLaw.Where(X => X.LawName.StartsWith(search) || search == null).ToListAsync());
            }
        }


        // GET: CyberLaws/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cyberLaw = await _context.CyberLaw
                .FirstOrDefaultAsync(m => m.Law_no == id);
            if (cyberLaw == null)
            {
                return NotFound();
            }

            return View(cyberLaw);
        }

        // GET: CyberLaws/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CyberLaws/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Law_no,LawName,Punishment,LDeails")] CyberLaw cyberLaw)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cyberLaw);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cyberLaw);
        }

        // GET: CyberLaws/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cyberLaw = await _context.CyberLaw.FindAsync(id);
            if (cyberLaw == null)
            {
                return NotFound();
            }
            return View(cyberLaw);
        }

        // POST: CyberLaws/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Law_no,LawName,Punishment,LDeails")] CyberLaw cyberLaw)
        {
            if (id != cyberLaw.Law_no)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cyberLaw);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CyberLawExists(cyberLaw.Law_no))
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
            return View(cyberLaw);
        }

        // GET: CyberLaws/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cyberLaw = await _context.CyberLaw
                .FirstOrDefaultAsync(m => m.Law_no == id);
            if (cyberLaw == null)
            {
                return NotFound();
            }

            return View(cyberLaw);
        }

        // POST: CyberLaws/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cyberLaw = await _context.CyberLaw.FindAsync(id);
            _context.CyberLaw.Remove(cyberLaw);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CyberLawExists(int id)
        {
            return _context.CyberLaw.Any(e => e.Law_no == id);
        }
    }
}
