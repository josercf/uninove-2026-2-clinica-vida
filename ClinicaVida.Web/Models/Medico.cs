
namespace ClinicaVida.Web.Models;

public class Medico
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string CRM { get; set; } = string.Empty;

    public int EspecialidadeId { get; set; }

    public Especialidade? Especialidade { get; set; }
}
