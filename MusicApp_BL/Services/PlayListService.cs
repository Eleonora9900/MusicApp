using System;
using MusicApp_BL.Interfaces;
using MusicApp_Models.Requests;
using MusicApp_Models.Responses;

namespace MusicApp_BL.Services
{
	public class PlayListService : IPlaylistService
	{
        private readonly IArtistService _artistService;
        private readonly ISongService _songService;

		public PlayListService(IArtistService artistService, ISongService songService)
		{
            _artistService = artistService;
            _songService = songService;
		}

        public GetAllSongsByArtistResponse GetAllSongs(GetAllSongsByArtistRequest request)
        {
            var result = new GetAllSongsByArtistResponse();
            result.Artist = _artistService.GetById(request.ArtistId);
            result.Songs = _songService.GetAllSongsByArtist(request.ArtistId);
            return result;
        }
    }
}

