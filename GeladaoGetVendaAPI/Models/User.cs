using System.ComponentModel.DataAnnotations;

namespace AcademiaGetUsuarioAPI.Models
{
    public class User:Person
    {
        [Required(ErrorMessage = "O campo Username é obrigatório")]
        public string Username { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        public string Password { get; set; }
        [Required(ErrorMessage = "O campo professor é obrigatório")]
        public Profissional Professor { get; set; }
        public TreinoMensal TreinoMensal { get; set; }


    }
}
