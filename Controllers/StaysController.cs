using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kanoo.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kanoo.Controllers
{
    public class StaysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Stays
        public async Task<IActionResult> Index()
        {
              return _context.Stays != null ? 
                          View(await _context.Stays.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Stays'  is null.");
        }

        // GET: Stays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Stays == null)
            {
                return NotFound();
            }

            var stay = await _context.Stays
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stay == null)
            {
                return NotFound();
            }

            return View(stay);
        }

        // GET: Stays/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["RegionId"] = new SelectList(_context.Destinations, "Id", "Id");
            return View();
        }

        // POST: Stays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,DestinationName,RegionId,HotelName,StartDate,EndDate,Rooms,Adults,Children,PricePerDay")] Stay stay)
        {
            if (ModelState.IsValid)
            {
                PopulateSqlTable.PopulateStayTable(_context, stay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["RegionId"] = new SelectList(_context.Destinations, "Id", "Id");
            return View(stay);
        }

        // GET: Stays/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Stays == null)
            {
                return NotFound();
            }

            var stay = await _context.Stays.FindAsync(id);
            if (stay == null)
            {
                return NotFound();
            }

            return View(stay);
        }

        // POST: Stays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DestinationName,StartDate,EndDate,Rooms,Adults,Children,PricePerDay")] Stay stay)
        {
            if (id != stay.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StayExists(stay.Id))
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

            return View(stay);
        }

        // GET: Stays/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Stays == null)
            {
                return NotFound();
            }

            var stay = await _context.Stays
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stay == null)
            {
                return NotFound();
            }

            return View(stay);
        }

        // POST: Stays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Stays == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Stays'  is null.");
            }
            var stay = await _context.Stays.FindAsync(id);
            if (stay != null)
            {
                _context.Stays.Remove(stay);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StayExists(int id)
        {
          return (_context.Stays?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
