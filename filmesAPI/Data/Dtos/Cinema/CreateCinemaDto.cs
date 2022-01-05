using System.ComponentModel.DataAnnotations;

namespace filmesAPI.Data.Dtos.Cinema
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo de EnderecoId é obrigatório")]
        public int EnderecoId { get; set; }
        //public int EnderecoFK { get; set; }
        public int GerenteId { get; set; }
    }
}
