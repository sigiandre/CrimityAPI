using CrimityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrimityAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios {get;set;}
    }
}
