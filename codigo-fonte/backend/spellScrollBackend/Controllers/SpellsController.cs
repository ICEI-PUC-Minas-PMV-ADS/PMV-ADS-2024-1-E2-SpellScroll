using app_web_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace spellScrollBackend.Controllers
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

            var dados = await _context.Spells.ToListAsync();

            return View(dados);
        }
    }
}
