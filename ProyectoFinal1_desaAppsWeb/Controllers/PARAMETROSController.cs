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
    public class PARAMETROSController : Controller
    {
        private readonly DBContext _context;

        public PARAMETROSController(DBContext context)
        {
            _context = context;
        }

        // GET: PARAMETROS
        public async Task<IActionResult> Index()
        {
            return View(await _context.PARAMETROS.ToListAsync());
        }

        // GET: PARAMETROS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _pARAMETROS = await _context.PARAMETROS
                .FirstOrDefaultAsync(m => m.Id_Parametro == id);
            if (_pARAMETROS == null)
            {
                return NotFound();
            }

            return View(_pARAMETROS);
        }

        // GET: PARAMETROS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PARAMETROS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Parametro,Ruta_previsual_libros,Ruta_almacen_libros,Ruta_previsual_peliculas,Ruta_almacen_peliculas,Ruta_previsual_musica,Ruta_almacen_musica")] PARAMETROS _pARAMETROS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(_pARAMETROS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_pARAMETROS);
        }

        // GET: PARAMETROS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _pARAMETROS = await _context.PARAMETROS.FindAsync(id);
            if (_pARAMETROS == null)
            {
                return NotFound();
            }
            return View(_pARAMETROS);
        }

        // POST: PARAMETROS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Parametro,Ruta_previsual_libros,Ruta_almacen_libros,Ruta_previsual_peliculas,Ruta_almacen_peliculas,Ruta_previsual_musica,Ruta_almacen_musica")] PARAMETROS _pARAMETROS)
        {
            if (id != _pARAMETROS.Id_Parametro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_pARAMETROS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PARAMETROSExists(_pARAMETROS.Id_Parametro))
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
            return View(_pARAMETROS);
        }

        // GET: PARAMETROS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _pARAMETROS = await _context.PARAMETROS
                .FirstOrDefaultAsync(m => m.Id_Parametro == id);
            if (_pARAMETROS == null)
            {
                return NotFound();
            }

            return View(_pARAMETROS);
        }

        // POST: PARAMETROS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var _pARAMETROS = await _context.PARAMETROS.FindAsync(id);
            _context.PARAMETROS.Remove(_pARAMETROS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PARAMETROSExists(int id)
        {
            return _context.PARAMETROS.Any(e => e.Id_Parametro == id);
        }
    }
}
