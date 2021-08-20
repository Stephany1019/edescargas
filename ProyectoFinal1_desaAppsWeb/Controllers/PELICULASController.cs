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
    public class PELICULASController : Controller
    {
        private readonly DBContext _context;
        private BITACORA _bitacora = new BITACORA();
        public PELICULASController(DBContext context)
        {
            _context = context;
        }

        // GET: PELICULAS
        public async Task<IActionResult> Index()
        {
            return View(await _context.PELICULAS.ToListAsync());
        }

        // GET: PELICULAS/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _pELICULAS = await _context.PELICULAS
                .FirstOrDefaultAsync(m => m.Id_Pelicula == id);
            if (_pELICULAS == null)
            {
                return NotFound();
            }

            return View(_pELICULAS);
        }

        // GET: PELICULAS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PELICULAS/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Pelicula,Nombre,Annio,Idioma,Actores,Archivo_descarga,Archivo_previsual")] PELICULAS _pELICULAS)
        {
            if (ModelState.IsValid)
            {
                //concatena el prefijo y el consecutivo
                _pELICULAS.Id_Pelicula = obtenerPrefijosLibros() + obtenerConsecutivosLibros();
                _context.Add(_pELICULAS);

                _bitacora.Usuario = Utils.Encriptar(User.ToString());
                _bitacora.Fecha_Hora = DateTime.Now;
                _bitacora.Id_registro = _pELICULAS.Id_Pelicula.ToString();
                _bitacora.Tipo = Utils.Encriptar("1");
                _bitacora.Descripcion = Utils.Encriptar("crea un registro pelicula");
                _bitacora.Registro_detalle = Utils.Encriptar("Create");

                _context.BITACORA.Add(_bitacora);

                //incrementa el consecutivo en la tabla
                actualizarConsecutivosLibros();

                Utils.encryp = false;

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_pELICULAS);
        }

        // GET: PELICULAS/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _pELICULAS = await _context.PELICULAS.FindAsync(id);
            if (_pELICULAS == null)
            {
                return NotFound();
            }
            return View(_pELICULAS);
        }

        // POST: PELICULAS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_Pelicula,Nombre,Annio,Idioma,Actores,Archivo_descarga,Archivo_previsual")] PELICULAS _pELICULAS)
        {
            if (id != _pELICULAS.Id_Pelicula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(_pELICULAS);

                    _bitacora.Usuario = Utils.Encriptar(User.ToString());
                    _bitacora.Fecha_Hora = DateTime.Now;
                    _bitacora.Id_registro = _pELICULAS.Id_Pelicula.ToString();
                    _bitacora.Tipo = Utils.Encriptar("1");
                    _bitacora.Descripcion = Utils.Encriptar("edita un registro pelicula");
                    _bitacora.Registro_detalle = Utils.Encriptar("Edit");

                    _context.BITACORA.Add(_bitacora);
                    Utils.encryp = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PELICULASExists(_pELICULAS.Id_Pelicula))
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
            return View(_pELICULAS);
        }

        // GET: PELICULAS/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _pELICULAS = await _context.PELICULAS
                .FirstOrDefaultAsync(m => m.Id_Pelicula == id);
            if (_pELICULAS == null)
            {
                return NotFound();
            }

            return View(_pELICULAS);
        }

        // POST: PELICULAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var _pELICULAS = await _context.PELICULAS.FindAsync(id);
            _context.PELICULAS.Remove(_pELICULAS);

            _bitacora.Usuario = Utils.Encriptar(User.ToString());
            _bitacora.Fecha_Hora = DateTime.Now;
            _bitacora.Id_registro = _pELICULAS.Id_Pelicula.ToString();
            _bitacora.Tipo = Utils.Encriptar("1");
            _bitacora.Descripcion = Utils.Encriptar("borra un registro pelicula");
            _bitacora.Registro_detalle = Utils.Encriptar("delete");

            _context.BITACORA.Add(_bitacora);
            Utils.encryp = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private string obtenerConsecutivosLibros()
        {
            string result = string.Empty;
            result = (from p in _context.CONSECUTIVOS
                      where p.Id_TipoProducto == 1
                      select p.Consecutivo).FirstOrDefault().ToString();

            return result;
        }

        private string obtenerPrefijosLibros()
        {
            string result = string.Empty;
            var datos = _context.CONSECUTIVOS.FirstOrDefault(a => a.Id_TipoProducto == 1 && a.Posee_prefijo == true);
            if (datos != null)
            {
                return result = datos.Prefijo;
            }
            return string.Empty;
        }

        private void actualizarConsecutivosLibros()
        {
            CONSECUTIVOS result = (from p in _context.CONSECUTIVOS
                                   where p.Id_TipoProducto == 1
                                   select p).SingleOrDefault();

            result.Consecutivo = int.Parse(obtenerConsecutivosLibros()) + 1;
            _context.SaveChanges();
        }

        private bool PELICULASExists(string id)
        {
            return _context.PELICULAS.Any(e => e.Id_Pelicula == id);
        }

        public async Task<IActionResult> busquedaPeliculas()
        {
            return View("busquedaPeliculas");
        }
    }
}
