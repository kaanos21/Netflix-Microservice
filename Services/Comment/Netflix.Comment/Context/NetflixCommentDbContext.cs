using Microsoft.EntityFrameworkCore;
using Netflix.Comment.Entities;


namespace Netflix.Comment.Context
{
    public class NetflixCommentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1441;Initial Catalog=NetflixCommentDb;User=sa;Password=123456aA*;TrustServerCertificate=True");
        }

        public DbSet<Comments> Comments { get; set; }
    }
}
