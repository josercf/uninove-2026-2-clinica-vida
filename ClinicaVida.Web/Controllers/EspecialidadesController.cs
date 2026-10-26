
using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
    public IActionResult Index()
    {
        var contagem = new Dictionary<int, int>();

        foreach (var especialidade in ClinicaEmMemoria.Especialidades)
        {
            contagem[especialidade.Id] = ClinicaEmMemoria.Medicos
                .Count(m => m.EspecialidadeId == especialidade.Id);
        }

        ViewBag.MedicosPorEspecialidade = contagem;

        return View(ClinicaEmMemoria.Especialidades);
    }
}
