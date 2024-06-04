using Spells.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IActionResult> Index()
        {
           
            var dados = await _context.Spell.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Spell spells)
        {
            if (ModelState.IsValid)
            {
                _context.Spell.Add(spells);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(spells);
        }
    }
}
