using System.ComponentModel.DataAnnotations;

namespace CrimityAPI.Models.Dtos
{
    public class UsuarioLoginDto
    {
        [Required(ErrorMessage = "El email es obligatorio")]
        public string email { get; set; }
        [Required(ErrorMessage = "El Password es obligatorio")]
        public string Password { get; set; }
    }
}
