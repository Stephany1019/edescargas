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
        private BITACORA _bitacora = new BITACORA();
        private CONSECUTIVOS _consecutivos = new CONSECUTIVOS();
        public LIBROSController(DBContext context)
        {
            _context = context;
        }

        // GET: LIBROS
        public async Task<IActionResult> Index()
        {
            Utils.encryp = true;
            return View(await _context.LIBROS.ToListAsync());
        }

        // GET: LIBROS/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _lIBROS = await _context.LIBROS
                .FirstOrDefaultAsync(m => m.Id_libro == id);
            if (_lIBROS == null)
            {
                return NotFound();
            }
            Utils.encryp = true;
            return View(_lIBROS);
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
        public async Task<IActionResult> Create([Bind("Id_libro,Nombre_libro,Autor,Idioma,Editorial,Annio_publicacion,Archivo_descarga,Archivo_previsual")] LIBROS _lIBROS)
        {
            if (ModelState.IsValid)
            {
                Utils.encryp = false;
                //concatena el prefijo y el consecutivo
                _lIBROS.Id_libro = obtenerPrefijosLibros() + obtenerConsecutivosLibros();
                _lIBROS.Id_libro = Utils.Encriptar(_lIBROS.Id_libro);
                _lIBROS.Nombre_libro       =   Utils.Encriptar(_lIBROS.Nombre_libro);
                _lIBROS.Autor              =   Utils.Encriptar(_lIBROS.Autor);
                _lIBROS.Idioma             =   Utils.Encriptar(_lIBROS.Idioma);
                _lIBROS.Editorial          =   Utils.Encriptar(_lIBROS.Editorial);
                //_lIBROS.Annio_publicacion  =   Utils.Encriptar(_lIBROS.Annio_publicacion);
                _lIBROS.Archivo_descarga   =   Utils.Encriptar(_lIBROS.Archivo_descarga );
                _lIBROS.Archivo_previsual  =   Utils.Encriptar(_lIBROS.Archivo_previsual);



                _context.Add(_lIBROS);

                _bitacora.Usuario = Utils.Encriptar(User.ToString());
                _bitacora.Fecha_Hora = DateTime.Now;
                _bitacora.Id_registro = Utils.Encriptar(_lIBROS.Id_libro.ToString());
                _bitacora.Tipo = Utils.Encriptar("1");
                _bitacora.Descripcion = Utils.Encriptar("crea un libro");
                _bitacora.Registro_detalle = Utils.Encriptar("Create");
                _context.BITACORA.Add(_bitacora);

                //incrementa el consecutivo en la tabla
                actualizarConsecutivosLibros();
                Utils.encryp = false;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(_lIBROS);
        }

        // GET: LIBROS/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _lIBROS = await _context.LIBROS.FindAsync(id);
            if (_lIBROS == null)
            {
                return NotFound();
            }
            return View(_lIBROS);
        }

        // POST: LIBROS/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id_libro,Nombre_libro,Autor,Idioma,Editorial,Annio_publicacion,Archivo_descarga,Archivo_previsual")] LIBROS _lIBROS)
        {
            if (id != _lIBROS.Id_libro)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Utils.encryp = false;
                    //concatena el prefijo y el consecutivo
                    _lIBROS.Id_libro = obtenerPrefijosLibros() + obtenerConsecutivosLibros();
                    _lIBROS.Id_libro = Utils.Encriptar(_lIBROS.Id_libro);
                    _lIBROS.Nombre_libro = Utils.Encriptar(_lIBROS.Nombre_libro);
                    _lIBROS.Autor = Utils.Encriptar(_lIBROS.Autor);
                    _lIBROS.Idioma = Utils.Encriptar(_lIBROS.Idioma);
                    _lIBROS.Editorial = Utils.Encriptar(_lIBROS.Editorial);
                    //_lIBROS.Annio_publicacion  =   Utils.Encriptar(_lIBROS.Annio_publicacion);
                    _lIBROS.Archivo_descarga = Utils.Encriptar(_lIBROS.Archivo_descarga);
                    _lIBROS.Archivo_previsual = Utils.Encriptar(_lIBROS.Archivo_previsual);
                    Utils.encryp = false;

                    _context.Update(_lIBROS);

                    _bitacora.Usuario = Utils.Encriptar(User.ToString());
                    _bitacora.Fecha_Hora = DateTime.Now;
                    _bitacora.Id_registro = Utils.Encriptar(_lIBROS.Id_libro.ToString());
                    _bitacora.Tipo = Utils.Encriptar("1");
                    _bitacora.Descripcion = Utils.Encriptar("edita un libro");
                    _bitacora.Registro_detalle = Utils.Encriptar("edit");

                    _context.BITACORA.Add(_bitacora);
                    Utils.encryp = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LIBROSExists(_lIBROS.Id_libro))
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
            return View(_lIBROS);
        }

        // GET: LIBROS/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var _lIBROS = await _context.LIBROS
                .FirstOrDefaultAsync(m => m.Id_libro == id);
            if (_lIBROS == null)
            {
                return NotFound();
            }

            return View(_lIBROS);
        }

        // POST: LIBROS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var _lIBROS = await _context.LIBROS.FindAsync(id);
            _context.LIBROS.Remove(_lIBROS);

            _bitacora.Usuario = Utils.Encriptar(User.ToString());
            _bitacora.Fecha_Hora = DateTime.Now;
            _bitacora.Id_registro = Utils.Encriptar(_lIBROS.Id_libro.ToString());
            _bitacora.Tipo = Utils.Encriptar("1");
            _bitacora.Descripcion = Utils.Encriptar("borra un libro");
            _bitacora.Registro_detalle = Utils.Encriptar("Delete");

            _context.BITACORA.Add(_bitacora);
            Utils.encryp = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LIBROSExists(string id)
        {
            return _context.LIBROS.Any(e => e.Id_libro == id);
        }


        private string obtenerConsecutivosLibros()
        {
            string result = string.Empty;
            result = (from p in _context.CONSECUTIVOS
                           where p.Id_TipoProducto == 2
                           select p.Consecutivo).FirstOrDefault().ToString();

            return result;
        }

        private string obtenerPrefijosLibros()
        {
            string result = string.Empty;
            var datos = _context.CONSECUTIVOS.FirstOrDefault(a => a.Id_TipoProducto == 2 && a.Posee_prefijo == true);
            if (datos != null)
            {
                return result = datos.Prefijo;
            }
            return string.Empty;
        }

        private void actualizarConsecutivosLibros()
        {
            CONSECUTIVOS result = (from p in _context.CONSECUTIVOS
                          where p.Id_TipoProducto == 2
                          select p).SingleOrDefault();

            result.Consecutivo = int.Parse(obtenerConsecutivosLibros()) + 1;
            _context.SaveChanges();
        }

        public async Task<IActionResult> createLibros()
        {
            return View("Create");
        }
    }
}
