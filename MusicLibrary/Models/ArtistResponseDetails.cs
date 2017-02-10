using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.Models
{
    public class ArtistResponseDetails
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }

        public IEnumerable<AlbumResponse> albums { get; set; }
    }
}