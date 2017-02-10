using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicLibrary.Models;
using MusicLibrary.DAL;
using System.Data.Entity;

namespace MusicLibrary.Services
{
    public class AlbumService
    {
        internal IEnumerable<AlbumResponseDetails> GetAll(IAlbumRepository _repository)
        {
            return _repository.GetAll();
        }

        internal void Add(AlbumRequest album, IAlbumRepository _repository)
        {
            _repository.Add(album);
        }

        internal void Edit(AlbumRequest albumNew, int id, IAlbumRepository _repository)
        {
            _repository.Edit(albumNew, id);
        }

        internal void Delete(int id, IAlbumRepository _repository)
        {
            _repository.Delete(id);
        }

        internal AlbumResponseDetails GetById(int id, IAlbumRepository _repository)
        {
            return _repository.GetById(id);
        }
    }
}