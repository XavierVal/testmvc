using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ulises_mvc.Models;

namespace Ulises_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Persona persona = new Models.Persona();
        persona.Nombre = "Paco";
        persona.Pais = "Francia";

        ViewData["Message"] = "Esto es un mensaje viewdata desde el controller";

        ViewBag.Message = "esto es un viewbag";

        return View(persona);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Test()
    {
        return View();
    }

    public IActionResult Lista()
    {
        return View();
    }

    public IActionResult Crear()
    {
        return View();

    }
    public IActionResult Form()
    {
        return View();
    }
        public IActionResult Mascotas()
    {
        Mascotas mascota = new Models.Mascotas();
        mascota.Nombre = "Pipi";
        mascota.Raza = "chchiwawa";
        mascota.ID = 1;

        ViewData["mascota"] = mascota;

        return View(mascota);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}

