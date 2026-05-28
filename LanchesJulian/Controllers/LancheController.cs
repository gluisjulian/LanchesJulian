using LanchesJulian.Context;
using LanchesJulian.Repositories.Interfaces;
using LanchesJulian.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesJulian.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _repository;

        public LancheController(ILancheRepository repository)
        {
            _repository = repository;
        }


        public IActionResult List()
        {
            //var lanches = _repository.Lanches;
            //return View(lanches);

            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _repository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lancheListViewModel);
        }
    }
}
