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
    public class FlightAndHotelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightAndHotelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FlightAndHotels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FlightAndHotels.Include(f => f.Department);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FlightAndHotels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FlightAndHotels == null)
            {
                return NotFound();
            }

            var flightAndHotel = await _context.FlightAndHotels
                .Include(f => f.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightAndHotel == null)
            {
                return NotFound();
            }

            return View(flightAndHotel);
        }

        // GET: FlightAndHotels/Create
        public IActionResult Create()
        {
            ViewData["TravelServiceId"] = new SelectList(_context.TravelService, "Id", "Description");
            // ViewData["From"] = new SelectList(Enum.GetValues(typeof(Airport)));
            // ViewData["To"] = new SelectList(Enum.GetValues(typeof(Airport)));
            return View();
        }

        // POST: FlightAndHotels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TravelServiceId,From,To,Leave,Return")] FlightAndHotel flightAndHotel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightAndHotel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TravelServiceId"] = new SelectList(_context.TravelService, "Id", "Description", flightAndHotel.TravelServiceId);
            // ViewData["From"] = new SelectList(Enum.GetValues(typeof(Airport)));
            // ViewData["To"] = new SelectList(Enum.GetValues(typeof(Airport)));
            return View(flightAndHotel);
        }

        // GET: FlightAndHotels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FlightAndHotels == null)
            {
                return NotFound();
            }

            var flightAndHotel = await _context.FlightAndHotels.FindAsync(id);
            if (flightAndHotel == null)
            {
                return NotFound();
            }
            ViewData["TravelServiceId"] = new SelectList(_context.TravelService, "Id", "Description", flightAndHotel.TravelServiceId);
            // ViewData["From"] = new SelectList(Enum.GetValues(typeof(Airport)));
            // ViewData["To"] = new SelectList(Enum.GetValues(typeof(Airport)));
            return View(flightAndHotel);
        }

        // POST: FlightAndHotels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TravelServiceId,From,To,Leave,Return")] FlightAndHotel flightAndHotel)
        {
            if (id != flightAndHotel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightAndHotel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightAndHotelExists(flightAndHotel.Id))
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
            ViewData["TravelServiceId"] = new SelectList(_context.TravelService, "Id", "Description", flightAndHotel.TravelServiceId);
            // ViewData["From"] = new SelectList(Enum.GetValues(typeof(Airport)));
            // ViewData["To"] = new SelectList(Enum.GetValues(typeof(Airport)));
            return View(flightAndHotel);
        }

        // GET: FlightAndHotels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FlightAndHotels == null)
            {
                return NotFound();
            }

            var flightAndHotel = await _context.FlightAndHotels
                .Include(f => f.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightAndHotel == null)
            {
                return NotFound();
            }

            return View(flightAndHotel);
        }

        // POST: FlightAndHotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FlightAndHotels == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FlightAndHotels'  is null.");
            }
            var flightAndHotel = await _context.FlightAndHotels.FindAsync(id);
            if (flightAndHotel != null)
            {
                _context.FlightAndHotels.Remove(flightAndHotel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightAndHotelExists(int id)
        {
          return (_context.FlightAndHotels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
