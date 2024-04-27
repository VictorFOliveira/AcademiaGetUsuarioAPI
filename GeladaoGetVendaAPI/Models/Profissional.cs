using AcademiaGetUsuarioAPI.enums;
using System.ComponentModel.DataAnnotations;

namespace AcademiaGetUsuarioAPI.Models
{
    public class Profissional : Person
    {
        [Required(ErrorMessage = "O campo credencial é obrigatório")]
        public string Credencial { get; set; }
        [Required(ErrorMessage = "O campo salário é obrigatório")]
        public double Salário { get; set; }
        public bool HoraExtra { get; set; }
        [Required(ErrorMessage = "O campo especialidade é obrigatório")]
        public Professor Especialidade { get; set; }

    }
}
