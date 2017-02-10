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
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }

        public Genre genre { get; set; }
        public virtual Artist artist { get; set; } //poniewaz z "public string Artist" byłoby za łatwo :]
    }
}