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
    public class CaseProfilesController : Controller
    {
        private readonly AppDbContext _context;

        public CaseProfilesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CaseProfiles
        public async Task<IActionResult> Index(string searchBy,string search)

        {
            if (searchBy == "Case_Id")
            {
                return View(await _context.CaseProfiles.Where(X=>X.Case_Id== Int32.Parse(search) || search==null).ToListAsync());
            }
            else
            {
                return View(await _context.CaseProfiles.Where(X => X.CaseName.StartsWith(search) ||search==null).ToListAsync());
            }
        }

        // GET: CaseProfiles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caseProfile = await _context.CaseProfiles
                .FirstOrDefaultAsync(m => m.Case_Id == id);
            if (caseProfile == null)
            {
                return NotFound();
            }

            return View(caseProfile);
        }

        // GET: CaseProfiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CaseProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Case_Id,CaseName,ClientName,CaseHistory,Plaintiff,Defendant,Phone,Address,Fee,Idate,Hdate")] CaseProfile caseProfile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caseProfile);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caseProfile);
        }

        // GET: CaseProfiles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caseProfile = await _context.CaseProfiles.FindAsync(id);
            if (caseProfile == null)
            {
                return NotFound();
            }
            return View(caseProfile);
        }

        // POST: CaseProfiles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Case_Id,CaseName,ClientName,Plaintiff,Defendant,Phone,Address,Fee,Idate,Hdate")] CaseProfile caseProfile)
        {
            if (id != caseProfile.Case_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caseProfile);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaseProfileExists(caseProfile.Case_Id))
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
            return View(caseProfile);
        }

        // GET: CaseProfiles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caseProfile = await _context.CaseProfiles
                .FirstOrDefaultAsync(m => m.Case_Id == id);
            if (caseProfile == null)
            {
                return NotFound();
            }

            return View(caseProfile);
        }

        // POST: CaseProfiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caseProfile = await _context.CaseProfiles.FindAsync(id);
            _context.CaseProfiles.Remove(caseProfile);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaseProfileExists(int id)
        {
            return _context.CaseProfiles.Any(e => e.Case_Id == id);
        }
    }
}
