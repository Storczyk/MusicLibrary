using MusicLibrary.DAL;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.Models
{
    /// <summary>
    /// Detailed Model used for response
    /// </summary>
    public class AlbumResponseDetails
    {
        /// <summary>
        /// Album ID
        /// </summary>
        public int AlbumId { get; set; }

        /// <summary>
        /// Title of new album
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Genre of album
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Genre genre { get; set; }

        /// <summary>
        /// artist of this album
        /// </summary>
        public ArtistResponse artist { get; set; }
    }
}