using ProjetoCadastroContatos.Models;
using System.Collections.Generic;

namespace ProjetoCadastroContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> ExibirTodos();
        ContatoModel BuscarId(int id);
        ContatoModel Adicionar(ContatoModel contato); 
        ContatoModel Editar(ContatoModel contato); 
        bool Delete(int id);

    }
}
