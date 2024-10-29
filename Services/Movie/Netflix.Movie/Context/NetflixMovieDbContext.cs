using Microsoft.EntityFrameworkCore;
using Netflix.Movie.Entities;

namespace Netflix.Movie.Context
{
    public class NetflixMovieDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1442;initial Catalog=NetflixMovieDb;User=sa;Password=123456aA*; TrustServerCertificate=True");
        }
        public DbSet<Movies> Movies { get; set; }
    }
}
