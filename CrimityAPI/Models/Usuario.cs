using System.ComponentModel.DataAnnotations;

namespace CrimityAPI.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
