using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationAspCoreMvc.Models;

namespace WebApplicationAspCoreMvc.Controllers
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

        [HttpPost]
        public IActionResult Index(string nombre)
        {
            return RedirectToAction("Completado", new { nombre });
        }

        public IActionResult Completado(string nombre)
        {
            return View("Completado", nombre);
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