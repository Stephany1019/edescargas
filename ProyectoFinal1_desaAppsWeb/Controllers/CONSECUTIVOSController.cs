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
    public class CONSECUTIVOSController : Controller
    {
        private readonly DBContext _context;

        public CONSECUTIVOSController(DBContext context)
        {
            _context = context;
        }

        // GET: CONSECUTIVOS
        public async Task<IActionResult> Index()
        {
            return View(await _context.CONSECUTIVOS.ToListAsync());
        }

        // GET: CONSECUTIVOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _cONSECUTIVOS = await _context.CONSECUTIVOS
                .FirstOrDefaultAsync(m => m.Id == id);
            if (_cONSECUTIVOS == null)
            {
                return NotFound();
            }

            return View(_cONSECUTIVOS);
        }

        // GET: CONSECUTIVOS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CONSECUTIVOS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Id_TipoProducto,Consecutivo,Posee_prefijo,Prefijo,Posee_rango,Rango_inicial,Rango_final")] CONSECUTIVOS _cONSECUTIVOS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(_cONSECUTIVOS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_cONSECUTIVOS);
        }

        // GET: CONSECUTIVOS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _cONSECUTIVOS = await _context.CONSECUTIVOS.FindAsync(id);
            if (_cONSECUTIVOS == null)
            {
                return NotFound();
            }
            return View(_cONSECUTIVOS);
        }

        // POST: CONSECUTIVOS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Id_TipoProducto,Consecutivo,Posee_prefijo,Prefijo,Posee_rango,Rango_inicial,Rango_final")] CONSECUTIVOS _cONSECUTIVOS)
        {
            if (id != _cONSECUTIVOS.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_cONSECUTIVOS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CONSECUTIVOSExists(_cONSECUTIVOS.Id))
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
            return View(_cONSECUTIVOS);
        }

        // GET: CONSECUTIVOS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _cONSECUTIVOS = await _context.CONSECUTIVOS
                .FirstOrDefaultAsync(m => m.Id == id);
            if (_cONSECUTIVOS == null)
            {
                return NotFound();
            }

            return View(_cONSECUTIVOS);
        }

        // POST: CONSECUTIVOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var _cONSECUTIVOS = await _context.CONSECUTIVOS.FindAsync(id);
            _context.CONSECUTIVOS.Remove(_cONSECUTIVOS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CONSECUTIVOSExists(int id)
        {
            return _context.CONSECUTIVOS.Any(e => e.Id == id);
        }
    }
}
