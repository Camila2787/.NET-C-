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
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {

                new Proyecto
                {
                    Titulo = "App para certificaciones Microsoft",
                    Descripcion = "Portal de entrenamiento Tecnologías Microsoft",
                    link = "https://learn.microsoft.com/es-es/certifications/",
                    ImagenUrl = "https://techcrunch.com/wp-content/uploads/2016/03/microsoft.jpg"
                },
                new Proyecto
                {
                    Titulo = "Grupo Bancolombia",
                    Descripcion = "Desarrollo App Clientes",
                    link = "https://www.bancolombia.com/personas//",
                    ImagenUrl = "https://vignette.wikia.nocookie.net/logopedia/images/1/17/Bancolombia_logo_2006_vertical.png/revision/latest?cb=20180217003657"
                },
                new Proyecto
                {
                    Titulo = "Desarrollo App Virtual Éxito",
                    Descripcion = "Desarrollo App Compras Online Angular",
                    link = "https://www.exito.com//",
                    ImagenUrl = "http://cr00.epimg.net/radio/imagenes/2019/03/01/medellin/1551440431_671515_1551440625_noticia_normal.jpg"
                },
                new Proyecto
                {
                    Titulo = "Desarrollo App Simulador de Préstamos",
                    Descripcion = "Desarrollo App de Préstamos",
                    link = "https://www.bancoldex.com/",
                    ImagenUrl = "http://2.bp.blogspot.com/-VS06PGA9mJw/UVWqrdd5OrI/AAAAAAAAAH8/fWW90FgelII/s1600/bancoldex.jpg"

                },

            };
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
