using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.Models
{
    /// <summary>
    /// Detailed Model used for response
    /// </summary>
    public class ArtistResponseDetails
    {
        /// <summary>
        /// id of artist
        /// </summary>
        public int ArtistId { get; set; }

        /// <summary>
        /// name of artist
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// all albums of this artist
        /// </summary>
        public IEnumerable<AlbumResponse> albums { get; set; }
    }
}