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
    public class TravelAdvisorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _httpClient;

        public TravelAdvisorsController(ApplicationDbContext context)
        {
            _context = context;
            _httpClient = new HttpClient();
        }

        // GET: TravelAdvisors
        public async Task<IActionResult> Index()
        {
              return _context.TravelAdvisor != null ? 
                          View(await _context.TravelAdvisor.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.TravelAdvisor'  is null.");
        }

        // GET: TravelAdvisors/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || _context.TravelAdvisor == null)
            {
                return NotFound();
            }

            var travelAdvisor = await _context.TravelAdvisor
                .FirstOrDefaultAsync(m => m.TravelAdvisorId == id);
            if (travelAdvisor == null)
            {
                return NotFound();
            }

            return View(travelAdvisor);
        }

        // GET: TravelAdvisors/Create
        public IActionResult Create()
        {
            JsonToSqlTable.PopulateTravelTable(_context, _httpClient);
            return View();
        }

        // POST: TravelAdvisors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TravelAdvisorId,Category,Description,Address,ImageUrl")] TravelAdvisor travelAdvisor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(travelAdvisor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(travelAdvisor);
        }

        // GET: TravelAdvisors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TravelAdvisor == null)
            {
                return NotFound();
            }

            var travelAdvisor = await _context.TravelAdvisor.FindAsync(id);
            if (travelAdvisor == null)
            {
                return NotFound();
            }
            return View(travelAdvisor);
        }

        // POST: TravelAdvisors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TravelAdvisorId,Category,Description,Address,ImageUrl")] TravelAdvisor travelAdvisor)
        {
            if (id != travelAdvisor.TravelAdvisorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(travelAdvisor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TravelAdvisorExists(travelAdvisor.TravelAdvisorId))
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
            return View(travelAdvisor);
        }

        // GET: TravelAdvisors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TravelAdvisor == null)
            {
                return NotFound();
            }

            var travelAdvisor = await _context.TravelAdvisor
                .FirstOrDefaultAsync(m => m.TravelAdvisorId == id);
            if (travelAdvisor == null)
            {
                return NotFound();
            }

            return View(travelAdvisor);
        }

        // POST: TravelAdvisors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TravelAdvisor == null)
            {
                return Problem("Entity set 'ApplicationDbContext.TravelAdvisor'  is null.");
            }
            var travelAdvisor = await _context.TravelAdvisor.FindAsync(id);
            if (travelAdvisor != null)
            {
                _context.TravelAdvisor.Remove(travelAdvisor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TravelAdvisorExists(int id)
        {
          return (_context.TravelAdvisor?.Any(e => e.TravelAdvisorId == id)).GetValueOrDefault();
        }
    }
}
