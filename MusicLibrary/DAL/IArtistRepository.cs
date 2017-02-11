using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.DAL
{
    public interface IArtistRepository
    {
        IEnumerable<ArtistResponse> GetAll();
        ArtistResponseDetails GetById(int id);
        void Edit(ArtistRequest artist, int id);
        void Delete(int id);
    }
}
