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
    /// Adding, Editing, Getting artist By Id and All Artists from db
    /// </summary>
    public class ArtistController : ApiController
    {
        private ArtistService _artistService;
        private IArtistRepository _artistRepository;
        public ArtistController() { _artistService = new ArtistService(); _artistRepository = new ArtistRepository(); }

        /// <summary>
        /// Editing existing artist
        /// </summary>
        /// <param name="artist">new artist info</param>
        /// <param name="id">id of artist to edit</param>
        /// <returns></returns>
        [HttpPost, Route("artists/{id:int}"), ModelValidation]
        public IHttpActionResult Edit([FromBody] ArtistRequest artist, int id)
        {
            _artistService.Edit(artist, id, _artistRepository);
            return Ok();
        }

        /// <summary>
        /// Gets all Artits
        /// </summary>
        /// <returns>Collection of ArtistResponse</returns>
        [HttpGet, Route("artists")]
        public IHttpActionResult GetArtists()
        {
            return Ok(_artistService.GetAll(_artistRepository));
        }

        /// <summary>
        /// Gets artist by id
        /// </summary>
        /// <param name="id">artist id</param>
        /// <returns>ArtistResponseDetails</returns>
        [HttpGet, Route("artist/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_artistService.GetById(id, _artistRepository));
        }

        /// <summary>
        /// Deletes artist from db
        /// </summary>
        /// <param name="id">id of artist to delete</param>
        /// <returns></returns>
        [HttpDelete, Route("artist/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            _artistService.Delete(id, _artistRepository);
            return Ok();
        }
    }
}
