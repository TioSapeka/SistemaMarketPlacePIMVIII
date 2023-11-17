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
        private int id;

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
        public IActionResult Adicionar(Carrinho carrinho) 
        {
            _CarrinhoRepository.Adicionar(carrinho);
            TempData["MensagemSucesso"] = "Produto adicionado com sucesso";
            return RedirectToAction("Index");
        }
        public IActionResult Atualizar(Carrinho carrinho) 
        {
           Carrinho Carrinho = _CarrinhoRepository.ObterPorId(id);
            return View();
        }
    }
    public IActionResult excluir(int id)
    {
        _CarrinhoRepository.excluir(id);

        return RedirectToActionResult("Index");

    }


    }
