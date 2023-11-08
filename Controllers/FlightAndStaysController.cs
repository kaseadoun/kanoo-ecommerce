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
        public IActionResult Create()
        {
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Description");
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Id");
            ViewData["StayId"] = new SelectList(_context.Stays, "Id", "Id");

            return View();
        }

        // POST: FlightAndStays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FlightId,StayId,DiscountId,From,To,StartDate,EndDate")] FlightAndStay flightAndStay)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flightAndStay);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DiscountId"] = new SelectList(_context.Discounts, "Id", "Description", flightAndStay.DiscountId);
            ViewData["FlightId"] = new SelectList(_context.Flights, "Id", "Id", flightAndStay.FlightId);
            ViewData["StayId"] = new SelectList(_context.Stays, "Id", "Id", flightAndStay.StayId);
            return View(flightAndStay);
        }

        // GET: FlightAndStays/Edit/5
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
            return View(flightAndStay);
        }

        // POST: FlightAndStays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
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
            return View(flightAndStay);
        }

        // GET: FlightAndStays/Delete/5
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