namespace VotacionUCAWebApplication.Models
{
    public class Candidatos
    {
        public int Id { get; set; }
        public int IdEstudiante { get; set; }
        public int IdVotacion { get; set; }
        public int VotosObtenidos { get; set; }
    }
}