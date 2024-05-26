
using Microsoft.AspNetCore.Mvc;
using MusicApp_BL.Interfaces;
using MusicApp_Models.Models;

namespace MusicApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet("Get all")]
        public IEnumerable<Album> GetAll()
        {
            return _albumService.GetAllAlbums();
        }

        [HttpGet("GetById")]
        public Album GetById(int id)
        {
            return _albumService.GetAlbumById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody] Album album)
        {
            _albumService.AddAlbum(album);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _albumService.DeleteAlbum(id);
        }
    }
}

