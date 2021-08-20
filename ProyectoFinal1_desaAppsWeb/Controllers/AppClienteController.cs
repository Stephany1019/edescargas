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
    public class AppClienteController : Controller
    {
        private readonly DBContext _context;

        public AppClienteController(DBContext context)
        {
            _context = context;
        }

        // GET: AppCliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.AppCliente.ToListAsync());
        }

        // GET: AppCliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appCliente = await _context.AppCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appCliente == null)
            {
                return NotFound();
            }

            return View(appCliente);
        }

        // GET: AppCliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AppCliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,qwe")] AppCliente appCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appCliente);
        }

        // GET: AppCliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appCliente = await _context.AppCliente.FindAsync(id);
            if (appCliente == null)
            {
                return NotFound();
            }
            return View(appCliente);
        }

        // POST: AppCliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,qwe")] AppCliente appCliente)
        {
            if (id != appCliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppClienteExists(appCliente.Id))
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
            return View(appCliente);
        }

        // GET: AppCliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appCliente = await _context.AppCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appCliente == null)
            {
                return NotFound();
            }

            return View(appCliente);
        }

        // POST: AppCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appCliente = await _context.AppCliente.FindAsync(id);
            _context.AppCliente.Remove(appCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppClienteExists(int id)
        {
            return _context.AppCliente.Any(e => e.Id == id);
        }
        public async Task<IActionResult> compras()
        {
            return View("compras");
        }
        public async Task<IActionResult> descargas()
        {
            return View("descargas");
        }
        public async Task<IActionResult> busqueda()
        {
            return View("busqueda");
        }

        public async Task<IActionResult> busquedaPeliculas()
        {
            return View("busquedaPeliculas");
        }

        public async Task<IActionResult> busquedaLibros()
        {
            return View("busquedaLibros");
        }

        public async Task<IActionResult> busquedaMusica()
        {
            return View("busquedaMusica");
        }

        public async Task<IActionResult> proximamente()
        {
            return View("proximamente");
        }

    }
}
