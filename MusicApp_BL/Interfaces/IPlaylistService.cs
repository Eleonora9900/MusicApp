using System;
using MusicApp_Models.Requests;
using MusicApp_Models.Responses;

namespace MusicApp_BL.Interfaces
{
	public interface IPlaylistService
	{
		public GetAllSongsByArtistResponse GetAllSongs(GetAllSongsByArtistRequest request);
	}
}

