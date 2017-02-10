using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicLibrary.DAL
{
    public interface IAlbumRepository
    {
        void Add(AlbumRequest album);
        IEnumerable<AlbumResponseDetails> GetAll();
        void Edit(AlbumRequest albumNew, int id);
        void Delete(int id);
        AlbumResponseDetails GetById(int id);
    }
}