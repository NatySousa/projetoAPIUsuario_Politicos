namespace Projeto_Desafio_API_Usuario.Entities
{
    public class Deputado
    {
        public int Id { get; set; }
        public bool Processo { get; set; }
        public string Representante { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string SiglaPartido { get; set; }
        public string NomePartido { get; set; }
        public string ProjetoLei { get; set; }
        public string Foto { get; set; }
    }
}