using Microsoft.EntityFrameworkCore;
using MusicLibrary.Models.Configuration;

namespace MusicLibrary.Models.Objects
{
    public class DatabaseCtx : DbContext
    {
        public DatabaseCtx(DbContextOptions<DatabaseCtx> options) : base(options) { }


        public DbSet<Artist> Artists { get; set; }
        public DbSet<Music> Music { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigureArtist());
            modelBuilder.ApplyConfiguration(new ConfigureMusic());
            modelBuilder.ApplyConfiguration(new ConfigureArtistMusic());


        }


    }

}

