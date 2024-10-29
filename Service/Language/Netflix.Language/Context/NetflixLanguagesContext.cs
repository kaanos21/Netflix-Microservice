using Microsoft.EntityFrameworkCore;
using Netflix.Language.Entities;

namespace Netflix.Language.Context
{
    public class NetflixLanguagesContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-COQ9ECD\\SQLEXPRESS;database=NetflixLanguageDb;integrated security=true ; TrustServerCertificate=True");
        }
        public DbSet<Languages> Languages {  get; set; }
        public DbSet<Subtitles> Subtitles {  get; set; }
    }
}
