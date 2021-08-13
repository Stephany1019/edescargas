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
    public class USUARIOController : Controller
    {
        private readonly DBContext _context;

        public USUARIOController(DBContext context)
        {
            _context = context;
        }

        // GET: USUARIOs
        public async Task<IActionResult> Index()
        {
            return View(await _context.USUARIO.ToListAsync());
        }

        // GET: USUARIOs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSUARIO = await _context.USUARIO
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (uSUARIO == null)
            {
                return NotFound();
            }

            return View(uSUARIO);
        }

        // GET: USUARIOs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: USUARIOs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_usuario,Usuario,Contrasena,Email,Pregunta_seguridad,Respuesta_seguridad")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {

                    _context.Add(uSUARIO);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                
            }
            return View(uSUARIO);
        }

        // GET: USUARIOs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSUARIO = await _context.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return NotFound();
            }
            return View(uSUARIO);
        }

        // POST: USUARIOs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_usuario,Usuario,Contrasena,Email,Pregunta_seguridad,Respuesta_seguridad")] USUARIO uSUARIO)
        {
            if (id != uSUARIO.Id_usuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(uSUARIO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!USUARIOExists(uSUARIO.Id_usuario))
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
            return View(uSUARIO);
        }

        // GET: USUARIOs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSUARIO = await _context.USUARIO
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (uSUARIO == null)
            {
                return NotFound();
            }

            return View(uSUARIO);
        }

        // POST: USUARIOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var uSUARIO = await _context.USUARIO.FindAsync(id);
            _context.USUARIO.Remove(uSUARIO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool USUARIOExists(int id)
        {
            return _context.USUARIO.Any(e => e.Id_usuario == id);
        }


        public async Task<IActionResult> lista_usuarios()
        {
            return View(await _context.USUARIO.ToListAsync());
        }
    }
}
