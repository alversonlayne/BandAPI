using BandAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.DbContexts
{
    public class BandAlbumContext : DbContext
    {
        public BandAlbumContext(DbContextOptions<BandAlbumContext> options) :
            base(options)
        {
        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(
                new Band()
                {
                    Id = Guid.Parse("e912458d-da72-46df-a17c-7427c9687237"),
                    Name = "Metallica",
                    Founded = new DateTime(1981, 1, 1),
                    MainGenre = "Heavy Metal"
                },
                new Band()
                {
                    Id = Guid.Parse("95209b50-83f6-4995-834f-708c495f78be"),
                    Name = "The Shins",
                    Founded = new DateTime(1996, 3, 6),
                    MainGenre = "Indie Rock"
                },
                new Band()
                {
                    Id = Guid.Parse("552f2f6a-bd51-4969-a8f0-9c1fcb7301a9"),
                    Name = "Guns N Roses",
                    Founded = new DateTime(1985, 1, 1),
                    MainGenre = "Rock"
                },
                new Band()
                {
                    Id = Guid.Parse("c3203c2c-653d-4033-bbb3-bf44f379db7c"),
                    Name = "ABBA",
                    Founded = new DateTime(1972, 7, 7),
                    MainGenre = "Disco"
                },
                new Band()
                {
                    Id = Guid.Parse("5f7d7c0b-6052-468a-9414-da1364ee76c1"),
                    Name = "Oasis",
                    Founded = new DateTime(1992, 9, 7),
                    MainGenre = "Alternative"
                }
            );

            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    Id = Guid.Parse("d6db7bd7-2406-48a9-ab9e-adaeaa10a3e1"),
                    Title = "Master of Puppets",
                    Description = "Master of Puppets is the third studio album by American heavy metal band Metallica, released on March 3, 1986, by Elektra Records.",
                    BandId = Guid.Parse("e912458d-da72-46df-a17c-7427c9687237")
                },
                new Album
                {
                    Id = Guid.Parse("d277729c-d5b5-44e7-b70f-3a798053a6b1"),
                    Title = "Oh, Inverted World",
                    Description = "Oh, Inverted World is the debut studio album by American indie rock band The Shins, released on June 19, 2001 to critical acclaim.",
                    BandId = Guid.Parse("95209b50-83f6-4995-834f-708c495f78be"),
                },
                new Album
                {
                    Id = Guid.Parse("0238aa24-1064-404d-867f-1c6c37bb48d9"),
                    Title = "Appetite for Destruction",
                    Description = "Appetite for Destruction is the debut studio album by American hard rock band Guns N' Roses. It was released on July 21, 1987, by Geffen Records.",
                    BandId = Guid.Parse("552f2f6a-bd51-4969-a8f0-9c1fcb7301a9"),

                },
                new Album
                {
                    Id = Guid.Parse("3ac39fec-e8ec-45e8-bcc3-c62743da1fee"),
                    Title = "Arrival",
                    Description = "Arrival is the fourth studio album by the Swedish pop group ABBA. It was originally released in Sweden on 11 October 1976 by Polar Records. ",
                    BandId = Guid.Parse("c3203c2c-653d-4033-bbb3-bf44f379db7c")
                },
                new Album
                {
                    Id = Guid.Parse("fe89c16a-07a8-44f5-886b-4fa75015feb8"),
                    Title = "Definitely Maybe",
                    Description = "Definitely Maybe is the debut studio album by English rock band Oasis, released by Creation Records on 29 August 1994.",
                    BandId = Guid.Parse("5f7d7c0b-6052-468a-9414-da1364ee76c1")
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
