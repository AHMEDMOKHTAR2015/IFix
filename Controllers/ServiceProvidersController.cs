using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IFix.Data;
using IFix.Models;

namespace IFix.Controllers
{
    public class ServiceProvidersController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ServiceProvidersController()
        {
            _context = new ApplicationDBContext();
        }

        // GET: ServiceProviders
        public async Task<IActionResult> Index()
        {
            return View(await _context.ServicesProviders.ToListAsync());
        }

        // GET: ServiceProviders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProviders = await _context.ServicesProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceProviders == null)
            {
                return NotFound();
            }

            return View(serviceProviders);
        }

        // GET: ServiceProviders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ServiceProviders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CenterId,ServiceRequestId,Name,PhoneNumber,Email,Address,Type")] ServiceProviders serviceProviders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(serviceProviders);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(serviceProviders);
        }

        // GET: ServiceProviders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProviders = await _context.ServicesProviders.FindAsync(id);
            if (serviceProviders == null)
            {
                return NotFound();
            }
            return View(serviceProviders);
        }

        // POST: ServiceProviders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CenterId,ServiceRequestId,Name,PhoneNumber,Email,Address,Type")] ServiceProviders serviceProviders)
        {
            if (id != serviceProviders.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(serviceProviders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceProvidersExists(serviceProviders.Id))
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
            return View(serviceProviders);
        }

        // GET: ServiceProviders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var serviceProviders = await _context.ServicesProviders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (serviceProviders == null)
            {
                return NotFound();
            }

            return View(serviceProviders);
        }

        // POST: ServiceProviders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceProviders = await _context.ServicesProviders.FindAsync(id);
            if (serviceProviders != null)
            {
                _context.ServicesProviders.Remove(serviceProviders);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceProvidersExists(int id)
        {
            return _context.ServicesProviders.Any(e => e.Id == id);
        }
    }
}
