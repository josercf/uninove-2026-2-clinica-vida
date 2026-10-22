namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia", Descricao = "Atendimento ao coração e circulação" },
        new Especialidade { Id = 2, Nome = "Pediatria", Descricao = "Atendimento infantil" },
        new Especialidade { Id = 3, Nome = "Dermatologia", Descricao = "Cuidados com a pele" },
        new Especialidade { Id = 4, Nome = "Ortopedia", Descricao = "Cuidados com ossos e articulações" }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Dra. Aline Rezende", Crm = "32109", EspecialidadeId = 1, Especialidade = Especialidades[0] },
        new Medico { Id = 2, Nome = "Dr. Bernardo Prado", Crm = "98765", EspecialidadeId = 2, Especialidade = Especialidades[1] },
        new Medico { Id = 3, Nome = "Dra. Clarice Mendes", Crm = "45123", EspecialidadeId = 1, Especialidade = Especialidades[0] },
        new Medico { Id = 4, Nome = "Dr. Daniel Farias", Crm = "78234", EspecialidadeId = 3, Especialidade = Especialidades[2] },
        new Medico { Id = 5, Nome = "Dra. Elisa Vasconcelos", Crm = "65432", EspecialidadeId = 4, Especialidade = Especialidades[3] },
        new Medico { Id = 6, Nome = "Dr. Gabriel Monteiro", Crm = "19827", EspecialidadeId = 2, Especialidade = Especialidades[1] }
    };
}