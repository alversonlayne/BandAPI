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
            base (options)
        {
        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
