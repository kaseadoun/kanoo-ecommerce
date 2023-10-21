using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kanoo.Models;
using Newtonsoft.Json;
using System.Data;
using System.ComponentModel;

namespace Kanoo.Controllers
{
    // !! THIS IS A TEMPORARY MVC FOR TESTING THE API CONNECTIONS !!
    public class ApisController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly HttpClient _httpClient;

        public ApisController(ApplicationDbContext context)
        {
            _context = context;
            _httpClient = new HttpClient();
        }

        public async Task<IActionResult> Index()
        {
            return _context.Api != null ? 
                          View(await _context.Api.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Api'  is null.");
        }

        // GET: Apis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Api == null)
            {
                return NotFound();
            }

            var api = await _context.Api
                .FirstOrDefaultAsync(m => m.id == id);
            if (api == null)
            {
                return NotFound();
            }

            return View(api);
        }

        // Delete the other Create() generated from scaffolding
        // Delete the form inside Create.cshtml in Views
        // This function will create the data for us
        public IActionResult Create()
        {
            JsonToSqlTable.PopulateApiTable(_context, _httpClient);
            return View();
        }

        // GET: Apis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Api == null)
            {
                return NotFound();
            }

            var api = await _context.Api.FindAsync(id);
            if (api == null)
            {
                return NotFound();
            }
            return View(api);
        }

        // POST: Apis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,year,month,day,hour,minute,seconds,milliSeconds,dateTime,date,time,timeZone,dayOfWeek,dstActive")] Api api)
        {
            if (id != api.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(api);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApiExists(api.id))
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
            return View(api);
        }

        // GET: Apis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Api == null)
            {
                return NotFound();
            }

            var api = await _context.Api
                .FirstOrDefaultAsync(m => m.id == id);
            if (api == null)
            {
                return NotFound();
            }

            return View(api);
        }

        // POST: Apis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Api == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Api'  is null.");
            }
            var api = await _context.Api.FindAsync(id);
            if (api != null)
            {
                _context.Api.Remove(api);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApiExists(int id)
        {
            return (_context.Api?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
