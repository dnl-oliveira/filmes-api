using filmesAPI.Models;

namespace filmesAPI.Data.Dtos.Sessao
{
    public class ReadSessaoDto
    {
        public filmesAPI.Models.Cinema Cinema { get; set; }
        public filmesAPI.Models.Filme Filme { get; set; }
        public int Id { get; set; }

        public DateTime HorarioDeEncerramento { get; set; }
        public DateTime HorarioDeInicio { get; set; }
    }
}
