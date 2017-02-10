using MusicLibrary.DAL;
using System.ComponentModel.DataAnnotations;

namespace MusicLibrary.Models
{
    public class AlbumRequest
    {
        public string Title { get; set; }

        [Required]
        public Genre genre { get; set; }

        [Required]
        public ArtistRequest artist { get; set; }
    }
}