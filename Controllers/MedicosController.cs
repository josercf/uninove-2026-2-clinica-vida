using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ClinicaVida.Web.Models;

namespace ClinicaVida.Web.Controllers;

public class MedicosController : Controller
{
    // GET: /Medicos OU /Medicos?especialidadeId=1
    public IActionResult Index(int? especialidadeId)
    {
        var medicos = ClinicaEmMemoria.Medicos.AsEnumerable();

        // Se houver um filtro de especialidade selecionado
        if (especialidadeId.HasValue && especialidadeId.Value > 0)
        {
            medicos = medicos.Where(m => m.EspecialidadeId == especialidadeId.Value);
        }

        // Ordena a lista em ordem alfabética por Nome
        var listaOrdenada = medicos.OrderBy(m => m.Nome).ToList();

        // Envia as especialidades para carregar o dropdown <select>
        ViewBag.Especialidades = new SelectList(
            ClinicaEmMemoria.Especialidades, 
            "Id", 
            "Nome", 
            especialidadeId
        );

        return View(listaOrdenada);
    }

    // GET: /Medicos/Details/1
    public IActionResult Details(int id)
    {
        var medico = ClinicaEmMemoria.Medicos.FirstOrDefault(m => m.Id == id);

        if (medico == null)
        {
            return NotFound(); // Devolve erro 404
        }

        return View(medico);
    }
}