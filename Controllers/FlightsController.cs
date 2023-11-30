using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kanoo.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kanoo.Controllers
{
    public class FlightsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Flights
        public async Task<IActionResult> Index()
        {
              return _context.Flights != null ? 
                          View(await _context.Flights.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Flights'  is null.");
        }

        // GET: Flights/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // GET: Flights/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["From"] = new SelectList(_context.Airports, "IataCode", "IataCode");
            ViewData["To"] = new SelectList(_context.Airports, "IataCode", "IataCode");
            ViewData["ServiceClass"] = new SelectList(Enum.GetValues(typeof(ServiceClass)));
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("From,To,Arrival,Departure,NumOfAdults,NumOfSeniors,ServiceClass")] Flight flight)
        {
            if (ModelState.IsValid)
            {
                // Make a new object with the parameters in Bind() from the form data, and send the object with those
                // parameters to PopulateFlightTable() to call the API
                PopulateSqlTable.PopulateFlightTable(_context, flight);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Display all of the IataCodes from the database
            ViewData["From"] = new SelectList(_context.Airports, "IataCode", "IataCode");
            ViewData["To"] = new SelectList(_context.Airports, "IataCode", "IataCode");
            // Display all of the service class options from the ServiceClass enum
            ViewData["ServiceClass"] = new SelectList(Enum.GetValues(typeof(ServiceClass)));
            return View(flight);
        }
        
        // GET: Flights/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights.FindAsync(id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: Flights/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,From,To,StartDate,EndDate,Price")] Flight flight)
        {
            if (id != flight.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flight);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightExists(flight.Id))
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

            return View(flight);
        }

        // GET: Flights/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Flights == null)
            {
                return NotFound();
            }

            var flight = await _context.Flights
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flight == null)
            {
                return NotFound();
            }

            return View(flight);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Flights == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Flights'  is null.");
            }
            var flight = await _context.Flights.FindAsync(id);
            if (flight != null)
            {
                _context.Flights.Remove(flight);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightExists(int id)
        {
          return (_context.Flights?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
