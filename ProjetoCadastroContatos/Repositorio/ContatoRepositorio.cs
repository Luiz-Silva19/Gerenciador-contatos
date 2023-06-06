using ProjetoCadastroContatos.Data;
using ProjetoCadastroContatos.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoCadastroContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)//injetando
        {
            _bancoContext=bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravando no banco de Dados

            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();//salvando no banco após adicionar
            return contato;

        }

        public ContatoModel BuscarId(int id)
        {
            //vai buscar na tabela contato o id que estou passando na lambda
            return _bancoContext.Contatos.FirstOrDefault(b => b.Id == id);
        }

        public bool Delete(int id)
        {
            ContatoModel contatoModel = BuscarId(id);
            if (contatoModel == null) throw new System.Exception("Erro ao Deletar Contato");
            _bancoContext.Contatos.Remove(contatoModel);
            _bancoContext.SaveChanges();
            return true;
        }

        public ContatoModel Editar(ContatoModel contato)
        {
            ContatoModel contatoModel=BuscarId(contato.Id);
            
            if (contatoModel == null) throw new System.Exception("Erro na atualização do Contato");
            contatoModel.Name = contato.Name;
            contatoModel.Email = contato.Email;
            contatoModel.Celular = contato.Celular;
            _bancoContext.Contatos.Update(contatoModel);
            _bancoContext.SaveChanges();
            return contatoModel;
        }

        public List<ContatoModel> ExibirTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}
