namespace CrimityAPI.Models.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Nombre { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
