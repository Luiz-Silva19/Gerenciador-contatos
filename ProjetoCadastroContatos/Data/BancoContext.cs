using Microsoft.EntityFrameworkCore;
using ProjetoCadastroContatos.Controllers;
using ProjetoCadastroContatos.Models;

namespace ProjetoCadastroContatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
