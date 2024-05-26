using Microsoft.AspNetCore.Mvc;
using MusicApp_BL.Interfaces;
using MusicApp_Models.Models;

namespace MusicApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController : ControllerBase
    {
        private readonly ISongService _songService;

        public SongController(ISongService songService)
        {
            _songService = songService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Song> GetAll()
        {
            return _songService.GetAllSongs();
        }

        [HttpGet("GetById")]
        public Song GetById(int id)
        {
            return _songService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Song song)
        {
            _songService.AddSong(song);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _songService.DeleteSong(id);
        }
    }
}

