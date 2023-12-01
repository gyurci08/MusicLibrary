using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicLibrary.Models.Objects;
using System.Reflection.Emit;

namespace MusicLibrary.Models.Configuration
{
    public class ConfigureMusic : IEntityTypeConfiguration<Music>
    {
        public void Configure(EntityTypeBuilder<Music> entity)
        {

            entity.HasKey(x => x.Id);

            entity.HasData(new { Id = 1, Title = "Éjjel érkezem", Year = 1986 },
                           new { Id = 2, Title = "Ballag a katona", Year = 1985 },
                           new { Id = 3, Title = "Eldorádó", Year = 2023 }

            );




        }
    }


}