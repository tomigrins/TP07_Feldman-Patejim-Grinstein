using System.Diagnostics;
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
        ViewBag.Juego.jugadores = DevolverListaUsuarios();
        return View();
    }

    public IActionResult Comenzar(string name, int dificultad){
        Juego juego = new Juego(); 
        juego.LlenarListaPalabras();
        juego.inicializarJuego(name, dificultad);
        HttpContext.Session.SetString("Juego", Objeto.ObjectToString(juego));

    }
    public IActionResult FinJuego(int intentos)
    {
        ViewBag.
        return View("Index");
    }
}
