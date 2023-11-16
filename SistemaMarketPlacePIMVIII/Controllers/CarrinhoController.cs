using Microsoft.AspNetCore.Mvc;
using SistemaMarketPlacePIMVIII.Models;
using SistemaMarketPlacePIMVIII.Repositories;
using System.Diagnostics;

namespace SistemaMarketPlacePIMVIII.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly IRepository _CarrinhoRepository;

        public CarrinhoController(IRepository CarrinhoRepository)
        {
            _CarrinhoRepository = CarrinhoRepository;
        }
        private readonly ILogger<CarrinhoController> _logger;

        public CarrinhoController(ILogger<CarrinhoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           List<Carrinho> Carrinho = _CarrinhoRepository.ObterTodos();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(Carrinho carrinho) 
        {
            _CarrinhoRepository.Adicionar(carrinho);
            return RedirectToAction("Index");
        }
        public IActionResult Atualizar(Carrinho carrinho) 
        {
            return View();
        }
    }
    
}