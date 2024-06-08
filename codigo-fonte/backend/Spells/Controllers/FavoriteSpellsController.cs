using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spells.Models;

namespace Spells.Controllers
{
    public class FavoriteSpellsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FavoriteSpellsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FavoriteSpells
        public async Task<IActionResult> Index()
        {
              return _context.FavoriteSpells != null ? 
                          View(await _context.FavoriteSpells.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.FavoriteSpells'  is null.");
        }

        // GET: FavoriteSpells/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FavoriteSpells == null)
            {
                return NotFound();
            }

            var favoriteSpell = await _context.FavoriteSpells
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favoriteSpell == null)
            {
                return NotFound();
            }

            return View(favoriteSpell);
        }

        // GET: FavoriteSpells/Create
        public IActionResult Create()
        {
            ViewData["SpellId"] = new SelectList(_context.Spell, "Id", "SpellName"); // Assuming "SpellName" is the property to display
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,SpellId")] FavoriteSpell favoriteSpell)
        {
            if (ModelState.IsValid)
            {
                _context.Add(favoriteSpell);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpellId"] = new SelectList(_context.Spell, "Id", "SpellName", favoriteSpell.SpellId); // Assuming "SpellName" is the property to display
            return View(favoriteSpell);
        }

        // GET: FavoriteSpells/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FavoriteSpells == null)
            {
                return NotFound();
            }

            var favoriteSpell = await _context.FavoriteSpells.FindAsync(id);
            if (favoriteSpell == null)
            {
                return NotFound();
            }
            return View(favoriteSpell);
        }

        // POST: FavoriteSpells/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,SpellId")] FavoriteSpell favoriteSpell)
        {
            if (id != favoriteSpell.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favoriteSpell);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavoriteSpellExists(favoriteSpell.Id))
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
            return View(favoriteSpell);
        }

        // GET: FavoriteSpells/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FavoriteSpells == null)
            {
                return NotFound();
            }

            var favoriteSpell = await _context.FavoriteSpells
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favoriteSpell == null)
            {
                return NotFound();
            }

            return View(favoriteSpell);
        }

        // POST: FavoriteSpells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FavoriteSpells == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FavoriteSpells'  is null.");
            }
            var favoriteSpell = await _context.FavoriteSpells.FindAsync(id);
            if (favoriteSpell != null)
            {
                _context.FavoriteSpells.Remove(favoriteSpell);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FavoriteSpellExists(int id)
        {
          return (_context.FavoriteSpells?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
