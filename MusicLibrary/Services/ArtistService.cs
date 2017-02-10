using MusicLibrary.DAL;
using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace MusicLibrary.Services
{
    public class ArtistService
    {
        internal IEnumerable<ArtistResponse> GetAll(IArtistRepository _repository)
        {
            return _repository.GetAll();
        }

        internal ArtistResponseDetails GetById(int id, IArtistRepository _repository)
        {
            return _repository.GetById(id);
        }

        internal void Edit(ArtistRequest artistNew, int id, IArtistRepository _repository)
        {
            _repository.Edit(artistNew, id);
        }

        internal void Delete(int id, IArtistRepository _repository)
        {
            _repository.Delete(id);
        }
    }
}