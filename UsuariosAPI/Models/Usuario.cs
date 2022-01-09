using System.ComponentModel.DataAnnotations;

namespace UsuariosAPI.Models
{
    public class Usuario
    {
      
       [Key]
        public int Id { get; set; }
        
        public string Username { get; set; }
        
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
