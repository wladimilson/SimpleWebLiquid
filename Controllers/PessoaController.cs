using Microsoft.AspNetCore.Mvc;
using SimpleWebLiquid.Models;
using SimpleWebLiquid.Repositories;

namespace SimpleWebLiquid.Controllers
{
    public class PessoaController: Controller
    {
        public readonly PessoaRepository repository;

        public PessoaController() => repository = new PessoaRepository();

        public IActionResult Index()
        {
            var pessoas = repository.GetAll();

            return View(pessoas);
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create([FromForm] Pessoa pessoa)
        {
            repository.Add(pessoa);
            return RedirectToAction(nameof(Index));
        }
    }
}