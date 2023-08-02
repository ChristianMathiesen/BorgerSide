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
    public class BorgerTipsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BorgerTipsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: BorgerTips
        public async Task<IActionResult> Index()
        {
              return _context.BorgerTip != null ? 
                          View(await _context.BorgerTip.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.BorgerTip'  is null.");
        }

        // GET: BorgerTips/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.BorgerTip == null)
            {
                return NotFound();
            }

            var borgerTip = await _context.BorgerTip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borgerTip == null)
            {
                return NotFound();
            }

            return View(borgerTip);
        }

        // GET: BorgerTips/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BorgerTips/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Navn,Email,Description,CreatedDateTime")] BorgerTip borgerTip)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borgerTip);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(borgerTip);
        }

        // GET: BorgerTips/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.BorgerTip == null)
            {
                return NotFound();
            }

            var borgerTip = await _context.BorgerTip.FindAsync(id);
            if (borgerTip == null)
            {
                return NotFound();
            }
            return View(borgerTip);
        }

        // POST: BorgerTips/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Navn,Email,Description,CreatedDateTime")] BorgerTip borgerTip)
        {
            if (id != borgerTip.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borgerTip);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorgerTipExists(borgerTip.Id))
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
            return View(borgerTip);
        }

        // GET: BorgerTips/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.BorgerTip == null)
            {
                return NotFound();
            }

            var borgerTip = await _context.BorgerTip
                .FirstOrDefaultAsync(m => m.Id == id);
            if (borgerTip == null)
            {
                return NotFound();
            }

            return View(borgerTip);
        }

        // POST: BorgerTips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.BorgerTip == null)
            {
                return Problem("Entity set 'ApplicationDbContext.BorgerTip'  is null.");
            }
            var borgerTip = await _context.BorgerTip.FindAsync(id);
            if (borgerTip != null)
            {
                _context.BorgerTip.Remove(borgerTip);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BorgerTipExists(int id)
        {
          return (_context.BorgerTip?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
