using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MusicLibrary.Models.Objects;

namespace MusicLibrary.Models.Configuration
{
    public class ConfigureArtistMusic : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> entity)
        {
            entity.HasMany(x => x.Musics).WithMany(x => x.Artists)
                .UsingEntity(ba => ba.HasData(
                                                new { ArtistsId = 1, MusicsId = 1 },
                                                new { ArtistsId = 2, MusicsId = 2 },
                                                new { ArtistsId = 3, MusicsId = 3 },
                                                new { ArtistsId = 4, MusicsId = 3 },
                                                new { ArtistsId = 5, MusicsId = 4 },
                                                new { ArtistsId = 6, MusicsId = 4 }
                                              ));

        }
    }


}