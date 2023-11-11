using Microsoft.AspNetCore.Mvc;
using SistemaMarketPlacePIMVIII.Models;
using System.Diagnostics;

namespace SistemaMarketPlacePIMVIII.Controllers
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
    }
}