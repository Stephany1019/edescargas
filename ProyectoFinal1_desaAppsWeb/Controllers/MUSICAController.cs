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
    public class MUSICAController : Controller
    {
        private readonly DBContext _context;

        public MUSICAController(DBContext context)
        {
            _context = context;
        }

        // GET: MUSICA
        public async Task<IActionResult> Index()
        {
            return View(await _context.MUSICA.ToListAsync());
        }

        // GET: MUSICA/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _mUSICA = await _context.MUSICA
                .FirstOrDefaultAsync(m => m.Id_musica == id);
            if (_mUSICA == null)
            {
                return NotFound();
            }

            return View(_mUSICA);
        }

        // GET: MUSICA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MUSICA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_musica,Nombre_musica,Tipo_interpretacion,Idioma,Pais,Disquera,Nombre_disco,Annio,Archivo_descarga,Archivo_previsual")] MUSICA _mUSICA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(_mUSICA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_mUSICA);
        }

        // GET: MUSICA/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _mUSICA = await _context.MUSICA.FindAsync(id);
            if (_mUSICA == null)
            {
                return NotFound();
            }
            return View(_mUSICA);
        }

        // POST: MUSICA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_musica,Nombre_musica,Tipo_interpretacion,Idioma,Pais,Disquera,Nombre_disco,Annio,Archivo_descarga,Archivo_previsual")] MUSICA _mUSICA)
        {
            if (id != _mUSICA.Id_musica)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_mUSICA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MUSICAExists(_mUSICA.Id_musica))
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
            return View(_mUSICA);
        }

        // GET: MUSICA/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _mUSICA = await _context.MUSICA
                .FirstOrDefaultAsync(m => m.Id_musica == id);
            if (_mUSICA == null)
            {
                return NotFound();
            }

            return View(_mUSICA);
        }

        // POST: MUSICA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var _mUSICA = await _context.MUSICA.FindAsync(id);
            _context.MUSICA.Remove(_mUSICA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MUSICAExists(string id)
        {
            return _context.MUSICA.Any(e => e.Id_musica == id);
        }
    }
}
