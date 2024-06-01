using System;
using MusicApp_Models.Models;

namespace MusicApp_BL.Interfaces
{
	public interface ISongService 
	{
		List<Song> GetAllSongs();
		Song GetById(int id);
		void AddSong(Song song);
		void DeleteSong(int id);
		List<Song> GetAllSongsByArtist(int artistId);
	}
}

