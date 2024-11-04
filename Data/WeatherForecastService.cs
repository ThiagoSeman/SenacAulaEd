using SenacAulaEd.Models;

namespace SenacAulaEd.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }

        public static List<Aluno> GetAlunosAsync()
        {

            List<Aluno> alunos = new List<Aluno>
{
    new Aluno
    {
        Id = Guid.NewGuid(),
        Nome = "Carlos Silva",
        dataNascimento = new DateTime(1995, 5, 20),
        dataCad = new DateTime(2023, 1, 10),
        CPF = "11122233344",
        Login = "carlos.silva",
        Senha = "senha123",
        Matricula = "2023001",
        Enderecos = new List<Endereco>
        {
            new Endereco
            {
                Id = Guid.NewGuid(),
                Rua = "Rua das Flores",
                Numero = "123",
                Bairro = "Centro",
                Cidade = "São Paulo",
                UF = "SP",
                Pais = "Brasil",
                CEP = "01001000"
            }
        },
        Contatos = new List<Contato>
        {
            new Contato
            {
                Id = Guid.NewGuid(),
                Telefone = "1123456789",
                Celular = "11987654321",
                Email = "carlos@exemplo.com",
                Tipo = TipoContato.Comercial,
                Site = "www.carlossilva.com"
            }
        }
    },
    new Aluno
    {
        Id = Guid.NewGuid(),
        Nome = "Ana Santos",
        dataNascimento = new DateTime(1998, 10, 30),
        dataCad = new DateTime(2023, 1, 11),
        CPF = "55566677788",
        Login = "ana.santos",
        Senha = "ana123",
        Matricula = "2023002",
        Enderecos = new List<Endereco>
        {
            new Endereco
            {
                Id = Guid.NewGuid(),
                Rua = "Av. Paulista",
                Numero = "500",
                Bairro = "Bela Vista",
                Cidade = "São Paulo",
                UF = "SP",
                Pais = "Brasil",
                CEP = "01311000"
            }
        },
        Contatos = new List<Contato>
        {
            new Contato
            {
                Id = Guid.NewGuid(),
                Telefone = "1122233344",
                Celular = "11999988877",
                Email = "ana.santos@exemplo.com",
                Tipo = TipoContato.Residencial,
                Site = ""
            }
        }
    },
    new Aluno
    {
        Id = Guid.NewGuid(),
        Nome = "Bruno Alves",
        dataNascimento = new DateTime(2000, 3, 14),
        dataCad = new DateTime(2023, 1, 15),
        CPF = "12345678900",
        Login = "bruno.alves",
        Senha = "bruno123",
        Matricula = "2023003",
        Enderecos = new List<Endereco>
        {
            new Endereco
            {
                Id = Guid.NewGuid(),
                Rua = "Rua A",
                Numero = "45",
                Bairro = "Jardins",
                Cidade = "Rio de Janeiro",
                UF = "RJ",
                Pais = "Brasil",
                CEP = "22011001"
            }
        },
        Contatos = new List<Contato>
        {
            new Contato
            {
                Id = Guid.NewGuid(),
                Telefone = "2134567890",
                Celular = "21987654321",
                Email = "bruno@exemplo.com",
                Tipo = TipoContato.Referencia,
                Site = ""
            }
        }
    },
    new Aluno
    {
        Id = Guid.NewGuid(),
        Nome = "Clara Moura",
        dataNascimento = new DateTime(1992, 6, 5),
        dataCad = new DateTime(2023, 2, 1),
        CPF = "98765432100",
        Login = "clara.moura",
        Senha = "clara123",
        Matricula = "2023004",
        Enderecos = new List<Endereco>
        {
            new Endereco
            {
                Id = Guid.NewGuid(),
                Rua = "Av. Brasil",
                Numero = "1000",
                Bairro = "Copacabana",
                Cidade = "Rio de Janeiro",
                UF = "RJ",
                Pais = "Brasil",
                CEP = "22060001"
            }
        },
        Contatos = new List<Contato>
        {
            new Contato
            {
                Id = Guid.NewGuid(),
                Telefone = "2122223333",
                Celular = "21911122233",
                Email = "clara@exemplo.com",
                Tipo = TipoContato.Outros,
                Site = "www.claramoura.com"
            }
        }
    },
    new Aluno
    {
        Id = Guid.NewGuid(),
        Nome = "Diego Pereira",
        dataNascimento = new DateTime(1988, 7, 19),
        dataCad = new DateTime(2023, 2, 15),
        CPF = "45678912300",
        Login = "diego.pereira",
        Senha = "diego123",
        Matricula = "2023005",
        Enderecos = new List<Endereco>
        {
            new Endereco
            {
                Id = Guid.NewGuid(),
                Rua = "Rua das Acácias",
                Numero = "200",
                Bairro = "Moema",
                Cidade = "São Paulo",
                UF = "SP",
                Pais = "Brasil",
                CEP = "04086002"
            }
        },
        Contatos = new List<Contato>
        {
            new Contato
            {
                Id = Guid.NewGuid(),
                Telefone = "1144556677",
                Celular = "11933344455",
                Email = "diego@exemplo.com",
                Tipo = TipoContato.Comercial,
                Site = ""
            }
        }
    } 
};
            return Task.FromResult(alunos);
        }
    }
}
