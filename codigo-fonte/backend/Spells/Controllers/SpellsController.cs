using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Spells.Models;
using spellScrollBackend.Models;

namespace Spells.Controllers
{
    public class SpellsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpellsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Spells
        public async Task<IActionResult> Index()
        {
              return _context.Spell != null ? 
                          View(await _context.Spell.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Spell'  is null.");
        }

        // GET: Spells/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Spell == null)
            {
                return NotFound();
            }

            var spell = await _context.Spell
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spell == null)
            {
                return NotFound();
            }

            return View(spell);
        }

        // GET: Spells/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spells/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Classes,Concentration,Description,Duration,Level,Material,Reach,Ritual,School,Somatic,SpellName,Time,Verbal")] Spell spell)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spell);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spell);
        }

        // GET: Spells/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Spell == null)
            {
                return NotFound();
            }

            var spell = await _context.Spell.FindAsync(id);
            if (spell == null)
            {
                return NotFound();
            }
            return View(spell);
        }

        // POST: Spells/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Classes,Concentration,Description,Duration,Level,Material,Reach,Ritual,School,Somatic,SpellName,Time,Verbal")] Spell spell)
        {
            if (id != spell.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spell);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpellExists(spell.Id))
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
            return View(spell);
        }

        // GET: Spells/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Spell == null)
            {
                return NotFound();
            }

            var spell = await _context.Spell
                .FirstOrDefaultAsync(m => m.Id == id);
            if (spell == null)
            {
                return NotFound();
            }

            return View(spell);
        }

        // POST: Spells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Spell == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Spell'  is null.");
            }
            var spell = await _context.Spell.FindAsync(id);
            if (spell != null)
            {
                _context.Spell.Remove(spell);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpellExists(string id)
        {
          return (_context.Spell?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
