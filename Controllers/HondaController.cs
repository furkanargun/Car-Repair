using CarRepair.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRepair.Controllers
{
    public class HondaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HondaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Model;
            return View(await applicationDbContext.ToListAsync());
        }
    }
}
