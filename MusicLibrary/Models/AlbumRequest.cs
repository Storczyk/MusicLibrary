using MusicLibrary.DAL;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models
{
    /// <summary>
    /// Model used to adding album to database
    /// </summary>
    public class AlbumRequest
    {
        /// <summary>
        /// Title of new album
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Genre of album
        /// </summary>
        [Required]
        public Genre genre { get; set; }

        /// <summary>
        /// artist of this album
        /// </summary>
        [Required]
        public ArtistRequest artist { get; set; }
    }
}