namespace SenacAulaEd.Models
{
    public class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public DateTime dataCad { get; set; }
        public string CPF { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Matricula { get; set; }

        public List<Endereco> Enderecos { get; set; }
        public List<Contato> Contatos { get; set; }

    }

    public enum TipoContato
    {
        Comercial,
        Residencial,
        Referencia,
        Outros
    }

    public class Contato
    {
        public Guid Id { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public TipoContato Tipo { get; set; }
        public string Site { get; set; }
    }

    public class Endereco
    {
        public Guid Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        public string CEP { get; set; }
    }
}