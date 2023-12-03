﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicLibrary.Models.Objects;

#nullable disable

namespace MusicLibrary.Migrations
{
    [DbContext(typeof(DatabaseCtx))]
    partial class DatabaseCtxModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ArtistMusic", b =>
                {
                    b.Property<int>("ArtistsId")
                        .HasColumnType("int");

                    b.Property<int>("MusicsId")
                        .HasColumnType("int");

                    b.HasKey("ArtistsId", "MusicsId");

                    b.HasIndex("MusicsId");

                    b.ToTable("ArtistMusic");

                    b.HasData(
                        new
                        {
                            ArtistsId = 1,
                            MusicsId = 1
                        },
                        new
                        {
                            ArtistsId = 2,
                            MusicsId = 2
                        },
                        new
                        {
                            ArtistsId = 3,
                            MusicsId = 3
                        },
                        new
                        {
                            ArtistsId = 4,
                            MusicsId = 3
                        },
                        new
                        {
                            ArtistsId = 5,
                            MusicsId = 4
                        },
                        new
                        {
                            ArtistsId = 6,
                            MusicsId = 4
                        });
                });

            modelBuilder.Entity("MusicLibrary.Models.Objects.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Edda Művek"
                        },
                        new
                        {
                            Id = 2,
                            Name = "R-GO"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Desh"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Azariah"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Daryl Hall"
                        },
                        new
                        {
                            Id = 6,
                            Name = "John Oates"
                        });
                });

            modelBuilder.Entity("MusicLibrary.Models.Objects.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Music");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Éjjel érkezem",
                            Year = 1986
                        },
                        new
                        {
                            Id = 2,
                            Title = "Ballag a katona",
                            Year = 1985
                        },
                        new
                        {
                            Id = 3,
                            Title = "Eldorádó",
                            Year = 2023
                        },
                        new
                        {
                            Id = 4,
                            Title = "Maneater",
                            Year = 1982
                        });
                });

            modelBuilder.Entity("ArtistMusic", b =>
                {
                    b.HasOne("MusicLibrary.Models.Objects.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicLibrary.Models.Objects.Music", null)
                        .WithMany()
                        .HasForeignKey("MusicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
