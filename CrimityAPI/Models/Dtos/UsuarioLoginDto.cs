using System.ComponentModel.DataAnnotations;

namespace CrimityAPI.Models.Dtos
{
    public class UsuarioLoginDto
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string NombreUsuario { get; set; }
        [Required(ErrorMessage = "El Password es obligatorio")]
        public string Password { get; set; }
    }
}
