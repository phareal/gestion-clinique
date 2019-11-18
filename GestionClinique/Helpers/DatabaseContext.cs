

using Microsoft.EntityFrameworkCore;

namespace GestionClinique.Models
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions optionsBuilder):base(optionsBuilder)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<sudo> sudo { get; set; }
    }
}