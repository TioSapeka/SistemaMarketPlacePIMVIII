using Microsoft.AspNetCore.Mvc;
using SistemaMarketPlacePIMVIII.Models;
using SistemaMarketPlacePIMVIII.Repositories;
using System.Diagnostics;

namespace SistemaMarketPlacePIMVIII.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
