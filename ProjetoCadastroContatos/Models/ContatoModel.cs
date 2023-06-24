using System.ComponentModel.DataAnnotations;

namespace ProjetoCadastroContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira um nome por favor!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe um endereço de Email, por favor!")]
        [EmailAddress(ErrorMessage = "Email inválido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe um número de Celular, por favor!")]
        [Phone(ErrorMessage = "Celular inválido!")]
        public string Celular { get; set; }

    }
}
