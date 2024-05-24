using System;
using MusicApp_Models.Models;

namespace MusicApp_DL.Interfaces
{
	public interface IAlbumRepository
	{
		List<Album> GetAll();
		Album GetById(Guid id);
		void Add(Album album);
		void Delete(Guid id);
	}
}

