using System;
using MusicApp_Models.Models;

namespace MusicApp_DL.Interfaces
{
	public interface ISongRepository
	{
        List<Song> GetAll();
		Song GetById(int id);
		void Add(Song song);
		void Delete(int id);
		List<Song> GetAllSongsByArtist(int artistId);
	}
}

