using System;
using MusicApp_Models.Models;

namespace MusicApp_DL.Interfaces
{
	public interface IAlbumRepository
	{
		List<Album> GetAll();
		Album GetById(int id);
		void Add(Album album);
		void Delete(int id);
	}
}

