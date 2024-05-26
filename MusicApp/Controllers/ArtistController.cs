
using Microsoft.AspNetCore.Mvc;
using MusicApp_BL.Interfaces;
using MusicApp_Models.Models;

namespace MusicApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistController : ControllerBase
    {
        private readonly IArtistService _artistService;
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet("Get All")]
        public IEnumerable<Artist> GetAll()
        {
            return _artistService.GetAll();
        }

        [HttpGet("GetById")]
        public Artist GetById(int id)
        {
            return _artistService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Artist artist)
        {
            _artistService.Add(artist);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _artistService.Delete(id);
        }
    }
}

