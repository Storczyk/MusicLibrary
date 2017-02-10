using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicLibrary.DAL
{
    public class MusicLibContext:DbContext
    {
        public MusicLibContext():base("MusicDb")
        {

        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}