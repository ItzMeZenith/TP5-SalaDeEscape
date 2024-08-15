using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EnigmaTotal.Models;

namespace EnigmaTotal.Controllers;

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

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Comenzar()
    {
        return View("habitacion" + Escape.GetEstadoJuego());
    }

    public IActionResult Creditos()
    {
        return View();
    }

    public IActionResult Victoria()
    {
        return View();
    }

    public IActionResult Habitacion(int sala, string clave)
    {
        if(sala > Escape.GetEstadoJuego())
        {
            ViewBag.Error = "Se debe realizar la habitación correspondiente con el estado del juego ("+Escape.GetEstadoJuego()+")";
        }
        else
        {
            bool a = Escape.ResolverSala(sala, clave);
            if(a)
            {
                if(sala == 4)
                {
                    return View("victoria");
                }
            }
            else
            {
                ViewBag.Error = "La respuesta introducida es incorrecta";
            }
        }

        return View("habitacion" + Escape.GetEstadoJuego());
    }

}

