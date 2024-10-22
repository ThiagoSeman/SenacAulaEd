namespace SenacAulaEd.Models
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Ano { get; set; }
        public int Paginas { get; set; }
        public string Genero { get; set; }
        public string Local { get; set; }
        public int Qtddisponivel { get; set; }
        public string Fornecedor { get; set; }
        public string Edicao { get; set; }
    }

    public class Retirada
    {
        public Guid Id { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataEfetiva { get; set; }
        public string NomeUsuario { get; set; }

    }
}
