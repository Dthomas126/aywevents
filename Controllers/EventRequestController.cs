using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aywevents.Data;
using aywevents.Models;

namespace aywevents.Controllers
{
    public class EventRequestController : Controller
    {
        private readonly EventContext _context;

        public EventRequestController(EventContext context)
        {
            _context = context;
        }

        // GET: EventRequest
        public async Task<IActionResult> Index()
        {
            return View(await _context.EventRequest.ToListAsync());
        }

        // GET: EventRequest/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventRequest = await _context.EventRequest
                .FirstOrDefaultAsync(m => m.ID == id);
            if (eventRequest == null)
            {
                return NotFound();
            }

            return View(eventRequest);
        }

        // GET: EventRequest/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EventRequest/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,Phone,Details,Service,Location,Date")] EventRequest eventRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(eventRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(eventRequest);
        }

        // GET: EventRequest/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventRequest = await _context.EventRequest.FindAsync(id);
            if (eventRequest == null)
            {
                return NotFound();
            }
            return View(eventRequest);
        }

        // POST: EventRequest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,Phone,Details,Service,Location,Date")] EventRequest eventRequest)
        {
            if (id != eventRequest.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(eventRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventRequestExists(eventRequest.ID))
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
            return View(eventRequest);
        }

        // GET: EventRequest/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventRequest = await _context.EventRequest
                .FirstOrDefaultAsync(m => m.ID == id);
            if (eventRequest == null)
            {
                return NotFound();
            }

            return View(eventRequest);
        }

        // POST: EventRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var eventRequest = await _context.EventRequest.FindAsync(id);
            _context.EventRequest.Remove(eventRequest);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventRequestExists(int id)
        {
            return _context.EventRequest.Any(e => e.ID == id);
        }
    }
}
