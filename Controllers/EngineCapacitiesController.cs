using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRepair.Data;
using CarRepair.Models;

namespace CarRepair.Controllers
{
    public class EngineCapacitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EngineCapacitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EngineCapacities
        public async Task<IActionResult> Index()
        {
              return View(await _context.EngineCapacity.ToListAsync());
        }

        // GET: EngineCapacities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EngineCapacity == null)
            {
                return NotFound();
            }

            var engineCapacity = await _context.EngineCapacity
                .FirstOrDefaultAsync(m => m.Id == id);
            if (engineCapacity == null)
            {
                return NotFound();
            }

            return View(engineCapacity);
        }

        // GET: EngineCapacities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EngineCapacities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Capacity")] EngineCapacity engineCapacity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(engineCapacity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(engineCapacity);
        }

        // GET: EngineCapacities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EngineCapacity == null)
            {
                return NotFound();
            }

            var engineCapacity = await _context.EngineCapacity.FindAsync(id);
            if (engineCapacity == null)
            {
                return NotFound();
            }
            return View(engineCapacity);
        }

        // POST: EngineCapacities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Capacity")] EngineCapacity engineCapacity)
        {
            if (id != engineCapacity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(engineCapacity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EngineCapacityExists(engineCapacity.Id))
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
            return View(engineCapacity);
        }

        // GET: EngineCapacities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EngineCapacity == null)
            {
                return NotFound();
            }

            var engineCapacity = await _context.EngineCapacity
                .FirstOrDefaultAsync(m => m.Id == id);
            if (engineCapacity == null)
            {
                return NotFound();
            }

            return View(engineCapacity);
        }

        // POST: EngineCapacities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EngineCapacity == null)
            {
                return Problem("Entity set 'ApplicationDbContext.EngineCapacity'  is null.");
            }
            var engineCapacity = await _context.EngineCapacity.FindAsync(id);
            if (engineCapacity != null)
            {
                _context.EngineCapacity.Remove(engineCapacity);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EngineCapacityExists(int id)
        {
          return _context.EngineCapacity.Any(e => e.Id == id);
        }
    }
}
