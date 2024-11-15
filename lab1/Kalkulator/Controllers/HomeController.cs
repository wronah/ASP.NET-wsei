using Kalkulator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Kalkulator.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            ViewBag.Name = "Jan";
            ViewBag.godzina = DateTime.Now.Hour;
            ViewBag.powitanie = ViewBag.godzina < 17 ? "Dzien dobry" : "Dobry wieczor";
            Dane[] osoby =
            {
                new Dane {Imie="Jan", Nazwisko="Kowalski"},
                new Dane {Imie="Anna", Nazwisko="Nowak"},
                new Dane {Imie="Monika", Nazwisko="Zab³otni"},
            };
            return View(osoby);
        }

        public IActionResult UrodzinyForm()
        {
            return View();
        }

        public IActionResult Urodziny(Urodziny urodziny)
        {
            ViewBag.Message = $"witaj {urodziny.Imie} {urodziny.Nazwisko} Masz {DateTime.Now.Year - urodziny.Rok}";
            return View();
        }
    }
}
