using Microsoft.AspNetCore.Mvc;
using TP07_Feldman_Patejim_Grinstein.Models;

namespace TP07_Feldman_Patejim_Grinstein.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Jugadores = Juego.DevolverListaUsuarios();
        return View();
    }

    public IActionResult Comenzar(string name, int dificultad)
    {
        var juego = new Juego();
        juego.LlenarListaPalabras();
        juego.InicializarJuego(name, dificultad);

        // Guarda el juego en sesión (requiere que hayas configurado AddSession en Program.cs)
        HttpContext.Session.SetString("Juego", Objetos.ObjectToString(juego));

        ViewBag.Palabra = juego.PalabraActual;

        return View("Juego");
    }

    public IActionResult FinJuego(int intentos)
    {
        return RedirectToAction("Index");
    }
}
