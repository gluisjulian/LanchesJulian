using LanchesJulian.Models;
using LanchesJulian.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesJulian.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _repository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository repository, CarrinhoCompra carrinhoCompra)
        {
            _repository = repository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
