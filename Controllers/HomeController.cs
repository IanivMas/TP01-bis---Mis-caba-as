using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP1bis.Models;

namespace TP1bis.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        complejo complejo = new complejo();
        ViewBag.cabañas = complejo.devolverCabañas();
        return View();
    }
    public IActionResult accion1 ()
    {
        
        return View();
    }
    public IActionResult accion2 (int id)
    {
        complejo complejo = new complejo();
        ViewBag.cabaña = complejo.devolverCabaña(id);
        return View("cabaña");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
