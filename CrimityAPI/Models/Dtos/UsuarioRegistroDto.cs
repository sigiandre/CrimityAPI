using System.ComponentModel.DataAnnotations;

namespace CrimityAPI.Models.Dtos
{
    public class UsuarioRegistroDto
    {
        [Required(ErrorMessage = "El usuario es obligatorio")]
        public string NombreUsuario { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Email es obligatorio")]
        public string email { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "El Password es obligatorio")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
