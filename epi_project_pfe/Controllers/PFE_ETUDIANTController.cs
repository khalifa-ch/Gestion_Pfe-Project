using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using epi_project_pfe.Data;
using epi_project_pfe.Models;

namespace epi_project_pfe.Controllers
{
    public class PFE_ETUDIANTController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PFE_ETUDIANTController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PFE_ETUDIANT
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PFE_ETUDIANT.Include(p => p.Etudiant).Include(p => p.Pfe);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PFE_ETUDIANT/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PFE_ETUDIANT == null)
            {
                return NotFound();
            }

            var pFE_ETUDIANT = await _context.PFE_ETUDIANT
                .Include(p => p.Etudiant)
                .Include(p => p.Pfe)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pFE_ETUDIANT == null)
            {
                return NotFound();
            }

            return View(pFE_ETUDIANT);
        }

        // GET: PFE_ETUDIANT/Create
        public IActionResult Create()
        {
            ViewData["EtudiantId"] = new SelectList(_context.Etudiant, "Id", "Id");
            ViewData["PfeId"] = new SelectList(_context.PFE, "Id", "Id");
            return View();
        }

        // POST: PFE_ETUDIANT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PfeId,EtudiantId")] PFE_ETUDIANT pFE_ETUDIANT)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pFE_ETUDIANT);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EtudiantId"] = new SelectList(_context.Etudiant, "Id", "Id", pFE_ETUDIANT.EtudiantId);
            ViewData["PfeId"] = new SelectList(_context.PFE, "Id", "Id", pFE_ETUDIANT.PfeId);
            return View(pFE_ETUDIANT);
        }

        // GET: PFE_ETUDIANT/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PFE_ETUDIANT == null)
            {
                return NotFound();
            }

            var pFE_ETUDIANT = await _context.PFE_ETUDIANT.FindAsync(id);
            if (pFE_ETUDIANT == null)
            {
                return NotFound();
            }
            ViewData["EtudiantId"] = new SelectList(_context.Etudiant, "Id", "Id", pFE_ETUDIANT.EtudiantId);
            ViewData["PfeId"] = new SelectList(_context.PFE, "Id", "Id", pFE_ETUDIANT.PfeId);
            return View(pFE_ETUDIANT);
        }

        // POST: PFE_ETUDIANT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PfeId,EtudiantId")] PFE_ETUDIANT pFE_ETUDIANT)
        {
            if (id != pFE_ETUDIANT.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pFE_ETUDIANT);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PFE_ETUDIANTExists(pFE_ETUDIANT.Id))
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
            ViewData["EtudiantId"] = new SelectList(_context.Etudiant, "Id", "Id", pFE_ETUDIANT.EtudiantId);
            ViewData["PfeId"] = new SelectList(_context.PFE, "Id", "Id", pFE_ETUDIANT.PfeId);
            return View(pFE_ETUDIANT);
        }

        // GET: PFE_ETUDIANT/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PFE_ETUDIANT == null)
            {
                return NotFound();
            }

            var pFE_ETUDIANT = await _context.PFE_ETUDIANT
                .Include(p => p.Etudiant)
                .Include(p => p.Pfe)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pFE_ETUDIANT == null)
            {
                return NotFound();
            }

            return View(pFE_ETUDIANT);
        }

        // POST: PFE_ETUDIANT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PFE_ETUDIANT == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PFE_ETUDIANT'  is null.");
            }
            var pFE_ETUDIANT = await _context.PFE_ETUDIANT.FindAsync(id);
            if (pFE_ETUDIANT != null)
            {
                _context.PFE_ETUDIANT.Remove(pFE_ETUDIANT);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PFE_ETUDIANTExists(int id)
        {
          return (_context.PFE_ETUDIANT?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
