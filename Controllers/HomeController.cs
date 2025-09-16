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
        return View();
    }
}
