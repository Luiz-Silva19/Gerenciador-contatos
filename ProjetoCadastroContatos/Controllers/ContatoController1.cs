using Microsoft.AspNetCore.Mvc;
using ProjetoCadastroContatos.Models;
using ProjetoCadastroContatos.Repositorio;

namespace ProjetoCadastroContatos.Controllers
{
    public class Contato : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio; 
        public Contato(IContatoRepositorio contatoRepositorio)//usando injeção de dependência
        {
            _contatoRepositorio= contatoRepositorio;
        }
        public IActionResult Index() //Esses IActiionResult sem especificar o método, se torna GET por padrão
        {
            var contatos = _contatoRepositorio.ExibirTodos();
            return View(contatos);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            ContatoModel contatoid=_contatoRepositorio.BuscarId(id);
            return View(contatoid);
        }

        public IActionResult DeleteConfirmation(int id)
        {
            ContatoModel contatoid = _contatoRepositorio.BuscarId(id);
            return View(contatoid);
        }

        public IActionResult Delete(int id)
        {
            _contatoRepositorio.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Create(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Update(ContatoModel contato)
        {
            _contatoRepositorio.Editar(contato);
            return RedirectToAction("Index");
        }

    }
}
