using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal1_desaAppsWeb;
using ProyectoFinal1_desaAppsWeb.Models;

namespace ProyectoFinal1_desaAppsWeb.Controllers
{
    public class AppAdminController : Controller
    {
        private readonly DBContext _context;

        public AppAdminController(DBContext context)
        {
            _context = context;
        }

        // GET: AppAdmin
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppAdmin.ToListAsync());
        }

        // GET: AppAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appAdmin = await _context.AppAdmin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appAdmin == null)
            {
                return NotFound();
            }

            return View(appAdmin);
        }

        // GET: AppAdmin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,qwe")] AppAdmin appAdmin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appAdmin);
        }

        // GET: AppAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appAdmin = await _context.AppAdmin.FindAsync(id);
            if (appAdmin == null)
            {
                return NotFound();
            }
            return View(appAdmin);
        }

        // POST: AppAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,qwe")] AppAdmin appAdmin)
        {
            if (id != appAdmin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppAdminExists(appAdmin.Id))
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
            return View(appAdmin);
        }

        // GET: AppAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appAdmin = await _context.AppAdmin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appAdmin == null)
            {
                return NotFound();
            }

            return View(appAdmin);
        }

        // POST: AppAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appAdmin = await _context.AppAdmin.FindAsync(id);
            _context.AppAdmin.Remove(appAdmin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppAdminExists(int id)
        {
            return _context.AppAdmin.Any(e => e.Id == id);
        }

        public async Task<IActionResult> admin()
        {
            return View("admin");
        }

        public async Task<IActionResult> consecutivos()
        {
            return View("consecutivos");
        }
    }
}
