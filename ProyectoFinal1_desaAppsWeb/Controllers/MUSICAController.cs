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
        private BITACORA _bitacora = new BITACORA();
        public MUSICAController(DBContext context)
        {
            _context = context;
        }

        // GET: MUSICA
        public async Task<IActionResult> Index()
        {
            Utils.encryp = true;
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
            Utils.encryp = true;
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
                Utils.encryp = false;
                
                //concatena el prefijo y el consecutivo
                _mUSICA.Id_musica = obtenerPrefijosLibros() + obtenerConsecutivosLibros();

                _mUSICA.Id_musica = Utils.Encriptar(_mUSICA.Nombre_musica);
                _mUSICA.Nombre_musica = Utils.Encriptar(_mUSICA.Nombre_musica);
                _mUSICA.Tipo_interpretacion   =  Utils.Encriptar(_mUSICA.Tipo_interpretacion);
                _mUSICA.Idioma                =  Utils.Encriptar(_mUSICA.Idioma);
                _mUSICA.Pais                  =  Utils.Encriptar(_mUSICA.Pais);
                _mUSICA.Disquera              =  Utils.Encriptar(_mUSICA.Disquera);
                _mUSICA.Nombre_disco          =  Utils.Encriptar(_mUSICA.Nombre_disco);
                //_mUSICA.Annio                 =  Utils.Encriptar(_mUSICA.Annio);
                _mUSICA.Archivo_descarga      =  Utils.Encriptar(_mUSICA.Archivo_descarga);
                _mUSICA.Archivo_previsual     =  Utils.Encriptar(_mUSICA.Archivo_previsual);

                _context.Add(_mUSICA);
                

                _bitacora.Usuario = Utils.Encriptar(User.ToString());
                _bitacora.Fecha_Hora = DateTime.Now;
                _bitacora.Id_registro = Utils.Encriptar(_mUSICA.Id_musica.ToString());
                _bitacora.Tipo = Utils.Encriptar("1");
                _bitacora.Descripcion = Utils.Encriptar("crea un registro musica");
                _bitacora.Registro_detalle = Utils.Encriptar("Create");

                _context.BITACORA.Add(_bitacora);

                //incrementa el consecutivo en la tabla
                actualizarConsecutivosLibros();

                Utils.encryp = false;
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
                    Utils.encryp = false;
                    _mUSICA.Id_musica = Utils.Encriptar(_mUSICA.Nombre_musica);
                    _mUSICA.Nombre_musica = Utils.Encriptar(_mUSICA.Nombre_musica);
                    _mUSICA.Tipo_interpretacion = Utils.Encriptar(_mUSICA.Tipo_interpretacion);
                    _mUSICA.Idioma = Utils.Encriptar(_mUSICA.Idioma);
                    _mUSICA.Pais = Utils.Encriptar(_mUSICA.Pais);
                    _mUSICA.Disquera = Utils.Encriptar(_mUSICA.Disquera);
                    _mUSICA.Nombre_disco = Utils.Encriptar(_mUSICA.Nombre_disco);
                    //_mUSICA.Annio                 =  Utils.Encriptar(_mUSICA.Annio);
                    _mUSICA.Archivo_descarga = Utils.Encriptar(_mUSICA.Archivo_descarga);
                    _mUSICA.Archivo_previsual = Utils.Encriptar(_mUSICA.Archivo_previsual);
                    Utils.encryp = false;


                    _context.Update(_mUSICA);
                    _bitacora.Usuario = Utils.Encriptar(User.ToString());
                    _bitacora.Fecha_Hora = DateTime.Now;
                    _bitacora.Id_registro = Utils.Encriptar(_mUSICA.Id_musica.ToString());
                    _bitacora.Tipo = Utils.Encriptar("1");
                    _bitacora.Descripcion = Utils.Encriptar("edita un registro musica");
                    _bitacora.Registro_detalle = Utils.Encriptar("Edit");

                    _context.BITACORA.Add(_bitacora);
                    Utils.encryp = false;

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

            _bitacora.Usuario = Utils.Encriptar(User.ToString());
            _bitacora.Fecha_Hora = DateTime.Now;
            _bitacora.Id_registro = _mUSICA.Id_musica.ToString();
            _bitacora.Tipo = Utils.Encriptar("1");
            _bitacora.Descripcion = Utils.Encriptar("borra un registro musica");
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
                      where p.Id_TipoProducto == 3
                      select p.Consecutivo).FirstOrDefault().ToString();

            return result;
        }

        private string obtenerPrefijosLibros()
        {
            string result = string.Empty;
            var datos = _context.CONSECUTIVOS.FirstOrDefault(a => a.Id_TipoProducto == 3 && a.Posee_prefijo == true);
            if (datos != null)
            {
                return result = datos.Prefijo;
            }
            return string.Empty;
        }

        private void actualizarConsecutivosLibros()
        {
            CONSECUTIVOS result = (from p in _context.CONSECUTIVOS
                                   where p.Id_TipoProducto == 3
                                   select p).SingleOrDefault();

            result.Consecutivo = int.Parse(obtenerConsecutivosLibros()) + 1;
            _context.SaveChanges();
        }

        private bool MUSICAExists(string id)
        {
            return _context.MUSICA.Any(e => e.Id_musica == id);
        }
    }
}
