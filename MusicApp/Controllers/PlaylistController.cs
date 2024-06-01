using System;
using Microsoft.AspNetCore.Mvc;
using MusicApp_BL.Interfaces;
using MusicApp_Models.Requests;
using MusicApp_Models.Responses;

namespace MusicApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaylistController : ControllerBase 
	{
		private readonly IPlaylistService _playlistService;
		public PlaylistController(IPlaylistService playlistService)
		{
			_playlistService = playlistService;
		}

        [HttpPost("GetAllSongsByArtist")]
		public GetAllSongsByArtistResponse GetAllSongsByArtist(GetAllSongsByArtistRequest request)
		{
			return _playlistService.GetAllSongs(request);
		}
    }
}

