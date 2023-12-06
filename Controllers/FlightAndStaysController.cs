using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kanoo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis;

namespace Kanoo.Controllers
{
    public class FlightAndStaysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlightAndStaysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FlightAndStays
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.FlightAndStays.Include(f => f.DiscountDepartment).Include(f => f.FlightDepartment).Include(f => f.StayDepartment);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FlightAndStays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FlightAndStays == null)
            {
                return NotFound();
            }

            var flightAndStay = await _context.FlightAndStays
                .Include(f => f.DiscountDepartment)
                .Include(f => f.FlightDepartment)
                .Include(f => f.StayDepartment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightAndStay == null)
            {
                return NotFound();
            }

            return View(flightAndStay);
        }

        // GET: FlightAndStays/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Description");
            ViewData["FlightId"] = new SelectList(_context.Flights, "DestinationName", "DestinationName");
            ViewData["StayId"] = new SelectList(_context.Stays, "DestinationName", "DestinationName");

            var stayRegionIds = _context.Stays.Select(s => s.RegionId).Distinct();
            ViewData["To"] = new SelectList(_context.Destinations.Where(d => stayRegionIds.Contains(d.Id)), "Id", "City");

            return View();
        }

        // POST: FlightAndStays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,FlightId,StayId,DiscountId,From,To,StartDate,EndDate")] FlightAndStay flightAndStay)
        {
            if (ModelState.IsValid)
            {
                var discount = _context.Discounts.Where(d => flightAndStay.DiscountId == d.Id).Select(d => d.DiscountAmount).ToArray();

                var join = _context.Stays.Join(
                    _context.Flights,
                    stayDestination => stayDestination.DestinationName,
                    flightDestionation => flightDestionation.ArrivalAirport.DestinationName,
                    (s, f) => new
                    {
                        FlightId = f.Id,
                        StayId = s.Id,
                        DiscountId = flightAndStay.DiscountId,
                        From = f.From,
                        To = f.To,
                        StartDate = s.StartDate,
                        EndDate = s.EndDate,
                        Price = (s.PricePerDay + f.Price) - ((s.PricePerDay + f.Price) * (decimal)discount[0])
                    }
                ).ToArray();

                for (var i = 0; i < join.Length; i++)
                {
                    FlightAndStay newBundle = new FlightAndStay
                    {
                        FlightId = join[i].FlightId,
                        StayId = join[i].StayId,
                        DiscountId = join[i].DiscountId,
                        From = join[i].From,
                        To = join[i].To,
                        StartDate = join[i].StartDate,
                        EndDate = join[i].EndDate,
                        Price = join[i].Price
                    };

                    _context.Add(newBundle);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            var stayRegionIds = _context.Stays.Select(s => s.RegionId).Distinct();
            ViewData["To"] = new SelectList(_context.Destinations.Where(d => stayRegionIds.Contains(d.Id)), "Id", "City");
            
            return View(flightAndStay);
        }

        // GET: FlightAndStays/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FlightAndStays == null)
            {
                return NotFound();
            }

            var flightAndStay = await _context.FlightAndStays.FindAsync(id);
            if (flightAndStay == null)
            {
                return NotFound();
            }
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Description", flightAndStay.DiscountId);
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Id", flightAndStay.FlightId);
            ViewData["StayId"] = new SelectList(_context.Stays, "Id", "Id", flightAndStay.StayId);

            var stayRegionIds = _context.Stays.Select(s => s.RegionId).Distinct();
            ViewData["To"] = new SelectList(_context.Destinations.Where(d => stayRegionIds.Contains(d.Id)), "Id", "City");
            return View(flightAndStay);
        }

        // POST: FlightAndStays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FlightId,StayId,DiscountId,From,To,StartDate,EndDate")] FlightAndStay flightAndStay)
        {
            if (id != flightAndStay.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flightAndStay);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightAndStayExists(flightAndStay.Id))
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
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Description", flightAndStay.DiscountId);
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Id", flightAndStay.FlightId);
            ViewData["StayId"] = new SelectList(_context.Stays, "Id", "Id", flightAndStay.StayId);
            var stayRegionIds = _context.Stays.Select(s => s.RegionId).Distinct();
            ViewData["To"] = new SelectList(_context.Destinations.Where(d => stayRegionIds.Contains(d.Id)), "Id", "City");
            return View(flightAndStay);
        }

        // GET: FlightAndStays/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FlightAndStays == null)
            {
                return NotFound();
            }

            var flightAndStay = await _context.FlightAndStays
                .Include(f => f.DiscountDepartment)
                .Include(f => f.FlightDepartment)
                .Include(f => f.StayDepartment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flightAndStay == null)
            {
                return NotFound();
            }

            return View(flightAndStay);
        }

        // POST: FlightAndStays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.FlightAndStays == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FlightAndStays'  is null.");
            }
            var flightAndStay = await _context.FlightAndStays.FindAsync(id);
            if (flightAndStay != null)
            {
                _context.FlightAndStays.Remove(flightAndStay);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightAndStayExists(int id)
        {
            return (_context.FlightAndStays?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
