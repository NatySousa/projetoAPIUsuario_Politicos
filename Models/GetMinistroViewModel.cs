using System.ComponentModel.DataAnnotations;

namespace Projeto_Desafio_API_Usuario.Models
{
    public class GetMinistroViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string SiglaPartido { get; set; }
        public string NomePartido { get; set; }
        public string ProjetoLei { get; set; }
    }
}