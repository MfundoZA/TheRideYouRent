using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TheRideYouRent.Data;
using TheRideYouRent.Models;

namespace TheRideYouRent.Controllers
{
    public class ReturnsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReturnsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Returns
        public async Task<IActionResult> Index()
        {
            return View(await _context.Return.ToListAsync());
        }

        // GET: Returns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @return = await _context.Return
                .FirstOrDefaultAsync(m => m.returnId == id);
            if (@return == null)
            {
                return NotFound();
            }

            return View(@return);
        }

        // GET: Returns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Returns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("returnId,rentalId,returnDate,fine")] Return @return)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@return);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@return);
        }

        // GET: Returns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @return = await _context.Return.FindAsync(id);
            if (@return == null)
            {
                return NotFound();
            }
            return View(@return);
        }

        // POST: Returns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("returnId,rentalId,returnDate,fine")] Return @return)
        {
            if (id != @return.returnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@return);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReturnExists(@return.returnId))
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
            return View(@return);
        }

        // GET: Returns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @return = await _context.Return
                .FirstOrDefaultAsync(m => m.returnId == id);
            if (@return == null)
            {
                return NotFound();
            }

            return View(@return);
        }

        // POST: Returns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @return = await _context.Return.FindAsync(id);
            _context.Return.Remove(@return);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReturnExists(int id)
        {
            return _context.Return.Any(e => e.returnId == id);
        }
    }
}
