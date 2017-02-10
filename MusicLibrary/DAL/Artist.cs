using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.DAL
{
    /// <summary>
    /// Artist entity kept in Database
    /// </summary>
    public class Artist
    {
        /// <summary>
        /// artist id
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        /// name of artist
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// all artist's albums
        /// </summary>
        public virtual ICollection<Album> albums { get; set; }
    }
}