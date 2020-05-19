﻿// <auto-generated />
using System;
using BandAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BandAPI.Migrations
{
    [DbContext(typeof(BandAlbumContext))]
    partial class BandAlbumContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("BandId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d6db7bd7-2406-48a9-ab9e-adaeaa10a3e1"),
                            BandId = new Guid("e912458d-da72-46df-a17c-7427c9687237"),
                            Description = "Master of Puppets is the third studio album by American heavy metal band Metallica, released on March 3, 1986, by Elektra Records.",
                            Title = "Master of Puppets"
                        },
                        new
                        {
                            Id = new Guid("d277729c-d5b5-44e7-b70f-3a798053a6b1"),
                            BandId = new Guid("95209b50-83f6-4995-834f-708c495f78be"),
                            Description = "Oh, Inverted World is the debut studio album by American indie rock band The Shins, released on June 19, 2001 to critical acclaim.",
                            Title = "Oh, Inverted World"
                        },
                        new
                        {
                            Id = new Guid("0238aa24-1064-404d-867f-1c6c37bb48d9"),
                            BandId = new Guid("552f2f6a-bd51-4969-a8f0-9c1fcb7301a9"),
                            Description = "Appetite for Destruction is the debut studio album by American hard rock band Guns N' Roses. It was released on July 21, 1987, by Geffen Records.",
                            Title = "Appetite for Destruction"
                        },
                        new
                        {
                            Id = new Guid("3ac39fec-e8ec-45e8-bcc3-c62743da1fee"),
                            BandId = new Guid("c3203c2c-653d-4033-bbb3-bf44f379db7c"),
                            Description = "Arrival is the fourth studio album by the Swedish pop group ABBA. It was originally released in Sweden on 11 October 1976 by Polar Records. ",
                            Title = "Arrival"
                        },
                        new
                        {
                            Id = new Guid("fe89c16a-07a8-44f5-886b-4fa75015feb8"),
                            BandId = new Guid("5f7d7c0b-6052-468a-9414-da1364ee76c1"),
                            Description = "Definitely Maybe is the debut studio album by English rock band Oasis, released by Creation Records on 29 August 1994.",
                            Title = "Definitely Maybe"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Band", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Founded")
                        .HasColumnType("datetime2");

                    b.Property<string>("MainGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Bands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e912458d-da72-46df-a17c-7427c9687237"),
                            Founded = new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Heavy Metal",
                            Name = "Metallica"
                        },
                        new
                        {
                            Id = new Guid("95209b50-83f6-4995-834f-708c495f78be"),
                            Founded = new DateTime(1996, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Indie Rock",
                            Name = "The Shins"
                        },
                        new
                        {
                            Id = new Guid("552f2f6a-bd51-4969-a8f0-9c1fcb7301a9"),
                            Founded = new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Rock",
                            Name = "Guns N Roses"
                        },
                        new
                        {
                            Id = new Guid("c3203c2c-653d-4033-bbb3-bf44f379db7c"),
                            Founded = new DateTime(1972, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Disco",
                            Name = "ABBA"
                        },
                        new
                        {
                            Id = new Guid("5f7d7c0b-6052-468a-9414-da1364ee76c1"),
                            Founded = new DateTime(1992, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            MainGenre = "Alternative",
                            Name = "Oasis"
                        });
                });

            modelBuilder.Entity("BandAPI.Entities.Album", b =>
                {
                    b.HasOne("BandAPI.Entities.Band", "Band")
                        .WithMany("Albums")
                        .HasForeignKey("BandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
