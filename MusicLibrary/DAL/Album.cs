using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.DAL
{
    public enum Genre
    {
        Rock=0, Pop=1, Folk=2, DiscoPolo=3, Techno=4
    }
    /// <summary>
    /// Album entity kept in Database
    /// </summary>
    public class Album
    {
        /// <summary>
        /// Album ID
        /// </summary>
        public int AlbumId { get; set; }
        /// <summary>
        /// Title of album
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Genre of album
        /// </summary>
        public Genre genre { get; set; }

        /// <summary>
        /// Artist of album
        /// </summary>
        public virtual Artist artist { get; set; } //poniewaz z "public string Artist" byłoby za łatwo :]
    }
}