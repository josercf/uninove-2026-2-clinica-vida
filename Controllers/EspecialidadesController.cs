using Microsoft.AspNetCore.Mvc;
using ClinicaVida.Web.Models;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
    // GET: /Especialidades
    public IActionResult Index()
    {
        // 1. Pega a lista de especialidades
        var especialidades = ClinicaEmMemoria.Especialidades;

        // 2. Cria o Dictionary: Chave = EspecialidadeId, Valor = Quantidade de Médicos
        var contagemMedicos = ClinicaEmMemoria.Medicos
            .GroupBy(m => m.EspecialidadeId)
            .ToDictionary(g => g.Key, g => g.Count());

        // 3. Envia o Dictionary para a View
        ViewBag.ContagemMedicos = contagemMedicos;

        return View(especialidades);
    }
}