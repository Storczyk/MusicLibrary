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
    /// <summary>
    /// Adding, Editing, Deleting, Getting album By Id and All albums from Db
    /// </summary>
    public class AlbumController : ApiController
    {
        private AlbumService _albumService;
        private IAlbumRepository _albumRepository;
        AlbumController() { _albumService = new AlbumService(); _albumRepository = new AlbumRepository(); } 

        /// <summary>
        /// Adds 'album' to Database
        /// </summary>
        /// <param name="album">album to add</param>
        /// <returns></returns>
        [HttpPost, Route("album"), ModelValidation]
        public IHttpActionResult AddAlbum([FromBody] AlbumRequest album)
        {
            _albumService.Add(album,_albumRepository);
            return Ok();
        }

        /// <summary>
        /// Edits existing album
        /// </summary>
        /// <param name="album">new album paremeters</param>
        /// <param name="id">ID of edited album</param>
        /// <returns></returns>
        [HttpPost, Route("album/{id:int}"), ModelValidation]
        public IHttpActionResult Edit([FromBody] AlbumRequest album, int id)
        {
            _albumService.Edit(album, id, _albumRepository);
            return Ok();
        }

        /// <summary>
        /// Gets all albums
        /// </summary>
        /// <returns>Collection of AlbumResponse</returns>
        [HttpGet, Route("albums")]
        public IHttpActionResult GetAlbums()
        {
            return Ok(_albumService.GetAll(_albumRepository));
        }

        /// <summary>
        /// Get album by Id
        /// </summary>
        /// <param name="id">ID of album</param>
        /// <returns>AlbumResponseDetails</returns>
        [HttpGet, Route("album/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_albumService.GetById(id, _albumRepository));
        }

        /// <summary>
        /// Deletes album from Database
        /// </summary>
        /// <param name="id">ID of deleted album</param>
        /// <returns></returns>
        [HttpDelete, Route("album/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            _albumService.Delete(id, _albumRepository);
            return Ok();
        }
    }
}
