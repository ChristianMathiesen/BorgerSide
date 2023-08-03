using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BorgerSide.Data;
using BorgerSide.Models;

namespace BorgerSide.Controllers
{
    public class OlietankFormularsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OlietankFormularsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OlietankFormulars
        public async Task<IActionResult> Index()
        {
              return _context.OlietankFormular != null ? 
                          View(await _context.OlietankFormular.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.OlietankFormular'  is null.");
        }

        // GET: OlietankFormulars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OlietankFormular == null)
            {
                return NotFound();
            }

            var olietankFormular = await _context.OlietankFormular
                .FirstOrDefaultAsync(m => m.Id == id);
            if (olietankFormular == null)
            {
                return NotFound();
            }

            return View(olietankFormular);
        }

        // GET: OlietankFormulars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OlietankFormulars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Navn,Email,Ejer,Forurening,CreatedDateTime")] OlietankFormular olietankFormular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(olietankFormular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(olietankFormular);
        }

        // GET: OlietankFormulars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OlietankFormular == null)
            {
                return NotFound();
            }

            var olietankFormular = await _context.OlietankFormular.FindAsync(id);
            if (olietankFormular == null)
            {
                return NotFound();
            }
            return View(olietankFormular);
        }

        // POST: OlietankFormulars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Navn,Email,Ejer,Forurening,CreatedDateTime")] OlietankFormular olietankFormular)
        {
            if (id != olietankFormular.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(olietankFormular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OlietankFormularExists(olietankFormular.Id))
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
            return View(olietankFormular);
        }

        // GET: OlietankFormulars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OlietankFormular == null)
            {
                return NotFound();
            }

            var olietankFormular = await _context.OlietankFormular
                .FirstOrDefaultAsync(m => m.Id == id);
            if (olietankFormular == null)
            {
                return NotFound();
            }

            return View(olietankFormular);
        }

        // POST: OlietankFormulars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OlietankFormular == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OlietankFormular'  is null.");
            }
            var olietankFormular = await _context.OlietankFormular.FindAsync(id);
            if (olietankFormular != null)
            {
                _context.OlietankFormular.Remove(olietankFormular);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OlietankFormularExists(int id)
        {
          return (_context.OlietankFormular?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
