using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.DAL
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Album> albums { get; set; }
    }
}