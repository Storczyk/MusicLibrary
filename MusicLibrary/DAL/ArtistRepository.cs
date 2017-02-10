using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicLibrary.Models;
using System.Web.Mvc;
namespace MusicLibrary.DAL
{
    public class ArtistRepository : IArtistRepository
    {
        public void Delete(int id)
        {
            using (var ctx = new MusicLibContext())
            {
                var artist = ctx.Artists.Find(id);
                if (artist == null)
                {
                    throw new IndexOutOfRangeException("invalid Id");
                }
                ctx.Artists.Remove(artist);
                ctx.SaveChanges();
            }
        }

        public void Edit(ArtistRequest artistNew, int id)
        {
            using (var ctx = new MusicLibContext())
            {
                var artist = ctx.Artists.Find(id);
                if (artist == null)
                {
                    throw new IndexOutOfRangeException("invalid Id");
                }
                artist.Name = artistNew.Name;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<ArtistResponse> GetAll()
        {
            using (var ctx = new MusicLibContext())
            {
                return ctx.Artists.Select(i => new ArtistResponse
                {
                    ArtistId = i.ArtistId,
                    Name = i.Name
                }).OrderBy(i => i.Name).ToList();
            }
        }

        public ArtistResponseDetails GetById(int id)
        {
            using (var ctx = new MusicLibContext())
            {
                var artist = ctx.Artists.Find(id);
                if (artist == null)
                    throw new IndexOutOfRangeException("invalid Id");
                var artistAlbums = artist.albums.Select(i => new AlbumResponse
                {
                    Title = i.Title,
                    AlbumId = i.AlbumId,
                    genre = i.genre
                });
                return new ArtistResponseDetails
                {
                    albums = artistAlbums,
                    ArtistId = artist.ArtistId,
                    Name = artist.Name
                };
            }
        }
    }
}