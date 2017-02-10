using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicLibrary.Models;
using System.Data.Entity;

namespace MusicLibrary.DAL
{
    public class AlbumRepository : IAlbumRepository
    {
        public void Add(AlbumRequest album)
        {
            using (var ctx = new MusicLibContext())
            {
                var albumNew = ctx.Albums.FirstOrDefault(i => i.Title == album.Title && i.genre == album.genre);
                if (albumNew == null)
                {
                    var existringArtist = ctx.Artists.FirstOrDefault(i => i.Name == album.artist.Name);
                    albumNew = new Album
                    {
                        Title = album.Title,
                        genre = album.genre,
                        artist = existringArtist
                    };
                    ctx.Albums.Add(albumNew);
                }
                if (albumNew.artist == null)
                {
                    albumNew.artist = new Artist
                    {
                        Name = album.artist.Name
                    };
                }
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = new MusicLibContext())
            {
                var album = ctx.Albums.Find(id);
                if (album == null)
                {
                    throw new IndexOutOfRangeException("invalid Id");
                }
                ctx.Albums.Remove(album);
                ctx.SaveChanges();
            }
        }

        public void Edit(AlbumRequest albumNew, int id)
        {
            using (var ctx = new MusicLibContext())
            {
                var album = ctx.Albums.Find(id);
                if (album == null)
                {
                    throw new IndexOutOfRangeException("invalid Id");
                }
                album.Title = albumNew.Title;
                album.genre = albumNew.genre;
                ctx.SaveChanges();
            }
        }

        public IEnumerable<AlbumResponseDetails> GetAll()
        {
            using (var ctx = new MusicLibContext())
            {
                return ctx.Albums.Select(i => new AlbumResponseDetails
                {
                    AlbumId = i.AlbumId,
                    artist = new ArtistResponse { Name = i.artist.Name, ArtistId = i.artist.ArtistId },
                    genre = i.genre,
                    Title = i.Title
                }).OrderBy(i => i.Title).ToList();
            }
        }

        public AlbumResponseDetails GetById(int id)
        {
            using (var ctx = new MusicLibContext())
            {
                var album = ctx.Albums.Where(i => i.AlbumId == id).Include(i => i.artist).Select(i => new AlbumResponseDetails
                {
                    AlbumId = i.AlbumId,
                    artist = new ArtistResponse { Name = i.artist.Name, ArtistId = i.artist.ArtistId },
                    genre = i.genre,
                    Title = i.Title
                }).FirstOrDefault();
                if (album == null)
                {
                    throw new IndexOutOfRangeException("Invalid Id");
                }
                return album;
            }
        }
    }
}