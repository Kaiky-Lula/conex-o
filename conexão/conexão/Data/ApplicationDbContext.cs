using conexão.Models;
using Microsoft.EntityFrameworkCore;

namespace conexão.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Código da imagem
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
