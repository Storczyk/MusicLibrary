using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.Models
{
    /// <summary>
    /// Model used for response
    /// </summary>
    public class ArtistResponse
    {
        /// <summary>
        /// id of artist
        /// </summary>
        public int? ArtistId { get; set; }
        /// <summary>
        /// name of artist
        /// </summary>
        public string Name { get; set; }
    }
}