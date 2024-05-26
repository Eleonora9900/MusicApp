using System;
using MusicApp_Models.Models;

namespace MusicApp_BL.Interfaces
{
	public interface IAlbumService
	{
		List<Album> GetAllAlbums();
		Album GetAlbumById(int id);
		void AddAlbum(Album album);
		void DeleteAlbum(int id);
	}
}

