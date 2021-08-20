using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoFinal1_desaAppsWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1_desaAppsWeb.Controllers
{
    public class PRODUCTOSController : Controller
    {
        private readonly ILogger<PRODUCTOSController> _logger;

        public PRODUCTOSController(ILogger<PRODUCTOSController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> index()
        {
            return View("index");
        }

        public async Task<IActionResult> libros()
        {
            return View("libros");
        }

        public async Task<IActionResult> musica()
        {
            return View("musica");
        }

        public async Task<IActionResult> peliculas()
        {
            return View("peliculas");
        }
    }
}
