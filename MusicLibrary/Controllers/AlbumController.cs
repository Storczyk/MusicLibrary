using MusicLibrary.DAL;
using MusicLibrary.Filters;
using MusicLibrary.Models;
using MusicLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MusicLibrary.Controllers
{
    public class AlbumController : ApiController
    {
        private AlbumService _albumService;
        private IAlbumRepository _albumRepository;
        AlbumController() { _albumService = new AlbumService(); _albumRepository = new AlbumRepository(); } 

        [HttpPost, Route("album"), ModelValidation]
        public IHttpActionResult AddAlbum([FromBody] AlbumRequest album)
        {
            _albumService.Add(album,_albumRepository);
            return Ok();
        }

        [HttpPost, Route("album/{id:int}"), ModelValidation]
        public IHttpActionResult Edit([FromBody] AlbumRequest album, int id)
        {
            _albumService.Edit(album, id, _albumRepository);
            return Ok();
        }

        [HttpGet, Route("albums")]
        public IHttpActionResult GetAlbums()
        {
            return Ok(_albumService.GetAll(_albumRepository));
        }

        [HttpGet, Route("album/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_albumService.GetById(id, _albumRepository));
        }

        [HttpDelete, Route("album/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            _albumService.Delete(id, _albumRepository);
            return Ok();
        }
    }
}
