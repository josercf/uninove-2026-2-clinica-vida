using System.ComponentModel.DataAnnotations;

namespace ClinicaVida.Web.Models;

public class Consulta
{
    public int Id { get; set; }

    [Display(Name = "Paciente")]
    [Range(1, int.MaxValue, ErrorMessage = "Selecione o paciente.")]
    public int PacienteId { get; set; }

    [Display(Name = "Médico")]
    [Range(1, int.MaxValue, ErrorMessage = "Selecione o médico.")]
    public int MedicoId { get; set; }

    [Display(Name = "Data da consulta")]
    [Required(ErrorMessage = "Informe a data da consulta.")]
    [DataType(DataType.Date)]
    public DateTime Data { get; set; }

    [Display(Name = "Horário")]
    [Required(ErrorMessage = "Informe o horário da consulta.")]
    [DataType(DataType.Time)]
    public TimeSpan Horario { get; set; }

    [Display(Name = "Observações")]
    [StringLength(300, ErrorMessage = "As observações têm no máximo {1} caracteres.")]
    public string? Observacoes { get; set; }
}