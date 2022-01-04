﻿using System.ComponentModel.DataAnnotations;

namespace filmesAPI.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Campo Genero pode ter no máximo 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "O Campo Duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}
