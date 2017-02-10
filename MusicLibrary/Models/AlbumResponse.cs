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
    /// Model used for response
    /// </summary>
    public class AlbumResponse
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
    }
}