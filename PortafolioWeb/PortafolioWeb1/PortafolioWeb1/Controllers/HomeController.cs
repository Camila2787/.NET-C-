using Microsoft.AspNetCore.Mvc;
using PortafolioWeb1.Models;
using System.Diagnostics;

namespace PortafolioWeb1.Controllers
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
            var Persona = new Persona()
            {
                Nombre = "Camila Contreras Rangel",
                Edad = 21
            };
            return View("Index", Persona);
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
}
