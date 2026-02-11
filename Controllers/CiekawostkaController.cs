using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using frostpunk2_ciekawostki.Data;
using frostpunk2_ciekawostki.Models;

namespace frostpunk2_ciekawostki.Controllers
{
    public class CiekawostkaController : Controller
    {
        private readonly FrostpunkContext _context;

        public CiekawostkaController(FrostpunkContext context)
        {
            _context = context;
        }

        // GET: Ciekawostka
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ciekawostki.ToListAsync());
        }

        // GET: Ciekawostka/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciekawostka = await _context.Ciekawostki
                .FirstOrDefaultAsync(m => m.CiekawostkaId == id);
            if (ciekawostka == null)
            {
                return NotFound();
            }

            return View(ciekawostka);
        }

        // GET: Ciekawostka/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ciekawostka/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CiekawostkaId,Tytul,Opis,ZdjeciaURL")] Ciekawostka ciekawostka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciekawostka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ciekawostka);
        }

        // GET: Ciekawostka/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciekawostka = await _context.Ciekawostki.FindAsync(id);
            if (ciekawostka == null)
            {
                return NotFound();
            }
            return View(ciekawostka);
        }

        // POST: Ciekawostka/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CiekawostkaId,Tytul,Opis,ZdjeciaURL")] Ciekawostka ciekawostka)
        {
            if (id != ciekawostka.CiekawostkaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciekawostka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CiekawostkaExists(ciekawostka.CiekawostkaId))
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
            return View(ciekawostka);
        }

        // GET: Ciekawostka/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciekawostka = await _context.Ciekawostki
                .FirstOrDefaultAsync(m => m.CiekawostkaId == id);
            if (ciekawostka == null)
            {
                return NotFound();
            }

            return View(ciekawostka);
        }

        // POST: Ciekawostka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ciekawostka = await _context.Ciekawostki.FindAsync(id);
            if (ciekawostka != null)
            {
                _context.Ciekawostki.Remove(ciekawostka);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CiekawostkaExists(int id)
        {
            return _context.Ciekawostki.Any(e => e.CiekawostkaId == id);
        }
    }
}
