using CarRepair.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRepair.Controllers
{
    public class SecondHandController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SecondHandController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Car;
            return View(await applicationDbContext.ToListAsync());
        }
    }
}
