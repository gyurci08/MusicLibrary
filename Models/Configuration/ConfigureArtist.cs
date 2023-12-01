using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicLibrary.Models.Objects;

namespace MusicLibrary.Models.Configuration
{
    public class ConfigureArtist : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> entity)
        {
            entity.HasKey(x => x.Id);

            entity.HasData(
                            new { Id = 1, Name = "Edda Művek" },
                            new { Id = 2, Name = "R-GO" },
                            new { Id = 3, Name = "Desh" },
                            new { Id = 4, Name = "Azariah" }

                            );


        }
    }


}