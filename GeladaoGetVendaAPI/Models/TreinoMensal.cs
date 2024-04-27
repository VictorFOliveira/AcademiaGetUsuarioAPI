namespace AcademiaGetUsuarioAPI.Models
{
    public class TreinoMensal
    {
        public List<string> Segunda { get; set; }
        public List<string> Terça { get; set; }
        public List<string> Quarta { get; set; }
        public List<string> Quinta { get; set; }
        public List<string> Sexta { get; set; }
        public List<string>? Sabado { get; set; }
        public List<string>? Domingo { get; set; }

    }
}
