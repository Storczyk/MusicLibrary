using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicLibrary.Models
{
    /// <summary>
    /// Model used to editing artist
    /// </summary>
    public class ArtistRequest
    {
        /// <summary>
        /// name of artist
        /// </summary>
        [Required]
        public string Name { get; set; }
    }
}