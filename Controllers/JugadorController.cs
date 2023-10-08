using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ulises_mvc.Models;

namespace Ulises_mvc.Controllers
{
	public class JugadorController : Controller
    {
        private static List<Jugador> jugadores = new List<Jugador>();


        [HttpPost]
        public IActionResult Guardar(Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                jugadores.Add(jugador);
                return RedirectToAction("Lista");
            }

            return View("Crear", jugador);
        }



        public IActionResult Crear()
        {
        return View();
        }

        public IActionResult Lista()
        {
            return View(jugadores);
        }
    }
}

