using System.ComponentModel.DataAnnotations;

namespace AcademiaGetUsuarioAPI.Models
{
    public class Person
    {

        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage ="O campo nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        public long  Cpf { get; set; }
        [Required(ErrorMessage = "O campo data de nascimento é obrigatório")]
        public DateOnly Data_nascimento { get; set; }

    }
}
