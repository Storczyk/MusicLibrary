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
    public class ArtistController : ApiController
    {
        private ArtistService _artistService;
        private IArtistRepository _artistRepository;
        public ArtistController() { _artistService = new ArtistService(); _artistRepository = new ArtistRepository(); }

        [HttpPost, Route("artists/{id:int}"), ModelValidation]
        public IHttpActionResult Edit([FromBody] ArtistRequest artist, int id)
        {
            _artistService.Edit(artist, id, _artistRepository);
            return Ok();
        }

        [HttpGet, Route("artists")]
        public IHttpActionResult GetArtists()
        {
            return Ok(_artistService.GetAll(_artistRepository));
        }

        [HttpGet, Route("artist/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            return Ok(_artistService.GetById(id, _artistRepository));
        }

        [HttpDelete, Route("artist/{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            _artistService.Delete(id, _artistRepository);
            return Ok();
        }
    }
}
