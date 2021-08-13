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
    public class LIBROSController : Controller
    {
        private readonly DBContext _context;

        public LIBROSController(DBContext context)
        {
            _context = context;
        }

        // GET: LIBROS
        public async Task<IActionResult> Index()
        {
            return View(await _context.LIBROS.ToListAsync());
        }

        // GET: LIBROS/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIBROS = await _context.LIBROS
                .FirstOrDefaultAsync(m => m.Id_libro == id);
            if (lIBROS == null)
            {
                return NotFound();
            }

            return View(lIBROS);
        }

        // GET: LIBROS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LIBROS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_libro,Nombre_libro,Autor,Idioma,Editorial,Annio_publicacion,Archivo_descarga,Archivo_previsual")] LIBROS lIBROS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lIBROS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lIBROS);
        }

        // GET: LIBROS/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIBROS = await _context.LIBROS.FindAsync(id);
            if (lIBROS == null)
            {
                return NotFound();
            }
            return View(lIBROS);
        }

        // POST: LIBROS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_libro,Nombre_libro,Autor,Idioma,Editorial,Annio_publicacion,Archivo_descarga,Archivo_previsual")] LIBROS lIBROS)
        {
            if (id != lIBROS.Id_libro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lIBROS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LIBROSExists(lIBROS.Id_libro))
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
            return View(lIBROS);
        }

        // GET: LIBROS/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lIBROS = await _context.LIBROS
                .FirstOrDefaultAsync(m => m.Id_libro == id);
            if (lIBROS == null)
            {
                return NotFound();
            }

            return View(lIBROS);
        }

        // POST: LIBROS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lIBROS = await _context.LIBROS.FindAsync(id);
            _context.LIBROS.Remove(lIBROS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LIBROSExists(string id)
        {
            return _context.LIBROS.Any(e => e.Id_libro == id);
        }
    }
}
