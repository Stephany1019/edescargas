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
    public class BITACORAController : Controller
    {
        private readonly DBContext _context;

        public BITACORAController(DBContext context)
        {
            _context = context;
        }

        // GET: BITACORA
        public async Task<IActionResult> Index()
        {
            Utils.encryp = true;
            return View(await _context.BITACORA.ToListAsync());
        }

        // GET: BITACORA/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _bITACORA = await _context.BITACORA
                .FirstOrDefaultAsync(m => m.Id_Bitacora == id);
            if (_bITACORA == null)
            {
                return NotFound();
            }
            Utils.encryp = true;
            return View(_bITACORA);
        }

        // GET: BITACORA/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BITACORA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Bitacora,Usuario,Fecha_Hora,Id_registro,Tipo,Descripcion,Registro_detalle")] BITACORA _bITACORA)
        {
            if (ModelState.IsValid)
            {
                Utils.encryp = false;
                _bITACORA.Usuario = Utils.Encriptar(_bITACORA.Usuario);
                _bITACORA.Id_registro = Utils.Encriptar(_bITACORA.Id_registro);
                _bITACORA.Tipo = Utils.Encriptar(_bITACORA.Tipo);
                _bITACORA.Descripcion = Utils.Encriptar(_bITACORA.Descripcion);
                _bITACORA.Registro_detalle = Utils.Encriptar(_bITACORA.Registro_detalle);
                Utils.encryp = false;
                _context.Add(_bITACORA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_bITACORA);
        }

        // GET: BITACORA/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _bITACORA = await _context.BITACORA.FindAsync(id);
            if (_bITACORA == null)
            {
                return NotFound();
            }

            return View(_bITACORA);
        }

        // POST: BITACORA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Bitacora,Usuario,Fecha_Hora,Id_registro,Tipo,Descripcion,Registro_detalle")] BITACORA _bITACORA)
        {
            if (id != _bITACORA.Id_Bitacora)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Utils.encryp = true;
                    _context.Update(_bITACORA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BITACORAExists(_bITACORA.Id_Bitacora))
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
            return View(_bITACORA);
        }

        // GET: BITACORA/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _bITACORA = await _context.BITACORA
                .FirstOrDefaultAsync(m => m.Id_Bitacora == id);
            if (_bITACORA == null)
            {
                return NotFound();
            }

            return View(_bITACORA);
        }

        // POST: BITACORA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var _bITACORA = await _context.BITACORA.FindAsync(id);
            _context.BITACORA.Remove(_bITACORA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BITACORAExists(int id)
        {
            return _context.BITACORA.Any(e => e.Id_Bitacora == id);
        }
    }
}
