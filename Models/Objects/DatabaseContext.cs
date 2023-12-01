using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MusicLibrary.Models.Objects
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Music> Musics { get; set; } = null!;
        public DbSet<Artist> Artists { get; set; } = null!;
        public DbSet<ArtistMusic> ArtistMusics { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            modelBuilder.Entity<Music>().HasData(new Music { MusicId = 1, Title = "Éjjel érkezem", Year = 1986 });

            modelBuilder.Entity<Artist>().HasData(new Artist { ArtistId = 1, Name = "Edda Művek" });




            modelBuilder.Entity<ArtistMusic>().HasKey(sc => new { sc.ArtistId, sc.MusicId });

            modelBuilder.Entity<ArtistMusic>().HasOne(e=>e.Music).WithMany(e=>e.ArtistMusics).HasForeignKey(e=>e.MusicId);

            modelBuilder.Entity<ArtistMusic>().HasOne(e => e.Artist).WithMany(e => e.ArtistMusics).HasForeignKey(e => e.ArtistId);

            modelBuilder.Entity<ArtistMusic>().HasData(new { ArtistId = 1, MusicId = 1 });

        }


    }
}
