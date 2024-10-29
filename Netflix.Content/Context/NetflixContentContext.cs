using Microsoft.EntityFrameworkCore;
using Netflix.Content.Entities;

namespace Netflix.Content.Context
{
    public class NetflixContentContext:DbContext
    {
        public NetflixContentContext(DbContextOptions<NetflixContentContext> options)
            : base(options)
        {
        }

        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Series> Series { get; set; }

        

    }
}
