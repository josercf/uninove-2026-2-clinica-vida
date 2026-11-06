namespace ClinicaVida.Web.Models;

public class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade { Id = 1, Nome = "Cardiologia",  Descricao = "Coração e vasos" },
        new Especialidade { Id = 2, Nome = "Pediatria",    Descricao = "Crianças e adolescentes" },
        new Especialidade { Id = 3, Nome = "Dermatologia", Descricao = "Pele, cabelos e unhas" },
        new Especialidade { Id = 4, Nome = "Ortopedia",    Descricao = "Ossos, músculos e articulações" },
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico { Id = 1, Nome = "Dra. Marta Lisboa",   Crm = "55307", EspecialidadeId = 1 },
        new Medico { Id = 2, Nome = "Dr. Caio Nunes",      Crm = "41880", EspecialidadeId = 2 },
        new Medico { Id = 3, Nome = "Dra. Helena Prado",   Crm = "34211", EspecialidadeId = 1 },
        new Medico { Id = 4, Nome = "Dr. Ivo Reis",        Crm = "60912", EspecialidadeId = 4 },
        new Medico { Id = 5, Nome = "Dra. Sofia Brandão",  Crm = "62145", EspecialidadeId = 2 },
        new Medico { Id = 6, Nome = "Dr. Otávio Lemos",    Crm = "70233", EspecialidadeId = 3 },
    };

   public static List<Paciente> Pacientes { get; } = new()
    {
        new Paciente { Id = 1, Nome = "Ana Beatriz Rocha", Cpf = "123.456.789-09" },
        new Paciente { Id = 2, Nome = "Carlos Eduardo Lima", Cpf = "987.654.321-00" },
        new Paciente { Id = 3, Nome = "Mariana Tavares", Cpf = "111.222.333-44" },
    };

    public static List<Consulta> Consultas { get; } = new();
}