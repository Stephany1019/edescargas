using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProyectoFinal1_desaAppsWeb;
using ProyectoFinal1_desaAppsWeb.Models;

namespace ProyectoFinal1_desaAppsWeb.Controllers
{
    public class USUARIOController : Controller
    {
        private readonly DBContext _context;
        public IConfiguration _configuration;

        private BITACORA _bitacora = new BITACORA();
        public USUARIOController(DBContext context)
        {
            _context = context;
        }

        //public USUARIOController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        // GET: USUARIOs
        public async Task<IActionResult> Index()
        {
            Utils.encryp = true;
            return View(await _context.USUARIO.ToListAsync());
        }

        // GET: USUARIOs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSUARIOkk = await _context.USUARIO
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (uSUARIOkk == null)
            {
                return NotFound();
            }
            Utils.encryp = true;
            return View(uSUARIOkk);
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
        //string Contrasena, [Bind("Id_usuario, Usuario, Contrasena, Email, Pregunta_seguridad ,Respuesta_seguridad")]
        public async Task<IActionResult> Create([Bind("Id_usuario, Usuario, Contrasena, Email, Pregunta_seguridad ,Respuesta_seguridad")] USUARIO uSUARIOkk)
        {
            if (ModelState.IsValid)
            {
                Utils.encryp = false;
                uSUARIOkk.Usuario = Utils.Encriptar(uSUARIOkk.Usuario);
                uSUARIOkk.Contrasena = Utils.Encriptar(uSUARIOkk.Contrasena);
                uSUARIOkk.Email = Utils.Encriptar(uSUARIOkk.Email);
                uSUARIOkk.Pregunta_seguridad = Utils.Encriptar("Color favorito");
                uSUARIOkk.Respuesta_seguridad = Utils.Encriptar(uSUARIOkk.Respuesta_seguridad);
                
                
                _context.Add(uSUARIOkk);
                

                _bitacora.Usuario = uSUARIOkk.Usuario;
                _bitacora.Fecha_Hora = DateTime.Now;
                _bitacora.Id_registro = uSUARIOkk.Id_usuario.ToString();
                _bitacora.Tipo = Utils.Encriptar("1");
                _bitacora.Descripcion = Utils.Encriptar("Crea un nuevo usuario");
                _bitacora.Registro_detalle = Utils.Encriptar("Create");

                _context.BITACORA.Add(_bitacora);
                Utils.encryp = false;
                //Utils.insertarBitacora(_configuration.GetConnectionString("DefaultConnection"), uSUARIOkk.Usuario, DateTime.Now, uSUARIOkk.Id_usuario.ToString(), "1", "Create un nuevo usuario", "CreateUser");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            return View(uSUARIOkk);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //string Contrasena, [Bind("Id_usuario, Usuario, Contrasena, Email, Pregunta_seguridad ,Respuesta_seguridad")]
        public async Task<IActionResult> CreateUser([Bind("Id_usuario, Usuario, Contrasena, Email, Pregunta_seguridad ,Respuesta_seguridad")] USUARIO uSUARIOkk)
        {
            if (ModelState.IsValid)
            {
                Utils.encryp = false;
                uSUARIOkk.Usuario = Utils.Encriptar(uSUARIOkk.Usuario);
                uSUARIOkk.Contrasena = Utils.Encriptar(uSUARIOkk.Contrasena);
                uSUARIOkk.Email = Utils.Encriptar(uSUARIOkk.Email);
                uSUARIOkk.Pregunta_seguridad = Utils.Encriptar("Color favorito");
                uSUARIOkk.Respuesta_seguridad = Utils.Encriptar(uSUARIOkk.Respuesta_seguridad);

                Utils.encryp = false;
                _context.Add(uSUARIOkk);

                _bitacora.Usuario = uSUARIOkk.Usuario;
                _bitacora.Fecha_Hora = DateTime.Now;
                _bitacora.Id_registro = uSUARIOkk.Id_usuario.ToString();
                _bitacora.Tipo = Utils.Encriptar("1");
                _bitacora.Descripcion = Utils.Encriptar("Crea un nuevo usuario");
                _bitacora.Registro_detalle = Utils.Encriptar("CreateUser");

                _context.BITACORA.Add(_bitacora);
                Utils.encryp = false;
                await _context.SaveChangesAsync();

                //Utils.insertarBitacora(_configuration.GetConnectionString("DefaultConnection"), uSUARIOkk.Usuario,DateTime.Now, uSUARIOkk.Id_usuario.ToString(),"1","Create un nuevo usuario","CreateUser");
                
                return View("../Home/Index");

            }
            return View("../Home/Index");
        }

        // GET: USUARIOs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSUARIOkk = await _context.USUARIO.FindAsync(id);
            if (uSUARIOkk == null)
            {
                return NotFound();
            }

            return View(uSUARIOkk);
        }

        // POST: USUARIOs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_usuario,Usuario,Contrasena,Email,Pregunta_seguridad,Respuesta_seguridad")] USUARIO uSUARIOkk)
        {
            if (id != uSUARIOkk.Id_usuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Utils.encryp = false;
                    uSUARIOkk.Usuario = Utils.Encriptar(uSUARIOkk.Usuario);
                    uSUARIOkk.Contrasena = Utils.Encriptar(uSUARIOkk.Contrasena);
                    uSUARIOkk.Email = Utils.Encriptar(uSUARIOkk.Email);
                    uSUARIOkk.Pregunta_seguridad = Utils.Encriptar("Color favorito");
                    uSUARIOkk.Respuesta_seguridad = Utils.Encriptar(uSUARIOkk.Respuesta_seguridad);

                    Utils.encryp = false;
                    _context.Update(uSUARIOkk);

                    _bitacora.Usuario = uSUARIOkk.Usuario;
                    _bitacora.Fecha_Hora = DateTime.Now;
                    _bitacora.Id_registro = uSUARIOkk.Id_usuario.ToString();
                    _bitacora.Tipo = Utils.Encriptar("1");
                    _bitacora.Descripcion = Utils.Encriptar("Edita un usuario");
                    _bitacora.Registro_detalle = Utils.Encriptar("Edit");

                    _context.BITACORA.Add(_bitacora);
                    Utils.encryp = false;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!USUARIOExists(uSUARIOkk.Id_usuario))
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
            return View(uSUARIOkk);
        }

        // GET: USUARIOs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var uSUARIOkk = await _context.USUARIO
                .FirstOrDefaultAsync(m => m.Id_usuario == id);
            if (uSUARIOkk == null)
            {
                return NotFound();
            }

            return View(uSUARIOkk);
        }

        // POST: USUARIOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Utils.encryp = false;
            var uSUARIOkk = await _context.USUARIO.FindAsync(id);
            _context.USUARIO.Remove(uSUARIOkk);

            _bitacora.Usuario = uSUARIOkk.Usuario;
            _bitacora.Fecha_Hora = DateTime.Now;
            _bitacora.Id_registro = uSUARIOkk.Id_usuario.ToString();
            _bitacora.Tipo = Utils.Encriptar("1");
            _bitacora.Descripcion = Utils.Encriptar("Elimina un usuario");
            _bitacora.Registro_detalle = Utils.Encriptar("DeleteConfirmed");

            _context.BITACORA.Add(_bitacora);
            Utils.encryp = false;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool USUARIOExists(int id)
        {
            return _context.USUARIO.Any(e => e.Id_usuario == id);
        }

        private bool USUARIOExistsEmail(string email)
        {
            return _context.USUARIO.Any(e => e.Email.Equals(Utils.Encriptar(email)));
        }

        private bool USUARIOExistsContrasena(string contra)
        {
            return _context.USUARIO.Any(e => e.Contrasena.Equals(Utils.Encriptar(contra)));
        }

        public async Task<IActionResult> lista_usuarios()
        {
            Utils.encryp = true;
            return View(await _context.USUARIO.ToListAsync());
        }

        public async Task<IActionResult> cambio_contrasena()
        {
            return View("cambio_contrasena");
        }

        public async Task<IActionResult> signIn()
        {
            return View("signIn");
        }

        public async Task<IActionResult> logIn(USUARIO uSUARIOkk)
        {
            if (USUARIOExistsEmail(uSUARIOkk.Email) && USUARIOExistsContrasena(uSUARIOkk.Contrasena))
            {
                return View("../Home/Index");
            }
            return View("signIn");
        }
    }
}
