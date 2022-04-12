using FunProject_Jadi_MVC.Models;
using FunProject_Jadi_MVC.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace FunProject_Jadi_MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoRepository _produtoRepository;

        public ProdutoController(ProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        
        public IActionResult Index()
        {
            ViewData["Title"] = "Meus Produtos";
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var lista = _produtoRepository.Lista();

            return View(lista);
        }

        [HttpGet]
        public IActionResult Criar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Criar(Produto produto)
        {
            _produtoRepository.Criar(produto);

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var edicaoProduto = _produtoRepository.BuscarProduto(id);
            return View(edicaoProduto);
        }

        [HttpPost]
        public IActionResult Atualizar(Produto produto)
        {
            _produtoRepository.AtualizarProduto(produto);

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult ConfirmarExclusao(int id)
        {
            var exclusaoProduto = _produtoRepository.BuscarProduto(id);
            return View(exclusaoProduto);
        }

        
        public IActionResult Excluir(int id)
        {
            var exclusaoProduto = _produtoRepository.BuscarProduto(id);
            _produtoRepository.Excluir(exclusaoProduto);

            return RedirectToAction("Listar");
        }
    }
}
