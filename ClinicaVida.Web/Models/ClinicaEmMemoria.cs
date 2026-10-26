
namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Cuidados com o coração." },
        new Especialidade { Id = 2, Nome = "Pediatria", Descricao = "Saúde de crianças e adolescentes." },
        new Especialidade { Id = 3, Nome = "Ortopedia", Descricao = "Cuidados com ossos e articulações." },
        new Especialidade { Id = 4, Nome = "Dermatologia", Descricao = "Cuidados com a pele." }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Ana Prado", CRM = "123456-SP", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Bruno Almeida", CRM = "234567-SP", EspecialidadeId = 2 },
        new Medico { Id = 3, Nome = "Carla Mendes", CRM = "345678-SP", EspecialidadeId = 3 },
        new Medico { Id = 4, Nome = "Diego Santos", CRM = "456789-SP", EspecialidadeId = 4 },
        new Medico { Id = 5, Nome = "Fernanda Costa", CRM = "567890-SP", EspecialidadeId = 1 },
        new Medico { Id = 6, Nome = "Gabriel Souza", CRM = "678901-SP", EspecialidadeId = 2 }
    };
}
