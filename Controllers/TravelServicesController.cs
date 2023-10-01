using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kanoo.Models;

namespace Kanoo.Controllers
{
    public class TravelServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TravelServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TravelServices
        public async Task<IActionResult> Index()
        {
              return _context.TravelService != null ? 
                          View(await _context.TravelService.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TravelService'  is null.");
        }

        // GET: TravelServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TravelService == null)
            {
                return NotFound();
            }

            var travelService = await _context.TravelService
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelService == null)
            {
                return NotFound();
            }

            return View(travelService);
        }

        // GET: TravelServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TravelServices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] TravelService travelService)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelService);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelService);
        }

        // GET: TravelServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TravelService == null)
            {
                return NotFound();
            }

            var travelService = await _context.TravelService.FindAsync(id);
            if (travelService == null)
            {
                return NotFound();
            }
            return View(travelService);
        }

        // POST: TravelServices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] TravelService travelService)
        {
            if (id != travelService.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelService);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelServiceExists(travelService.Id))
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
            return View(travelService);
        }

        // GET: TravelServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TravelService == null)
            {
                return NotFound();
            }

            var travelService = await _context.TravelService
                .FirstOrDefaultAsync(m => m.Id == id);
            if (travelService == null)
            {
                return NotFound();
            }

            return View(travelService);
        }

        // POST: TravelServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TravelService == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TravelService'  is null.");
            }
            var travelService = await _context.TravelService.FindAsync(id);
            if (travelService != null)
            {
                _context.TravelService.Remove(travelService);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelServiceExists(int id)
        {
          return (_context.TravelService?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
