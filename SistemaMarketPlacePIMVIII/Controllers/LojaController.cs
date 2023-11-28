using Microsoft.AspNetCore.Mvc;

namespace SistemaMarketPlacePIMVIII.Controllers
{
    public class LojaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Carrinho()
        {
            return View();
        }
    }
}
