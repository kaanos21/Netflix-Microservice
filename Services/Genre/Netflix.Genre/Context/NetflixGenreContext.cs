using Microsoft.EntityFrameworkCore;
using Netflix.Genre.Entitites;

namespace Netflix.Genre.Context
{
    public class NetflixGenreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-COQ9ECD\\SQLEXPRESS;database=NetflixGenreDb;integrated security=true ; TrustServerCertificate=True");
        }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<GenreMappings> GenreMappings { get; set; }
    }
}
