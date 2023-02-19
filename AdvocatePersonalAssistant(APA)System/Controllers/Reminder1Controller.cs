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
    public class Reminder1Controller : Controller
    {
        private readonly AppDbContext _context;

        public Reminder1Controller(AppDbContext context)
        {
            _context = context;
        }

        // GET: Reminder1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Reminder1.ToListAsync());
        }

        // GET: Reminder1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminder1 = await _context.Reminder1
                .FirstOrDefaultAsync(m => m.SL_no == id);
            if (reminder1 == null)
            {
                return NotFound();
            }

            return View(reminder1);
        }

        // GET: Reminder1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reminder1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SL_no,Case_Id,Rdate,rms")] Reminder1 reminder1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reminder1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reminder1);
        }

        // GET: Reminder1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminder1 = await _context.Reminder1.FindAsync(id);
            if (reminder1 == null)
            {
                return NotFound();
            }
            return View(reminder1);
        }

        // POST: Reminder1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SL_no,Case_Id,Rdate,rms")] Reminder1 reminder1)
        {
            if (id != reminder1.SL_no)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reminder1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Reminder1Exists(reminder1.SL_no))
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
            return View(reminder1);
        }

        // GET: Reminder1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reminder1 = await _context.Reminder1
                .FirstOrDefaultAsync(m => m.SL_no == id);
            if (reminder1 == null)
            {
                return NotFound();
            }

            return View(reminder1);
        }

        // POST: Reminder1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reminder1 = await _context.Reminder1.FindAsync(id);
            _context.Reminder1.Remove(reminder1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Reminder1Exists(int id)
        {
            return _context.Reminder1.Any(e => e.SL_no == id);
        }
    }
}
